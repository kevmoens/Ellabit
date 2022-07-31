using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Text;
using Microsoft.Extensions.Logging;
using Microsoft.JSInterop;
using OmniSharp.Models.SignatureHelp;
using OmniSharp.Models.v1.Completion;
using OmniSharp.Options;
using Ellabit.Omnisharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ellabit.Monaco
{
    public class MonacoService
    {
        #region Fields
        HttpClient _client;
        RoslynProject? _completionProject;
        RoslynProject? _diagnosticProject;
        OmniSharpCompletionService? _completionService;
        OmniSharpSignatureHelpService? _signatureService;

        #endregion

        #region Records

        public record Diagnostic()
        {
            public LinePosition Start { get; init; }
            public LinePosition End { get; init; }
            public string? Message { get; init; } 
            public int Severity { get; init; }
        }

        #endregion

        #region Constructors

        public MonacoService(HttpClient client)
        {
            _client = client;

            // default code
            this.DefaultCode =
$@"using System; 
                 
namespace {nameof(Ellabit)}.{nameof(Monaco)}
{{
    class Filter 
    {{               
        public Filter() 
        {{ 
            
        }}
    }} 
}};
";
        }
        public async Task<MonacoService> Initialize() 
        { 

            _completionProject = await (new RoslynProject(_client)).Initialize();
            _diagnosticProject = await (new RoslynProject(_client)).Initialize();

            var loggerFactory = LoggerFactory.Create(configure => { });
            var formattingOptions = new FormattingOptions();
            if (_completionProject.Workspace == null)
            {
                throw new ArgumentNullException("CompletionProject Workspace");
            }
            _completionService = new OmniSharpCompletionService(_completionProject.Workspace, formattingOptions, loggerFactory);
            _signatureService = new OmniSharpSignatureHelpService(_completionProject.Workspace);
            return this;
        }

        #endregion

        #region Properties

        public string DefaultCode { get; init; }

        #endregion

        #region Methods

        [JSInvokable]
        public async Task<CompletionResponse> GetCompletionAsync(string code, CompletionRequest completionRequest)
        {
            Solution updatedSolution;
            if (_completionProject == null)
            {
                throw new ArgumentNullException("Completion Project");
            }

            if (_completionProject.Workspace == null)
            {
                throw new ArgumentNullException("Completion Project Workspace");
            }

            if (_completionProject.DocumentId == null)
            {
                throw new ArgumentNullException("Completion Project Document Id");
            } 
            do
            {
                updatedSolution = _completionProject.Workspace.CurrentSolution.WithDocumentText(_completionProject.DocumentId, SourceText.From(code));
            } while (!_completionProject.Workspace.TryApplyChanges(updatedSolution));
            if (_completionService == null)
            {
                return new CompletionResponse() { IsIncomplete = true };
            }
            var document = updatedSolution.GetDocument(_completionProject.DocumentId);
            if (document == null)
            {
                throw new ArgumentNullException("Document");
            }
            var completionResponse = await _completionService.Handle(completionRequest, document);

            return completionResponse;
        }

        [JSInvokable]
        public async Task<CompletionResolveResponse> GetCompletionResolveAsync(CompletionResolveRequest completionResolveRequest)
        {
            if (_completionProject == null)
            {
                throw new ArgumentNullException("Completion Project");
            }

            if (_completionProject.Workspace == null)
            {
                throw new ArgumentNullException("Completion Project Workspace");
            }

            if (_completionService == null)
            {
                throw new ArgumentNullException("Completion Service");
            }

            var document = _completionProject.Workspace.CurrentSolution.GetDocument(_completionProject.DocumentId);
            if (document == null)
            {
                throw new ArgumentNullException("Document");
            }
            var completionResponse = await _completionService.Handle(completionResolveRequest, document);

            return completionResponse;
        }

        [JSInvokable]
        public async Task<SignatureHelpResponse?> GetSignatureHelpAsync(string code, SignatureHelpRequest signatureHelpRequest)
        {
            Solution updatedSolution;

            if (_completionProject == null)
            {
                throw new ArgumentNullException("Completion Project");
            }

            if (_completionProject.Workspace == null)
            {
                throw new ArgumentNullException("Completion Project Workspace");
            }

            if (_completionProject.DocumentId == null)
            {
                throw new ArgumentNullException("Completion Project Document Id");
            }

            do
            {
                updatedSolution = _completionProject.Workspace.CurrentSolution.WithDocumentText(_completionProject.DocumentId, SourceText.From(code));
            } while (!_completionProject.Workspace.TryApplyChanges(updatedSolution));

            var document = updatedSolution.GetDocument(_completionProject.DocumentId);
            if (_signatureService == null)
            {
                throw new ArgumentNullException("Signature Service");
            }
            if (document == null)
            {
                throw new ArgumentNullException("Document");
            }
            var signatureHelpResponse = await _signatureService.Handle(signatureHelpRequest, document);

            return signatureHelpResponse;
        }

        public async Task<List<Diagnostic>> GetDiagnosticsAsync(string code)
        {
            Solution updatedSolution;

            if (_diagnosticProject == null)
            {
                throw new ArgumentNullException("Diagnostic Project");
            }

            if (_diagnosticProject.Workspace == null)
            {
                throw new ArgumentNullException("Diagnostic Project Workspace");
            }

            if (_diagnosticProject.DocumentId == null)
            {
                throw new ArgumentNullException("Diagnostic Project Document Id");
            }

            do
            {
                updatedSolution = _diagnosticProject.Workspace.CurrentSolution.WithDocumentText(_diagnosticProject.DocumentId, SourceText.From(code));
            } while (!_diagnosticProject.Workspace.TryApplyChanges(updatedSolution));

            var compilation = await updatedSolution.Projects.First().GetCompilationAsync();
            if (compilation == null)
            {
                throw new ArgumentNullException("Compilation");
            }
            var dotnetDiagnostics = compilation.GetDiagnostics();

            var diagnostics = dotnetDiagnostics.Select(current =>
            {
                var lineSpan = current.Location.GetLineSpan();

                return new Diagnostic()
                {
                    Start = lineSpan.StartLinePosition,
                    End = lineSpan.EndLinePosition,
                    Message = current.GetMessage(),
                    Severity = this.GetSeverity(current.Severity)
                };
            }).ToList();

            return diagnostics;
        }

        private int GetSeverity(DiagnosticSeverity severity)
        {
            return severity switch
            {
                DiagnosticSeverity.Hidden => 1,
                DiagnosticSeverity.Info => 2,
                DiagnosticSeverity.Warning => 4,
                DiagnosticSeverity.Error => 8,
                _ => throw new Exception("Unknown diagnostic severity.")
            };
        }

        #endregion
    }
}
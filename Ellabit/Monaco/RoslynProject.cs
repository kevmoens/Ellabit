using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.Host.Mef;
using Microsoft.CodeAnalysis.Text;
using System.Collections.Concurrent;

namespace Ellabit.Monaco
{
    public class RoslynProject
    {
        private HttpClient _client;
        public RoslynProject(HttpClient client)
        {
            _client = client;
        }
        public async Task<RoslynProject> Initialize()
        {
            var host = MefHostServices.Create(MefHostServices.DefaultAssemblies);

            // workspace
            _Workspace = new AdhocWorkspace(host);

            // project
            //var filePath = typeof(object).Assembly.Location;
            var filePath = typeof(object).Assembly.GetName().Name;
            if (filePath == null)
            {
                throw new ArgumentNullException("filePath typeof(object).Assembly Name");
            }
            var documentationProvider = XmlDocumentationProvider.CreateFromFile(@"./Resources/System.Runtime.xml");

            var projectInfo = ProjectInfo
                .Create(ProjectId.CreateNewId(), VersionStamp.Create(), "Ellabit", "Ellabit", LanguageNames.CSharp)
                .WithMetadataReferences(new[]
                {
                    MetadataReference.CreateFromStream(await GetReferenceAssemblyStreamAsync(filePath), documentation: documentationProvider)
                })
                .WithCompilationOptions(new CSharpCompilationOptions(OutputKind.DynamicallyLinkedLibrary));

            var project = Workspace?.AddProject(projectInfo);

            // code
            _UseOnlyOnceDocument = Workspace?.AddDocument(project?.Id, "Code.cs", SourceText.From(string.Empty));
            _DocumentId = UseOnlyOnceDocument?.Id;
            return this;
        }

        private async Task<IEnumerable<Stream>> GetReferenceAssembliesStreamsAsync(IEnumerable<string> referenceAssemblyNames)
        {
            if (_client == null)
            {
                return new Stream[] { };
            }
            var streams = new ConcurrentBag<Stream>();

            await Task.WhenAll(
                (IEnumerable<Task>)referenceAssemblyNames.Select(async assemblyName =>
                {
                    streams.Add(await GetReferenceAssemblyStreamAsync(assemblyName));
                }));

            return streams;
        }

        private async Task<Stream> GetReferenceAssemblyStreamAsync(string assemblyName)
        {
            HttpResponseMessage? result = null;
            try
            {
                result = await _client.GetAsync($"/_framework/{assemblyName}.dll");

                result.EnsureSuccessStatusCode();
            }
            catch
            {
                try
                {
                    result = await _client.GetAsync($"/Ellabit/_framework/{assemblyName}.dll");

                    result.EnsureSuccessStatusCode();
                }
                catch (Exception ex)
                {
                    throw new Exception($"GetReferenceAssembliesStreamsAsync: {result?.RequestMessage?.RequestUri?.Host}:{result?.RequestMessage?.RequestUri?.Port}{result?.RequestMessage?.RequestUri?.AbsolutePath} =" + ex.Message);
                }
            }

            return await result.Content.ReadAsStreamAsync();
        }


        private AdhocWorkspace? _Workspace;

        public AdhocWorkspace? Workspace { get { return _Workspace; } }

        private Document? _UseOnlyOnceDocument;

        public Document? UseOnlyOnceDocument { get { return _UseOnlyOnceDocument; } }

        private DocumentId? _DocumentId;
        public DocumentId? DocumentId { get { return _DocumentId; } }
    }
}
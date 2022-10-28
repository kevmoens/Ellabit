using BlazorMonaco;
using CSharpToBlockly;
using Ellabit.Challenges;
using Ellabit.DynamicCode;
using Ellabit.Monaco;
using IronBlock.Blocks;
using Microsoft.AspNetCore.Components;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.JSInterop;
using MudBlazor;
using System;

namespace Ellabit.Pages
{
    public partial class Challenge : ComponentBase, IDisposable
    {

        [Parameter]
        public int? ChallengeId { get; set; }
        [Inject]
        public HttpClient? HttpClient { get; set; }
        [Inject]
        public IJSRuntime? JS { get; set; }
        [Inject]
        public NavigationManager? NavMan { get; set; }
        [Inject]
        public SimpleUnloadable? _unloadable { get; set; }
        [Inject]
        private IDialogService? DialogService { get; set; }
        [Inject]
        private Ellabit.Challenges.Challenges? Challenges { get; set; }
        [Inject]
        private MonacoService? monacoService { get; set; }
        [Inject]
        private SharpParse? ParseCodeToBlock { get; set; }

        bool hasRegisteredBlockly = false;
        ElementReference blocklyReference;
        string blockXml = string.Empty;
        private IJSObjectReference? module;
        bool _isDarkMode = false;
        int prevTabIndex = -1;
        string? code = string.Empty;
        string testResults = "";
        bool fail = true;
        bool runningTests = false;
        protected override void OnInitialized()
        {
            base.OnInitialized();
            blockXml = string.Empty;
            SetChallenge();
        }

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            //Monaco Editor
            if (!_hasRegisteredMonaco && JS != null && monacoService != null)
            {
                await InitializeMonacoEditor();
            }

            //Blockly
            if (hasRegisteredBlockly == false
                && ParseCodeToBlock != null
                && JS != null
                && EqualityComparer<ElementReference>.Default.Equals(blocklyReference, default(ElementReference)) == false) //html tag exists
            {
                await InitializeBlockly();
                hasRegisteredBlockly = true;
            }
            await base.OnAfterRenderAsync(firstRender);
        }

        private async Task InitializeBlockly()
        {
            //Initialize Blockly Editor
            module = await JS.InvokeAsync<IJSObjectReference>("import",
                "./javascript/blockly_ui_interop.js");
            await InitializeBlocklyToolbox();
            await InitializeBlocklyChallengeCodeBlocks();
        }

        private async Task InitializeBlocklyToolbox()
        {
            var blocklyToolbox = string.Empty;
            if (_unloadable?.Context?.Challenge is IChallengeBlocklyToolbox)
            {
                blocklyToolbox = ((IChallengeBlocklyToolbox)_unloadable.Context.Challenge).BlocklyToolboxXML;
            }
            await module.InvokeVoidAsync("initialize", new object?[] { blocklyToolbox });
        }

        private async Task InitializeBlocklyChallengeCodeBlocks()
        {
            var code = _unloadable?.Context?.Challenge?.Code;
            if (code != null && blockXml == string.Empty)
            {
                if (_unloadable?.Context?.Challenge is IChallengeBlocklyInitialCode)
                {
                    blockXml = ((IChallengeBlocklyInitialCode)_unloadable.Context.Challenge).BlocklyXML;
                }
                else
                {
                    blockXml = ParseCodeToBlock.Parse(code).ToString();
                }
            }
            if (blockXml != string.Empty)
            {
                await module.InvokeVoidAsync("setBlocks", new object?[] { blockXml });
                StateHasChanged();
            }
        }

        private async Task InitializeMonacoEditor()
        {
            await monacoService.Initialize();
            _objRef = DotNetObjectReference.Create(this.monacoService);
            await JS.InvokeAsync<string>("registerProviders", _objRef);
            _hasRegisteredMonaco = true;


            IJSObjectReference? module = await JS.InvokeAsync<IJSObjectReference>("import", "./scripts/theme.js");
            var isDarkMode = await module.InvokeAsync<bool>("isDarkTheme", new object[] { });
            _isDarkMode = isDarkMode;
        }

        public async void OnBlocklyToCSharp()
        {
            if (_unloadable?.Context?.Challenge == null)
            {
                return;
            }
            BlockSyntax blockMethodBlock = await BlocklyGetCSharpMethod();

            //Get current C# source to SyntaxTree
            SyntaxNode syntax = CSharpSyntaxTree.ParseText(_unloadable.Context.Challenge.Code ?? "").GetRoot();
            //Get Sample Code's method from SyntaxTree
            MethodDeclarationSyntax method = (from node in syntax.DescendantNodes()
                .OfType<MethodDeclarationSyntax>()
                                              select node).First();
            //If Method has body, which is the starting and ending { }
            if (method.Body != null)
            {
                var methodBody = (SyntaxNode)method.Body;
                //Replace Sample Method with source generated from Blockly
                var output = syntax.ReplaceNode(methodBody, blockMethodBlock);
                //Fix Whitespace issues
                output = output.SyntaxTree.GetRoot().NormalizeWhitespace();
                //Update code to be used 
                code = output.ToFullString();
            }
        }

        private async Task<BlockSyntax> BlocklyGetCSharpMethod()
        {
            //Get Blockly code to C#
            var blockMethodCode = await module.InvokeAsync<string>("evalProgram");
            SyntaxNode blockMethod = CSharpSyntaxTree.ParseText(blockMethodCode).GetRoot();
            BlockSyntax blockMethodBlock = (from node in blockMethod.DescendantNodes()
                                                .OfType<BlockSyntax>()
                                            select node).First();
            return blockMethodBlock;
        }

        [JSInvokable]
        public static string Evaluate(string xml)
        {
            var parser =
            new IronBlock.Parser()
              .AddStandardBlocks()
              .Parse(xml);
            var blockSyntax = parser.Generate();
            blockSyntax = blockSyntax.NormalizeWhitespace();

            var blockMethodBody = (from method in blockSyntax.DescendantNodes()
                    .OfType<LocalFunctionStatementSyntax>()
                 select method.Body).FirstOrDefault();

            return blockMethodBody?.ToFullString() ?? "";

        }
        public void SetChallenge()
        {
            if (_unloadable?.Context != null && Challenges != null)
            {
                if (ChallengeId == null)
                {
                    ChallengeId = 0;
                }
                if (Challenges.Count < (ChallengeId ?? 0) )
                {
                    if (NavMan == null)
                    {
                        return;
                    }
                    NavMan.NavigateTo("");
                    return;
                }
                _unloadable.Context.Challenge = Challenges[ChallengeId ?? 0];
                if (code == String.Empty)
                {
                    code = _unloadable.Context.Challenge.Code;
                    SyntaxNode syntax = CSharpSyntaxTree.ParseText(code ?? "").GetRoot();
                    syntax = syntax.SyntaxTree.GetRoot().NormalizeWhitespace();
                    code = syntax.ToFullString();
                }
                StateHasChanged();
            }
        }
        /// <summary>
        /// Since the state of the editor is lost every time we switch tabs we have to 
        /// - Iniialize editor every time we go into the code tab
        /// - When leaving code tab save text in editor
        /// </summary>
        /// <param name="tabIndex"></param>
        public async void OnTabChanged(int tabIndex)
        {
            if (prevTabIndex == TabIDBlockly() && module != null)
            {
                blockXml = await module.InvokeAsync<string>("getBlockXml", new object[] { });
            }
            if (tabIndex != TabIDCode())
            {
                await TabChanged_ClearEditor();
            }
            blocklyReference = default(ElementReference);
            hasRegisteredBlockly = false;
            prevTabIndex = tabIndex;
        }
        public async Task TabChanged_ClearEditor()
        {
            if (JS == null)
            {
                return;
            }
            if (_editor != null && _unloadable?.Context?.Challenge != null && prevTabIndex == TabIDCode())
            {
                code = await _editor.GetValue();            
            }
        }
        public int TabIDBlockly()
        {
            if (_unloadable?.Context?.Challenge is IChallengeBlockly && ((IChallengeBlockly)_unloadable.Context.Challenge).ShowBlockly)
            {
                return 1;
            }
            return -999;
        }
        public int TabIDCode()
        {
            if (_unloadable?.Context?.Challenge is IChallengeBlockly && ((IChallengeBlockly)_unloadable.Context.Challenge).ShowBlockly)
            {
                return 2;
            }
            return 1;
        }
        public async Task TabChanged_LoadEditor()
        {
            if (JS == null)
            {
                return;
            }
            StateHasChanged();
            await Task.Delay(1);


            await Task.Delay(1);
        }

        public async void OnExecuteTests()
        {
            ClearChallengeCache();
            testResults = "";
            StateHasChanged();
            await ExecuteTests();
        }
        private async Task ExecuteTests()
        {
            testResults = "";
            var testCode = _unloadable?.Context?.Challenge as IChallengeTestCode;
            if (ExecuteTests_Validation(testCode) == false)
            {
                return;
            }
            var origCode = _unloadable.Context.Challenge.Code;
            _unloadable.Context.Challenge.Code = code;
            try
            {
                await ExecuteTests_RunAllTests(testCode);
            }
            catch (Exception ex)
            {
                if (DialogService != null)
                {
                    await DialogService.ShowMessageBox(
                        "Error",
                        ex.Message,
                        yesText: "OK");
                    StateHasChanged();
                }

                testResults += "\nUnexpected Error " + ex.Message;
                return;
            }
            finally
            {
                _unloadable.Context.Challenge.Code = origCode;
                runningTests = false;
                StateHasChanged();
            }
        }
        public bool ExecuteTests_Validation(IChallengeTestCode? testCode)
        {

            if (!(_unloadable?.Context?.Challenge is IChallenge))
            {
                testResults += "\nChallenge, missing IChallenge";
                return false;
            }
            if (!(_unloadable?.Context?.Challenge is IChallengeTestCode))
            {
                testResults += "\nInvalid Challenge, missing IChallengeTestCode";
                return false;
            }

            if (testCode?.Tests == null)
            {
                testResults += "\nCode didn't compile";
                return false;
            }
            return true;
        }
        public async Task ExecuteTests_RunAllTests(IChallengeTestCode? testCode)
        {
            int testNum = 1;
            fail = false;
            runningTests = true;
            foreach (var test in testCode.Tests)
            {
                await ExecuteTests_RunOneTest(test, testNum);
                testNum++;
            }

        }
        public async Task ExecuteTests_RunOneTest(string? test, int testNum)
        {
            try
            {
                var testResult = await _unloadable.Context.RunTest(new RunTestArgs() { Method = test});
                if (testResult.pass)
                {
                    testResults += $"<br/>Test {testNum} <h6 style='color: green'>Pass</h6>";
                }
                else
                {
                    testResults += $"<br/>Test {testNum} <h6 style='color: red'>FAILED</h6> " + testResult.message;
                    fail = true;
                }
            }
            catch (Exception ex)
            {
                fail = true;
                if (ex is IOException)
                {
                    testResults += $"<br/><h6 style='color: red'>FAILED</h6> " + ex.Message;
                    return;
                }
                testResults += $"<br/>Test {testNum} " + "\n <h6 style='color: red'>FAILED</h6> " + ex.Message;
            }
        }
        public void OnNextChallenge()
        {
            if (NavMan == null)
            {
                return;
            }
            if (ChallengeId == null)
            {
                ChallengeId = 1;
            }
            ChallengeId++;
            if (HttpClient?.BaseAddress?.Host != "localhost")
            {
                NavMan.NavigateTo($"/Ellabit/{ChallengeId}");
            } else
            { 
                NavMan.NavigateTo($"/{ChallengeId}");
            }
        }
        public void ClearChallengeCache()
        {

            if (_unloadable?.Context?.Challenge == null)
            {
                return;
            }
            _unloadable.ClearCache();
            SetChallenge();
        }

        private bool _hasRegisteredMonaco = false;
        private MonacoEditor? _editor;
        private DotNetObjectReference<MonacoService>? _objRef;
        private List<MonacoService.Diagnostic>? Diagnostics { get; set; }

        private StandaloneEditorConstructionOptions EditorConstructionOptions(MonacoEditor editor)
        {
            string themeName = _isDarkMode ? "vs-dark" : "vs";
            return new StandaloneEditorConstructionOptions
            {
                AutomaticLayout = true,
                Language = "csharp",
                Value = code ?? "",
                Theme = themeName
            };
        }

        public void Dispose()
        {
            _objRef?.Dispose();
        }
    }
}

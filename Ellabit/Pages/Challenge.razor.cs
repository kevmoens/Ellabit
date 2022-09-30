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
        private SharpParse ParseCodeToBlock { get; set; }

        bool hasRegisteredBlockly = false;
        ElementReference blocklyReference;
        string blockXml = string.Empty;
        private IJSObjectReference? module;
        bool loaded = false;
        bool _isDarkMode = false;
        int prevTabIndex = -1;
        string? code;
        string testResults = "";
        bool fail = true;
        bool runningTests = false;
        protected override void OnInitialized()
        {
            base.OnInitialized();
            SetChallenge();
        }

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            //Monaco Editor
            if (!_hasRegisteredMonaco && JS != null && monacoService != null)
            {
                await monacoService.Initialize();
                _objRef = DotNetObjectReference.Create(this.monacoService);
                await JS.InvokeAsync<string>("registerProviders", _objRef);
                _hasRegisteredMonaco = true;


                IJSObjectReference? module = await JS.InvokeAsync<IJSObjectReference>("import", "./scripts/theme.js");
                var isDarkMode = await module.InvokeAsync<bool>("isDarkTheme", new object[] { });
                _isDarkMode = isDarkMode;
            }

            //Blockly
            if (hasRegisteredBlockly == false
                && JS != null
                && EqualityComparer<ElementReference>.Default.Equals(blocklyReference, default(ElementReference)) == false) //html tag exists
            {
                module = await JS.InvokeAsync<IJSObjectReference>("import",
                    "./javascript/blockly_ui_interop.js");
                await module.InvokeVoidAsync("initialize", new object?[] { });
                hasRegisteredBlockly = true;
                var code = _unloadable?.Context?.Challenge?.Code;
                if (code != null)
                { 
                    blockXml = ParseCodeToBlock.Parse(code).ToString();
                }
                if (blockXml != string.Empty)
                {
                    await module.InvokeVoidAsync("setBlocks", new object?[] { blockXml });
                    StateHasChanged();
                }
            }
            await base.OnAfterRenderAsync(firstRender);
        }

        public async void OnBlocklyToCSharp()
        {
            if (_unloadable?.Context?.Challenge == null)
            {
                return;
            }
            //Get Blockly code to C#
            var blockMethodCode = await module.InvokeAsync<string>("evalProgram");
            SyntaxNode blockMethod = CSharpSyntaxTree.ParseText(blockMethodCode).GetRoot();
            BlockSyntax blockMethodBlock = (from node in blockMethod.DescendantNodes()
                                                .OfType<BlockSyntax>()
                                            select node).First();

            //Get current C# source 
            SyntaxNode syntax = CSharpSyntaxTree.ParseText(_unloadable.Context.Challenge.Code ?? "").GetRoot();
            MethodDeclarationSyntax method = (from node in syntax.DescendantNodes()
                .OfType<MethodDeclarationSyntax>()
                          select node).First();
            var methodBody = (SyntaxNode)method.Body;
            //Replace
            var output = syntax.ReplaceNode(methodBody, blockMethodBlock);
            output = output.SyntaxTree.GetRoot().NormalizeWhitespace();
            _unloadable.Context.Challenge.Code = output.ToFullString();
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
                code = _unloadable.Context.Challenge.Code;
                StateHasChanged();
            }
        }
        /// <summary>
        /// Since the state of the editor is lost every time we switch tabs we have to 
        /// - Iniialize editory every time we go into the code tab
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
                _unloadable.Context.Challenge.Code = code;
            }
        }
        public int TabIDBlockly()
        {
            if (_unloadable?.Context?.Challenge?.ShowBlockly ?? false == true)
            {
                return 1;
            }
            return -999;
        }
        public int TabIDCode()
        {
            if (_unloadable?.Context?.Challenge?.ShowBlockly ?? false == true)
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


            loaded = true;
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

            if (_unloadable?.Context?.Challenge?.Tests == null)
            {
                testResults += "\nCode didn't compile";
                return;
            }

            try
            {
                int testNum = 1;
                fail = false;
                runningTests = true;
                foreach (var test in _unloadable.Context.Challenge.Tests)
                {
                    try
                    {
                        var testResult = await _unloadable.Context.RunTest(test);
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
                    testNum++;
                }

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
                runningTests = false;
                StateHasChanged();
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
            _unloadable.Context.Challenge.Code = code;
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
                Value = _unloadable?.Context?.Challenge?.Code ?? "",
                Theme = themeName
            };
        }

        public void Dispose()
        {
            _objRef?.Dispose();
        }
    }
}

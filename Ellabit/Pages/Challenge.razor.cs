using Ellabit.Challenges;
using Ellabit.DynamicCode;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using MudBlazor;

namespace Ellabit.Pages
{
    public partial class Challenge : ComponentBase
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
        public IServiceProvider? ServiceProvider { get; set; }
        [Inject]
        private IDialogService? DialogService { get; set; }
        [Inject]
        private Ellabit.Challenges.Challenges? Challenges { get; set; }
        bool loaded = false;
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
        public void SetChallenge()
        {
            if (_unloadable?.Context != null && Challenges != null)
            {
                if (ChallengeId == null)
                {
                    ChallengeId = 1;
                }
                if (!Challenges.ContainsKey(ChallengeId ?? 1))
                {
                    if (NavMan == null)
                    {
                        return;
                    }
                    NavMan.NavigateTo("");
                    return;
                }
                _unloadable.Context.Challenge = Challenges[ChallengeId ?? 1];
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
            if (tabIndex != 1)
            {
                await TabChanged_ClearEditor();
            }
            if (tabIndex == 1)
            {
                await TabChanged_LoadEditor();
            }
            prevTabIndex = tabIndex;
        }
        public async Task TabChanged_ClearEditor()
        {
            if (JS == null)
            {
                return;
            }
            if (loaded && _unloadable?.Context?.Challenge != null && prevTabIndex == 1)
            {
                code = await BlazacoJSInterop.GetValue(JS, "editor");
                _unloadable.Context.Challenge.Code = code;
            }
            await BlazacoJSInterop.ClearEditors(JS);
        }
        public async Task TabChanged_LoadEditor()
        {
            if (JS == null)
            {
                return;
            }
            StateHasChanged();
            await Task.Delay(1);
            await BlazacoJSInterop.InitializeEditor(JS, "editor");
            if (_unloadable?.Context?.Challenge?.Code != null)
            {
                await BlazacoJSInterop.SetValue(JS, "editor", code ?? "");
            }
            IJSObjectReference? module = await JS.InvokeAsync<IJSObjectReference>("import", "./scripts/theme.js");
            if (await module.InvokeAsync<bool>("isDarkTheme", new object[] { }))
            {
                await BlazacoJSInterop.SetTheme(JS, "editor", "vs-dark");
            }
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
    }
}

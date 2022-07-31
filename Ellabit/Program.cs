using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Ellabit;
using Ellabit.DynamicCode;
using Ellabit.Monaco;
using MudBlazor.Services;
using Ellabit.Challenges;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");


builder.Services.AddScoped<MonacoService>();
builder.Services.AddScoped<SimpleUnloadable>();
builder.Services.AddScoped<SimpleUnloadableAssemblyLoadContext>();
builder.Services.AddSingleton<Challenges>(Challenges.GetChallenges());
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddMudServices();

await builder.Build().RunAsync();


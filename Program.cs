using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MudBlazor.Services;
using PersonalWebsite.Components;
using PersonalWebsite.Extensions;
using System.Reflection;



var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.Services.AddHttpClient("LanyardApi", c =>
{
	c.BaseAddress = new Uri("https://api.lanyard.rest/v1/users/");
});

builder.Services.AddHttpClient("LastFmApi", c =>
{
	c.BaseAddress = new Uri($"https://ws.audioscrobbler.com/2.0/");
});

builder.Services.AddDataServices(Assembly.GetExecutingAssembly());

builder.Services.AddMudServices();

await builder.Build().RunAsync();

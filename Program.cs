using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MudBlazor.Services;
using PersonalWebsite.Components;
using PersonalWebsite.Services.DataServices.DataServices;
using PersonalWebsite.Services.DataServices.Interfaces;



var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.Services.AddHttpClient("LanyardApi", c =>
{
	c.BaseAddress = new Uri("https://api.lanyard.rest/v1/users/");
});

builder.Services.AddTransient<ILanyardDataService, LanyardDataService>();

builder.Services.AddMudServices();

await builder.Build().RunAsync();

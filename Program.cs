using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Application;
using Application.Models;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");


var api = new Api();
var section = builder.Configuration.GetSection("Api");
api = section.Get<Api>();



builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(api.Url) }); // builder.HostEnvironment.BaseAddress




await builder.Build().RunAsync();

global using ToDoApplication_WebAPI_Blazor.Client.Services.TodoItemService;
global using ToDoApplication_WebAPI_Blazor.Shared;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using ToDoApplication_WebAPI_Blazor.Client;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped<ITodoItemService, TodoItemService>();

await builder.Build().RunAsync();

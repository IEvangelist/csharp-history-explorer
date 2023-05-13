// Copyright (c) David Pine. All rights reserved.
// Licensed under the MIT License.

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient
{
    BaseAddress = new Uri(builder.HostEnvironment.BaseAddress)
});
builder.Services.AddMudServices();
builder.Services.AddLocalStorageServices();
builder.Services.AddSessionStorageServices();
builder.Services.AddMemoryCache();
builder.Services.AddScoped<FeatureClient>();
builder.Services.AddSingleton<AppState>();
builder.Services.AddSingleton<AppService>();

await builder.Build().RunAsync();

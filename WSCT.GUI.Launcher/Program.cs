using WSCT.GUI.Launcher;
using WSCT.GUI.Plugins;
using WSCT.GUI.Services;

var builder = WebApplication.CreateBuilder(args);

// Ensure static web assets are loaded whether running in Dev or Prod (e.g. standalone exe)
builder.WebHost.UseStaticWebAssets();

// Add Razor and Interactive Server components
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

// Core Headless Services
builder.Services.AddSingleton<ILogService, LogService>();
builder.Services.AddSingleton<ISmartCardSessionService, SmartCardSessionService>();

// Discover and configure plugins
var pluginsManager = builder.Services.AddPlugins();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}

app.UseAntiforgery();
app.MapStaticAssets();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode()
    .AddAdditionalAssemblies(
        [
            typeof(WSCT.GUI.Components.CardWorkbench).Assembly,
            .. pluginsManager.PluginAssemblies
        ]
    );

// Initialize smartcard session and layers
var sessionService = app.Services.GetRequiredService<ISmartCardSessionService>();
sessionService.Initialize();

app.Run();
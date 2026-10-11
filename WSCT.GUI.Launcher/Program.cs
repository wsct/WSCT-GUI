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
builder.Services.AddSingleton<PluginsManager>();
builder.Services.AddSingleton<ISmartCardSessionService, SmartCardSessionService>();

// Plugin Services
builder.Services.AddSingleton<WSCT.GUI.Plugins.ISO7816Tools.Services.Iso7816SessionService>();

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
        typeof(WSCT.GUI.Components.CardWorkbench).Assembly,
        typeof(WSCT.GUI.Plugins.LayerInteractive.InteractiveLayerGui).Assembly,
        typeof(WSCT.GUI.Plugins.ISO7816Tools.Iso7816ToolsGui).Assembly
    );

// Discover built-in plugins
var pluginsManager = app.Services.GetRequiredService<PluginsManager>();
pluginsManager.Discover(typeof(WSCT.GUI.Plugins.LayerInteractive.PluginEntry).Assembly);
pluginsManager.Discover(typeof(WSCT.GUI.Plugins.ISO7816Tools.PluginEntry).Assembly);

// Initialize smartcard session and layers
var sessionService = app.Services.GetRequiredService<ISmartCardSessionService>();
sessionService.Initialize();

app.Run();
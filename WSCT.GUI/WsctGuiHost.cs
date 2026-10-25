using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using WSCT.GUI.Components;
using WSCT.GUI.Plugins;
using WSCT.GUI.Services;

namespace WSCT.GUI
{
    public static class WsctGuiHost
    {
        public static void Run(string[] args, string? pluginsDirectory = null)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Ensure static web assets are loaded whether running in Dev or Prod (e.g. standalone exe)
            builder.WebHost.UseStaticWebAssets();

            builder.Services.AddWsctGui(pluginsDirectory);

            var app = builder.Build();

            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
            }

            app.UseAntiforgery();
            app.MapStaticAssets();
            app.UseWsctGui();

            app.Run();
        }

        public static IServiceCollection AddWsctGui(this IServiceCollection services, string? pluginsDirectory = null)
        {
            services.AddRazorComponents()
                .AddInteractiveServerComponents();

            services.AddSingleton<ILogService, LogService>();
            services.AddSingleton<ISmartCardSessionService, SmartCardSessionService>();

            services.AddPlugins(pluginsDirectory);

            return services;
        }

        public static WebApplication UseWsctGui(this WebApplication app)
        {
            var pluginsManager = app.Services.GetRequiredService<PluginsManager>();

            app.MapRazorComponents<App>()
                .AddInteractiveServerRenderMode()
                .AddAdditionalAssemblies([.. pluginsManager.PluginAssemblies]);

            var sessionService = app.Services.GetRequiredService<ISmartCardSessionService>();
            sessionService.Initialize();

            return app;
        }
    }
}

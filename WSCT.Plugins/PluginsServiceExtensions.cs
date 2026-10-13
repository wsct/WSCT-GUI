using Microsoft.Extensions.DependencyInjection;

namespace WSCT.GUI.Plugins
{
    public static class PluginsServiceExtensions
    {
        /// <summary>
        /// Discovers plugins, executes their service configuration, and registers the <see cref="PluginsManager"/> singleton.
        /// </summary>
        /// <param name="services">The service collection.</param>
        /// <param name="pluginsDirectory">Optional directory to scan for plugins; defaults to <see cref="AppDomain.CurrentDomain.BaseDirectory"/>.</param>
        /// <returns>The populated <see cref="PluginsManager"/> instance.</returns>
        public static PluginsManager AddPlugins(this IServiceCollection services, string? pluginsDirectory = null)
        {
            var manager = new PluginsManager();
            manager.DiscoverLoadedAssemblies();
            manager.DiscoverInDirectory(pluginsDirectory ?? AppDomain.CurrentDomain.BaseDirectory);

            foreach (var plugin in manager.Plugins)
            {
                try
                {
                    var instance = plugin.CreateInstance();
                    instance?.ConfigureServices(services);
                }
                catch (Exception)
                {
                    // Ignore service configuration errors for individual failing plugins
                }
            }

            services.AddSingleton(manager);
            return manager;
        }
    }
}

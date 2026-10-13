using Microsoft.Extensions.DependencyInjection;

namespace WSCT.GUI.Plugins
{
    /// <summary>
    /// Public interface to be implemented by all WSCT plugins.
    /// </summary>
    public interface IPlugin
    {
        /// <summary>
        /// Display name of the plugin.
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Description of the plugin.
        /// </summary>
        string Description { get; }

        /// <summary>
        /// Icon class (e.g. Bootstrap icon class).
        /// </summary>
        string Icon => "bi bi-puzzle";

        /// <summary>
        /// The Razor Component type to render in an integrated tab.
        /// </summary>
        Type ComponentType { get; }

        /// <summary>
        /// Configures services required by the plugin in the application dependency injection container.
        /// </summary>
        /// <param name="services">The service collection to register services into.</param>
        void ConfigureServices(IServiceCollection services) { }
    }
}
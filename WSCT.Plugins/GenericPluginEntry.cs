using System.Reflection;

namespace WSCT.GUI.Plugins
{
    /// <summary>
    /// Generic IPlugin implementation for Razor components.
    /// </summary>
    public class GenericPluginEntry<TComponent> : IPlugin
    {
        public virtual string Name => GetType().GetCustomAttribute<PluginEntryAttribute>()?.Name ?? GetType().Name;

        public virtual string Description => GetType().GetCustomAttribute<PluginEntryAttribute>()?.Description ?? string.Empty;

        public virtual string Icon => "bi bi-puzzle";

        public virtual Type ComponentType => typeof(TComponent);
    }
}
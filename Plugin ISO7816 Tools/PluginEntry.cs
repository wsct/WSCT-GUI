using WSCT.GUI.Plugins.ISO7816Tools.Resources;

namespace WSCT.GUI.Plugins.ISO7816Tools
{
    /// <inheritdoc />
    /// <summary>
    /// Plugin Entry point dedicated to create and show associated GUI.
    /// </summary>
    [PluginEntry(Name = nameof(Lang.Iso7816PluginName), Description = nameof(Lang.Iso7816pluginDescription), ResourceType = typeof(Lang))]
    public class PluginEntry : GenericPluginEntry<Gui> //  : IPlugin
    {
    }
}
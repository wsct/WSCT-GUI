using WSCT.GUI.Plugins.LayerInteractive.Resources;

namespace WSCT.GUI.Plugins.LayerInteractive
{
    /// <inheritdoc />
    /// <summary>
    /// Plugin Entry point dedicated to create and show associated GUI.
    /// </summary>
    [PluginEntry(Name = nameof(Lang.ControllerPluginName), Description = nameof(Lang.ControllerPluginDescription), ResourceType = typeof(Lang))]
    public class PluginEntry : GenericPluginEntry<Gui>
    {
    }
}
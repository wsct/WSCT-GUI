using WSCT.GUI.Plugins.LayerInteractive.Resources;

namespace WSCT.GUI.Plugins.LayerInteractive
{
    /// <inheritdoc />
    /// <summary>
    /// Plugin Entry point providing the Interactive Layer controller view.
    /// </summary>
    [PluginEntry(Name = nameof(Lang.ControllerPluginName), Description = nameof(Lang.ControllerPluginDescription), ResourceType = typeof(Lang))]
    public class PluginEntry : GenericPluginEntry<InteractiveLayerGui>
    {
        public override string Icon => "bi bi-sliders";
    }
}
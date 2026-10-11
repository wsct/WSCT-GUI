using WSCT.GUI.Plugins.ISO7816Tools.Resources;

namespace WSCT.GUI.Plugins.ISO7816Tools
{
    /// <inheritdoc />
    /// <summary>
    /// Plugin Entry point providing the ISO 7816 Tools view.
    /// </summary>
    [PluginEntry(Name = nameof(Lang.Iso7816PluginName), Description = nameof(Lang.Iso7816pluginDescription), ResourceType = typeof(Lang))]
    public class PluginEntry : GenericPluginEntry<Iso7816ToolsGui>
    {
        public override string Icon => "bi bi-credit-card-2-front";
    }
}
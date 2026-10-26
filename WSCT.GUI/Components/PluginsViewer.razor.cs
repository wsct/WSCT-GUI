using Microsoft.AspNetCore.Components;
using WSCT.GUI.Plugins;
using WSCT.GUI.Services;

namespace WSCT.GUI.Components
{
    public partial class PluginsViewer(ISmartCardSessionService SessionService)
    {
        [Parameter]
        public EventCallback<PluginInfo> OnOpenPlugin { get; set; }

        private PluginInfo? _selectedPlugin;

        protected override void OnInitialized()
        {
            _selectedPlugin = SessionService.DiscoveredPlugins.FirstOrDefault();
        }

        private void SelectPlugin(PluginInfo plugin)
        {
            _selectedPlugin = plugin;
        }
    }
}
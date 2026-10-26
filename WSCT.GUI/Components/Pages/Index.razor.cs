using WSCT.GUI.Plugins;
using WSCT.GUI.Services;

namespace WSCT.GUI.Components.Pages
{
    public partial class Index(ISmartCardSessionService SessionService)
    {
        private string _activeTabId = "workbench";
        private readonly List<PluginTabItem> _openPluginTabs = [];

        private class PluginTabItem
        {
            public string Id { get; set; } = string.Empty;
            public string Title { get; set; } = string.Empty;
            public string Icon { get; set; } = "bi bi-puzzle";
            public Type ComponentType { get; set; } = null!;
        }

        private void SelectTab(string id)
        {
            _activeTabId = id;
        }

        private void OpenPluginTab(PluginInfo pluginInfo)
        {
            var existing = _openPluginTabs.FirstOrDefault(t => t.Id == pluginInfo.Type.FullName);
            if (existing != null)
            {
                _activeTabId = existing.Id;
                return;
            }

            try
            {
                var instance = pluginInfo.CreateInstance();
                if (instance?.ComponentType != null)
                {
                    var tab = new PluginTabItem
                    {
                        Id = pluginInfo.Type.FullName ?? Guid.NewGuid().ToString(),
                        Title = instance.Name,
                        Icon = instance.Icon,
                        ComponentType = instance.ComponentType
                    };
                    _openPluginTabs.Add(tab);
                    _activeTabId = tab.Id;
                }
            }
            catch (Exception)
            {
                // If plugin fails to instantiate, stay on plugins page
            }
        }

        private void CloseTab(PluginTabItem tab)
        {
            int index = _openPluginTabs.IndexOf(tab);
            _openPluginTabs.Remove(tab);

            if (_activeTabId == tab.Id)
            {
                if (_openPluginTabs.Count > 0)
                {
                    int newIndex = Math.Min(index, _openPluginTabs.Count - 1);
                    _activeTabId = _openPluginTabs[newIndex].Id;
                }
                else
                {
                    _activeTabId = "workbench";
                }
            }
        }
    }
}
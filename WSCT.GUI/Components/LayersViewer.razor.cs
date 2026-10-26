using System.Reflection;
using WSCT.GUI.Services;

namespace WSCT.GUI.Components
{
    public partial class LayersViewer(ISmartCardSessionService SessionService)
    {
        private dynamic? _selectedLayer;
        private string _layerAssemblyName = string.Empty;
        private string _layerAssemblyVersion = string.Empty;
        private string _layerAssemblyDescription = string.Empty;

        protected override void OnInitialized()
        {
            var first = SessionService.ChannelLayerDescriptions?.LayerDescriptions.FirstOrDefault();
            if (first != null)
            {
                SelectLayer(first);
            }
        }

        private void SelectLayer(dynamic layer)
        {
            _selectedLayer = layer;
            try
            {
                string dll = layer.DllName ?? "";
                string path = layer.PathToDll ?? "";
                string fullPath = Path.IsPathRooted(dll) && File.Exists(dll)
                    ? dll
                    : (!string.IsNullOrEmpty(path) && File.Exists(Path.Combine(path, dll))
                        ? Path.Combine(path, dll)
                        : Path.Combine(AppDomain.CurrentDomain.BaseDirectory, Path.GetFileName(dll)));

                if (File.Exists(fullPath))
                {
                    var assembly = Assembly.LoadFrom(fullPath);
                    var name = assembly.GetName();
                    _layerAssemblyName = name.Name ?? "";
                    _layerAssemblyVersion = name.Version?.ToString() ?? "";
                    var desc = assembly.GetCustomAttribute<AssemblyDescriptionAttribute>();
                    _layerAssemblyDescription = desc?.Description ?? "";
                }
                else
                {
                    _layerAssemblyName = Path.GetFileName(dll);
                    _layerAssemblyVersion = "N/A";
                    _layerAssemblyDescription = "DLL file not found on disk.";
                }
            }
            catch (Exception ex)
            {
                _layerAssemblyName = "Error";
                _layerAssemblyVersion = ex.Message;
                _layerAssemblyDescription = string.Empty;
            }
        }
    }
}
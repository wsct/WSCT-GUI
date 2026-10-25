using System.Reflection;

namespace WSCT.GUI.Plugins
{
    public class PluginsManager
    {
        public List<PluginInfo> Plugins { get; }

        public IEnumerable<Assembly> PluginAssemblies => Plugins.Select(p => p.Type.Assembly).Distinct();

        public PluginsManager()
        {
            Plugins = [];
        }

        public void Discover(Assembly assembly)
        {
            foreach (var pluginInfo in EnumeratePluginInfo(assembly))
            {
                if (!Plugins.Any(p => p.Type == pluginInfo.Type))
                {
                    Plugins.Add(pluginInfo);
                }
            }
        }

        public void Discover(string assemblyPath)
        {
            try
            {
                var asmName = Path.GetFileNameWithoutExtension(assemblyPath);
                var loaded = AppDomain.CurrentDomain.GetAssemblies()
                    .FirstOrDefault(a => !a.IsDynamic && string.Equals(a.GetName().Name, asmName, StringComparison.OrdinalIgnoreCase));
                var assembly = loaded ?? Assembly.LoadFrom(assemblyPath);
                Discover(assembly);
            }
            catch (Exception)
            {
                // Ignore files that are not valid .NET assemblies or fail to load
            }
        }

        public void DiscoverInDirectory(string directoryPath)
        {
            if (!Directory.Exists(directoryPath))
            {
                return;
            }

            foreach (var assemblyPath in Directory.EnumerateFiles(directoryPath, "*.dll"))
            {
                Discover(assemblyPath);
            }
        }

        public void DiscoverLoadedAssemblies()
        {
            foreach (var assembly in AppDomain.CurrentDomain.GetAssemblies())
            {
                if (!assembly.IsDynamic)
                {
                    Discover(assembly);
                }
            }
        }

        private static IEnumerable<PluginInfo> EnumeratePluginInfo(Assembly assembly)
        {
            // In a Linux + Mono environment, an exception may be raised on some system dll (System.Runtime.Serialization.Xml.dll): just ignore it
            Type[] typesInAssembly;
            try
            {
                typesInAssembly = assembly.GetTypes();
            }
            catch (ReflectionTypeLoadException ex)
            {
                typesInAssembly = ex.Types.Where(t => t != null).ToArray()!;
            }
            catch (Exception)
            {
                typesInAssembly = Array.Empty<Type>();
            }

            foreach (var type in typesInAssembly)
            {
                PluginEntryAttribute? attribute = null;
                try
                {
                    attribute = type.GetCustomAttribute<PluginEntryAttribute>() as PluginEntryAttribute;
                }
                catch (Exception)
                {
                    // Ignore attribute inspection errors
                }

                if (attribute != null && typeof(IPlugin).IsAssignableFrom(type))
                {
                    yield return new PluginInfo { Type = type, Attribute = attribute };
                }
            }
        }
    }
}

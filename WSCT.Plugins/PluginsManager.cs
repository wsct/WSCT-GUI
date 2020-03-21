using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace WSCT.GUI.Plugins
{
    public class PluginsManager
    {
        public List<PluginInfo> Plugins { get; }

        public PluginsManager()
        {
            Plugins = new List<PluginInfo>();
        }

        public void Discover(Assembly assembly)
        {
            foreach (var pluginInfo in EnumeratePluginInfo(assembly))
            {
                Plugins.Add(pluginInfo);
            }
        }

        public void Discover(string assemblyPath)
        {
            Discover(Assembly.LoadFrom(assemblyPath));
        }

        public void DiscoverInDirectory(string directoryPath)
        {
            foreach (var assemblyPath in Directory.EnumerateFiles(directoryPath, "*.dll"))
            {
                Discover(assemblyPath);
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
            catch (Exception)
            {
                typesInAssembly = Array.Empty<Type>();
            }

            foreach (var type in typesInAssembly)
            {
                if (type.GetCustomAttribute(typeof(PluginEntryAttribute)) is PluginEntryAttribute attribute)
                {
                    yield return new PluginInfo { Type = type, Attribute = attribute };
                }
            }
        }
    }
}

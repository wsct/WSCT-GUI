using System;
using System.Reflection;

namespace WSCT.GUI.Plugins
{
    public class PluginInfo
    {
        public Type Type { get; set; }
        public PluginEntryAttribute Attribute { get; set; }

        public IPlugin CreateInstance()
        {
            Assembly.Load(Type.Assembly.GetName());
            return (IPlugin)Activator.CreateInstance(Type);
        }
    }
}
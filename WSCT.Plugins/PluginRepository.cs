using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Serialization;
using WSCT.Helpers.Reflection;

namespace WSCT.GUI.Plugins
{
    /// <summary>
    /// 
    /// </summary>
    [XmlRoot("Plugins")]
    public class PluginRepository
    {
        #region >> Fields

        private List<PluginDescription> _plugins;

        #endregion

        #region >> Properties

        /// <summary>
        /// Plugins Count
        /// </summary>
        [XmlIgnore]
        public int Count
        {
            get { return _plugins.Count; }
        }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement("plugin")]
        public List<PluginDescription> Plugins
        {
            get { return _plugins; }
            set { _plugins = value; }
        }

        #endregion

        #region >> Constructors

        /// <summary>
        /// Creates a new instance.
        /// </summary>
        public PluginRepository()
        {
            _plugins = new List<PluginDescription>();
        }

        #endregion

        #region >> Static methods

        /// <summary>
        /// Create a new instance of the plugin described by <see cref="PluginDescription"/>.
        /// </summary>
        /// <param name="description">Descriptor of the plugin to be instanciated.</param>
        /// <returns>A new instance of the plugin.</returns>
        public static IPlugin CreateInstance(PluginDescription description)
        {
            return AssemblyLoader.CreateInstance<IPlugin>(description.PathToDll + description.DllName, description.ClassName);
        }

        #endregion

        #region >> Methods

        /// <summary>
        /// Add a new plugin descriptor to the manager.
        /// </summary>
        /// <param name="pluginDescription">Descriptor of the plugin to be added.</param>
        public void Add(PluginDescription pluginDescription)
        {
            _plugins.Add(pluginDescription);
        }

        /// <summary>
        /// Create a new instance of the plugin named <paramref name="pluginName"/>.
        /// </summary>
        /// <param name="pluginName">Name of the plugin to be instanciated.</param>
        /// <returns>A new instance of the plugin.</returns>
        public IPlugin CreateInstance(String pluginName)
        {
            return CreateInstance(Get(pluginName));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pluginName">Name of the plugin to look for.</param>
        /// <returns><c>true</c> if the plugin descriptor exists.</returns>
        public Boolean IsValid(String pluginName)
        {
            return _plugins.Any(plugin => plugin.Name == pluginName);
        }

        /// <summary>
        /// Get the <see cref="PluginDescription"/> instance which name is <paramref name="pluginName"/>.
        /// </summary>
        /// <param name="pluginName"></param>
        /// <returns>The PluginDescriptor instance or null if not find.</returns>
        public PluginDescription Get(String pluginName)
        {
            return _plugins.FirstOrDefault(plugin => plugin.Name == pluginName && plugin.IsValid);
        }

        #endregion
    }
}
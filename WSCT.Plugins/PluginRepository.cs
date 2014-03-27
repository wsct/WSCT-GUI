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
        public int count
        {
            get { return _plugins.Count; }
        }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement("plugin")]
        public List<PluginDescription> plugins
        {
            get { return _plugins; }
            set { _plugins = value; }
        }

        #endregion

        #region >> Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public PluginRepository()
        {
            _plugins = new List<PluginDescription>();
        }

        #endregion

        #region >> Static methods

        /// <summary>
        /// Create a new instance of the pluginDesc described by <c>PluginDescriptor</c>
        /// </summary>
        /// <param name="pluginDesc">Descriptor of the pluginDesc to be instanciated</param>
        /// <returns>A new instance of the pluginDesc</returns>
        public static IPlugin createInstance(PluginDescription pluginDesc)
        {
            return AssemblyLoader.CreateInstance<IPlugin>(pluginDesc.pathToDll + pluginDesc.dllName, pluginDesc.className);
        }

        #endregion

        #region >> Methods

        /// <summary>
        /// Add a new pluginDesc descriptor to the manager
        /// </summary>
        /// <param name="pluginDesc">Descriptor of the pluginDesc to be added</param>
        public void add(PluginDescription pluginDesc)
        {
            _plugins.Add(pluginDesc);
        }

        /// <summary>
        /// Create a new instance of the pluginDesc named <c>pluginNamed</c>
        /// </summary>
        /// <param name="pluginName">Name of the pluginDesc to be instanciated</param>
        /// <returns>A new instance of the pluginDesc</returns>
        public IPlugin createInstance(String pluginName)
        {
            return createInstance(get(pluginName));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pluginName">Name of the pluginDesc to look for</param>
        /// <returns><c>true</c> if the pluginDesc descriptor exists</returns>
        public Boolean isValid(String pluginName)
        {
            return _plugins.Any(plugin => plugin.name == pluginName);
        }

        /// <summary>
        /// Get the <c>PluginDescriptor</c> instance which name is <c>pluginName</c>
        /// </summary>
        /// <param name="pluginName"></param>
        /// <returns>The PluginDescriptor instance or null if not find</returns>
        public PluginDescription get(String pluginName)
        {
            return _plugins.FirstOrDefault(plugin => plugin.name == pluginName && plugin.isValid);
        }

        #endregion
    }
}
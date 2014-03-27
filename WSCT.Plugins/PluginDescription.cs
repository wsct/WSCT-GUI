using System;
using System.Xml.Serialization;

namespace WSCT.GUI.Plugins
{
    /// <summary>
    /// 
    /// </summary>
    public class PluginDescription
    {
        #region >> Fields

        private String _className;
        private String _dllName;
        private String _name;
        private String _pathToDll;

        #endregion

        #region >> Constructors

        /// <summary>
        /// 
        /// </summary>
        public PluginDescription()
        {
            _pathToDll = "";
        }

        #endregion

        #region >> Properties

        /// <summary>
        /// 
        /// </summary>
        [XmlAttribute("name")]
        public String name
        {
            get { return _name; }
            set { _name = (value == "" ? null : value); }
        }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement("dll")]
        public String dllName
        {
            get { return _dllName; }
            set { _dllName = (value == "" ? null : value); }
        }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement("className")]
        public String className
        {
            get { return _className; }
            set { _className = (value ?? string.Empty); }
        }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement("pathToDll")]
        public String pathToDll
        {
            get { return _pathToDll; }
            set { _pathToDll = (value ?? string.Empty); }
        }

        /// <summary>
        /// 
        /// </summary>
        [XmlIgnore]
        public Boolean isValid
        {
            get { return (name != null && _dllName != null); }
        }

        #endregion
    }
}
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
        public String Name
        {
            get { return _name; }
            set { _name = (value == "" ? null : value); }
        }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement("dll")]
        public String DllName
        {
            get { return _dllName; }
            set { _dllName = (value == "" ? null : value); }
        }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement("className")]
        public String ClassName
        {
            get { return _className; }
            set { _className = (value ?? string.Empty); }
        }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement("pathToDll")]
        public String PathToDll
        {
            get { return _pathToDll; }
            set { _pathToDll = (value ?? string.Empty); }
        }

        /// <summary>
        /// 
        /// </summary>
        [XmlIgnore]
        public Boolean IsValid
        {
            get { return (Name != null && _dllName != null); }
        }

        #endregion
    }
}
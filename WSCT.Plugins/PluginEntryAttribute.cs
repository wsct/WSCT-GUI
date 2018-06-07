using System;

namespace WSCT.GUI.Plugins
{
    public class PluginEntryAttribute : Attribute
    {
        private readonly LocalizableString _name = new LocalizableString();
        private readonly LocalizableString _description = new LocalizableString();
        private Type _resourceType;

        /// <summary>
        /// Name of the plugin, localized if <see cref="ResourceType"/> is set.
        /// </summary>
        public string Name
        {
            get => _name.LocalizedValue;
            set => _name.Value = value;
        }

        /// <summary>
        /// Description of the plugin, localized if <see cref="ResourceType"/> is set.
        /// </summary>
        public string Description
        {
            get => _description.LocalizedValue;
            set => _description.Value = value;
        }

        /// <summary>
        /// Type that contains the resources for the <see cref="Name"/> and <see cref="Description"/>.
        /// </summary>
        public Type ResourceType
        {
            get => _resourceType;
            set
            {
                _resourceType = value;
                _name.ResourceType = value;
                _description.ResourceType = value;
            }
        }
    }
}

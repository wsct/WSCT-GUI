using System;

namespace WSCT.GUI.Plugins
{
    /// <summary>
    /// Helper class for providing a localizable string property. 
    /// </summary>
    /// <remarks>
    /// Inspired by https://referencesource.microsoft.com/#System.ComponentModel.DataAnnotations/DataAnnotations/LocalizableString.cs
    /// </remarks>
    internal class LocalizableString
    {
        #region >> Private Fields

        private string _value;
        private Type _resourceType;

        private string _localizedValue;

        #endregion

        #region >> Properties

        /// <summary>
        /// Localized value if available or else the <see cref="Value"/>.
        /// </summary>
        public string LocalizedValue
        {
            get
            {
                if (_localizedValue == null)
                {
                    if (_value == null || _resourceType == null)
                    {
                        _localizedValue = _value;
                    }
                    else
                    {
                        var property = _resourceType.GetProperty(_value);
                        if (property == null)
                        {
                            _localizedValue = _value;
                        }
                        else
                        {
                            _localizedValue = property.GetValue(null) as string;
                        }
                    }
                }

                return _localizedValue;
            }
        }

        /// <summary>
        /// Raw value if <see cref="ResourceType"/> is <c>null</c> or resource identifier in <see cref="ResourceType"/>.
        /// </summary>
        public string Value
        {
            get => _value;
            set
            {
                if (_value == value)
                {
                    return;
                }

                _localizedValue = null;
                _value = value;
            }
        }

        /// <summary>
        /// Resource type to be used for localization.
        /// </summary>
        public Type ResourceType
        {
            get => _resourceType;
            set
            {
                if (_resourceType != value)
                {
                    _localizedValue = null;
                    _resourceType = value;
                }
            }
        }

        #endregion
    }
}

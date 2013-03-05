using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

using WSCT.Wrapper;

namespace WSCT.Layers.Interactive.Actions
{
    /// <summary>
    /// Concrete action: getAttrib(...)
    /// <see cref="WSCT.Core.ICardChannel.getAttrib"/>
    /// </summary>
    [XmlRoot("getAttrib")]
    public class GetAttribAction : AbstractAction, IXmlSerializable
    {
        #region >> Constructors

        /// <summary>
        /// R-APDU
        /// </summary>
        public String response
        { get; set; }

        /// <summary>
        /// Action parameter
        /// </summary>
        public Attrib attrib
        { get; set; }

        #endregion

        #region >> Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public GetAttribAction()
            : base("getAttrib")
        {
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="attrib">Action parameter</param>
        /// <param name="response">Action parameter</param>
        public GetAttribAction(Attrib attrib, String response)
            : this()
        {
            this.attrib = attrib;
            this.response = response;
        }

        #endregion

        #region >> IXmlSerializable Members

        /// <inheritdoc />
        public System.Xml.Schema.XmlSchema GetSchema()
        {
            return null;
        }

        /// <inheritdoc />
        public void ReadXml(System.Xml.XmlReader reader)
        {
            attrib = (Attrib)Enum.Parse(typeof(Attrib), reader.GetAttribute("attrib"));
            reader.ReadStartElement();
            response = reader.ReadString();
            reader.ReadEndElement();
        }

        /// <inheritdoc />
        public void WriteXml(System.Xml.XmlWriter writer)
        {
            writer.WriteAttributeString("attrib", attrib.ToString());
            writer.WriteString(response);
        }

        #endregion
    }
}

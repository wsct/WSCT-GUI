using System;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using WSCT.Core;
using WSCT.Wrapper;

namespace WSCT.Layers.Interactive.Actions
{
    /// <summary>
    /// Concrete action: getAttrib(...)
    /// <see cref="ICardChannel.GetAttrib"/>
    /// </summary>
    [XmlRoot("getAttrib")]
    public class GetAttribAction : AbstractAction, IXmlSerializable
    {
        #region >> Constructors

        /// <summary>
        /// R-APDU
        /// </summary>
        public String response { get; set; }

        /// <summary>
        /// Action parameter
        /// </summary>
        public Attrib attrib { get; set; }

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
        public XmlSchema GetSchema()
        {
            return null;
        }

        /// <inheritdoc />
        public void ReadXml(XmlReader reader)
        {
            attrib = (Attrib)Enum.Parse(typeof(Attrib), reader.GetAttribute("attrib"));
            reader.ReadStartElement();
            response = reader.ReadString();
            reader.ReadEndElement();
        }

        /// <inheritdoc />
        public void WriteXml(XmlWriter writer)
        {
            writer.WriteAttributeString("attrib", attrib.ToString());
            writer.WriteString(response);
        }

        #endregion
    }
}
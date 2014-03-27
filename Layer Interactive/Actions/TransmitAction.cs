using System;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using WSCT.Core;

namespace WSCT.Layers.Interactive.Actions
{
    /// <summary>
    /// Concrete action: transmit(...)
    /// <see cref="ICardChannel.Transmit"/>
    /// </summary>
    [XmlRoot("transmit")]
    public class TransmitAction : AbstractAction, IXmlSerializable
    {
        #region >> Properties

        /// <summary>
        /// R-APDU
        /// </summary>
        public String response { get; set; }

        /// <summary>
        /// C-APDU
        /// </summary>
        public String command { get; set; }

        #endregion

        #region >> Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public TransmitAction()
            : base("transmit")
        {
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="command">C-APDU</param>
        /// <param name="response">R-APDU</param>
        public TransmitAction(String command, String response)
            : this()
        {
            this.command = command;
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
            command = reader.GetAttribute("command");
            reader.ReadStartElement();
            response = reader.ReadString();
            reader.ReadEndElement();
        }

        /// <inheritdoc />
        public void WriteXml(XmlWriter writer)
        {
            writer.WriteAttributeString("command", command);
            writer.WriteString(response);
        }

        #endregion
    }
}
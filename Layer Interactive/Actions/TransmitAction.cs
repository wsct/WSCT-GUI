using System;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using WSCT.Core;

namespace WSCT.Layers.Interactive.Actions
{
    /// <summary>
    /// Concrete action: transmit(...).
    /// <see cref="ICardChannel.Transmit"/>
    /// </summary>
    [XmlRoot("transmit")]
    public class TransmitAction : AbstractAction, IXmlSerializable
    {
        #region >> Properties

        /// <summary>
        /// R-APDU.
        /// </summary>
        public String Response { get; set; }

        /// <summary>
        /// C-APDU.
        /// </summary>
        public String Command { get; set; }

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
        /// Creates a new instance.
        /// </summary>
        /// <param name="command">C-APDU.</param>
        /// <param name="response">R-APDU.</param>
        public TransmitAction(String command, String response)
            : this()
        {
            Command = command;
            Response = response;
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
            Command = reader.GetAttribute("command");
            reader.ReadStartElement();
            Response = reader.ReadContentAsString();
            reader.ReadEndElement();
        }

        /// <inheritdoc />
        public void WriteXml(XmlWriter writer)
        {
            writer.WriteAttributeString("command", Command);
            writer.WriteString(Response);
        }

        #endregion
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Xml.Serialization;

namespace WSCT.Layers.Interactive.Actions
{
    /// <summary>
    /// Concrete action: transmit(...)
    /// <see cref="WSCT.Core.ICardChannel.transmit"/>
    /// </summary>
    [XmlRoot("transmit")]
    public class TransmitAction : AbstractAction, IXmlSerializable
    {
        #region >> Properties

        /// <summary>
        /// R-APDU
        /// </summary>
        public String response
        { get; set; }

        /// <summary>
        /// C-APDU
        /// </summary>
        public String command
        { get; set; }

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
        public System.Xml.Schema.XmlSchema GetSchema()
        {
            return null;
        }

        /// <inheritdoc />
        public void ReadXml(System.Xml.XmlReader reader)
        {
            command = reader.GetAttribute("command");
            reader.ReadStartElement();
            response = reader.ReadString();
            reader.ReadEndElement();
        }

        /// <inheritdoc />
        public void WriteXml(System.Xml.XmlWriter writer)
        {
            writer.WriteAttributeString("command", command);
            writer.WriteString(response);
        }

        #endregion
    }
}

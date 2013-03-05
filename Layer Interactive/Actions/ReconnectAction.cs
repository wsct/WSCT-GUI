using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

using WSCT.Wrapper;

namespace WSCT.Layers.Interactive.Actions
{
    /// <summary>
    /// Concrete action: reconnect(...)
    /// <see cref="WSCT.Core.ICardChannel.reconnect"/>
    /// </summary>
    [XmlRoot("reconnect")]
    public class ReconnectAction : AbstractAction, IXmlSerializable
    {
        #region >> Properties

        /// <summary>
        /// Action parameter
        /// </summary>
        public Protocol protocol
        { get; set; }

        /// <summary>
        /// Action parameter
        /// </summary>
        public Disposition initialization
        { get; set; }

        #endregion

        #region >> Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ReconnectAction()
            : base("reconnect")
        {
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="protocol">Action parameter</param>
        /// <param name="initialization">Action parameter</param>
        public ReconnectAction(Protocol protocol, Disposition initialization)
            : this()
        {
            this.protocol = protocol;
            this.initialization = initialization;
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
            initialization = (Disposition)Enum.Parse(typeof(Disposition), reader.GetAttribute("initialization"));
            reader.ReadStartElement();
            protocol = (Protocol)Enum.Parse(typeof(Protocol), reader.ReadString());
            reader.ReadEndElement();
        }

        /// <inheritdoc />
        public void WriteXml(System.Xml.XmlWriter writer)
        {
            writer.WriteAttributeString("initialization", initialization.ToString());
            writer.WriteString(protocol.ToString());
        }

        #endregion
    }
}

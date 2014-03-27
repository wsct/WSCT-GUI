using System;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using WSCT.Core;
using WSCT.Wrapper;

namespace WSCT.Layers.Interactive.Actions
{
    /// <summary>
    /// Concrete action: reconnect(...)
    /// <see cref="ICardChannel.Reconnect"/>
    /// </summary>
    [XmlRoot("reconnect")]
    public class ReconnectAction : AbstractAction, IXmlSerializable
    {
        #region >> Properties

        /// <summary>
        /// Action parameter
        /// </summary>
        public Protocol protocol { get; set; }

        /// <summary>
        /// Action parameter
        /// </summary>
        public Disposition initialization { get; set; }

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
        public XmlSchema GetSchema()
        {
            return null;
        }

        /// <inheritdoc />
        public void ReadXml(XmlReader reader)
        {
            initialization = (Disposition)Enum.Parse(typeof(Disposition), reader.GetAttribute("initialization"));
            reader.ReadStartElement();
            protocol = (Protocol)Enum.Parse(typeof(Protocol), reader.ReadString());
            reader.ReadEndElement();
        }

        /// <inheritdoc />
        public void WriteXml(XmlWriter writer)
        {
            writer.WriteAttributeString("initialization", initialization.ToString());
            writer.WriteString(protocol.ToString());
        }

        #endregion
    }
}
using System;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using WSCT.Core;
using WSCT.Wrapper;

namespace WSCT.Layers.Interactive.Actions
{
    /// <summary>
    /// Concrete action: connect(...)
    /// <see cref="ICardChannel.Connect"/>
    /// </summary>
    [XmlRoot("connect")]
    public class ConnectAction : AbstractAction, IXmlSerializable
    {
        #region >> Properties

        /// <summary>
        /// Action parameter
        /// </summary>
        public Protocol protocol { get; set; }

        #endregion

        #region >> Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ConnectAction()
            : base("connect")
        {
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="protocol">Action parameter</param>
        public ConnectAction(Protocol protocol)
            : this()
        {
            this.protocol = protocol;
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
            reader.ReadStartElement();
            protocol = (Protocol)Enum.Parse(typeof(Protocol), reader.ReadString());
            reader.ReadEndElement();
        }

        /// <inheritdoc />
        public void WriteXml(XmlWriter writer)
        {
            writer.WriteString(protocol.ToString());
        }

        #endregion
    }
}
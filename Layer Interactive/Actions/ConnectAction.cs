using System;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using WSCT.Core;
using WSCT.Wrapper;

namespace WSCT.Layers.Interactive.Actions
{
    /// <summary>
    /// Concrete action: connect(...).
    /// <see cref="ICardChannel.Connect"/>.
    /// </summary>
    [XmlRoot("connect")]
    public class ConnectAction : AbstractAction, IXmlSerializable
    {
        #region >> Properties

        /// <summary>
        /// Action parameter.
        /// </summary>
        public Protocol Protocol { get; set; }

        #endregion

        #region >> Constructors

        /// <summary>
        /// Creates a new instance.
        /// </summary>
        public ConnectAction()
            : base("connect")
        {
        }

        /// <summary>
        /// Creates a new instance.
        /// </summary>
        /// <param name="protocol">Action parameter.</param>
        public ConnectAction(Protocol protocol)
            : this()
        {
            Protocol = protocol;
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
            Protocol = (Protocol)Enum.Parse(typeof(Protocol), reader.ReadString());
            reader.ReadEndElement();
        }

        /// <inheritdoc />
        public void WriteXml(XmlWriter writer)
        {
            writer.WriteString(Protocol.ToString());
        }

        #endregion
    }
}
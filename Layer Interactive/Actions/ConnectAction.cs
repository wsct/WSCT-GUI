using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

using WSCT.Wrapper;

namespace WSCT.Layers.Interactive.Actions
{
    /// <summary>
    /// Concrete action: connect(...)
    /// <see cref="WSCT.Core.ICardChannel.connect"/>
    /// </summary>
    [XmlRoot("connect")]
    public class ConnectAction : AbstractAction, IXmlSerializable
    {
        #region >> Properties

        /// <summary>
        /// Action parameter
        /// </summary>
        public Protocol protocol
        { get; set; }

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
        public System.Xml.Schema.XmlSchema GetSchema()
        {
            return null;
        }

        /// <inheritdoc />
        public void ReadXml(System.Xml.XmlReader reader)
        {
            reader.ReadStartElement();
            protocol = (Protocol)Enum.Parse(typeof(Protocol), reader.ReadString());
            reader.ReadEndElement();
        }

        /// <inheritdoc />
        public void WriteXml(System.Xml.XmlWriter writer)
        {
            writer.WriteString(protocol.ToString());
        }

        #endregion
    }
}

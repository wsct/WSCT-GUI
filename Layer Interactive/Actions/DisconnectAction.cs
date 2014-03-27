using System;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using WSCT.Core;
using WSCT.Wrapper;

namespace WSCT.Layers.Interactive.Actions
{
    /// <summary>
    /// Concrete action: disconnect(...)
    /// <see cref="ICardChannel.Disconnect"/>
    /// </summary>
    [XmlRoot("disconnect")]
    public class DisconnectAction : AbstractAction, IXmlSerializable
    {
        #region >> Properties

        /// <summary>
        /// A parameter of the action
        /// </summary>
        public Disposition disposition { get; set; }

        #endregion

        #region >> Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public DisconnectAction()
            : base("reconnect")
        {
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="disposition">Value of the parameter</param>
        public DisconnectAction(Disposition disposition)
            : this()
        {
            this.disposition = disposition;
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
            disposition = (Disposition)Enum.Parse(typeof(Disposition), reader.GetAttribute("disposition"));
            reader.ReadStartElement();
            reader.ReadEndElement();
        }

        /// <inheritdoc />
        public void WriteXml(XmlWriter writer)
        {
            writer.WriteAttributeString("disposition", disposition.ToString());
        }

        #endregion
    }
}
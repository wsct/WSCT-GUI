using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

using WSCT.Wrapper;

namespace WSCT.Layers.Interactive.Actions
{
    /// <summary>
    /// Concrete action: disconnect(...)
    /// <see cref="WSCT.Core.ICardChannel.disconnect"/>
    /// </summary>
    [XmlRoot("disconnect")]
    public class DisconnectAction : AbstractAction, IXmlSerializable
    {
        #region >> Properties

        /// <summary>
        /// A parameter of the action
        /// </summary>
        public Disposition disposition
        { get; set; }

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
        public System.Xml.Schema.XmlSchema GetSchema()
        {
            return null;
        }

        /// <inheritdoc />
        public void ReadXml(System.Xml.XmlReader reader)
        {
            disposition = (Disposition)Enum.Parse(typeof(Disposition), reader.GetAttribute("disposition"));
            reader.ReadStartElement();
            reader.ReadEndElement();
        }

        /// <inheritdoc />
        public void WriteXml(System.Xml.XmlWriter writer)
        {
            writer.WriteAttributeString("disposition", disposition.ToString());
        }

        #endregion
    }
}

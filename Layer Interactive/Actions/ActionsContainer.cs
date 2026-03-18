using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace WSCT.Layers.Interactive.Actions
{
    /// <summary>
    /// Actions container that can be serialized / deserialized.
    /// </summary>
    [XmlRoot("actions")]
    public class ActionsContainer : IXmlSerializable
    {
        #region >> Properties

        /// <summary>
        /// List of concrete actions.
        /// </summary>
        public List<AbstractAction> ActionsList { get; set; } = [];

        #endregion

        #region >> Constructors

        /// <summary>
        /// Creates a new instance.
        /// </summary>
        public ActionsContainer()
        {
        }

        /// <summary>
        /// Creates a new instance.
        /// </summary>
        /// <param name="actionList">List on concrete actions to be handled by the object.</param>
        public ActionsContainer(List<AbstractAction> actionList)
            : this()
        {
            ActionsList = actionList;
        }

        #endregion

        #region >> IXmlSerializable Members

        /// <inheritdoc />
        public XmlSchema? GetSchema()
        {
            return null;
        }

        /// <inheritdoc />
        public void ReadXml(XmlReader reader)
        {
            ActionsList = [];

            reader.ReadStartElement();

            while (reader.NodeType != XmlNodeType.EndElement)
            {
                switch (reader.NodeType)
                {
                    case (XmlNodeType.Element):
                        var serializer = reader.Name switch
                        {
                            "connect" => new XmlSerializer(typeof(ConnectAction)),
                            "disconnect" => new XmlSerializer(typeof(DisconnectAction)),
                            "getAttrib" => new XmlSerializer(typeof(GetAttribAction)),
                            "reconnect" => new XmlSerializer(typeof(ReconnectAction)),
                            "transmit" => new XmlSerializer(typeof(TransmitAction)),
                            _ => throw new Exception($"Unattended node name [{reader.Name}] when deserializing"),
                        };
                        if (serializer.Deserialize(reader) is AbstractAction action)
                        {
                            ActionsList.Add(action);
                        }
                        break;
                    case (XmlNodeType.Comment):
                        reader.ReadContentAsString();
                        break;
                    default:
                        throw new Exception($"Unattended XmlNodeType [{reader.NodeType}] when deserializing");
                }
            }

            reader.ReadEndElement();
        }

        /// <inheritdoc />
        public void WriteXml(XmlWriter writer)
        {
            foreach (var action in ActionsList)
            {
                XmlSerializer serializer;
                if (action is ConnectAction)
                {
                    serializer = new XmlSerializer(typeof(ConnectAction));
                }
                else if (action is DisconnectAction)
                {
                    serializer = new XmlSerializer(typeof(DisconnectAction));
                }
                else if (action is GetAttribAction)
                {
                    serializer = new XmlSerializer(typeof(GetAttribAction));
                }
                else if (action is ReconnectAction)
                {
                    serializer = new XmlSerializer(typeof(ReconnectAction));
                }
                else if (action is TransmitAction)
                {
                    serializer = new XmlSerializer(typeof(TransmitAction));
                }
                else
                {
                    throw new Exception("Unknown AbstractInteractiveClass to serialize");
                }
                serializer.Serialize(writer, action);
            }
        }

        #endregion
    }
}
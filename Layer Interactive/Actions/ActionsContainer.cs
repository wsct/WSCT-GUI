using System;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace WSCT.Layers.Interactive.Actions
{
    /// <summary>
    /// Actions container that can be serialized / deserialized
    /// </summary>
    [XmlRoot("actions")]
    public class ActionsContainer : IXmlSerializable
    {
        #region >> Properties

        /// <summary>
        /// List of concrete actions
        /// </summary>
        public List<AbstractAction> actionsList { get; set; }

        #endregion

        #region >> Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ActionsContainer()
        {
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="actionList">List on concrete actions to be handled by the object</param>
        public ActionsContainer(List<AbstractAction> actionList)
            : this()
        {
            actionsList = actionList;
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
            actionsList = new List<AbstractAction>();

            reader.ReadStartElement();

            while (reader.NodeType != XmlNodeType.EndElement)
            {
                switch (reader.NodeType)
                {
                    case (XmlNodeType.Element):
                        XmlSerializer serializer;
                        switch (reader.Name)
                        {
                            case "connect":
                                serializer = new XmlSerializer(typeof(ConnectAction));
                                break;
                            case "disconnect":
                                serializer = new XmlSerializer(typeof(DisconnectAction));
                                break;
                            case "getAttrib":
                                serializer = new XmlSerializer(typeof(GetAttribAction));
                                break;
                            case "reconnect":
                                serializer = new XmlSerializer(typeof(ReconnectAction));
                                break;
                            case "transmit":
                                serializer = new XmlSerializer(typeof(TransmitAction));
                                break;
                            default:
                                throw new Exception(String.Format("Unattended node name [{0}] when deserializing", reader.Name));
                        }
                        actionsList.Add((AbstractAction)serializer.Deserialize(reader));
                        break;
                    case (XmlNodeType.Comment):
                        reader.ReadString();
                        break;
                    default:
                        throw new Exception(String.Format("Unattended XmlNodeType [{0}] when deserializing", reader.NodeType));
                }
            }

            reader.ReadEndElement();
        }

        /// <inheritdoc />
        public void WriteXml(XmlWriter writer)
        {
            foreach (var action in actionsList)
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
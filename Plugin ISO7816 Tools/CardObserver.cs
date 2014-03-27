using System;
using WSCT.Core;
using WSCT.Core.APDU;
using WSCT.ISO7816;
using WSCT.Wrapper;

namespace WSCT.GUI.Plugins.ISO7816Tools
{
    internal class CardObserver
    {
        private readonly GUI gui;

        #region >> Constructors

        public CardObserver(GUI _gui)
            : this(_gui, "[{0,7}] Core ")
        {
        }

        public CardObserver(GUI _gui, String _header)
        {
            gui = _gui;
        }

        #endregion

        /// <summary>
        /// 
        /// </summary>
        /// <param name="channel"></param>
        public void observeChannel(ICardChannelObservable channel)
        {
            channel.BeforeConnectEvent += beforeConnect;
            channel.AfterConnectEvent += notifyConnect;

            channel.BeforeDisconnectEvent += beforeDisconnect;
            channel.AfterDisconnectEvent += notifyDisconnect;

            channel.BeforeGetAttribEvent += beforeGetAttrib;
            channel.AfterGetAttribEvent += notifyGetAttrib;

            channel.BeforeReconnectEvent += beforeReconnect;
            channel.AfterReconnectEvent += notifyReconnect;

            channel.BeforeTransmitEvent += beforeTransmit;
            channel.AfterTransmitEvent += notifyTransmit;
        }

        #region >> CardChannelObservable delegates

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cardChannel"></param>
        /// <param name="errorCode"></param>
        /// <param name="shareMode"></param>
        /// <param name="preferedProtocol"></param>
        public void notifyConnect(ICardChannel cardChannel, ShareMode shareMode, Protocol preferedProtocol, ErrorCode errorCode)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cardChannel"></param>
        /// <param name="errorCode"></param>
        /// <param name="disposition"></param>
        public void notifyDisconnect(ICardChannel cardChannel, Disposition disposition, ErrorCode errorCode)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cardChannel"></param>
        /// <param name="errorCode"></param>
        /// <param name="attrib"></param>
        /// <param name="buffer"></param>
        public void notifyGetAttrib(ICardChannel cardChannel, Attrib attrib, byte[] buffer, ErrorCode errorCode)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cardChannel"></param>
        /// <param name="errorCode"></param>
        /// <param name="shareMode"></param>
        /// <param name="preferedProtocol"></param>
        /// <param name="initialization"></param>
        public void notifyReconnect(ICardChannel cardChannel, ShareMode shareMode, Protocol preferedProtocol, Disposition initialization, ErrorCode errorCode)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cardChannel"></param>
        /// <param name="errorCode"></param>
        /// <param name="cardCommand"></param>
        /// <param name="cardResponse"></param>
        public void notifyTransmit(ICardChannel cardChannel, ICardCommand cardCommand, ICardResponse cardResponse, ErrorCode errorCode)
        {
            if (gui.InvokeRequired)
            {
                gui.Invoke(new AfterTransmit(notifyTransmit), new Object[] { cardChannel, cardCommand, cardResponse, errorCode });
            }
            else
            {
                if (errorCode == ErrorCode.Success)
                {
                    gui.updateRAPDU(cardResponse);
                    gui.updateStatusWord((ResponseAPDU)cardResponse);
                    gui.updateHistoric(cardCommand, cardResponse);
                }
                else
                {
                    gui.updateRAPDU(null);
                    gui.updateStatusWord(null);
                    gui.updateHistoric(cardCommand, null);
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cardChannel"></param>
        /// <param name="shareMode"></param>
        /// <param name="preferedProtocol"></param>
        public void beforeConnect(ICardChannel cardChannel, ShareMode shareMode, Protocol preferedProtocol)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cardChannel"></param>
        /// <param name="disposition"></param>
        public void beforeDisconnect(ICardChannel cardChannel, Disposition disposition)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cardChannel"></param>
        /// <param name="attrib"></param>
        /// <param name="buffer"></param>
        public void beforeGetAttrib(ICardChannel cardChannel, Attrib attrib, byte[] buffer)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cardChannel"></param>
        /// <param name="shareMode"></param>
        /// <param name="preferedProtocol"></param>
        /// <param name="initialization"></param>
        public void beforeReconnect(ICardChannel cardChannel, ShareMode shareMode, Protocol preferedProtocol, Disposition initialization)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cardChannel"></param>
        /// <param name="cardCommand"></param>
        /// <param name="recvBuffer"></param>
        /// <param name="recvSize"></param>
        public void beforeTransmit(ICardChannel cardChannel, ICardCommand cardCommand, byte[] recvBuffer, UInt32 recvSize)
        {
            if (gui.InvokeRequired)
            {
                gui.Invoke(new BeforeTransmit(beforeTransmit), new Object[] { cardChannel, cardCommand, recvBuffer, recvSize });
            }
            else
            {
                gui.updateCAPDU(cardCommand);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cardChannel"></param>
        /// <param name="cardCommand"></param>
        /// <param name="cardResponse"></param>
        public void beforeTransmit(ICardChannel cardChannel, ICardCommand cardCommand, ICardResponse cardResponse)
        {
            if (gui.InvokeRequired)
            {
                gui.Invoke(new BeforeTransmit(beforeTransmit), new Object[] { cardChannel, cardCommand, cardResponse });
            }
            else
            {
                gui.updateCAPDU(cardCommand);
            }
        }

        #endregion
    }
}
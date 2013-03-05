using System;
using System.Collections.Generic;
using System.Text;

using WSCT.Core;
using WSCT.Core.APDU;
using WSCT.Wrapper;

using WSCT.Helpers;

namespace WSCT.GUI.Plugins.ISO7816Tools
{
    class CardObserver
    {
        private GUI gui;

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
        public void observeChannel(Core.ICardChannelObservable channel)
        {
            channel.beforeConnectEvent += beforeConnect;
            channel.afterConnectEvent += notifyConnect;

            channel.beforeDisconnectEvent += beforeDisconnect;
            channel.afterDisconnectEvent += notifyDisconnect;

            channel.beforeGetAttribEvent += beforeGetAttrib;
            channel.afterGetAttribEvent += notifyGetAttrib;

            channel.beforeReconnectEvent += beforeReconnect;
            channel.afterReconnectEvent += notifyReconnect;

            channel.beforeTransmitEvent += beforeTransmit;
            channel.afterTransmitEvent += notifyTransmit;
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
        public void notifyGetAttrib(ICardChannel cardChannel, Attrib attrib, Byte[] buffer, ErrorCode errorCode)
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
                gui.Invoke(new afterTransmit(notifyTransmit), new Object[] { cardChannel, cardCommand, cardResponse, errorCode });
            }
            else
            {
                if (errorCode == ErrorCode.SCARD_S_SUCCESS)
                {
                    gui.updateRAPDU(cardResponse);
                    gui.updateStatusWord((ISO7816.ResponseAPDU)cardResponse);
                    gui.updateHistoric(cardCommand, cardResponse);
                }
                else
                {
                    gui.updateRAPDU(null);
                    gui.updateStatusWord((ISO7816.ResponseAPDU)null);
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
        public void beforeGetAttrib(ICardChannel cardChannel, Attrib attrib, Byte[] buffer)
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
        public void beforeTransmit(ICardChannel cardChannel, ICardCommand cardCommand, Byte[] recvBuffer, UInt32 recvSize)
        {
            if (gui.InvokeRequired)
            {
                gui.Invoke(new beforeTransmit(beforeTransmit), new Object[] { cardChannel, cardCommand, recvBuffer, recvSize });
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
                gui.Invoke(new beforeTransmit(beforeTransmit), new Object[] { cardChannel, cardCommand, cardResponse });
            }
            else
            {
                gui.updateCAPDU(cardCommand);
            }
        }

        #endregion
    }
}
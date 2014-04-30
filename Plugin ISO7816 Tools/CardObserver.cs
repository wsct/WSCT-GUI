using System;
using WSCT.Core;
using WSCT.Core.APDU;
using WSCT.ISO7816;
using WSCT.Wrapper;

namespace WSCT.GUI.Plugins.ISO7816Tools
{
    internal class CardObserver
    {
        private readonly Gui gui;

        #region >> Constructors

        /// <summary>
        /// Creates a new instance.
        /// </summary>
        /// <param name="gui"></param>
        public CardObserver(Gui gui)
            : this(gui, "[{0,7}] Core ")
        {
        }

        /// <summary>
        /// Creates a new instance.
        /// </summary>
        /// <param name="gui"></param>
        /// <param name="header"></param>
        public CardObserver(Gui gui, string header)
        {
            this.gui = gui;
        }

        #endregion

        /// <summary>
        /// 
        /// </summary>
        /// <param name="channel"></param>
        public void ObserveChannel(ICardChannelObservable channel)
        {
            channel.BeforeConnectEvent += BeforeConnect;
            channel.AfterConnectEvent += NotifyConnect;

            channel.BeforeDisconnectEvent += BeforeDisconnect;
            channel.AfterDisconnectEvent += NotifyDisconnect;

            channel.BeforeGetAttribEvent += BeforeGetAttrib;
            channel.AfterGetAttribEvent += NotifyGetAttrib;

            channel.BeforeReconnectEvent += BeforeReconnect;
            channel.AfterReconnectEvent += NotifyReconnect;

            channel.BeforeTransmitEvent += BeforeTransmit;
            channel.AfterTransmitEvent += NotifyTransmit;
        }

        #region >> CardChannelObservable delegates

        private void NotifyConnect(ICardChannel cardChannel, ShareMode shareMode, Protocol preferedProtocol, ErrorCode errorCode)
        {
        }

        private void NotifyDisconnect(ICardChannel cardChannel, Disposition disposition, ErrorCode errorCode)
        {
        }

        private void NotifyGetAttrib(ICardChannel cardChannel, Attrib attrib, byte[] buffer, ErrorCode errorCode)
        {
        }

        private void NotifyReconnect(ICardChannel cardChannel, ShareMode shareMode, Protocol preferedProtocol, Disposition initialization, ErrorCode errorCode)
        {
        }

        private void NotifyTransmit(ICardChannel cardChannel, ICardCommand cardCommand, ICardResponse cardResponse, ErrorCode errorCode)
        {
            if (gui.InvokeRequired)
            {
                gui.Invoke(new AfterTransmit(NotifyTransmit), new Object[] { cardChannel, cardCommand, cardResponse, errorCode });
            }
            else
            {
                if (errorCode == ErrorCode.Success)
                {
                    gui.UpdateResponseApdu(cardResponse);
                    gui.UpdateStatusWord((ResponseAPDU)cardResponse);
                    gui.UpdateHistoric(cardCommand, cardResponse);
                }
                else
                {
                    gui.UpdateResponseApdu(null);
                    gui.UpdateStatusWord(null);
                    gui.UpdateHistoric(cardCommand, null);
                }
            }
        }

        private void BeforeConnect(ICardChannel cardChannel, ShareMode shareMode, Protocol preferedProtocol)
        {
        }

        private void BeforeDisconnect(ICardChannel cardChannel, Disposition disposition)
        {
        }

        private void BeforeGetAttrib(ICardChannel cardChannel, Attrib attrib, byte[] buffer)
        {
        }

        private void BeforeReconnect(ICardChannel cardChannel, ShareMode shareMode, Protocol preferedProtocol, Disposition initialization)
        {
        }

        private void BeforeTransmit(ICardChannel cardChannel, ICardCommand cardCommand, ICardResponse cardResponse)
        {
            if (gui.InvokeRequired)
            {
                gui.Invoke(new BeforeTransmit(BeforeTransmit), new Object[] { cardChannel, cardCommand, cardResponse });
            }
            else
            {
                gui.UpdateCommandApdu(cardCommand);
            }
        }

        #endregion
    }
}
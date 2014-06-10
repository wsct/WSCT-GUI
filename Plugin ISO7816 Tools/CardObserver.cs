using System;
using WSCT.Core;
using WSCT.Core.Events;
using WSCT.ISO7816;
using WSCT.Wrapper;

namespace WSCT.GUI.Plugins.ISO7816Tools
{
    internal sealed class CardObserver
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
            channel.BeforeTransmitEvent += BeforeTransmit;
            channel.AfterTransmitEvent += NotifyTransmit;
        }

        #region >> CardChannelObservable delegates

        private void NotifyTransmit(object sender, AfterTransmitEventArgs eventArgs)
        {
            if (gui.InvokeRequired)
            {
                gui.Invoke(new EventHandler<AfterTransmitEventArgs>(NotifyTransmit), new Object[] { sender, eventArgs });
            }
            else
            {
                if (eventArgs.ReturnValue == ErrorCode.Success)
                {
                    gui.UpdateResponseApdu(eventArgs.Response);
                    gui.UpdateStatusWord((ResponseAPDU)eventArgs.Response);
                    gui.UpdateHistoric(eventArgs.Command, eventArgs.Response);
                }
                else
                {
                    gui.UpdateResponseApdu(null);
                    gui.UpdateStatusWord(null);
                    gui.UpdateHistoric(eventArgs.Command, null);
                }
            }
        }

        private void BeforeTransmit(object sender, BeforeTransmitEventArgs eventArgs)
        {
            if (gui.InvokeRequired)
            {
                gui.Invoke(new EventHandler<BeforeTransmitEventArgs>(BeforeTransmit), new Object[] { sender, eventArgs });
            }
            else
            {
                gui.UpdateCommandApdu(eventArgs.Command);
            }
        }

        #endregion
    }
}
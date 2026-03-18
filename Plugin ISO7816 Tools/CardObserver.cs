using WSCT.Core;
using WSCT.Core.Events;
using WSCT.ISO7816;
using WSCT.Wrapper;

namespace WSCT.GUI.Plugins.ISO7816Tools
{
    /// <summary>
    /// Creates a new instance.
    /// </summary>
    /// <param name="gui"></param>
    internal sealed class CardObserver(IGui gui)
    {
        private readonly IGui _gui = gui;

        #region >> Constructors

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

        private void NotifyTransmit(object? sender, AfterTransmitEventArgs eventArgs)
        {
            _gui.InvokeOnUiThread(() =>
            {
                if (eventArgs.ReturnValue == ErrorCode.Success)
                {
                    _gui.UpdateResponseApdu(eventArgs.Response);
                    _gui.UpdateStatusWord((ResponseAPDU)eventArgs.Response);
                    _gui.UpdateHistoric(eventArgs.Command, eventArgs.Response);
                }
                else
                {
                    _gui.UpdateResponseApdu(null);
                    _gui.UpdateStatusWord(null);
                    _gui.UpdateHistoric(eventArgs.Command, null);
                }
            });
        }

        private void BeforeTransmit(object? sender, BeforeTransmitEventArgs eventArgs)
        {
            _gui.InvokeOnUiThread(() => _gui.UpdateCommandApdu(eventArgs.Command));
        }

        #endregion
    }
}
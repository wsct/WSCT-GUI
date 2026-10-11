using WSCT.Core;
using WSCT.Core.Events;
using WSCT.GUI.Plugins.ISO7816Tools.Services;
using WSCT.ISO7816;
using WSCT.Wrapper;

namespace WSCT.GUI.Plugins.ISO7816Tools
{
    internal sealed class CardObserver
    {
        private readonly Iso7816SessionService _service;

        public CardObserver(Iso7816SessionService service)
        {
            _service = service;
        }

        public void ObserveChannel(ICardChannelObservable channel)
        {
            channel.BeforeTransmitEvent += BeforeTransmit;
            channel.AfterTransmitEvent += NotifyTransmit;
        }

        private void NotifyTransmit(object? sender, AfterTransmitEventArgs eventArgs)
        {
            if (eventArgs.ReturnValue == ErrorCode.Success)
            {
                _service.UpdateResponse(eventArgs.Response);
                _service.AddToHistory(eventArgs.Command, eventArgs.Response);
            }
            else
            {
                _service.UpdateResponse(null);
                _service.AddToHistory(eventArgs.Command, null);
            }
        }

        private void BeforeTransmit(object? sender, BeforeTransmitEventArgs eventArgs)
        {
            _service.UpdateCommand(eventArgs.Command);
        }
    }
}
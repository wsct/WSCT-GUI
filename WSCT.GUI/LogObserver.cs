using WSCT.Core;
using WSCT.Core.Events;
using WSCT.GUI.Services;
using WSCT.Helpers;
using WSCT.Helpers.Linq;
using WSCT.Stack;
using WSCT.Wrapper;
using WSCT.Wrapper.Desktop.Core;

namespace WSCT.GUI
{
    internal sealed class LogObserver
    {
        private readonly ILogService _logService;
        private readonly ISmartCardSessionService _sessionService;

        private void WriteLogLine(LogLevel level, object? sender, string message)
        {
            string identifier = sender switch
            {
                ICardChannelLayerObservable channelLayer => channelLayer.LayerId,
                ICardChannelStack => "Stack",
                ICardContextLayerObservable contextLayer => contextLayer.LayerId,
                ICardContextStack => "Stack",
                _ => "Core"
            };
            _logService.Append(level, identifier, message);
        }

        public LogObserver(ILogService logService, ISmartCardSessionService sessionService)
        {
            _logService = logService;
            _sessionService = sessionService;
        }

        public void ObserveContext(ICardContextObservable context)
        {
            context.BeforeEstablishEvent += BeforeEstablish;
            context.BeforeListReaderGroupsEvent += BeforeListReaderGroups;
            context.BeforeListReadersEvent += BeforeListReaders;
            context.BeforeReleaseEvent += BeforeRelease;

            context.AfterEstablishEvent += NotifyEstablish;
            context.AfterListReaderGroupsEvent += NotifyListReaderGroups;
            context.AfterListReadersEvent += NotifyListReaders;
            context.AfterReleaseEvent += NotifyRelease;
        }

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

        public void ObserveMonitor(StatusChangeMonitor monitor)
        {
            monitor.OnCardInsertionEvent += OnCardInsertionEvent;
            monitor.OnCardRemovalEvent += OnCardRemovalEvent;
        }

        public void NotifyConnect(object? sender, AfterConnectEventArgs eventArgs)
        {
            if (eventArgs.ReturnValue == ErrorCode.Success)
            {
                WriteLogLine(LogLevel.Info, sender, $"<= {eventArgs.ReturnValue}");
                _sessionService.UpdateChannelStatus(ChannelStatusType.Connected);
            }
            else
            {
                WriteLogLine(LogLevel.Error, sender, $"<= {eventArgs.ReturnValue}");
                _sessionService.UpdateChannelStatus(ChannelStatusType.Error);
            }

            _sessionService.UpdateLastError(eventArgs.ReturnValue);
        }

        public void NotifyDisconnect(object? sender, AfterDisconnectEventArgs eventArgs)
        {
            if (eventArgs.ReturnValue == ErrorCode.Success)
            {
                WriteLogLine(LogLevel.Info, sender, $"<= {eventArgs.ReturnValue}");
                _sessionService.UpdateChannelStatus(ChannelStatusType.Disconnected);
            }
            else
            {
                WriteLogLine(LogLevel.Error, sender, $"<= {eventArgs.ReturnValue}");
                _sessionService.UpdateChannelStatus(ChannelStatusType.Error);
            }

            _sessionService.UpdateLastError(eventArgs.ReturnValue);
        }

        public void NotifyGetAttrib(object? sender, AfterGetAttribEventArgs eventArgs)
        {
            if (eventArgs.ReturnValue == ErrorCode.Success)
            {
                WriteLogLine(LogLevel.Info, sender, $"<= byte[]: [{eventArgs.Buffer.ToHexa()}]");
            }
            else
            {
                WriteLogLine(LogLevel.Error, sender, $"<= {eventArgs.ReturnValue}");
            }

            _sessionService.UpdateLastError(eventArgs.ReturnValue);
        }

        public void NotifyReconnect(object? sender, AfterReconnectEventArgs eventArgs)
        {
            if (eventArgs.ReturnValue == ErrorCode.Success)
            {
                WriteLogLine(LogLevel.Info, sender, $"<= {eventArgs.ReturnValue}");
                _sessionService.UpdateChannelStatus(ChannelStatusType.Connected);
            }
            else
            {
                WriteLogLine(LogLevel.Error, sender, $"<= {eventArgs.ReturnValue}");
                _sessionService.UpdateChannelStatus(ChannelStatusType.Error);
            }

            _sessionService.UpdateLastError(eventArgs.ReturnValue);
        }

        public void NotifyTransmit(object? sender, AfterTransmitEventArgs eventArgs)
        {
            if (eventArgs.ReturnValue == ErrorCode.Success)
            {
                WriteLogLine(LogLevel.Info, sender, $"<= RAPDU: [{eventArgs.Response}]");
            }
            else
            {
                WriteLogLine(LogLevel.Error, sender, $"<= {eventArgs.ReturnValue}");
            }

            _sessionService.UpdateLastError(eventArgs.ReturnValue);
        }

        public void BeforeConnect(object? sender, BeforeConnectEventArgs eventArgs)
        {
            if (sender is not ICardChannel cardChannel)
            {
                return;
            }

            WriteLogLine(LogLevel.Info, sender, $" => Connect(\"{cardChannel.ReaderName}\", {eventArgs.ShareMode}, {eventArgs.PreferedProtocol})");
        }

        public void BeforeDisconnect(object? sender, BeforeDisconnectEventArgs eventArgs)
        {
            WriteLogLine(LogLevel.Info, sender, $" => Disconnect({eventArgs.Disposition})");
        }

        public void BeforeGetAttrib(object? sender, BeforeGetAttribEventArgs eventArgs)
        {
            WriteLogLine(LogLevel.Info, sender, $" => GetAttrib({eventArgs.Attrib})");
        }

        public void BeforeReconnect(object? sender, BeforeReconnectEventArgs eventArgs)
        {
            WriteLogLine(LogLevel.Info, sender, $" => Reconnect({eventArgs.ShareMode}, {eventArgs.PreferedProtocol}, {eventArgs.Initialization})");
        }

        public void BeforeTransmit(object? sender, BeforeTransmitEventArgs eventArgs)
        {
            WriteLogLine(LogLevel.Info, sender, $" => Transmit({eventArgs.Command})");
        }

        private void BeforeEstablish(object? sender, BeforeEstablishEventArgs eventArgs)
        {
            WriteLogLine(LogLevel.Info, sender, " => Establish()");
        }

        private void BeforeListReaders(object? sender, BeforeListReadersEventArgs eventArgs)
        {
            WriteLogLine(LogLevel.Info, sender, $" => ListReaders({eventArgs.Group})");
        }

        private void BeforeListReaderGroups(object? sender, BeforeListReaderGroupsEventArgs eventArgs)
        {
            WriteLogLine(LogLevel.Info, sender, " => ListReaderGroups()");
        }

        private void BeforeRelease(object? sender, BeforeReleaseEventArgs eventArgs)
        {
            WriteLogLine(LogLevel.Info, sender, " => Release()");
        }

        private void NotifyEstablish(object? sender, AfterEstablishEventArgs eventArgs)
        {
            if (eventArgs.ReturnValue == ErrorCode.Success)
            {
                WriteLogLine(LogLevel.Info, sender, $"<= {eventArgs.ReturnValue}");
            }
            else
            {
                WriteLogLine(LogLevel.Error, sender, $"<= {eventArgs.ReturnValue}");
            }

            _sessionService.UpdateLastError(eventArgs.ReturnValue);
        }

        private void NotifyListReaders(object? sender, AfterListReadersEventArgs eventArgs)
        {
            if (sender is not ICardContext cardContext)
            {
                return;
            }

            if (eventArgs.ReturnValue == ErrorCode.Success)
            {
                cardContext.Readers.DoForEach(r => WriteLogLine(LogLevel.Info, sender, $"<= Reader: {r}"));
            }
            else
            {
                WriteLogLine(LogLevel.Error, sender, $"<= {eventArgs.ReturnValue}");
            }

            _sessionService.UpdateLastError(eventArgs.ReturnValue);
        }

        private void NotifyListReaderGroups(object? sender, AfterListReaderGroupsEventArgs eventArgs)
        {
            if (sender is not ICardContext cardContext)
            {
                return;
            }

            if (eventArgs.ReturnValue == ErrorCode.Success)
            {
                cardContext.Groups.DoForEach(g => WriteLogLine(LogLevel.Info, sender, $"<= Group: {g}"));
            }
            else
            {
                WriteLogLine(LogLevel.Error, sender, $"<= {eventArgs.ReturnValue}");
            }

            _sessionService.UpdateLastError(eventArgs.ReturnValue);
        }

        private void NotifyRelease(object? sender, AfterReleaseEventArgs eventArgs)
        {
            if (eventArgs.ReturnValue == ErrorCode.Success)
            {
                WriteLogLine(LogLevel.Info, sender, $"<= {eventArgs.ReturnValue}");
            }
            else
            {
                WriteLogLine(LogLevel.Error, sender, $"<= {eventArgs.ReturnValue}");
            }

            _sessionService.UpdateLastError(eventArgs.ReturnValue);
        }

        private void OnCardInsertionEvent(object? sender, OnCardInsertionEventArgs eventArgs)
        {
            WriteLogLine(LogLevel.Info, sender, $"<= Card insertion detected on reader {eventArgs.ReaderState.ReaderName}");
        }

        private void OnCardRemovalEvent(object? sender, OnCardRemovalEventArgs eventArgs)
        {
            WriteLogLine(LogLevel.Info, sender, $"<= Card removal detected on reader {eventArgs.ReaderState.ReaderName}");
        }
    }
}

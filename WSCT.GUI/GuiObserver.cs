using System;
using WSCT.Core;
using WSCT.Core.Events;
using WSCT.GUI.Resources;
using WSCT.Helpers;
using WSCT.Helpers.Linq;
using WSCT.Stack;
using WSCT.Wrapper;
using WSCT.Wrapper.Desktop.Core;

namespace WSCT.GUI
{
    internal sealed class GuiObserver
    {
        internal WinSCardGui Gui;
        internal string Header;

        private void WriteLine(LogLevel level, object sender, string message)
        {
            if (sender is ICardChannelLayerObservable channelLayer)
            {
                Gui.guiLogsView.AppendText(String.Format(Header, level, channelLayer.LayerId, message));
                return;
            }

            if (sender is ICardChannelObservable)
            {
                Gui.guiLogsView.AppendText(String.Format(Header, level, "unknown", message));
                return;
            }

            if (sender is ICardContextLayerObservable contextLayer)
            {
                Gui.guiLogsView.AppendText(String.Format(Header, level, contextLayer.LayerId, message));
                return;
            }

            if (sender is ICardContextObservable)
            {
                Gui.guiLogsView.AppendText(String.Format(Header, level, "unknown", message));
            }
        }

        #region >> Constructors

        /// <summary>
        /// Creates a new instance.
        /// </summary>
        /// <param name="gui"></param>
        public GuiObserver(WinSCardGui gui)
        {
            Header = "[{0,7}] [{1,7}] {2}" + Environment.NewLine;
            Gui = gui;
        }

        #endregion

        #region >> observe *

        /// <summary>
        /// 
        /// </summary>
        /// <param name="context"></param>
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="monitor"></param>
        public void ObserveMonitor(StatusChangeMonitor monitor)
        {
            monitor.OnCardInsertionEvent += OnCardInsertionEvent;
            monitor.OnCardRemovalEvent += OnCardRemovalEvent;
        }

        #endregion

        #region >> CardChannelObservable delegates

        public void NotifyConnect(object sender, AfterConnectEventArgs eventArgs)
        {
            if (Gui.InvokeRequired)
            {
                Gui.Invoke(new EventHandler<AfterConnectEventArgs>(NotifyConnect), sender, eventArgs);
                return;
            }

            if (eventArgs.ReturnValue == ErrorCode.Success)
            {
                Gui.guiLogsView.SelectionColor = Colors.LogDefaultColor;
                WriteLine(LogLevel.Info, sender, $"<=  {eventArgs.ReturnValue}");
                Gui.UpdateChannelStatus(ChannelStatusType.Connected);
            }
            else
            {
                Gui.guiLogsView.SelectionColor = Colors.LogErrorColor;
                WriteLine(LogLevel.Error, sender, $"<=  {eventArgs.ReturnValue}");
                Gui.UpdateChannelStatus(ChannelStatusType.Error);
            }

            Gui.UpdateLastError(eventArgs.ReturnValue);
        }

        public void NotifyDisconnect(object sender, AfterDisconnectEventArgs eventArgs)
        {
            if (Gui.InvokeRequired)
            {
                Gui.Invoke(new EventHandler<AfterDisconnectEventArgs>(NotifyDisconnect), sender, eventArgs);
                return;
            }

            if (eventArgs.ReturnValue == ErrorCode.Success)
            {
                Gui.guiLogsView.SelectionColor = Colors.LogDefaultColor;
                WriteLine(LogLevel.Info, sender, $"<=  {eventArgs.ReturnValue}");
                Gui.UpdateChannelStatus(ChannelStatusType.Disconnected);
            }
            else
            {
                Gui.guiLogsView.SelectionColor = Colors.LogErrorColor;
                WriteLine(LogLevel.Error, sender, $"<=  {eventArgs.ReturnValue}");
                Gui.UpdateChannelStatus(ChannelStatusType.Error);
            }

            Gui.UpdateLastError(eventArgs.ReturnValue);
        }

        public void NotifyGetAttrib(object sender, AfterGetAttribEventArgs eventArgs)
        {
            if (Gui.InvokeRequired)
            {
                Gui.Invoke(new EventHandler<AfterGetAttribEventArgs>(NotifyGetAttrib), sender, eventArgs);
                return;
            }

            if (eventArgs.ReturnValue == ErrorCode.Success)
            {
                Gui.guiLogsView.SelectionColor = Colors.LogDefaultColor;
                WriteLine(LogLevel.Info, sender, $"<=  byte[]: [{eventArgs.Buffer.ToHexa()}]");
            }
            else
            {
                Gui.guiLogsView.SelectionColor = Colors.LogErrorColor;
                WriteLine(LogLevel.Error, sender, String.Format(Header + "<=  {0}", eventArgs.ReturnValue));
            }

            Gui.UpdateLastError(eventArgs.ReturnValue);
        }

        public void NotifyReconnect(object sender, AfterReconnectEventArgs eventArgs)
        {
            if (Gui.InvokeRequired)
            {
                Gui.Invoke(new EventHandler<AfterReconnectEventArgs>(NotifyReconnect), sender, eventArgs);
                return;
            }

            if (eventArgs.ReturnValue == ErrorCode.Success)
            {
                Gui.guiLogsView.SelectionColor = Colors.LogDefaultColor;
                WriteLine(LogLevel.Info, sender, $"<=  {eventArgs.ReturnValue}");
                Gui.UpdateChannelStatus(ChannelStatusType.Connected);
            }
            else
            {
                Gui.guiLogsView.SelectionColor = Colors.LogErrorColor;
                WriteLine(LogLevel.Error, sender, $"<=  {eventArgs.ReturnValue}");
                Gui.UpdateChannelStatus(ChannelStatusType.Error);
            }

            Gui.UpdateLastError(eventArgs.ReturnValue);
        }

        public void NotifyTransmit(object sender, AfterTransmitEventArgs eventArgs)
        {
            if (Gui.InvokeRequired)
            {
                Gui.Invoke(new EventHandler<AfterTransmitEventArgs>(NotifyTransmit), sender, eventArgs);
                return;
            }

            if (eventArgs.ReturnValue == ErrorCode.Success)
            {
                Gui.guiLogsView.SelectionColor = Colors.LogDefaultColor;
                WriteLine(LogLevel.Info, sender, $"<=  RAPDU: [{eventArgs.Response}]");
            }
            else
            {
                Gui.guiLogsView.SelectionColor = Colors.LogErrorColor;
                WriteLine(LogLevel.Error, sender, $"<=  {eventArgs.ReturnValue}");
            }

            Gui.UpdateLastError(eventArgs.ReturnValue);
        }

        public void BeforeConnect(object sender, BeforeConnectEventArgs eventArgs)
        {
            if (Gui.InvokeRequired)
            {
                Gui.Invoke(new EventHandler<BeforeConnectEventArgs>(BeforeConnect), sender, eventArgs);
                return;
            }

            var cardChannel = (ICardChannel)sender;

            Gui.guiLogsView.SelectionColor = Colors.LogHighlightColor;
            WriteLine(LogLevel.Info, sender, $" => Connect(\"{cardChannel.ReaderName}\",{eventArgs.ShareMode},{eventArgs.PreferedProtocol})");
        }

        public void BeforeDisconnect(object sender, BeforeDisconnectEventArgs eventArgs)
        {
            if (Gui.InvokeRequired)
            {
                Gui.Invoke(new EventHandler<BeforeDisconnectEventArgs>(BeforeDisconnect), sender, eventArgs);
                return;
            }

            Gui.guiLogsView.SelectionColor = Colors.LogHighlightColor;
            WriteLine(LogLevel.Info, sender, $" => Disconnect({eventArgs.Disposition})");
        }

        public void BeforeGetAttrib(object sender, BeforeGetAttribEventArgs eventArgs)
        {
            if (Gui.InvokeRequired)
            {
                Gui.Invoke(new EventHandler<BeforeGetAttribEventArgs>(BeforeGetAttrib), sender, eventArgs);
                return;
            }

            Gui.guiLogsView.SelectionColor = Colors.LogHighlightColor;
            WriteLine(LogLevel.Info, sender, $" => GetAttrib({eventArgs.Attrib})");
        }

        public void BeforeReconnect(object sender, BeforeReconnectEventArgs eventArgs)
        {
            if (Gui.InvokeRequired)
            {
                Gui.Invoke(new EventHandler<BeforeReconnectEventArgs>(BeforeReconnect), sender, eventArgs);
                return;
            }

            Gui.guiLogsView.SelectionColor = Colors.LogHighlightColor;
            WriteLine(LogLevel.Info, sender,
                $" => Reconnect({eventArgs.ShareMode},{eventArgs.PreferedProtocol},{eventArgs.Initialization})");
        }

        public void BeforeTransmit(object sender, BeforeTransmitEventArgs eventArgs)
        {
            if (Gui.InvokeRequired)
            {
                Gui.Invoke(new EventHandler<BeforeTransmitEventArgs>(BeforeTransmit), sender, eventArgs);
                return;
            }

            Gui.guiLogsView.SelectionColor = Colors.LogHighlightColor;
            WriteLine(LogLevel.Info, sender, $" => Transmit({eventArgs.Command})");
        }

        #endregion

        #region >> CardContextObservable delegates

        private void BeforeEstablish(object sender, BeforeEstablishEventArgs eventArgs)
        {
            if (Gui.InvokeRequired)
            {
                Gui.Invoke(new EventHandler<BeforeEstablishEventArgs>(BeforeEstablish), sender, eventArgs);
                return;
            }

            Gui.guiLogsView.SelectionColor = Colors.LogHighlightColor;
            WriteLine(LogLevel.Info, sender, " => Establish()");
        }

        private void BeforeListReaders(object sender, BeforeListReadersEventArgs eventArgs)
        {
            if (Gui.InvokeRequired)
            {
                Gui.Invoke(new EventHandler<BeforeListReadersEventArgs>(BeforeListReaders), sender, eventArgs);
                return;
            }

            Gui.guiLogsView.SelectionColor = Colors.LogHighlightColor;
            WriteLine(LogLevel.Info, sender, $" => ListReaders({eventArgs.Group})");
        }

        private void BeforeListReaderGroups(object sender, BeforeListReaderGroupsEventArgs eventArgs)
        {
            if (Gui.InvokeRequired)
            {
                Gui.Invoke(new EventHandler<BeforeListReaderGroupsEventArgs>(BeforeListReaderGroups), sender, eventArgs);
                return;
            }

            Gui.guiLogsView.SelectionColor = Colors.LogHighlightColor;
            WriteLine(LogLevel.Info, sender, " => ListReaderGroups()");
        }

        private void BeforeRelease(object sender, BeforeReleaseEventArgs eventArgs)
        {
            if (Gui.InvokeRequired)
            {
                Gui.Invoke(new EventHandler<BeforeReleaseEventArgs>(BeforeRelease), sender, eventArgs);
                return;
            }

            Gui.guiLogsView.SelectionColor = Colors.LogHighlightColor;
            WriteLine(LogLevel.Info, sender, " => Release()");
        }

        private void NotifyEstablish(object sender, AfterEstablishEventArgs eventArgs)
        {
            if (Gui.InvokeRequired)
            {
                Gui.Invoke(new EventHandler<AfterEstablishEventArgs>(NotifyEstablish), sender, eventArgs);
                return;
            }

            if (eventArgs.ReturnValue == ErrorCode.Success)
            {
                Gui.guiLogsView.SelectionColor = Colors.LogDefaultColor;
                WriteLine(LogLevel.Info, sender, $"<=  {eventArgs.ReturnValue}");
            }
            else
            {
                Gui.guiLogsView.SelectionColor = Colors.LogErrorColor;
                WriteLine(LogLevel.Error, sender, $"<=  {eventArgs.ReturnValue}");
            }

            Gui.UpdateLastError(eventArgs.ReturnValue);
        }

        private void NotifyListReaders(object sender, AfterListReadersEventArgs eventArgs)
        {
            if (Gui.InvokeRequired)
            {
                Gui.Invoke(new EventHandler<AfterListReadersEventArgs>(NotifyListReaders), sender, eventArgs);
                return;
            }

            var cardContext = (ICardContext)sender;

            if (eventArgs.ReturnValue == ErrorCode.Success)
            {
                cardContext.Readers.DoForEach(
                    r => WriteLine(LogLevel.Info, sender, $"<=  Reader: {r}")
                    );
            }
            else
            {
                Gui.guiLogsView.SelectionColor = Colors.LogErrorColor;
                WriteLine(LogLevel.Error, sender, $"<=  {eventArgs.ReturnValue}");
            }

            Gui.UpdateLastError(eventArgs.ReturnValue);
        }

        private void NotifyListReaderGroups(object sender, AfterListReaderGroupsEventArgs eventArgs)
        {
            if (Gui.InvokeRequired)
            {
                Gui.Invoke(new EventHandler<AfterListReaderGroupsEventArgs>(NotifyListReaderGroups), sender, eventArgs);
                return;
            }

            var cardContext = (ICardContext)sender;

            if (eventArgs.ReturnValue == ErrorCode.Success)
            {
                cardContext.Groups.DoForEach(
                    g => WriteLine(LogLevel.Info, sender, $"<=  Group: {g}")
                    );
            }
            else
            {
                Gui.guiLogsView.SelectionColor = Colors.LogErrorColor;
                WriteLine(LogLevel.Error, sender, $"<=  {eventArgs.ReturnValue}");
            }

            Gui.UpdateLastError(eventArgs.ReturnValue);
        }

        private void NotifyRelease(object sender, AfterReleaseEventArgs eventArgs)
        {
            if (Gui.InvokeRequired)
            {
                Gui.Invoke(new EventHandler<AfterReleaseEventArgs>(NotifyRelease), sender, eventArgs);
                return;
            }

            if (eventArgs.ReturnValue == ErrorCode.Success)
            {
                Gui.guiLogsView.SelectionColor = Colors.LogDefaultColor;
                WriteLine(LogLevel.Info, sender, $"<=  {eventArgs.ReturnValue}");
            }
            else
            {
                Gui.guiLogsView.SelectionColor = Colors.LogErrorColor;
                WriteLine(LogLevel.Error, sender, $"<=  {eventArgs.ReturnValue}");
            }

            Gui.UpdateLastError(eventArgs.ReturnValue);
        }

        #endregion

        #region >> StatusChangeMonitor delegates

        private void OnCardInsertionEvent(object sender, OnCardInsertionEventArgs eventArgs)
        {
            if (Gui.InvokeRequired)
            {
                Gui.Invoke(new EventHandler<OnCardInsertionEventArgs>(OnCardInsertionEvent), eventArgs);
                return;
            }

            Gui.guiLogsView.SelectionColor = Colors.LogHighlightColor;
            WriteLine(LogLevel.Info, sender, $"<=  Card insertion detected on reader {eventArgs.ReaderState.ReaderName}\n");
        }

        private void OnCardRemovalEvent(object sender, OnCardRemovalEventArgs eventArgs)
        {
            if (Gui.InvokeRequired)
            {
                Gui.Invoke(new EventHandler<OnCardRemovalEventArgs>(OnCardRemovalEvent), eventArgs);
                return;
            }

            Gui.guiLogsView.SelectionColor = Colors.LogHighlightColor;
            WriteLine(LogLevel.Info, sender, $"<=  Card removal detected on reader {eventArgs.ReaderState.ReaderName}\n");
        }

        #endregion
    }
}
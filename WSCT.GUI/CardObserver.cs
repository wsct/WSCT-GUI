using System;
using System.Drawing;
using WSCT.Core;
using WSCT.Core.Events;
using WSCT.Helpers;
using WSCT.Helpers.Linq;
using WSCT.Stack;
using WSCT.Wrapper;
using WSCT.Wrapper.Desktop.Core;

namespace WSCT.GUI
{
    internal sealed class CardObserver
    {
        internal Color ErrorColor = Color.Red;

        internal WinSCardGui Gui;
        internal String Header;
        internal Color HighlightColor = Color.DarkBlue;
        internal Color StandardColor = Color.Black;

        private void WriteLine(LogLevel level, object sender, string message)
        {
            var channelLayer = sender as ICardChannelLayerObservable;
            if (channelLayer != null)
            {
                Gui.guiLogsView.AppendText(String.Format(Header, level, channelLayer.LayerId, message));
                return;
            }

            var channel = sender as ICardChannelObservable;
            if (channel != null)
            {
                Gui.guiLogsView.AppendText(String.Format(Header, level, "unknown", message));
                return;
            }

            var contextLayer = sender as ICardContextLayerObservable;
            if (contextLayer != null)
            {
                Gui.guiLogsView.AppendText(String.Format(Header, level, contextLayer.LayerId, message));
                return;
            }

            var context = sender as ICardContextObservable;
            if (context != null)
            {
                Gui.guiLogsView.AppendText(String.Format(Header, level, "unknown", message));
            }
        }

        #region >> Constructors

        /// <summary>
        /// Creates a new instance.
        /// </summary>
        /// <param name="gui"></param>
        public CardObserver(WinSCardGui gui)
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
                Gui.Invoke(new EventHandler<AfterConnectEventArgs>(NotifyConnect), new[] { sender, eventArgs });
                return;
            }

            if (eventArgs.ReturnValue == ErrorCode.Success)
            {
                Gui.guiLogsView.SelectionColor = StandardColor;
                WriteLine(LogLevel.Info, sender, String.Format("<=  {0}", eventArgs.ReturnValue));
                Gui.UpdateChannelStatus(ChannelStatusType.Connected);
            }
            else
            {
                Gui.guiLogsView.SelectionColor = ErrorColor;
                WriteLine(LogLevel.Error, sender, String.Format("<=  {0}", eventArgs.ReturnValue));
                Gui.UpdateChannelStatus(ChannelStatusType.Error);
            }

            Gui.UpdateLastError(eventArgs.ReturnValue);
        }

        public void NotifyDisconnect(object sender, AfterDisconnectEventArgs eventArgs)
        {
            if (Gui.InvokeRequired)
            {
                Gui.Invoke(new EventHandler<AfterDisconnectEventArgs>(NotifyDisconnect), new[] { sender, eventArgs });
                return;
            }

            if (eventArgs.ReturnValue == ErrorCode.Success)
            {
                Gui.guiLogsView.SelectionColor = StandardColor;
                WriteLine(LogLevel.Info, sender, String.Format("<=  {0}", eventArgs.ReturnValue));
                Gui.UpdateChannelStatus(ChannelStatusType.Disconnected);
            }
            else
            {
                Gui.guiLogsView.SelectionColor = ErrorColor;
                WriteLine(LogLevel.Error, sender, String.Format("<=  {0}", eventArgs.ReturnValue));
                Gui.UpdateChannelStatus(ChannelStatusType.Error);
            }

            Gui.UpdateLastError(eventArgs.ReturnValue);
        }

        public void NotifyGetAttrib(object sender, AfterGetAttribEventArgs eventArgs)
        {
            if (Gui.InvokeRequired)
            {
                Gui.Invoke(new EventHandler<AfterGetAttribEventArgs>(NotifyGetAttrib), new[] { sender, eventArgs });
                return;
            }

            if (eventArgs.ReturnValue == ErrorCode.Success)
            {
                Gui.guiLogsView.SelectionColor = StandardColor;
                WriteLine(LogLevel.Info, sender, String.Format("<=  byte[]: [{0}]", eventArgs.Buffer.ToHexa()));
            }
            else
            {
                Gui.guiLogsView.SelectionColor = ErrorColor;
                WriteLine(LogLevel.Error, sender, String.Format(Header + "<=  {0}", eventArgs.ReturnValue));
            }

            Gui.UpdateLastError(eventArgs.ReturnValue);
        }

        public void NotifyReconnect(object sender, AfterReconnectEventArgs eventArgs)
        {
            if (Gui.InvokeRequired)
            {
                Gui.Invoke(new EventHandler<AfterReconnectEventArgs>(NotifyReconnect), new[] { sender, eventArgs });
                return;
            }

            if (eventArgs.ReturnValue == ErrorCode.Success)
            {
                Gui.guiLogsView.SelectionColor = StandardColor;
                WriteLine(LogLevel.Info, sender, String.Format("<=  {0}", eventArgs.ReturnValue));
                Gui.UpdateChannelStatus(ChannelStatusType.Connected);
            }
            else
            {
                Gui.guiLogsView.SelectionColor = ErrorColor;
                WriteLine(LogLevel.Error, sender, String.Format("<=  {0}", eventArgs.ReturnValue));
                Gui.UpdateChannelStatus(ChannelStatusType.Error);
            }

            Gui.UpdateLastError(eventArgs.ReturnValue);
        }

        public void NotifyTransmit(object sender, AfterTransmitEventArgs eventArgs)
        {
            if (Gui.InvokeRequired)
            {
                Gui.Invoke(new EventHandler<AfterTransmitEventArgs>(NotifyTransmit), new[] { sender, eventArgs });
                return;
            }

            if (eventArgs.ReturnValue == ErrorCode.Success)
            {
                Gui.guiLogsView.SelectionColor = StandardColor;
                WriteLine(LogLevel.Info, sender, String.Format("<=  RAPDU: [{0}]", eventArgs.Response));
            }
            else
            {
                Gui.guiLogsView.SelectionColor = ErrorColor;
                WriteLine(LogLevel.Error, sender, String.Format("<=  {0}", eventArgs.ReturnValue));
            }

            Gui.UpdateLastError(eventArgs.ReturnValue);
        }

        public void BeforeConnect(object sender, BeforeConnectEventArgs eventArgs)
        {
            if (Gui.InvokeRequired)
            {
                Gui.Invoke(new EventHandler<BeforeConnectEventArgs>(BeforeConnect), new[] { sender, eventArgs });
                return;
            }

            var cardChannel = (ICardChannel)sender;

            Gui.guiLogsView.SelectionColor = HighlightColor;
            WriteLine(LogLevel.Info, sender, String.Format(" => Connect(\"{0}\",{1},{2})", cardChannel.ReaderName, eventArgs.ShareMode, eventArgs.PreferedProtocol));
        }

        public void BeforeDisconnect(object sender, BeforeDisconnectEventArgs eventArgs)
        {
            if (Gui.InvokeRequired)
            {
                Gui.Invoke(new EventHandler<BeforeDisconnectEventArgs>(BeforeDisconnect), new[] { sender, eventArgs });
                return;
            }

            Gui.guiLogsView.SelectionColor = HighlightColor;
            WriteLine(LogLevel.Info, sender, String.Format(" => Disconnect({0})", eventArgs.Disposition));
        }

        public void BeforeGetAttrib(object sender, BeforeGetAttribEventArgs eventArgs)
        {
            if (Gui.InvokeRequired)
            {
                Gui.Invoke(new EventHandler<BeforeGetAttribEventArgs>(BeforeGetAttrib), new[] { sender, eventArgs });
                return;
            }

            Gui.guiLogsView.SelectionColor = HighlightColor;
            WriteLine(LogLevel.Info, sender, String.Format(" => GetAttrib({0})", eventArgs.Attrib));
        }

        public void BeforeReconnect(object sender, BeforeReconnectEventArgs eventArgs)
        {
            if (Gui.InvokeRequired)
            {
                Gui.Invoke(new EventHandler<BeforeReconnectEventArgs>(BeforeReconnect), new[] { sender, eventArgs });
                return;
            }

            Gui.guiLogsView.SelectionColor = HighlightColor;
            WriteLine(LogLevel.Info, sender,
                String.Format(" => Reconnect({0},{1},{2})", eventArgs.ShareMode, eventArgs.PreferedProtocol, eventArgs.Initialization));
        }

        public void BeforeTransmit(object sender, BeforeTransmitEventArgs eventArgs)
        {
            if (Gui.InvokeRequired)
            {
                Gui.Invoke(new EventHandler<BeforeTransmitEventArgs>(BeforeTransmit), new[] { sender, eventArgs });
                return;
            }

            Gui.guiLogsView.SelectionColor = HighlightColor;
            WriteLine(LogLevel.Info, sender, String.Format(" => Transmit({0})", eventArgs.Command));
        }

        #endregion

        #region >> CardContextObservable delegates

        private void BeforeEstablish(object sender, BeforeEstablishEventArgs eventArgs)
        {
            if (Gui.InvokeRequired)
            {
                Gui.Invoke(new EventHandler<BeforeEstablishEventArgs>(BeforeEstablish), new[] { sender, eventArgs });
                return;
            }

            Gui.guiLogsView.SelectionColor = HighlightColor;
            WriteLine(LogLevel.Info, sender, " => Establish()");
        }

        private void BeforeListReaders(object sender, BeforeListReadersEventArgs eventArgs)
        {
            if (Gui.InvokeRequired)
            {
                Gui.Invoke(new EventHandler<BeforeListReadersEventArgs>(BeforeListReaders), new[] { sender, eventArgs });
                return;
            }

            Gui.guiLogsView.SelectionColor = HighlightColor;
            WriteLine(LogLevel.Info, sender, String.Format(" => ListReaders({0})", eventArgs.Group));
        }

        private void BeforeListReaderGroups(object sender, BeforeListReaderGroupsEventArgs eventArgs)
        {
            if (Gui.InvokeRequired)
            {
                Gui.Invoke(new EventHandler<BeforeListReaderGroupsEventArgs>(BeforeListReaderGroups), new[] { sender, eventArgs });
                return;
            }

            Gui.guiLogsView.SelectionColor = HighlightColor;
            WriteLine(LogLevel.Info, sender, " => ListReaderGroups()");
        }

        private void BeforeRelease(object sender, BeforeReleaseEventArgs eventArgs)
        {
            if (Gui.InvokeRequired)
            {
                Gui.Invoke(new EventHandler<BeforeReleaseEventArgs>(BeforeRelease), new[] { sender, eventArgs });
                return;
            }

            Gui.guiLogsView.SelectionColor = HighlightColor;
            WriteLine(LogLevel.Info, sender, " => Release()");
        }

        private void NotifyEstablish(object sender, AfterEstablishEventArgs eventArgs)
        {
            if (Gui.InvokeRequired)
            {
                Gui.Invoke(new EventHandler<AfterEstablishEventArgs>(NotifyEstablish), new[] { sender, eventArgs });
                return;
            }

            if (eventArgs.ReturnValue == ErrorCode.Success)
            {
                Gui.guiLogsView.SelectionColor = StandardColor;
                WriteLine(LogLevel.Info, sender, String.Format("<=  {0}", eventArgs.ReturnValue));
            }
            else
            {
                Gui.guiLogsView.SelectionColor = ErrorColor;
                WriteLine(LogLevel.Error, sender, String.Format("<=  {0}", eventArgs.ReturnValue));
            }

            Gui.UpdateLastError(eventArgs.ReturnValue);
        }

        private void NotifyListReaders(object sender, AfterListReadersEventArgs eventArgs)
        {
            if (Gui.InvokeRequired)
            {
                Gui.Invoke(new EventHandler<AfterListReadersEventArgs>(NotifyListReaders), new[] { sender, eventArgs });
                return;
            }

            var cardContext = (ICardContext)sender;

            if (eventArgs.ReturnValue == ErrorCode.Success)
            {
                cardContext.Readers.DoForEach(
                    r => WriteLine(LogLevel.Info, sender, String.Format("<=  Reader: {0}", r))
                    );
            }
            else
            {
                Gui.guiLogsView.SelectionColor = ErrorColor;
                WriteLine(LogLevel.Error, sender, String.Format("<=  {0}", eventArgs.ReturnValue));
            }

            Gui.UpdateLastError(eventArgs.ReturnValue);
        }

        private void NotifyListReaderGroups(object sender, AfterListReaderGroupsEventArgs eventArgs)
        {
            if (Gui.InvokeRequired)
            {
                Gui.Invoke(new EventHandler<AfterListReaderGroupsEventArgs>(NotifyListReaderGroups), new[] { sender, eventArgs });
                return;
            }

            var cardContext = (ICardContext)sender;

            if (eventArgs.ReturnValue == ErrorCode.Success)
            {
                cardContext.Groups.DoForEach(
                    g => WriteLine(LogLevel.Info, sender, String.Format("<=  Group: {0}", g))
                    );
            }
            else
            {
                Gui.guiLogsView.SelectionColor = ErrorColor;
                WriteLine(LogLevel.Error, sender, String.Format("<=  {0}", eventArgs.ReturnValue));
            }

            Gui.UpdateLastError(eventArgs.ReturnValue);
        }

        private void NotifyRelease(object sender, AfterReleaseEventArgs eventArgs)
        {
            if (Gui.InvokeRequired)
            {
                Gui.Invoke(new EventHandler<AfterReleaseEventArgs>(NotifyRelease), new[] { sender, eventArgs });
                return;
            }

            if (eventArgs.ReturnValue == ErrorCode.Success)
            {
                Gui.guiLogsView.SelectionColor = StandardColor;
                WriteLine(LogLevel.Info, sender, String.Format("<=  {0}", eventArgs.ReturnValue));
            }
            else
            {
                Gui.guiLogsView.SelectionColor = ErrorColor;
                WriteLine(LogLevel.Error, sender, String.Format("<=  {0}", eventArgs.ReturnValue));
            }

            Gui.UpdateLastError(eventArgs.ReturnValue);
        }

        #endregion

        #region >> StatusChangeMonitor delegates

        private void OnCardInsertionEvent(object sender, OnCardInsertionEventArgs eventArgs)
        {
            if (Gui.InvokeRequired)
            {
                Gui.Invoke(new EventHandler<OnCardInsertionEventArgs>(OnCardInsertionEvent), new Object[] { eventArgs });
                return;
            }

            Gui.guiLogsView.SelectionColor = HighlightColor;
            WriteLine(LogLevel.Info, sender, String.Format("<=  Card insertion detected on reader {0}\n", eventArgs.ReaderState.ReaderName));
        }

        private void OnCardRemovalEvent(object sender, OnCardRemovalEventArgs eventArgs)
        {
            if (Gui.InvokeRequired)
            {
                Gui.Invoke(new EventHandler<OnCardRemovalEventArgs>(OnCardRemovalEvent), new Object[] { eventArgs });
                return;
            }

            Gui.guiLogsView.SelectionColor = HighlightColor;
            WriteLine(LogLevel.Info, sender, String.Format("<=  Card removal detected on reader {0}\n", eventArgs.ReaderState.ReaderName));
        }

        #endregion
    }
}
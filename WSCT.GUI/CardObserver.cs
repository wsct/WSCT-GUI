using System;
using System.Drawing;
using WSCT.Core;
using WSCT.Core.APDU;
using WSCT.Helpers;
using WSCT.Wrapper;

namespace WSCT.GUI
{
    internal class CardObserver
    {
        internal Color ErrorColor = Color.Red;

        internal WinSCardGui Gui;
        internal String Header;
        internal Color HighlightColor = Color.DarkBlue;
        internal Color StandardColor = Color.Black;

        internal virtual void __start()
        {
            Gui.guiLogsView.AppendText(String.Format(Header + "ContextObserver started\n", LogLevel.Info));
        }

        #region >> Constructors

        /// <summary>
        /// Creates a new instance.
        /// </summary>
        /// <param name="gui"></param>
        public CardObserver(WinSCardGui gui)
            : this(gui, "Core ")
        {
        }

        /// <summary>
        /// Creates a new instance.
        /// </summary>
        /// <param name="gui"></param>
        /// <param name="header"></param>
        public CardObserver(WinSCardGui gui, string header)
        {
            Header = "[{0,7}] " + header + " ";
            Gui = gui;
            __start();
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
            //context.beforeGetStatusChangeEvent += beforeGetStatusChange;
            context.BeforeListReaderGroupsEvent += BeforeListReaderGroups;
            context.BeforeListReadersEvent += BeforeListReaders;
            context.BeforeReleaseEvent += BeforeRelease;

            context.AfterEstablishEvent += NotifyEstablish;
            //context.afterGetStatusChangeEvent += notifyGetStatusChange;
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

        public void NotifyConnect(ICardChannel cardChannel, ShareMode shareMode, Protocol preferedProtocol, ErrorCode errorCode)
        {
            if (Gui.InvokeRequired)
            {
                Gui.Invoke(new AfterConnect(NotifyConnect), new Object[] { cardChannel, shareMode, preferedProtocol, errorCode });
            }
            else
            {
                if (errorCode == ErrorCode.Success)
                {
                    Gui.guiLogsView.AppendText(String.Format(Header + ">> Error: {1}\n", LogLevel.Info, errorCode));
                    Gui.UpdateChannelStatus(ChannelStatusType.Connected);
                }
                else
                {
                    Gui.guiLogsView.SelectionColor = ErrorColor;
                    Gui.guiLogsView.AppendText(String.Format(Header + ">> Error: {1}\n", LogLevel.Warning, errorCode));
                    Gui.guiLogsView.SelectionColor = StandardColor;
                    Gui.UpdateChannelStatus(ChannelStatusType.Error);
                }
                Gui.UpdateLastError(errorCode);
            }
        }

        public void NotifyDisconnect(ICardChannel cardChannel, Disposition disposition, ErrorCode errorCode)
        {
            if (Gui.InvokeRequired)
            {
                Gui.Invoke(new AfterDisconnect(NotifyDisconnect), new Object[] { cardChannel, disposition, errorCode });
            }
            else
            {
                if (errorCode == ErrorCode.Success)
                {
                    Gui.guiLogsView.AppendText(String.Format(Header + ">> Error: {1}\n", LogLevel.Info, errorCode));
                    Gui.UpdateChannelStatus(ChannelStatusType.Disconnected);
                }
                else
                {
                    Gui.guiLogsView.SelectionColor = ErrorColor;
                    Gui.guiLogsView.AppendText(String.Format(Header + ">> Error: {1}\n", LogLevel.Warning, errorCode));
                    Gui.guiLogsView.SelectionColor = StandardColor;
                    Gui.UpdateChannelStatus(ChannelStatusType.Error);
                }
                Gui.UpdateLastError(errorCode);
            }
        }

        public void NotifyGetAttrib(ICardChannel cardChannel, Attrib attrib, byte[] buffer, ErrorCode errorCode)
        {
            if (Gui.InvokeRequired)
            {
                Gui.Invoke(new AfterGetAttrib(NotifyGetAttrib), new Object[] { cardChannel, attrib, buffer, errorCode });
            }
            else
            {
                if (errorCode == ErrorCode.Success)
                {
                    Gui.guiLogsView.AppendText(String.Format(Header + ">> Error: {1}\n", LogLevel.Info, errorCode));
                    Gui.guiLogsView.AppendText(String.Format(Header + ">> byte[]: [{1}]\n", LogLevel.Info, buffer.ToHexa()));
                    Gui.guiLogsView.AppendText(String.Format(Header + ">> String: \"{1}\"\n", LogLevel.Info, buffer.ToAsciiString()));
                }
                else
                {
                    Gui.guiLogsView.SelectionColor = ErrorColor;
                    Gui.guiLogsView.AppendText(String.Format(Header + ">> Error: {1}\n", LogLevel.Warning, errorCode));
                    Gui.guiLogsView.SelectionColor = StandardColor;
                }
                Gui.UpdateLastError(errorCode);
            }
        }

        public void NotifyReconnect(ICardChannel cardChannel, ShareMode shareMode, Protocol preferedProtocol, Disposition initialization, ErrorCode errorCode)
        {
            if (Gui.InvokeRequired)
            {
                Gui.Invoke(new AfterReconnect(NotifyReconnect), new Object[] { cardChannel, shareMode, preferedProtocol, initialization, errorCode });
            }
            else
            {
                if (errorCode == ErrorCode.Success)
                {
                    Gui.guiLogsView.AppendText(String.Format(Header + ">> Error: {1}\n", LogLevel.Info, errorCode));
                    Gui.UpdateChannelStatus(ChannelStatusType.Connected);
                }
                else
                {
                    Gui.guiLogsView.SelectionColor = ErrorColor;
                    Gui.guiLogsView.AppendText(String.Format(Header + ">> Error: {1}\n", LogLevel.Warning, errorCode));
                    Gui.guiLogsView.SelectionColor = StandardColor;
                    Gui.UpdateChannelStatus(ChannelStatusType.Error);
                }
                Gui.UpdateLastError(errorCode);
            }
        }

        public void NotifyTransmit(ICardChannel cardChannel, ICardCommand cardCommand, ICardResponse cardResponse, ErrorCode errorCode)
        {
            if (Gui.InvokeRequired)
            {
                Gui.Invoke(new AfterTransmit(NotifyTransmit), new Object[] { cardChannel, cardCommand, cardResponse, errorCode });
            }
            else
            {
                if (errorCode == ErrorCode.Success)
                {
                    Gui.guiLogsView.AppendText(String.Format(Header + ">> Error: {1}\n", LogLevel.Info, errorCode));
                    Gui.guiLogsView.AppendText(String.Format(Header + ">> RAPDU: [{1}]\n", LogLevel.Info, cardResponse));
                }
                else
                {
                    Gui.guiLogsView.SelectionColor = ErrorColor;
                    Gui.guiLogsView.AppendText(String.Format(Header + ">> Error: {1}\n", LogLevel.Warning, errorCode));
                    Gui.guiLogsView.SelectionColor = StandardColor;
                }
                Gui.UpdateLastError(errorCode);
            }
        }

        public void BeforeConnect(ICardChannel cardChannel, ShareMode shareMode, Protocol preferedProtocol)
        {
            if (Gui.InvokeRequired)
            {
                Gui.Invoke(new BeforeConnect(BeforeConnect), new Object[] { cardChannel, shareMode, preferedProtocol });
            }
            else
            {
                Gui.guiLogsView.SelectionColor = HighlightColor;
                Gui.guiLogsView.AppendText(String.Format(Header + "connect(\"{1}\",{2},{3})\n", LogLevel.Info, cardChannel.ReaderName, shareMode, preferedProtocol));
                Gui.guiLogsView.SelectionColor = StandardColor;
            }
        }

        public void BeforeDisconnect(ICardChannel cardChannel, Disposition disposition)
        {
            if (Gui.InvokeRequired)
            {
                Gui.Invoke(new BeforeDisconnect(BeforeDisconnect), new Object[] { cardChannel, disposition });
            }
            else
            {
                Gui.guiLogsView.SelectionColor = HighlightColor;
                Gui.guiLogsView.AppendText(String.Format(Header + "disconnect({1})\n", LogLevel.Info, disposition));
                Gui.guiLogsView.SelectionColor = StandardColor;
            }
        }

        public void BeforeGetAttrib(ICardChannel cardChannel, Attrib attrib, byte[] buffer)
        {
            if (Gui.InvokeRequired)
            {
                Gui.Invoke(new BeforeGetAttrib(BeforeGetAttrib), new Object[] { cardChannel, attrib, buffer });
            }
            else
            {
                Gui.guiLogsView.SelectionColor = HighlightColor;
                Gui.guiLogsView.AppendText(String.Format(Header + "getAttrib({1})\n", LogLevel.Info, attrib));
                Gui.guiLogsView.SelectionColor = StandardColor;
            }
        }

        public void BeforeReconnect(ICardChannel cardChannel, ShareMode shareMode, Protocol preferedProtocol, Disposition initialization)
        {
            if (Gui.InvokeRequired)
            {
                Gui.Invoke(new BeforeReconnect(BeforeReconnect), new Object[] { cardChannel, shareMode, preferedProtocol, initialization });
            }
            else
            {
                Gui.guiLogsView.SelectionColor = HighlightColor;
                Gui.guiLogsView.AppendText(String.Format(Header + "reconnect({1},{2},{3})\n", LogLevel.Info, shareMode, preferedProtocol, initialization));
                Gui.guiLogsView.SelectionColor = StandardColor;
            }
        }

        public void BeforeTransmit(ICardChannel cardChannel, ICardCommand cardCommand, byte[] recvBuffer, UInt32 recvSize)
        {
            if (Gui.InvokeRequired)
            {
                Gui.Invoke(new BeforeTransmit(BeforeTransmit), new Object[] { cardChannel, cardCommand, recvBuffer, recvSize });
            }
            else
            {
                Gui.guiLogsView.SelectionColor = HighlightColor;
                Gui.guiLogsView.AppendText(String.Format(Header + "transmit({1})\n", LogLevel.Info, cardCommand));
                Gui.guiLogsView.SelectionColor = StandardColor;
            }
        }

        public void BeforeTransmit(ICardChannel cardChannel, ICardCommand cardCommand, ICardResponse cardResponse)
        {
            if (Gui.InvokeRequired)
            {
                Gui.Invoke(new BeforeTransmit(BeforeTransmit), new Object[] { cardChannel, cardCommand, cardResponse });
            }
            else
            {
                Gui.guiLogsView.SelectionColor = HighlightColor;
                Gui.guiLogsView.AppendText(String.Format(Header + "transmit({1})\n", LogLevel.Info, cardCommand));
                Gui.guiLogsView.SelectionColor = StandardColor;
            }
        }

        #endregion

        #region >> CardContextObservable delegates

        private void BeforeEstablish(ICardContext cardContext)
        {
            if (Gui.InvokeRequired)
            {
                Gui.Invoke(new BeforeEstablish(BeforeEstablish), new Object[] { cardContext });
            }
            else
            {
                Gui.guiLogsView.SelectionColor = HighlightColor;
                Gui.guiLogsView.AppendText(String.Format(Header + "establish()\n", LogLevel.Info));
                Gui.guiLogsView.SelectionColor = StandardColor;
            }
        }

        private void BeforeGetStatusChange(ICardContext cardContext, UInt32 timeout, AbstractReaderState[] readerStates)
        {
            if (Gui.InvokeRequired)
            {
                Gui.Invoke(new BeforeGetStatusChange(BeforeGetStatusChange), new Object[] { cardContext, timeout, readerStates });
            }
            else
            {
                Gui.guiLogsView.SelectionColor = HighlightColor;
                Gui.guiLogsView.AppendText(String.Format(Header + "getStatusChange()\n", LogLevel.Info));
                Gui.guiLogsView.SelectionColor = StandardColor;
            }
        }

        private void BeforeListReaders(ICardContext cardContext, string group)
        {
            if (Gui.InvokeRequired)
            {
                Gui.Invoke(new BeforeListReaders(BeforeListReaders), new Object[] { cardContext, group });
            }
            else
            {
                Gui.guiLogsView.SelectionColor = HighlightColor;
                Gui.guiLogsView.AppendText(String.Format(Header + "listReaders({1})\n", LogLevel.Info, group));
                Gui.guiLogsView.SelectionColor = StandardColor;
            }
        }

        private void BeforeListReaderGroups(ICardContext cardContext)
        {
            if (Gui.InvokeRequired)
            {
                Gui.Invoke(new BeforeListReaderGroups(BeforeListReaderGroups), new Object[] { cardContext });
            }
            else
            {
                Gui.guiLogsView.SelectionColor = HighlightColor;
                Gui.guiLogsView.AppendText(String.Format(Header + "listReaderGroups()\n", LogLevel.Info));
                Gui.guiLogsView.SelectionColor = StandardColor;
            }
        }

        private void BeforeRelease(ICardContext cardContext)
        {
            if (Gui.InvokeRequired)
            {
                Gui.Invoke(new BeforeRelease(BeforeRelease), new Object[] { cardContext });
            }
            else
            {
                Gui.guiLogsView.SelectionColor = HighlightColor;
                Gui.guiLogsView.AppendText(String.Format(Header + "release()\n", LogLevel.Info));
                Gui.guiLogsView.SelectionColor = StandardColor;
            }
        }

        private void NotifyEstablish(ICardContext cardContext, ErrorCode errorCode)
        {
            if (Gui.InvokeRequired)
            {
                Gui.Invoke(new AfterEstablish(NotifyEstablish), new Object[] { cardContext, errorCode });
            }
            else
            {
                Gui.guiLogsView.SelectionColor = HighlightColor;
                Gui.guiLogsView.AppendText(String.Format(Header + ">> Error: {1}\n", LogLevel.Info, errorCode));
                Gui.guiLogsView.SelectionColor = StandardColor;
                Gui.UpdateLastError(errorCode);
            }
        }

        private void NotifyGetStatusChange(ICardContext cardContext, UInt32 timeout, AbstractReaderState[] readerStates, ErrorCode errorCode)
        {
            if (Gui.InvokeRequired)
            {
                Gui.Invoke(new AfterGetStatusChange(NotifyGetStatusChange), new Object[] { cardContext, timeout, readerStates, errorCode });
            }
            else
            {
                Gui.guiLogsView.SelectionColor = HighlightColor;
                Gui.guiLogsView.AppendText(String.Format(Header + "Error: {1}\n", LogLevel.Info, errorCode));
                Gui.guiLogsView.SelectionColor = StandardColor;
                if (errorCode == ErrorCode.Success)
                {
                    foreach (var readerState in readerStates)
                    {
                        Gui.guiLogsView.AppendText(String.Format(Header + ">> State:[{2}]\n", LogLevel.Info, readerState.EventState, readerState));
                    }
                }
            }
        }

        private void NotifyListReaders(ICardContext cardContext, string group, ErrorCode errorCode)
        {
            if (Gui.InvokeRequired)
            {
                Gui.Invoke(new AfterListReaders(NotifyListReaders), new Object[] { cardContext, group, errorCode });
            }
            else
            {
                Gui.guiLogsView.SelectionColor = HighlightColor;
                Gui.guiLogsView.AppendText(String.Format(Header + ">> Error: {1}\n", LogLevel.Info, errorCode, group));
                Gui.guiLogsView.SelectionColor = StandardColor;
                if (errorCode == ErrorCode.Success)
                {
                    foreach (var reader in cardContext.Readers)
                    {
                        Gui.guiLogsView.AppendText(String.Format(Header + ">> Reader descriptionFound: {1}\n", LogLevel.Info, reader));
                    }
                }
                Gui.UpdateLastError(errorCode);
            }
        }

        private void NotifyListReaderGroups(ICardContext cardContext, ErrorCode errorCode)
        {
            if (Gui.InvokeRequired)
            {
                Gui.Invoke(new AfterListReaderGroups(NotifyListReaderGroups), new Object[] { cardContext, errorCode });
            }
            else
            {
                Gui.guiLogsView.SelectionColor = HighlightColor;
                Gui.guiLogsView.AppendText(String.Format(Header + ">> Error: {1}\n", LogLevel.Info, errorCode));
                Gui.guiLogsView.SelectionColor = StandardColor;
                if (errorCode == ErrorCode.Success)
                {
                    foreach (var group in cardContext.Groups)
                    {
                        Gui.guiLogsView.AppendText(String.Format(Header + ">> Reader groups descriptionFound: {1}\n", LogLevel.Info, group));
                    }
                }
                Gui.UpdateLastError(errorCode);
            }
        }

        private void NotifyRelease(ICardContext cardContext, ErrorCode errorCode)
        {
            if (Gui.InvokeRequired)
            {
                Gui.Invoke(new AfterRelease(NotifyRelease), new Object[] { cardContext, errorCode });
            }
            else
            {
                Gui.guiLogsView.SelectionColor = HighlightColor;
                Gui.guiLogsView.AppendText(String.Format(Header + ">> Error: {1}\n", LogLevel.Info, errorCode));
                Gui.guiLogsView.SelectionColor = StandardColor;
                Gui.UpdateLastError(errorCode);
            }
        }

        #endregion

        #region >> StatusChangeMonitor delegates

        private void OnCardInsertionEvent(AbstractReaderState readerState)
        {
            if (Gui.InvokeRequired)
            {
                Gui.Invoke(new StatusChangeMonitor.OnCardInsertionEventHandler(OnCardInsertionEvent), new Object[] { readerState });
            }
            else
            {
                Gui.guiLogsView.SelectionColor = HighlightColor;
                Gui.guiLogsView.AppendText(String.Format(Header + ">> Card insertion detected on reader {1}\n", LogLevel.Info, readerState.ReaderName));
            }
        }

        private void OnCardRemovalEvent(AbstractReaderState readerState)
        {
            if (Gui.InvokeRequired)
            {
                Gui.Invoke(new StatusChangeMonitor.OnCardRemovalEventHandler(OnCardRemovalEvent), new Object[] { readerState });
            }
            else
            {
                Gui.guiLogsView.SelectionColor = HighlightColor;
                Gui.guiLogsView.AppendText(String.Format(Header + ">> Card removal detected on reader {1}\n", LogLevel.Info, readerState.ReaderName));
            }
        }

        #endregion
    }
}
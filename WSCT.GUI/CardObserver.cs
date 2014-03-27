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
        internal Color errorColor = Color.Red;

        internal WinSCardGUI gui;
        internal String header;
        internal Color highlightColor = Color.DarkBlue;
        internal Color standardColor = Color.Black;

        internal virtual void __start()
        {
            gui.guiLogsView.AppendText(String.Format(header + "ContextObserver started\n", LogLevel.Info));
        }

        #region >> Constructors

        public CardObserver(WinSCardGUI _gui)
            : this(_gui, "Core ")
        {
        }

        public CardObserver(WinSCardGUI _gui, String _header)
        {
            header = "[{0,7}] " + _header + " ";
            gui = _gui;
            __start();
        }

        #endregion

        #region >> observe *

        /// <summary>
        /// 
        /// </summary>
        /// <param name="context"></param>
        public void observeContext(ICardContextObservable context)
        {
            context.BeforeEstablishEvent += beforeEstablish;
            //context.beforeGetStatusChangeEvent += beforeGetStatusChange;
            context.BeforeListReaderGroupsEvent += beforeListReaderGroups;
            context.BeforeListReadersEvent += beforeListReaders;
            context.BeforeReleaseEvent += beforeRelease;

            context.AfterEstablishEvent += notifyEstablish;
            //context.afterGetStatusChangeEvent += notifyGetStatusChange;
            context.AfterListReaderGroupsEvent += notifyListReaderGroups;
            context.AfterListReadersEvent += notifyListReaders;
            context.AfterReleaseEvent += notifyRelease;
        }

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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="monitor"></param>
        public void observeMonitor(StatusChangeMonitor monitor)
        {
            monitor.OnCardInsertionEvent += onCardInsertionEvent;
            monitor.OnCardRemovalEvent += onCardRemovalEvent;
        }

        #endregion

        #region >> CardChannelObservable delegates

        public void notifyConnect(ICardChannel cardChannel, ShareMode shareMode, Protocol preferedProtocol, ErrorCode errorCode)
        {
            if (gui.InvokeRequired)
            {
                gui.Invoke(new AfterConnect(notifyConnect), new Object[] { cardChannel, shareMode, preferedProtocol, errorCode });
            }
            else
            {
                if (errorCode == ErrorCode.Success)
                {
                    gui.guiLogsView.AppendText(String.Format(header + ">> Error: {1}\n", LogLevel.Info, errorCode));
                    gui.updateChannelStatus(ChannelStatusType.connected);
                }
                else
                {
                    gui.guiLogsView.SelectionColor = errorColor;
                    gui.guiLogsView.AppendText(String.Format(header + ">> Error: {1}\n", LogLevel.Warning, errorCode));
                    gui.guiLogsView.SelectionColor = standardColor;
                    gui.updateChannelStatus(ChannelStatusType.error);
                }
                gui.updateLastError(errorCode);
            }
        }

        public void notifyDisconnect(ICardChannel cardChannel, Disposition disposition, ErrorCode errorCode)
        {
            if (gui.InvokeRequired)
            {
                gui.Invoke(new AfterDisconnect(notifyDisconnect), new Object[] { cardChannel, disposition, errorCode });
            }
            else
            {
                if (errorCode == ErrorCode.Success)
                {
                    gui.guiLogsView.AppendText(String.Format(header + ">> Error: {1}\n", LogLevel.Info, errorCode));
                    gui.updateChannelStatus(ChannelStatusType.disconnected);
                }
                else
                {
                    gui.guiLogsView.SelectionColor = errorColor;
                    gui.guiLogsView.AppendText(String.Format(header + ">> Error: {1}\n", LogLevel.Warning, errorCode));
                    gui.guiLogsView.SelectionColor = standardColor;
                    gui.updateChannelStatus(ChannelStatusType.error);
                }
                gui.updateLastError(errorCode);
            }
        }

        public void notifyGetAttrib(ICardChannel cardChannel, Attrib attrib, byte[] buffer, ErrorCode errorCode)
        {
            if (gui.InvokeRequired)
            {
                gui.Invoke(new AfterGetAttrib(notifyGetAttrib), new Object[] { cardChannel, attrib, buffer, errorCode });
            }
            else
            {
                if (errorCode == ErrorCode.Success)
                {
                    gui.guiLogsView.AppendText(String.Format(header + ">> Error: {1}\n", LogLevel.Info, errorCode));
                    gui.guiLogsView.AppendText(String.Format(header + ">> byte[]: [{1}]\n", LogLevel.Info, buffer.ToHexa()));
                    gui.guiLogsView.AppendText(String.Format(header + ">> String: \"{1}\"\n", LogLevel.Info, buffer.ToAsciiString()));
                }
                else
                {
                    gui.guiLogsView.SelectionColor = errorColor;
                    gui.guiLogsView.AppendText(String.Format(header + ">> Error: {1}\n", LogLevel.Warning, errorCode));
                    gui.guiLogsView.SelectionColor = standardColor;
                }
                gui.updateLastError(errorCode);
            }
        }

        public void notifyReconnect(ICardChannel cardChannel, ShareMode shareMode, Protocol preferedProtocol, Disposition initialization, ErrorCode errorCode)
        {
            if (gui.InvokeRequired)
            {
                gui.Invoke(new AfterReconnect(notifyReconnect), new Object[] { cardChannel, shareMode, preferedProtocol, initialization, errorCode });
            }
            else
            {
                if (errorCode == ErrorCode.Success)
                {
                    gui.guiLogsView.AppendText(String.Format(header + ">> Error: {1}\n", LogLevel.Info, errorCode));
                    gui.updateChannelStatus(ChannelStatusType.connected);
                }
                else
                {
                    gui.guiLogsView.SelectionColor = errorColor;
                    gui.guiLogsView.AppendText(String.Format(header + ">> Error: {1}\n", LogLevel.Warning, errorCode));
                    gui.guiLogsView.SelectionColor = standardColor;
                    gui.updateChannelStatus(ChannelStatusType.error);
                }
                gui.updateLastError(errorCode);
            }
        }

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
                    gui.guiLogsView.AppendText(String.Format(header + ">> Error: {1}\n", LogLevel.Info, errorCode));
                    gui.guiLogsView.AppendText(String.Format(header + ">> RAPDU: [{1}]\n", LogLevel.Info, cardResponse));
                }
                else
                {
                    gui.guiLogsView.SelectionColor = errorColor;
                    gui.guiLogsView.AppendText(String.Format(header + ">> Error: {1}\n", LogLevel.Warning, errorCode));
                    gui.guiLogsView.SelectionColor = standardColor;
                }
                gui.updateLastError(errorCode);
            }
        }

        public void beforeConnect(ICardChannel cardChannel, ShareMode shareMode, Protocol preferedProtocol)
        {
            if (gui.InvokeRequired)
            {
                gui.Invoke(new BeforeConnect(beforeConnect), new Object[] { cardChannel, shareMode, preferedProtocol });
            }
            else
            {
                gui.guiLogsView.SelectionColor = highlightColor;
                gui.guiLogsView.AppendText(String.Format(header + "connect(\"{1}\",{2},{3})\n", LogLevel.Info, cardChannel.ReaderName, shareMode, preferedProtocol));
                gui.guiLogsView.SelectionColor = standardColor;
            }
        }

        public void beforeDisconnect(ICardChannel cardChannel, Disposition disposition)
        {
            if (gui.InvokeRequired)
            {
                gui.Invoke(new BeforeDisconnect(beforeDisconnect), new Object[] { cardChannel, disposition });
            }
            else
            {
                gui.guiLogsView.SelectionColor = highlightColor;
                gui.guiLogsView.AppendText(String.Format(header + "disconnect({1})\n", LogLevel.Info, disposition));
                gui.guiLogsView.SelectionColor = standardColor;
            }
        }

        public void beforeGetAttrib(ICardChannel cardChannel, Attrib attrib, byte[] buffer)
        {
            if (gui.InvokeRequired)
            {
                gui.Invoke(new BeforeGetAttrib(beforeGetAttrib), new Object[] { cardChannel, attrib, buffer });
            }
            else
            {
                gui.guiLogsView.SelectionColor = highlightColor;
                gui.guiLogsView.AppendText(String.Format(header + "getAttrib({1})\n", LogLevel.Info, attrib));
                gui.guiLogsView.SelectionColor = standardColor;
            }
        }

        public void beforeReconnect(ICardChannel cardChannel, ShareMode shareMode, Protocol preferedProtocol, Disposition initialization)
        {
            if (gui.InvokeRequired)
            {
                gui.Invoke(new BeforeReconnect(beforeReconnect), new Object[] { cardChannel, shareMode, preferedProtocol, initialization });
            }
            else
            {
                gui.guiLogsView.SelectionColor = highlightColor;
                gui.guiLogsView.AppendText(String.Format(header + "reconnect({1},{2},{3})\n", LogLevel.Info, shareMode, preferedProtocol, initialization));
                gui.guiLogsView.SelectionColor = standardColor;
            }
        }

        public void beforeTransmit(ICardChannel cardChannel, ICardCommand cardCommand, byte[] recvBuffer, UInt32 recvSize)
        {
            if (gui.InvokeRequired)
            {
                gui.Invoke(new BeforeTransmit(beforeTransmit), new Object[] { cardChannel, cardCommand, recvBuffer, recvSize });
            }
            else
            {
                gui.guiLogsView.SelectionColor = highlightColor;
                gui.guiLogsView.AppendText(String.Format(header + "transmit({1})\n", LogLevel.Info, cardCommand));
                gui.guiLogsView.SelectionColor = standardColor;
            }
        }

        public void beforeTransmit(ICardChannel cardChannel, ICardCommand cardCommand, ICardResponse cardResponse)
        {
            if (gui.InvokeRequired)
            {
                gui.Invoke(new BeforeTransmit(beforeTransmit), new Object[] { cardChannel, cardCommand, cardResponse });
            }
            else
            {
                gui.guiLogsView.SelectionColor = highlightColor;
                gui.guiLogsView.AppendText(String.Format(header + "transmit({1})\n", LogLevel.Info, cardCommand));
                gui.guiLogsView.SelectionColor = standardColor;
            }
        }

        #endregion

        #region >> CardContextObservable delegates

        private void beforeEstablish(ICardContext cardContext)
        {
            if (gui.InvokeRequired)
            {
                gui.Invoke(new BeforeEstablish(beforeEstablish), new Object[] { cardContext });
            }
            else
            {
                gui.guiLogsView.SelectionColor = highlightColor;
                gui.guiLogsView.AppendText(String.Format(header + "establish()\n", LogLevel.Info));
                gui.guiLogsView.SelectionColor = standardColor;
            }
        }

        private void beforeGetStatusChange(ICardContext cardContext, UInt32 timeout, AbstractReaderState[] readerStates)
        {
            if (gui.InvokeRequired)
            {
                gui.Invoke(new BeforeGetStatusChange(beforeGetStatusChange), new Object[] { cardContext, timeout, readerStates });
            }
            else
            {
                gui.guiLogsView.SelectionColor = highlightColor;
                gui.guiLogsView.AppendText(String.Format(header + "getStatusChange()\n", LogLevel.Info));
                gui.guiLogsView.SelectionColor = standardColor;
            }
        }

        private void beforeListReaders(ICardContext cardContext, string group)
        {
            if (gui.InvokeRequired)
            {
                gui.Invoke(new BeforeListReaders(beforeListReaders), new Object[] { cardContext, group });
            }
            else
            {
                gui.guiLogsView.SelectionColor = highlightColor;
                gui.guiLogsView.AppendText(String.Format(header + "listReaders({1})\n", LogLevel.Info, group));
                gui.guiLogsView.SelectionColor = standardColor;
            }
        }

        private void beforeListReaderGroups(ICardContext cardContext)
        {
            if (gui.InvokeRequired)
            {
                gui.Invoke(new BeforeListReaderGroups(beforeListReaderGroups), new Object[] { cardContext });
            }
            else
            {
                gui.guiLogsView.SelectionColor = highlightColor;
                gui.guiLogsView.AppendText(String.Format(header + "listReaderGroups()\n", LogLevel.Info));
                gui.guiLogsView.SelectionColor = standardColor;
            }
        }

        private void beforeRelease(ICardContext cardContext)
        {
            if (gui.InvokeRequired)
            {
                gui.Invoke(new BeforeRelease(beforeRelease), new Object[] { cardContext });
            }
            else
            {
                gui.guiLogsView.SelectionColor = highlightColor;
                gui.guiLogsView.AppendText(String.Format(header + "release()\n", LogLevel.Info));
                gui.guiLogsView.SelectionColor = standardColor;
            }
        }

        private void notifyEstablish(ICardContext cardContext, ErrorCode errorCode)
        {
            if (gui.InvokeRequired)
            {
                gui.Invoke(new AfterEstablish(notifyEstablish), new Object[] { cardContext, errorCode });
            }
            else
            {
                gui.guiLogsView.SelectionColor = highlightColor;
                gui.guiLogsView.AppendText(String.Format(header + ">> Error: {1}\n", LogLevel.Info, errorCode));
                gui.guiLogsView.SelectionColor = standardColor;
                gui.updateLastError(errorCode);
            }
        }

        private void notifyGetStatusChange(ICardContext cardContext, UInt32 timeout, AbstractReaderState[] readerStates, ErrorCode errorCode)
        {
            if (gui.InvokeRequired)
            {
                gui.Invoke(new AfterGetStatusChange(notifyGetStatusChange), new Object[] { cardContext, timeout, readerStates, errorCode });
            }
            else
            {
                gui.guiLogsView.SelectionColor = highlightColor;
                gui.guiLogsView.AppendText(String.Format(header + "Error: {1}\n", LogLevel.Info, errorCode));
                gui.guiLogsView.SelectionColor = standardColor;
                if (errorCode == ErrorCode.Success)
                {
                    foreach (var readerState in readerStates)
                    {
                        gui.guiLogsView.AppendText(String.Format(header + ">> State:[{2}]\n", LogLevel.Info, readerState.EventState, readerState));
                    }
                }
            }
        }

        private void notifyListReaders(ICardContext cardContext, string group, ErrorCode errorCode)
        {
            if (gui.InvokeRequired)
            {
                gui.Invoke(new AfterListReaders(notifyListReaders), new Object[] { cardContext, group, errorCode });
            }
            else
            {
                gui.guiLogsView.SelectionColor = highlightColor;
                gui.guiLogsView.AppendText(String.Format(header + ">> Error: {1}\n", LogLevel.Info, errorCode, group));
                gui.guiLogsView.SelectionColor = standardColor;
                if (errorCode == ErrorCode.Success)
                {
                    foreach (var reader in cardContext.Readers)
                    {
                        gui.guiLogsView.AppendText(String.Format(header + ">> Reader descriptionFound: {1}\n", LogLevel.Info, reader));
                    }
                }
                gui.updateLastError(errorCode);
            }
        }

        private void notifyListReaderGroups(ICardContext cardContext, ErrorCode errorCode)
        {
            if (gui.InvokeRequired)
            {
                gui.Invoke(new AfterListReaderGroups(notifyListReaderGroups), new Object[] { cardContext, errorCode });
            }
            else
            {
                gui.guiLogsView.SelectionColor = highlightColor;
                gui.guiLogsView.AppendText(String.Format(header + ">> Error: {1}\n", LogLevel.Info, errorCode));
                gui.guiLogsView.SelectionColor = standardColor;
                if (errorCode == ErrorCode.Success)
                {
                    foreach (var group in cardContext.Groups)
                    {
                        gui.guiLogsView.AppendText(String.Format(header + ">> Reader groups descriptionFound: {1}\n", LogLevel.Info, group));
                    }
                }
                gui.updateLastError(errorCode);
            }
        }

        private void notifyRelease(ICardContext cardContext, ErrorCode errorCode)
        {
            if (gui.InvokeRequired)
            {
                gui.Invoke(new AfterRelease(notifyRelease), new Object[] { cardContext, errorCode });
            }
            else
            {
                gui.guiLogsView.SelectionColor = highlightColor;
                gui.guiLogsView.AppendText(String.Format(header + ">> Error: {1}\n", LogLevel.Info, errorCode));
                gui.guiLogsView.SelectionColor = standardColor;
                gui.updateLastError(errorCode);
            }
        }

        #endregion

        #region >> StatusChangeMonitor delegates

        private void onCardInsertionEvent(AbstractReaderState readerState)
        {
            if (gui.InvokeRequired)
            {
                gui.Invoke(new StatusChangeMonitor.OnCardInsertionEventHandler(onCardInsertionEvent), new Object[] { readerState });
            }
            else
            {
                gui.guiLogsView.SelectionColor = highlightColor;
                gui.guiLogsView.AppendText(String.Format(header + ">> Card insertion detected on reader {1}\n", LogLevel.Info, readerState.ReaderName));
            }
        }

        private void onCardRemovalEvent(AbstractReaderState readerState)
        {
            if (gui.InvokeRequired)
            {
                gui.Invoke(new StatusChangeMonitor.OnCardRemovalEventHandler(onCardRemovalEvent), new Object[] { readerState });
            }
            else
            {
                gui.guiLogsView.SelectionColor = highlightColor;
                gui.guiLogsView.AppendText(String.Format(header + ">> Card removal detected on reader {1}\n", LogLevel.Info, readerState.ReaderName));
            }
        }

        #endregion
    }
}
using System;
using System.Collections.Generic;
using System.Text;

using WSCT.Core;
using WSCT.Core.APDU;
using WSCT.Wrapper;

using WSCT.Helpers;

namespace WSCT.GUI
{
    class CardObserver
    {
        internal String header;
        internal System.Drawing.Color highlightColor = System.Drawing.Color.DarkBlue;
        internal System.Drawing.Color standardColor = System.Drawing.Color.Black;
        internal System.Drawing.Color errorColor = System.Drawing.Color.Red;

        internal WinSCardGUI gui;

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
        public void observeContext(Core.ICardContextObservable context)
        {
            context.beforeEstablishEvent += beforeEstablish;
            //context.beforeGetStatusChangeEvent += beforeGetStatusChange;
            context.beforeListReaderGroupsEvent += beforeListReaderGroups;
            context.beforeListReadersEvent += beforeListReaders;
            context.beforeReleaseEvent += beforeRelease;

            context.afterEstablishEvent += notifyEstablish;
            //context.afterGetStatusChangeEvent += notifyGetStatusChange;
            context.afterListReaderGroupsEvent += notifyListReaderGroups;
            context.afterListReadersEvent += notifyListReaders;
            context.afterReleaseEvent += notifyRelease;
        }

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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="monitor"></param>
        public void observeMonitor(Core.StatusChangeMonitor monitor)
        {
            monitor.onCardInsertionEvent += onCardInsertionEvent;
            monitor.onCardRemovalEvent += onCardRemovalEvent;
        }

        #endregion

        #region >> CardChannelObservable delegates

        public void notifyConnect(ICardChannel cardChannel, ShareMode shareMode, Protocol preferedProtocol, ErrorCode errorCode)
        {
            if (gui.InvokeRequired)
            {
                gui.Invoke(new afterConnect(notifyConnect), new Object[] { cardChannel, shareMode, preferedProtocol, errorCode });
            }
            else
            {
                if (errorCode == ErrorCode.SCARD_S_SUCCESS)
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
                gui.Invoke(new afterDisconnect(notifyDisconnect), new Object[] { cardChannel, disposition, errorCode });
            }
            else
            {
                if (errorCode == ErrorCode.SCARD_S_SUCCESS)
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

        public void notifyGetAttrib(ICardChannel cardChannel, Attrib attrib, Byte[] buffer, ErrorCode errorCode)
        {
            if (gui.InvokeRequired)
            {
                gui.Invoke(new afterGetAttrib(notifyGetAttrib), new Object[] { cardChannel, attrib, buffer, errorCode });
            }
            else
            {
                if (errorCode == ErrorCode.SCARD_S_SUCCESS)
                {
                    gui.guiLogsView.AppendText(String.Format(header + ">> Error: {1}\n", LogLevel.Info, errorCode));
                    gui.guiLogsView.AppendText(String.Format(header + ">> Byte[]: [{1}]\n", LogLevel.Info, buffer.toHexa()));
                    gui.guiLogsView.AppendText(String.Format(header + ">> String: \"{1}\"\n", LogLevel.Info, buffer.toString()));
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
                gui.Invoke(new afterReconnect(notifyReconnect), new Object[] { cardChannel, shareMode, preferedProtocol, initialization, errorCode });
            }
            else
            {
                if (errorCode == ErrorCode.SCARD_S_SUCCESS)
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
                gui.Invoke(new afterTransmit(notifyTransmit), new Object[] { cardChannel, cardCommand, cardResponse, errorCode });
            }
            else
            {
                if (errorCode == ErrorCode.SCARD_S_SUCCESS)
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
                gui.Invoke(new beforeConnect(beforeConnect), new Object[] { cardChannel, shareMode, preferedProtocol });
            }
            else
            {
                gui.guiLogsView.SelectionColor = highlightColor;
                gui.guiLogsView.AppendText(String.Format(header + "connect(\"{1}\",{2},{3})\n", LogLevel.Info, cardChannel.readerName, shareMode, preferedProtocol));
                gui.guiLogsView.SelectionColor = standardColor;
            }
        }

        public void beforeDisconnect(ICardChannel cardChannel, Disposition disposition)
        {
            if (gui.InvokeRequired)
            {
                gui.Invoke(new beforeDisconnect(beforeDisconnect), new Object[] { cardChannel, disposition });
            }
            else
            {
                gui.guiLogsView.SelectionColor = highlightColor;
                gui.guiLogsView.AppendText(String.Format(header + "disconnect({1})\n", LogLevel.Info, disposition));
                gui.guiLogsView.SelectionColor = standardColor;
            }
        }

        public void beforeGetAttrib(ICardChannel cardChannel, Attrib attrib, Byte[] buffer)
        {
            if (gui.InvokeRequired)
            {
                gui.Invoke(new beforeGetAttrib(beforeGetAttrib), new Object[] { cardChannel, attrib, buffer });
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
                gui.Invoke(new beforeReconnect(beforeReconnect), new Object[] { cardChannel, shareMode, preferedProtocol, initialization });
            }
            else
            {
                gui.guiLogsView.SelectionColor = highlightColor;
                gui.guiLogsView.AppendText(String.Format(header + "reconnect({1},{2},{3})\n", LogLevel.Info, shareMode, preferedProtocol, initialization));
                gui.guiLogsView.SelectionColor = standardColor;
            }
        }

        public void beforeTransmit(ICardChannel cardChannel, ICardCommand cardCommand, Byte[] recvBuffer, UInt32 recvSize)
        {
            if (gui.InvokeRequired)
            {
                gui.Invoke(new beforeTransmit(beforeTransmit), new Object[] { cardChannel, cardCommand, recvBuffer, recvSize });
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
                gui.Invoke(new beforeTransmit(beforeTransmit), new Object[] { cardChannel, cardCommand, cardResponse });
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
                gui.Invoke(new beforeEstablish(beforeEstablish), new Object[] { cardContext });
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
                gui.Invoke(new beforeGetStatusChange(beforeGetStatusChange), new Object[] { cardContext, timeout, readerStates });
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
                gui.Invoke(new beforeListReaders(beforeListReaders), new Object[] { cardContext, group });
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
                gui.Invoke(new beforeListReaderGroups(beforeListReaderGroups), new Object[] { cardContext });
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
                gui.Invoke(new beforeRelease(beforeRelease), new Object[] { cardContext });
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
                gui.Invoke(new afterEstablish(notifyEstablish), new Object[] { cardContext, errorCode });
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
                gui.Invoke(new afterGetStatusChange(notifyGetStatusChange), new Object[] { cardContext, timeout, readerStates, errorCode });
            }
            else
            {
                gui.guiLogsView.SelectionColor = highlightColor;
                gui.guiLogsView.AppendText(String.Format(header + "Error: {1}\n", LogLevel.Info, errorCode));
                gui.guiLogsView.SelectionColor = standardColor;
                if (errorCode == ErrorCode.SCARD_S_SUCCESS)
                    foreach (AbstractReaderState readerState in readerStates)
                    {
                        gui.guiLogsView.AppendText(String.Format(header + ">> State:[{2}]\n", LogLevel.Info, readerState.eventState, readerState));
                    }
            }
        }

        private void notifyListReaders(ICardContext cardContext, string group, ErrorCode errorCode)
        {
            if (gui.InvokeRequired)
            {
                gui.Invoke(new afterListReaders(notifyListReaders), new Object[] { cardContext, group, errorCode });
            }
            else
            {
                gui.guiLogsView.SelectionColor = highlightColor;
                gui.guiLogsView.AppendText(String.Format(header + ">> Error: {1}\n", LogLevel.Info, errorCode, group));
                gui.guiLogsView.SelectionColor = standardColor;
                if (errorCode == ErrorCode.SCARD_S_SUCCESS)
                    foreach (String reader in cardContext.readers)
                        gui.guiLogsView.AppendText(String.Format(header + ">> Reader descriptionFound: {1}\n", LogLevel.Info, reader));
                gui.updateLastError(errorCode);
            }
        }

        private void notifyListReaderGroups(ICardContext cardContext, ErrorCode errorCode)
        {
            if (gui.InvokeRequired)
            {
                gui.Invoke(new afterListReaderGroups(notifyListReaderGroups), new Object[] { cardContext, errorCode });
            }
            else
            {
                gui.guiLogsView.SelectionColor = highlightColor;
                gui.guiLogsView.AppendText(String.Format(header + ">> Error: {1}\n", LogLevel.Info, errorCode));
                gui.guiLogsView.SelectionColor = standardColor;
                if (errorCode == ErrorCode.SCARD_S_SUCCESS)
                    foreach (String group in cardContext.groups)
                        gui.guiLogsView.AppendText(String.Format(header + ">> Reader groups descriptionFound: {1}\n", LogLevel.Info, group));
                gui.updateLastError(errorCode);
            }
        }

        private void notifyRelease(ICardContext cardContext, ErrorCode errorCode)
        {
            if (gui.InvokeRequired)
            {
                gui.Invoke(new afterRelease(notifyRelease), new Object[] { cardContext, errorCode });
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
                gui.Invoke(new StatusChangeMonitor.onCardInsertionEventHandler(onCardInsertionEvent), new Object[] { readerState });
            }
            else
            {
                gui.guiLogsView.SelectionColor = highlightColor;
                gui.guiLogsView.AppendText(String.Format(header + ">> Card insertion detected on reader {1}\n", LogLevel.Info, readerState.readerName));
            }
        }

        private void onCardRemovalEvent(AbstractReaderState readerState)
        {
            if (gui.InvokeRequired)
            {
                gui.Invoke(new StatusChangeMonitor.onCardRemovalEventHandler(onCardRemovalEvent), new Object[] { readerState });
            }
            else
            {
                gui.guiLogsView.SelectionColor = highlightColor;
                gui.guiLogsView.AppendText(String.Format(header + ">> Card removal detected on reader {1}\n", LogLevel.Info, readerState.readerName));
            }
        }

        #endregion
    }
}
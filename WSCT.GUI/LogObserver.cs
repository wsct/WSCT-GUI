using System;
using System.Drawing;
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
    internal sealed class LogObserver
    {
        internal IWinSCardGui Gui;
        internal string Header;
        private readonly Color _hightlightColor;

        private void WriteLogLine(LogLevel level, object sender, string message)
        {
            string identifier;
            switch (sender)
            {
                case ICardChannelLayerObservable channelLayer:
                    identifier = channelLayer.LayerId;
                    break;
                case ICardChannelStack _:
                    identifier = "Stack";
                    break;
                case ICardContextLayerObservable contextLayer:
                    identifier = contextLayer.LayerId;
                    break;
                case ICardContextStack _:
                    identifier = "Stack";
                    break;
                default:
                    identifier = "unknown";
                    break;
            }
            Gui.AppendLineToLog(String.Format(Header, level, identifier, message));
        }

        #region >> Constructors

        /// <summary>
        /// Creates a new instance.
        /// </summary>
        /// <param name="gui"></param>
        /// <param name="defaultColor"></param>
        public LogObserver(IWinSCardGui gui, Color defaultColor)
        {
            Header = "[{0,7}] [{1,7}] {2}" + Environment.NewLine;
            Gui = gui;
            _hightlightColor = defaultColor;
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
            Gui.InvokeOnUiThread(() =>
            {
                if (eventArgs.ReturnValue == ErrorCode.Success)
                {
                    Gui.SetLogForeColor(Colors.LogDefaultColor);
                    WriteLogLine(LogLevel.Info, sender, $"<=  {eventArgs.ReturnValue}");
                    Gui.UpdateChannelStatus(ChannelStatusType.Connected);
                }
                else
                {
                    Gui.SetLogForeColor(Colors.LogErrorColor);
                    WriteLogLine(LogLevel.Error, sender, $"<=  {eventArgs.ReturnValue}");
                    Gui.UpdateChannelStatus(ChannelStatusType.Error);
                }

                Gui.UpdateLastError(eventArgs.ReturnValue);
            });
        }

        public void NotifyDisconnect(object sender, AfterDisconnectEventArgs eventArgs)
        {
            Gui.InvokeOnUiThread(() =>
            {
                if (eventArgs.ReturnValue == ErrorCode.Success)
                {
                    Gui.SetLogForeColor(Colors.LogDefaultColor);
                    WriteLogLine(LogLevel.Info, sender, $"<=  {eventArgs.ReturnValue}");
                    Gui.UpdateChannelStatus(ChannelStatusType.Disconnected);
                }
                else
                {
                    Gui.SetLogForeColor(Colors.LogErrorColor);
                    WriteLogLine(LogLevel.Error, sender, $"<=  {eventArgs.ReturnValue}");
                    Gui.UpdateChannelStatus(ChannelStatusType.Error);
                }

                Gui.UpdateLastError(eventArgs.ReturnValue);
            });
        }

        public void NotifyGetAttrib(object sender, AfterGetAttribEventArgs eventArgs)
        {
            Gui.InvokeOnUiThread(() =>
            {
                if (eventArgs.ReturnValue == ErrorCode.Success)
                {
                    Gui.SetLogForeColor(Colors.LogDefaultColor);
                    WriteLogLine(LogLevel.Info, sender, $"<=  byte[]: [{eventArgs.Buffer.ToHexa()}]");
                }
                else
                {
                    Gui.SetLogForeColor(Colors.LogErrorColor);
                    WriteLogLine(LogLevel.Error, sender, String.Format(Header + "<=  {0}", eventArgs.ReturnValue));
                }

                Gui.UpdateLastError(eventArgs.ReturnValue);
            });
        }

        public void NotifyReconnect(object sender, AfterReconnectEventArgs eventArgs)
        {
            Gui.InvokeOnUiThread(() =>
            {
                if (eventArgs.ReturnValue == ErrorCode.Success)
                {
                    Gui.SetLogForeColor(Colors.LogDefaultColor);
                    WriteLogLine(LogLevel.Info, sender, $"<=  {eventArgs.ReturnValue}");
                    Gui.UpdateChannelStatus(ChannelStatusType.Connected);
                }
                else
                {
                    Gui.SetLogForeColor(Colors.LogErrorColor);
                    WriteLogLine(LogLevel.Error, sender, $"<=  {eventArgs.ReturnValue}");
                    Gui.UpdateChannelStatus(ChannelStatusType.Error);
                }

                Gui.UpdateLastError(eventArgs.ReturnValue);
            });
        }

        public void NotifyTransmit(object sender, AfterTransmitEventArgs eventArgs)
        {
            Gui.InvokeOnUiThread(() =>
            {
                if (eventArgs.ReturnValue == ErrorCode.Success)
                {
                    Gui.SetLogForeColor(Colors.LogDefaultColor);
                    WriteLogLine(LogLevel.Info, sender, $"<=  RAPDU: [{eventArgs.Response}]");
                }
                else
                {
                    Gui.SetLogForeColor(Colors.LogErrorColor);
                    WriteLogLine(LogLevel.Error, sender, $"<=  {eventArgs.ReturnValue}");
                }

                Gui.UpdateLastError(eventArgs.ReturnValue);
            });
        }

        public void BeforeConnect(object sender, BeforeConnectEventArgs eventArgs)
        {
            Gui.InvokeOnUiThread(() =>
            {
                var cardChannel = (ICardChannel)sender;

                Gui.SetLogForeColor(_hightlightColor);
                WriteLogLine(LogLevel.Info, sender, $" => Connect(\"{cardChannel.ReaderName}\",{eventArgs.ShareMode},{eventArgs.PreferedProtocol})");
            });
        }

        public void BeforeDisconnect(object sender, BeforeDisconnectEventArgs eventArgs)
        {
            Gui.InvokeOnUiThread(() =>
            {
                Gui.SetLogForeColor(_hightlightColor);
                WriteLogLine(LogLevel.Info, sender, $" => Disconnect({eventArgs.Disposition})");
            });
        }

        public void BeforeGetAttrib(object sender, BeforeGetAttribEventArgs eventArgs)
        {
            Gui.InvokeOnUiThread(() =>
            {
                Gui.SetLogForeColor(_hightlightColor);
                WriteLogLine(LogLevel.Info, sender, $" => GetAttrib({eventArgs.Attrib})");
            });
        }

        public void BeforeReconnect(object sender, BeforeReconnectEventArgs eventArgs)
        {
            Gui.InvokeOnUiThread(() =>
            {
                Gui.SetLogForeColor(_hightlightColor);
                WriteLogLine(LogLevel.Info, sender,
                    $" => Reconnect({eventArgs.ShareMode},{eventArgs.PreferedProtocol},{eventArgs.Initialization})");
            });
        }

        public void BeforeTransmit(object sender, BeforeTransmitEventArgs eventArgs)
        {
            Gui.InvokeOnUiThread(() =>
            {
                Gui.SetLogForeColor(_hightlightColor);
                WriteLogLine(LogLevel.Info, sender, $" => Transmit({eventArgs.Command})");
            });
        }

        #endregion

        #region >> CardContextObservable delegates

        private void BeforeEstablish(object sender, BeforeEstablishEventArgs eventArgs)
        {
            Gui.InvokeOnUiThread(() =>
            {
                Gui.SetLogForeColor(_hightlightColor);
                WriteLogLine(LogLevel.Info, sender, " => Establish()");
            });
        }

        private void BeforeListReaders(object sender, BeforeListReadersEventArgs eventArgs)
        {
            Gui.InvokeOnUiThread(() =>
            {
                Gui.SetLogForeColor(_hightlightColor);
                WriteLogLine(LogLevel.Info, sender, $" => ListReaders({eventArgs.Group})");
            });
        }

        private void BeforeListReaderGroups(object sender, BeforeListReaderGroupsEventArgs eventArgs)
        {
            Gui.InvokeOnUiThread(() =>
            {
                Gui.SetLogForeColor(_hightlightColor);
                WriteLogLine(LogLevel.Info, sender, " => ListReaderGroups()");
            });
        }

        private void BeforeRelease(object sender, BeforeReleaseEventArgs eventArgs)
        {
            Gui.InvokeOnUiThread(() =>
            {
                Gui.SetLogForeColor(_hightlightColor);
                WriteLogLine(LogLevel.Info, sender, " => Release()");
            });
        }

        private void NotifyEstablish(object sender, AfterEstablishEventArgs eventArgs)
        {
            Gui.InvokeOnUiThread(() =>
            {
                if (eventArgs.ReturnValue == ErrorCode.Success)
                {
                    Gui.SetLogForeColor(Colors.LogDefaultColor);
                    WriteLogLine(LogLevel.Info, sender, $"<=  {eventArgs.ReturnValue}");
                }
                else
                {
                    Gui.SetLogForeColor(Colors.LogErrorColor);
                    WriteLogLine(LogLevel.Error, sender, $"<=  {eventArgs.ReturnValue}");
                }

                Gui.UpdateLastError(eventArgs.ReturnValue);
            });
        }

        private void NotifyListReaders(object sender, AfterListReadersEventArgs eventArgs)
        {
            Gui.InvokeOnUiThread(() =>
            {
                var cardContext = (ICardContext)sender;

                if (eventArgs.ReturnValue == ErrorCode.Success)
                {
                    cardContext.Readers.DoForEach(
                        r =>
                        {
                            Gui.SetLogForeColor(Colors.LogDefaultColor);
                            WriteLogLine(LogLevel.Info, sender, $"<=  Reader: {r}");
                        });
                }
                else
                {
                    Gui.SetLogForeColor(Colors.LogErrorColor);
                    WriteLogLine(LogLevel.Error, sender, $"<=  {eventArgs.ReturnValue}");
                }

                Gui.UpdateLastError(eventArgs.ReturnValue);
            });
        }

        private void NotifyListReaderGroups(object sender, AfterListReaderGroupsEventArgs eventArgs)
        {
            Gui.InvokeOnUiThread(() =>
            {
                var cardContext = (ICardContext)sender;

                if (eventArgs.ReturnValue == ErrorCode.Success)
                {
                    cardContext.Groups.DoForEach(
                        g =>
                        {
                            Gui.SetLogForeColor(Colors.LogDefaultColor);
                            WriteLogLine(LogLevel.Info, sender, $"<=  Group: {g}");
                        });
                }
                else
                {
                    Gui.SetLogForeColor(Colors.LogErrorColor);
                    WriteLogLine(LogLevel.Error, sender, $"<=  {eventArgs.ReturnValue}");
                }

                Gui.UpdateLastError(eventArgs.ReturnValue);
            });
        }

        private void NotifyRelease(object sender, AfterReleaseEventArgs eventArgs)
        {
            Gui.InvokeOnUiThread(() =>
            {
                if (eventArgs.ReturnValue == ErrorCode.Success)
                {
                    Gui.SetLogForeColor(Colors.LogDefaultColor);
                    WriteLogLine(LogLevel.Info, sender, $"<=  {eventArgs.ReturnValue}");
                }
                else
                {
                    Gui.SetLogForeColor(Colors.LogErrorColor);
                    WriteLogLine(LogLevel.Error, sender, $"<=  {eventArgs.ReturnValue}");
                }

                Gui.UpdateLastError(eventArgs.ReturnValue);
            });
        }

        #endregion

        #region >> StatusChangeMonitor delegates

        private void OnCardInsertionEvent(object sender, OnCardInsertionEventArgs eventArgs)
        {
            Gui.InvokeOnUiThread(() =>
            {
                Gui.SetLogForeColor(_hightlightColor);
                WriteLogLine(LogLevel.Info, sender, $"<=  Card insertion detected on reader {eventArgs.ReaderState.ReaderName}\n");
            });
        }

        private void OnCardRemovalEvent(object sender, OnCardRemovalEventArgs eventArgs)
        {
            Gui.InvokeOnUiThread(() =>
            {
                Gui.SetLogForeColor(_hightlightColor);
                WriteLogLine(LogLevel.Info, sender, $"<=  Card removal detected on reader {eventArgs.ReaderState.ReaderName}\n");
            });
        }

        #endregion
    }
}
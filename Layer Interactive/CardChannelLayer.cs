using System;
using WSCT.Core;
using WSCT.Core.APDU;
using WSCT.Core.Events;
using WSCT.Helpers;
using WSCT.Helpers.Events;
using WSCT.Layers.Interactive.Actions;
using WSCT.Stack;
using WSCT.Wrapper;

namespace WSCT.Layers.Interactive
{
    /// <summary>
    /// Interactive channel layer capable of saving data exchanges with the reader and replaying it later.
    /// Also install a fake reader, allowing replay mode to be used without physical reader.
    /// </summary>
    public class CardChannelLayer : ICardChannelLayer, ICardChannelObservable
    {
        #region >> Fields

        private Protocol _protocol;
        private ICardChannelStack _stack;

        #endregion

        #region >> ICardChannelLayer

        /// <inheritdoc />
        public void SetStack(ICardChannelStack stack)
        {
            _stack = stack;
        }

        /// <inheritdoc />
        public string LayerId
        {
            get { return "IAL"; }
        }

        #endregion

        #region >> ICardChannel

        /// <inheritdoc />
        public Protocol Protocol
        {
            get
            {
                if (InteractiveController.Mode == InteractiveMode.Replay)
                {
                    return _protocol;
                }
                return _stack.RequestLayer(this, SearchMode.Next).Protocol;
            }
        }

        /// <inheritdoc />
        public string ReaderName
        {
            get { return _stack.RequestLayer(this, SearchMode.Next).ReaderName; }
        }

        /// <inheritdoc />
        public void Attach(ICardContext context, string readerName)
        {
            _stack.RequestLayer(this, SearchMode.Next).Attach(context, readerName);
        }

        /// <inheritdoc />
        public ErrorCode Connect(ShareMode shareMode, Protocol preferedProtocol)
        {
            BeforeConnectEvent.Raise(this, new BeforeConnectEventArgs { ShareMode = shareMode, PreferedProtocol = preferedProtocol });

            ErrorCode ret;
            if (InteractiveController.Mode == InteractiveMode.Replay)
            {
                var nextAction = InteractiveController.ActionsList[InteractiveController.ActionsListId];
                if (nextAction is ConnectAction)
                {
                    // Retrieve protocol to send
                    _protocol = ((ConnectAction)nextAction).Protocol;
                    // Seek id to next action and check limits
                    if (++InteractiveController.ActionsListId == InteractiveController.ActionsList.Count)
                    {
                        InteractiveController.Mode = InteractiveMode.Transparent;
                    }
                    // Success
                    ret = ErrorCode.Success;
                }
                else
                {
                    // Raise an error
                    ret = ErrorCode.UnsupportedFeature;
                }
            }
            else
            {
                ret = _stack.RequestLayer(this, SearchMode.Next).Connect(shareMode, preferedProtocol);

                if (InteractiveController.Mode == InteractiveMode.Record)
                {
                    InteractiveController.ActionsList.Add(
                        new ConnectAction(Protocol)
                        );
                }
            }

            AfterConnectEvent.Raise(this, new AfterConnectEventArgs { ShareMode = shareMode, PreferedProtocol = preferedProtocol, ReturnValue = ret });

            return ret;
        }

        /// <inheritdoc />
        public ErrorCode Disconnect(Disposition disposition)
        {
            BeforeDisconnectEvent.Raise(this, new BeforeDisconnectEventArgs { Disposition = disposition });

            ErrorCode ret;
            if (InteractiveController.Mode == InteractiveMode.Replay)
            {
                var nextAction = InteractiveController.ActionsList[InteractiveController.ActionsListId];
                if (nextAction is DisconnectAction && ((DisconnectAction)nextAction).Disposition == disposition)
                {
                    // Seek id to next action and check limits
                    if (++InteractiveController.ActionsListId == InteractiveController.ActionsList.Count)
                    {
                        InteractiveController.Mode = InteractiveMode.Transparent;
                    }
                    // Success
                    ret = ErrorCode.Success;
                }
                else
                {
                    // Raise an error
                    ret = ErrorCode.UnsupportedFeature;
                }
            }
            else
            {
                ret = _stack.RequestLayer(this, SearchMode.Next).Disconnect(disposition);

                if (InteractiveController.Mode == InteractiveMode.Record)
                {
                    InteractiveController.ActionsList.Add(
                        new DisconnectAction(disposition)
                        );
                }
            }

            AfterDisconnectEvent.Raise(this, new AfterDisconnectEventArgs { Disposition = disposition, ReturnValue = ret });

            return ret;
        }

        /// <inheritdoc />
        public ErrorCode GetAttrib(Attrib attrib, ref byte[] buffer)
        {
            BeforeGetAttribEvent.Raise(this, new BeforeGetAttribEventArgs { Attrib = attrib, Buffer = buffer });

            ErrorCode ret;

            if (InteractiveController.Mode == InteractiveMode.Replay)
            {
                var nextAction = InteractiveController.ActionsList[InteractiveController.ActionsListId];
                if (nextAction is GetAttribAction && ((GetAttribAction)nextAction).Attrib == attrib)
                {
                    // Retrieve buffer to send
                    buffer = ((GetAttribAction)nextAction).Response.FromHexa();
                    // Seek id to next action and check limits
                    if (++InteractiveController.ActionsListId == InteractiveController.ActionsList.Count)
                    {
                        InteractiveController.Mode = InteractiveMode.Transparent;
                    }
                    // Success
                    ret = ErrorCode.Success;
                }
                else
                {
                    // Raise an error
                    ret = ErrorCode.UnsupportedFeature;
                }
            }
            else
            {
                ret = _stack.RequestLayer(this, SearchMode.Next).GetAttrib(attrib, ref buffer);

                if (InteractiveController.Mode == InteractiveMode.Record)
                {
                    InteractiveController.ActionsList.Add(
                        new GetAttribAction(attrib, buffer.ToHexa())
                        );
                }
            }

            AfterGetAttribEvent.Raise(this, new AfterGetAttribEventArgs { Attrib = attrib, Buffer = buffer, ReturnValue = ret });

            return ret;
        }

        /// <inheritdoc />
        public State GetStatus()
        {
            BeforeGetStatusEvent.Raise(this, new BeforeGetStatusEventArgs());

            var state = _stack.RequestLayer(this, SearchMode.Next).GetStatus();

            AfterGetStatusEvent.Raise(this, new AfterGetStatusEventArgs { State = state });

            return state;
        }

        /// <inheritdoc />
        public ErrorCode Reconnect(ShareMode shareMode, Protocol preferedProtocol, Disposition initialization)
        {
            BeforeReconnectEvent.Raise(this, new BeforeReconnectEventArgs { ShareMode = shareMode, PreferedProtocol = preferedProtocol, Initialization = initialization });

            ErrorCode ret;
            if (InteractiveController.Mode == InteractiveMode.Replay)
            {
                var nextAction = InteractiveController.ActionsList[InteractiveController.ActionsListId];
                if (nextAction is ReconnectAction && ((ReconnectAction)nextAction).Initialization == initialization)
                {
                    // Retrieve protocol to send
                    _protocol = ((ReconnectAction)nextAction).Protocol;
                    // Seek id to next action and check limits
                    if (++InteractiveController.ActionsListId == InteractiveController.ActionsList.Count)
                    {
                        InteractiveController.Mode = InteractiveMode.Transparent;
                    }
                    // Success
                    ret = ErrorCode.Success;
                }
                else
                {
                    // Raise an error
                    ret = ErrorCode.UnsupportedFeature;
                }
            }
            else
            {
                ret = _stack.RequestLayer(this, SearchMode.Next).Reconnect(shareMode, preferedProtocol, initialization);

                if (InteractiveController.Mode == InteractiveMode.Record)
                {
                    InteractiveController.ActionsList.Add(
                        new ReconnectAction(Protocol, initialization)
                        );
                }
            }

            AfterReconnectEvent.Raise(this, new AfterReconnectEventArgs { ShareMode = shareMode, PreferedProtocol = preferedProtocol, Initialization = initialization, ReturnValue = ret });

            return ret;
        }

        /// <inheritdoc />
        public ErrorCode Transmit(ICardCommand command, ICardResponse response)
        {
            BeforeTransmitEvent.Raise(this, new BeforeTransmitEventArgs { Command = command, Response = response });

            ErrorCode ret;

            if (InteractiveController.Mode == InteractiveMode.Replay)
            {
                var nextAction = InteractiveController.ActionsList[InteractiveController.ActionsListId];
                if (nextAction is TransmitAction && ((TransmitAction)nextAction).Command == command.ToString())
                {
                    // Retrieve response to send
                    response.Parse(((TransmitAction)nextAction).Response.FromHexa());
                    // Seek id to next action and check limits
                    if (++InteractiveController.ActionsListId == InteractiveController.ActionsList.Count)
                    {
                        InteractiveController.Mode = InteractiveMode.Transparent;
                    }
                    // Success
                    ret = ErrorCode.Success;
                }
                else
                {
                    // Raise an error
                    ret = ErrorCode.UnsupportedFeature;
                }
            }
            else
            {
                ret = _stack.RequestLayer(this, SearchMode.Next).Transmit(command, response);

                if (InteractiveController.Mode == InteractiveMode.Record)
                {
                    InteractiveController.ActionsList.Add(
                        new TransmitAction(command.ToString(), response.ToString())
                        );
                }
            }

            AfterTransmitEvent.Raise(this, new AfterTransmitEventArgs { Command = command, Response = response, ReturnValue = ret });

            return ret;
        }

        #endregion

        #region >> ICardChannelObservable

        /// <inheritdoc />
        public event EventHandler<BeforeConnectEventArgs> BeforeConnectEvent;

        /// <inheritdoc />
        public event EventHandler<AfterConnectEventArgs> AfterConnectEvent;

        /// <inheritdoc />
        public event EventHandler<BeforeDisconnectEventArgs> BeforeDisconnectEvent;

        /// <inheritdoc />
        public event EventHandler<AfterDisconnectEventArgs> AfterDisconnectEvent;

        /// <inheritdoc />
        public event EventHandler<BeforeGetAttribEventArgs> BeforeGetAttribEvent;

        /// <inheritdoc />
        public event EventHandler<AfterGetAttribEventArgs> AfterGetAttribEvent;

        /// <inheritdoc />
        public event EventHandler<BeforeGetStatusEventArgs> BeforeGetStatusEvent;

        /// <inheritdoc />
        public event EventHandler<AfterGetStatusEventArgs> AfterGetStatusEvent;

        /// <inheritdoc />
        public event EventHandler<BeforeReconnectEventArgs> BeforeReconnectEvent;

        /// <inheritdoc />
        public event EventHandler<AfterReconnectEventArgs> AfterReconnectEvent;

        /// <inheritdoc />
        public event EventHandler<BeforeTransmitEventArgs> BeforeTransmitEvent;

        /// <inheritdoc />
        public event EventHandler<AfterTransmitEventArgs> AfterTransmitEvent;

        #endregion
    }
}
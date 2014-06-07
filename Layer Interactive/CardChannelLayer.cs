using WSCT.Core;
using WSCT.Core.APDU;
using WSCT.Helpers;
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
            if (BeforeConnectEvent != null)
            {
                BeforeConnectEvent(this, shareMode, preferedProtocol);
            }

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

            if (AfterConnectEvent != null)
            {
                AfterConnectEvent(this, shareMode, preferedProtocol, ret);
            }

            return ret;
        }

        /// <inheritdoc />
        public ErrorCode Disconnect(Disposition disposition)
        {
            if (BeforeDisconnectEvent != null)
            {
                BeforeDisconnectEvent(this, disposition);
            }

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

            if (AfterDisconnectEvent != null)
            {
                AfterDisconnectEvent(this, disposition, ret);
            }

            return ret;
        }

        /// <inheritdoc />
        public ErrorCode GetAttrib(Attrib attrib, ref byte[] buffer)
        {
            if (BeforeGetAttribEvent != null)
            {
                BeforeGetAttribEvent(this, attrib, buffer);
            }

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

            if (AfterGetAttribEvent != null)
            {
                AfterGetAttribEvent(this, attrib, buffer, ret);
            }

            return ret;
        }

        /// <inheritdoc />
        public State GetStatus()
        {
            if (BeforeGetStatusEvent != null)
            {
                BeforeGetStatusEvent(this);
            }

            var ret = _stack.RequestLayer(this, SearchMode.Next).GetStatus();

            if (AfterGetStatusEvent != null)
            {
                AfterGetStatusEvent(this, ret);
            }

            return ret;
        }

        /// <inheritdoc />
        public ErrorCode Reconnect(ShareMode shareMode, Protocol preferedProtocol, Disposition initialization)
        {
            if (BeforeReconnectEvent != null)
            {
                BeforeReconnectEvent(this, shareMode, preferedProtocol, initialization);
            }

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

            if (AfterReconnectEvent != null)
            {
                AfterReconnectEvent(this, shareMode, preferedProtocol, initialization, ret);
            }

            return ret;
        }

        /// <inheritdoc />
        public ErrorCode Transmit(ICardCommand command, ICardResponse response)
        {
            if (BeforeTransmitEvent != null)
            {
                BeforeTransmitEvent(this, command, response);
            }

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

            if (AfterTransmitEvent != null)
            {
                AfterTransmitEvent(this, command, response, ret);
            }

            return ret;
        }

        #endregion

        #region >> ICardChannelObservable

        /// <inheritdoc />
        public event BeforeConnect BeforeConnectEvent;

        /// <inheritdoc />
        public event AfterConnect AfterConnectEvent;

        /// <inheritdoc />
        public event BeforeDisconnect BeforeDisconnectEvent;

        /// <inheritdoc />
        public event AfterDisconnect AfterDisconnectEvent;

        /// <inheritdoc />
        public event BeforeGetAttrib BeforeGetAttribEvent;

        /// <inheritdoc />
        public event AfterGetAttrib AfterGetAttribEvent;

        /// <inheritdoc />
        public event BeforeGetStatus BeforeGetStatusEvent;

        /// <inheritdoc />
        public event AfterGetStatus AfterGetStatusEvent;

        /// <inheritdoc />
        public event BeforeReconnect BeforeReconnectEvent;

        /// <inheritdoc />
        public event AfterReconnect AfterReconnectEvent;

        /// <inheritdoc />
        public event BeforeTransmit BeforeTransmitEvent;

        /// <inheritdoc />
        public event AfterTransmit AfterTransmitEvent;

        #endregion
    }
}
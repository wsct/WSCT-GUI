using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

using WSCT.Helpers;

using WSCT.Wrapper;
using WSCT.Core;
using WSCT.Stack;
using WSCT.Layers.Interactive.Actions;

namespace WSCT.Layers.Interactive
{
    /// <summary>
    /// Interactive channel layer capable of saving data exchanges with the reader and replaying it later.
    /// Also install a fake reader, allowing replay mode to be used without physical reader.
    /// </summary>
    public class CardChannelLayer : ICardChannelLayer, ICardChannelObservable
    {
        #region >> Fields

        ICardChannelStack _stack;

        Protocol _protocol;

        #endregion

        #region >> Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public CardChannelLayer()
        {
        }

        #endregion

        #region >> ICardChannelLayer

        /// <inheritdoc />
        public void setStack(ICardChannelStack stack)
        {
            _stack = stack;
        }

        #endregion

        #region >> ICardChannel

        /// <inheritdoc />
        public Protocol protocol
        {
            get
            {
                if (InteractiveController.mode == InteractiveMode.REPLAY)
                    return _protocol;
                else
                    return _stack.requestLayer(this, SearchMode.next).protocol;
            }
        }

        /// <inheritdoc />
        public string readerName
        {
            get
            {
                return _stack.requestLayer(this, SearchMode.next).readerName;
            }
        }

        /// <inheritdoc />
        public void attach(ICardContext context, string readerName)
        {
            _stack.requestLayer(this, SearchMode.next).attach(context, readerName);
        }

        /// <inheritdoc />
        public ErrorCode connect(ShareMode shareMode, Protocol preferedProtocol)
        {
            if (beforeConnectEvent != null) beforeConnectEvent(this, shareMode, preferedProtocol);

            ErrorCode ret;
            if (InteractiveController.mode == InteractiveMode.REPLAY)
            {
                AbstractAction nextAction = InteractiveController.actionsList[InteractiveController.actionsListId];
                if (nextAction is ConnectAction)
                {
                    // Retrieve protocol to send
                    _protocol = ((ConnectAction)nextAction).protocol;
                    // Seek id to next action and check limits
                    if (++InteractiveController.actionsListId == InteractiveController.actionsList.Count)
                        InteractiveController.mode = InteractiveMode.TRANSPARENT;
                    // Success
                    ret = ErrorCode.SCARD_S_SUCCESS;
                }
                else
                {
                    // Raise an error
                    ret = ErrorCode.SCARD_E_UNSUPPORTED_FEATURE;
                }
            }
            else
            {
                ret = _stack.requestLayer(this, SearchMode.next).connect(shareMode, preferedProtocol);

                if (InteractiveController.mode == InteractiveMode.RECORD)
                {
                    InteractiveController.actionsList.Add(
                        new Actions.ConnectAction(protocol)
                        );
                }
            }

            if (afterConnectEvent != null) afterConnectEvent(this, shareMode, preferedProtocol, ret);

            return ret;
        }

        /// <inheritdoc />
        public ErrorCode disconnect(Disposition disposition)
        {
            if (beforeDisconnectEvent != null) beforeDisconnectEvent(this, disposition);

            ErrorCode ret;
            if (InteractiveController.mode == InteractiveMode.REPLAY)
            {
                AbstractAction nextAction = InteractiveController.actionsList[InteractiveController.actionsListId];
                if (nextAction is DisconnectAction && ((DisconnectAction)nextAction).disposition == disposition)
                {
                    // Seek id to next action and check limits
                    if (++InteractiveController.actionsListId == InteractiveController.actionsList.Count)
                        InteractiveController.mode = InteractiveMode.TRANSPARENT;
                    // Success
                    ret = ErrorCode.SCARD_S_SUCCESS;
                }
                else
                {
                    // Raise an error
                    ret = ErrorCode.SCARD_E_UNSUPPORTED_FEATURE;
                }
            }
            else
            {
                ret = _stack.requestLayer(this, SearchMode.next).disconnect(disposition);

                if (InteractiveController.mode == InteractiveMode.RECORD)
                {
                    InteractiveController.actionsList.Add(
                        new Actions.DisconnectAction(disposition)
                        );
                }
            }

            if (afterDisconnectEvent != null) afterDisconnectEvent(this, disposition, ret);

            return ret;
        }

        /// <inheritdoc />
        public ErrorCode getAttrib(Attrib attrib, ref byte[] buffer)
        {
            if (beforeGetAttribEvent != null) beforeGetAttribEvent(this, attrib, buffer);

            ErrorCode ret;

            if (InteractiveController.mode == InteractiveMode.REPLAY)
            {
                AbstractAction nextAction = InteractiveController.actionsList[InteractiveController.actionsListId];
                if (nextAction is GetAttribAction && ((GetAttribAction)nextAction).attrib == attrib)
                {
                    // Retrieve buffer to send
                    buffer = ((GetAttribAction)nextAction).response.fromHexa();
                    // Seek id to next action and check limits
                    if (++InteractiveController.actionsListId == InteractiveController.actionsList.Count)
                        InteractiveController.mode = InteractiveMode.TRANSPARENT;
                    // Success
                    ret = ErrorCode.SCARD_S_SUCCESS;
                }
                else
                {
                    // Raise an error
                    ret = ErrorCode.SCARD_E_UNSUPPORTED_FEATURE;
                }
            }
            else
            {
                ret = _stack.requestLayer(this, SearchMode.next).getAttrib(attrib, ref buffer);

                if (InteractiveController.mode == InteractiveMode.RECORD)
                {
                    InteractiveController.actionsList.Add(
                        new Actions.GetAttribAction(attrib, buffer.toHexa())
                        );
                }
            }

            if (afterGetAttribEvent != null) afterGetAttribEvent(this, attrib, buffer, ret);

            return ret;
        }

        /// <inheritdoc />
        public State getStatus()
        {
            if (beforeGetStatusEvent != null) beforeGetStatusEvent(this);

            State ret = _stack.requestLayer(this, SearchMode.next).getStatus();

            if (afterGetStatusEvent != null) afterGetStatusEvent(this, ret);

            return ret;
        }

        /// <inheritdoc />
        public ErrorCode reconnect(ShareMode shareMode, Protocol preferedProtocol, Disposition initialization)
        {
            if (beforeReconnectEvent != null) beforeReconnectEvent(this, shareMode, preferedProtocol, initialization);

            ErrorCode ret;
            if (InteractiveController.mode == InteractiveMode.REPLAY)
            {
                AbstractAction nextAction = InteractiveController.actionsList[InteractiveController.actionsListId];
                if (nextAction is ReconnectAction && ((ReconnectAction)nextAction).initialization == initialization)
                {
                    // Retrieve protocol to send
                    _protocol = ((ReconnectAction)nextAction).protocol;
                    // Seek id to next action and check limits
                    if (++InteractiveController.actionsListId == InteractiveController.actionsList.Count)
                        InteractiveController.mode = InteractiveMode.TRANSPARENT;
                    // Success
                    ret = ErrorCode.SCARD_S_SUCCESS;
                }
                else
                {
                    // Raise an error
                    ret = ErrorCode.SCARD_E_UNSUPPORTED_FEATURE;
                }
            }
            else
            {
                ret = _stack.requestLayer(this, SearchMode.next).reconnect(shareMode, preferedProtocol, initialization);

                if (InteractiveController.mode == InteractiveMode.RECORD)
                {
                    InteractiveController.actionsList.Add(
                        new Actions.ReconnectAction(protocol, initialization)
                        );
                }
            }

            if (afterReconnectEvent != null) afterReconnectEvent(this, shareMode, preferedProtocol, initialization, ret);

            return ret;
        }

        /// <inheritdoc />
        public ErrorCode transmit(Core.APDU.ICardCommand command, Core.APDU.ICardResponse response)
        {
            if (beforeTransmitEvent != null) beforeTransmitEvent(this, command, response);

            ErrorCode ret;

            if (InteractiveController.mode == InteractiveMode.REPLAY)
            {
                AbstractAction nextAction = InteractiveController.actionsList[InteractiveController.actionsListId];
                if (nextAction is TransmitAction && ((TransmitAction)nextAction).command == command.ToString())
                {
                    // Retrieve response to send
                    response.parse(((TransmitAction)nextAction).response.fromHexa());
                    // Seek id to next action and check limits
                    if (++InteractiveController.actionsListId == InteractiveController.actionsList.Count)
                        InteractiveController.mode = InteractiveMode.TRANSPARENT;
                    // Success
                    ret = ErrorCode.SCARD_S_SUCCESS;
                }
                else
                {
                    // Raise an error
                    ret = ErrorCode.SCARD_E_UNSUPPORTED_FEATURE;
                }
            }
            else
            {
                ret = _stack.requestLayer(this, SearchMode.next).transmit(command, response);

                if (InteractiveController.mode == InteractiveMode.RECORD)
                {
                    InteractiveController.actionsList.Add(
                        new Actions.TransmitAction(command.ToString(), response.ToString())
                        );
                }
            }

            if (afterTransmitEvent != null) afterTransmitEvent(this, command, response, ret);

            return ret;
        }

        #endregion

        #region >> ICardChannelObservable

        /// <inheritdoc />
        public event beforeConnect beforeConnectEvent;
        /// <inheritdoc />
        public event afterConnect afterConnectEvent;

        /// <inheritdoc />
        public event beforeDisconnect beforeDisconnectEvent;
        /// <inheritdoc />
        public event afterDisconnect afterDisconnectEvent;

        /// <inheritdoc />
        public event beforeGetAttrib beforeGetAttribEvent;
        /// <inheritdoc />
        public event afterGetAttrib afterGetAttribEvent;

        /// <inheritdoc />
        public event beforeGetStatus beforeGetStatusEvent;
        /// <inheritdoc />
        public event afterGetStatus afterGetStatusEvent;

        /// <inheritdoc />
        public event beforeReconnect beforeReconnectEvent;
        /// <inheritdoc />
        public event afterReconnect afterReconnectEvent;

        /// <inheritdoc />
        public event beforeTransmit beforeTransmitEvent;
        /// <inheritdoc />
        public event afterTransmit afterTransmitEvent;

        #endregion
    }
}

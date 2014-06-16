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
    public class CardChannelLayer : ICardChannelLayer
    {
        #region >> Fields

        private Protocol protocol;
        private ICardChannelStack stack;

        #endregion

        #region >> ICardChannelLayer

        /// <inheritdoc />
        public void SetStack(ICardChannelStack stack)
        {
            this.stack = stack;
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
                    return protocol;
                }

                return stack.RequestLayer(this, SearchMode.Next).Protocol;
            }
        }

        /// <inheritdoc />
        public string ReaderName
        {
            get { return stack.RequestLayer(this, SearchMode.Next).ReaderName; }
        }

        /// <inheritdoc />
        public void Attach(ICardContext context, string readerName)
        {
            stack.RequestLayer(this, SearchMode.Next).Attach(context, readerName);
        }

        /// <inheritdoc />
        public ErrorCode Connect(ShareMode shareMode, Protocol preferedProtocol)
        {
            switch (InteractiveController.Mode)
            {
                case InteractiveMode.Replay:
                    var nextAction = InteractiveController.ActionsList[InteractiveController.ActionsListId] as ConnectAction;

                    if (nextAction == null)
                    {
                        return ErrorCode.UnsupportedFeature;
                    }

                    // Retrieve protocol to send
                    protocol = nextAction.Protocol;
                    // Seek id to next action and check limits
                    if (++InteractiveController.ActionsListId == InteractiveController.ActionsList.Count)
                    {
                        InteractiveController.Mode = InteractiveMode.Transparent;
                    }

                    return ErrorCode.Success;

                default:
                    var ret = stack.RequestLayer(this, SearchMode.Next).Connect(shareMode, preferedProtocol);

                    if (InteractiveController.Mode == InteractiveMode.Record)
                    {
                        InteractiveController.ActionsList.Add(new ConnectAction(Protocol));
                    }

                    return ret;
            }
        }

        /// <inheritdoc />
        public ErrorCode Disconnect(Disposition disposition)
        {
            switch (InteractiveController.Mode)
            {
                case InteractiveMode.Replay:
                    var nextAction = InteractiveController.ActionsList[InteractiveController.ActionsListId] as DisconnectAction;

                    if (nextAction == null || nextAction.Disposition != disposition)
                    {
                        return ErrorCode.UnsupportedFeature;
                    }

                    // Seek id to next action and check limits
                    if (++InteractiveController.ActionsListId == InteractiveController.ActionsList.Count)
                    {
                        InteractiveController.Mode = InteractiveMode.Transparent;
                    }

                    return ErrorCode.Success;

                default:
                    var ret = stack.RequestLayer(this, SearchMode.Next).Disconnect(disposition);

                    if (InteractiveController.Mode == InteractiveMode.Record)
                    {
                        InteractiveController.ActionsList.Add(new DisconnectAction(disposition));
                    }

                    return ret;
            }
        }

        /// <inheritdoc />
        public ErrorCode GetAttrib(Attrib attrib, ref byte[] buffer)
        {
            switch (InteractiveController.Mode)
            {
                case InteractiveMode.Replay:
                    var nextAction = InteractiveController.ActionsList[InteractiveController.ActionsListId] as GetAttribAction;

                    if (nextAction == null || nextAction.Attrib != attrib)
                    {
                        return ErrorCode.UnsupportedFeature;
                    }

                    // Retrieve buffer to send
                    buffer = nextAction.Response.FromHexa();
                    // Seek id to next action and check limits
                    if (++InteractiveController.ActionsListId == InteractiveController.ActionsList.Count)
                    {
                        InteractiveController.Mode = InteractiveMode.Transparent;
                    }

                    return ErrorCode.Success;

                default:
                    var ret = stack.RequestLayer(this, SearchMode.Next).GetAttrib(attrib, ref buffer);

                    if (InteractiveController.Mode == InteractiveMode.Record)
                    {
                        InteractiveController.ActionsList.Add(new GetAttribAction(attrib, buffer.ToHexa()));
                    }

                    return ret;
            }
        }

        /// <inheritdoc />
        public State GetStatus()
        {
            return stack.RequestLayer(this, SearchMode.Next).GetStatus();
        }

        /// <inheritdoc />
        public ErrorCode Reconnect(ShareMode shareMode, Protocol preferedProtocol, Disposition initialization)
        {
            switch (InteractiveController.Mode)
            {
                case InteractiveMode.Replay:
                    var nextAction = InteractiveController.ActionsList[InteractiveController.ActionsListId] as ReconnectAction;

                    if (nextAction == null || nextAction.Initialization != initialization)
                    {
                        return ErrorCode.UnsupportedFeature;
                    }

                    // Retrieve protocol to send
                    protocol = nextAction.Protocol;
                    // Seek id to next action and check limits
                    if (++InteractiveController.ActionsListId == InteractiveController.ActionsList.Count)
                    {
                        InteractiveController.Mode = InteractiveMode.Transparent;
                    }

                    return ErrorCode.Success;

                default:

                    var ret = stack.RequestLayer(this, SearchMode.Next).Reconnect(shareMode, preferedProtocol, initialization);

                    if (InteractiveController.Mode == InteractiveMode.Record)
                    {
                        InteractiveController.ActionsList.Add(new ReconnectAction(Protocol, initialization));
                    }

                    return ret;
            }
        }

        /// <inheritdoc />
        public ErrorCode Transmit(ICardCommand command, ICardResponse response)
        {
            switch (InteractiveController.Mode)
            {
                case InteractiveMode.Replay:
                    {
                        var nextAction = InteractiveController.ActionsList[InteractiveController.ActionsListId] as TransmitAction;

                        if (nextAction == null || nextAction.Command != command.ToString())
                        {
                            return ErrorCode.UnsupportedFeature;
                        }

                        // Retrieve response to send
                        response.Parse(nextAction.Response.FromHexa());
                        // Seek id to next action and check limits
                        if (++InteractiveController.ActionsListId == InteractiveController.ActionsList.Count)
                        {
                            InteractiveController.Mode = InteractiveMode.Transparent;
                        }

                        return ErrorCode.Success;
                    }

                default:
                    var ret = stack.RequestLayer(this, SearchMode.Next).Transmit(command, response);

                    if (InteractiveController.Mode == InteractiveMode.Record)
                    {
                        InteractiveController.ActionsList.Add(new TransmitAction(command.ToString(), response.ToString()));
                    }

                    return ret;
            }
        }

        #endregion
    }
}
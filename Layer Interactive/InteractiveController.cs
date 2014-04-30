using System;
using System.Collections.Generic;
using System.Linq;
using WSCT.GUI.Plugins;
using WSCT.Layers.Interactive.Actions;
using WSCT.Stack;

namespace WSCT.Layers.Interactive
{
    /// <summary>
    /// Controller for Interactive Layers.
    /// </summary>
    public class InteractiveController
    {
        #region >> Delegates

        /// <summary>
        /// Delegate for event raised when <see cref="InteractiveController.Mode"/> has changed.
        /// </summary>
        public delegate void InteractiveModeChangedEventHandler();

        #endregion

        #region >> Fields

        /// <summary>
        /// Mode of the layer.
        /// </summary>
        private static InteractiveMode PrivateMode = InteractiveMode.Transparent;

        #endregion

        #region >> Events

        /// <summary>
        /// Event raised when <see cref="Mode"/> has changed.
        /// </summary>
        public static InteractiveModeChangedEventHandler InteractiveModeChangedEvent;

        #endregion

        #region >> Properties

        /// <summary>
        /// Accessor the result of test of presence of the Interactive Context Layer.
        /// </summary>
        public static Boolean ContextLayerPresence
        {
            get
            {
                try
                {
                    if (!(SharedData.CardContext is ICardContextStack))
                    {
                        return false;
                    }
                }
                catch (Exception)
                {
                    return false;
                }
                return FindInteractiveLayerInStack((ICardContextStack)SharedData.CardContext);
            }
        }

        /// <summary>
        /// Accessor the result of test of presence of the Interactive Channel Layer.
        /// </summary>
        public static Boolean ChannelLayerPresence
        {
            get
            {
                try
                {
                    if (!(SharedData.CardChannel is ICardChannelStack))
                    {
                        return false;
                    }
                }
                catch (Exception)
                {
                    return false;
                }
                var stack = (ICardChannelStack)SharedData.CardChannel;
                return stack.Layers.OfType<CardChannelLayer>().Any();
            }
        }

        /// <summary>
        /// Interactive mode.
        /// </summary>
        public static InteractiveMode Mode
        {
            get { return PrivateMode; }
            set
            {
                PrivateMode = value;
                if (InteractiveModeChangedEvent != null)
                {
                    InteractiveModeChangedEvent();
                }
                OnInteractiveModeChanged();
            }
        }

        #endregion

        #region >> Static properties

        /// <summary>
        /// Indicates if IL use its fake smartcard reader.
        /// </summary>
        public static Boolean UseFakeReader = false;

        /// <summary>
        /// Name of the fake smartcard reader.
        /// </summary>
        public static String FakeReaderName = "Interactive Fake Smartcard Reader 0";

        /// <summary>
        /// List of actions used as source (REPLAY mode) or destination (RECORD mode)
        /// </summary>
        public static List<AbstractAction> ActionsList = new List<AbstractAction>();

        /// <summary>
        /// Identifier of current action in list of actions (REPLAY mode)
        /// </summary>
        public static int ActionsListId = 0;

        #endregion

        private static void OnInteractiveModeChanged()
        {
            if (Mode != InteractiveMode.Record || ActionsList != null)
            {
                return;
            }

            ActionsList = new List<AbstractAction>();
            ActionsListId = 0;
        }

        private static Boolean FindInteractiveLayerInStack(ICardContextStack stack)
        {
            // TODO: not sure if it works...
            foreach (var layer in stack.Layers)
            {
                if (layer is CardContextLayer)
                {
                    return true;
                }
                if (layer is ICardContextStack)
                {
                    if (FindInteractiveLayerInStack((ICardContextStack)layer))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private static Boolean FindInteractiveLayerInStack(ICardChannelStack stack)
        {
            foreach (var layer in stack.Layers)
            {
                if (layer is CardChannelLayer)
                {
                    return true;
                }
                if (layer is ICardChannelStack)
                {
                    if (FindInteractiveLayerInStack((ICardChannelStack)layer))
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
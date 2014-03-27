using System;
using System.Collections.Generic;
using System.Linq;
using WSCT.GUI.Plugins;
using WSCT.Layers.Interactive.Actions;
using WSCT.Stack;

namespace WSCT.Layers.Interactive
{
    /// <summary>
    /// Controller for Interactive Layers
    /// </summary>
    public class InteractiveController
    {
        #region >> Delegates

        /// <summary>
        /// Delegate for event raised when <see cref="InteractiveController.mode"/> has changed
        /// </summary>
        public delegate void InteractiveModeChangedEventHandler();

        #endregion

        #region >> Fields

        /// <summary>
        /// Mode of the layer
        /// </summary>
        private static InteractiveMode _mode = InteractiveMode.TRANSPARENT;

        #endregion

        #region >> Events

        /// <summary>
        /// Event raised when <see cref="mode"/> has changed
        /// </summary>
        public static InteractiveModeChangedEventHandler interactiveModeChangedEvent;

        #endregion

        #region >> Properties

        /// <summary>
        /// Accessor the result of test of presence of the Interactive Context Layer
        /// </summary>
        public static Boolean contextLayerPresence
        {
            get
            {
                try
                {
                    if (!(SharedData.cardContext is ICardContextStack))
                    {
                        return false;
                    }
                }
                catch (Exception)
                {
                    return false;
                }
                return findInteractiveLayerInStack((ICardContextStack)SharedData.cardContext);
            }
        }

        /// <summary>
        /// Accessor the result of test of presence of the Interactive Channel Layer
        /// </summary>
        public static Boolean channelLayerPresence
        {
            get
            {
                try
                {
                    if (!(SharedData.cardChannel is ICardChannelStack))
                    {
                        return false;
                    }
                }
                catch (Exception)
                {
                    return false;
                }
                var stack = (ICardChannelStack)SharedData.cardChannel;
                return stack.Layers.OfType<CardChannelLayer>().Any();
            }
        }

        /// <summary>
        /// Interactive mode
        /// </summary>
        public static InteractiveMode mode
        {
            get { return _mode; }
            set
            {
                _mode = value;
                if (interactiveModeChangedEvent != null)
                {
                    interactiveModeChangedEvent();
                }
                onInteractiveModeChanged();
            }
        }

        #endregion

        #region >> Static properties

        /// <summary>
        /// Indicates if IL use its fake smartcard reader.
        /// </summary>
        public static Boolean useFakeReader = false;

        /// <summary>
        /// Name of the fake smartcard reader.
        /// </summary>
        public static String fakeReaderName = "Interactive Fake Smartcard Reader 0";

        /// <summary>
        /// List of actions used as source (REPLAY mode) or destination (RECORD mode)
        /// </summary>
        public static List<AbstractAction> actionsList = new List<AbstractAction>();

        /// <summary>
        /// Identifier of current action in list of actions (REPLAY mode)
        /// </summary>
        public static int actionsListId = 0;

        #endregion

        private static void onInteractiveModeChanged()
        {
            if (mode == InteractiveMode.RECORD && actionsList == null)
            {
                actionsList = new List<AbstractAction>();
                actionsListId = 0;
            }
        }

        private static Boolean findInteractiveLayerInStack(ICardContextStack stack)
        {
            foreach (var layer in stack.Layers)
            {
                if (layer is CardContextLayer)
                {
                    return true;
                }
                if (layer is ICardContextStack)
                {
                    if (findInteractiveLayerInStack((ICardContextStack)layer))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private static Boolean findInteractiveLayerInStack(ICardChannelStack stack)
        {
            foreach (var layer in stack.Layers)
            {
                if (layer is CardChannelLayer)
                {
                    return true;
                }
                if (layer is ICardChannelStack)
                {
                    if (findInteractiveLayerInStack((ICardChannelStack)layer))
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

using WSCT.GUI.Plugins;
using WSCT.Layers.Interactive.Actions;

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
        static InteractiveMode _mode = InteractiveMode.TRANSPARENT;

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
                    if (!(SharedData.cardContext is Stack.ICardContextStack))
                        return false;
                }
                catch (Exception)
                {
                    return false;
                }
                return findInteractiveLayerInStack((Stack.ICardContextStack)SharedData.cardContext);

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
                    if (!(SharedData.cardChannel is Stack.ICardChannelStack))
                        return false;
                }
                catch (Exception)
                {
                    return false;
                }
                Stack.ICardChannelStack stack = (Stack.ICardChannelStack)SharedData.cardChannel;
                foreach (Stack.ICardChannelLayer layer in stack.layers)
                    if (layer is Layers.Interactive.CardChannelLayer)
                        return true;
                return false;
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
                if (InteractiveController.interactiveModeChangedEvent != null) InteractiveController.interactiveModeChangedEvent();
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

        static void onInteractiveModeChanged()
        {
            if (InteractiveController.mode == InteractiveMode.RECORD && InteractiveController.actionsList == null)
            {
                InteractiveController.actionsList = new List<AbstractAction>();
                InteractiveController.actionsListId = 0;
            }
        }

        static Boolean findInteractiveLayerInStack(Stack.ICardContextStack stack)
        {
            foreach (Stack.ICardContextLayer layer in stack.layers)
                if (layer is Layers.Interactive.CardContextLayer)
                    return true;
                else if (layer is Stack.ICardContextStack)
                    if (findInteractiveLayerInStack((Stack.ICardContextStack)layer))
                        return true;
            return false;
        }

        static Boolean findInteractiveLayerInStack(Stack.ICardChannelStack stack)
        {
            foreach (Stack.ICardChannelLayer layer in stack.layers)
                if (layer is Layers.Interactive.CardChannelLayer)
                    return true;
                else if (layer is Stack.ICardChannelStack)
                    if (findInteractiveLayerInStack((Stack.ICardChannelStack)layer))
                        return true;
            return false;
        }

    }
}

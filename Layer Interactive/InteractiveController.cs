using System;
using System.Collections.Generic;
using WSCT.Layers.Interactive.Actions;

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
        private static InteractiveMode privateMode = InteractiveMode.Transparent;

        #endregion

        #region >> Events

        /// <summary>
        /// Event raised when <see cref="Mode"/> has changed.
        /// </summary>
        public static InteractiveModeChangedEventHandler InteractiveModeChangedEvent;

        #endregion

        #region >> Properties

        /// <summary>
        /// Interactive mode.
        /// </summary>
        public static InteractiveMode Mode
        {
            get { return privateMode; }
            set
            {
                privateMode = value;
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
    }
}
using System;
using System.Collections.Generic;
using System.Text;

using WSCT.Core;

namespace WSCT.GUI.Plugins
{
    /// <summary>
    /// Container allowing to share current <see cref="ICardContext"/> and <see cref="ICardChannel"/> between WinSCard GUI and its plugins
    /// </summary>
    public class SharedData
    {
        #region >> Delegates

        /// <summary>
        /// Delegate for event sent after <see cref="SharedData.cardContext"/> object has been changed
        /// </summary>
        public delegate void CardContextChangedEventHandler();

        /// <summary>
        /// Delegate for event sent after <see cref="SharedData.cardChannel"/> object has been changed
        /// </summary>
        public delegate void CardChannelChangedEventHandler();

        #endregion

        #region >> Fields

        internal static ICardContext _cardContext = null;
        internal static ICardChannel _cardChannel = null;

        #endregion

        #region >> Properties

        /// <summary>
        /// Accessor to the global CardContext object
        /// </summary>
        public static ICardContext cardContext
        {
            get
            {
                if (!validContext)
                    throw new ContextNotInitializedException();
                return _cardContext;
            }
            set
            {
                _cardContext = value;
                if (SharedData.cardContextChangedEvent != null) SharedData.cardContextChangedEvent();
            }
        }

        /// <summary>
        /// Accessor to the global CardChannel object
        /// </summary>
        public static ICardChannel cardChannel
        {
            get
            {
                if (!validChannel)
                    throw new ChannelNotInitializedException();
                return _cardChannel;
            }
            set
            {
                _cardChannel = value;
                if (SharedData.cardChannelChangedEvent != null) SharedData.cardChannelChangedEvent();
            }
        }

        /// <summary>
        /// True if <c>cardContext</c> is not <c>null</c>
        /// </summary>
        public static Boolean validContext
        {
            get { return _cardContext != null; }
        }

        /// <summary>
        /// True if <c>cardChannel</c> is not <c>null</c>
        /// </summary>
        public static Boolean validChannel
        {
            get { return _cardChannel != null; }
        }

        #endregion

        #region >> events

        /// <summary>
        /// Event sent after <see cref="SharedData.cardContext"/> object has been changed
        /// </summary>
        public static event CardContextChangedEventHandler cardContextChangedEvent;

        /// <summary>
        /// Event sent after <see cref="SharedData.cardChannel"/> object has been changed
        /// </summary>
        public static event CardChannelChangedEventHandler cardChannelChangedEvent;

        #endregion
    }
}

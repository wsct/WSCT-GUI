using System;
using WSCT.Core;

namespace WSCT.GUI.Plugins
{
    /// <summary>
    /// Container allowing to share current <see cref="ICardContext"/> and <see cref="ICardChannel"/> between WinSCard GUI and its plugins.
    /// </summary>
    public class SharedData
    {
        #region >> Delegates

        /// <summary>
        /// Delegate for event sent after <see cref="SharedData.CardChannel"/> object has been changed.
        /// </summary>
        public delegate void CardChannelChangedEventHandler();

        /// <summary>
        /// Delegate for event sent after <see cref="SharedData.CardContext"/> object has been changed.
        /// </summary>
        public delegate void CardContextChangedEventHandler();

        #endregion

        #region >> Fields

        internal static ICardContext _cardContext = null;
        internal static ICardChannel _cardChannel = null;

        #endregion

        #region >> Properties

        /// <summary>
        /// Accessor to the global CardContext object.
        /// </summary>
        public static ICardContext CardContext
        {
            get
            {
                if (!IsValidContext)
                {
                    throw new ContextNotInitializedException();
                }
                return _cardContext;
            }
            set
            {
                _cardContext = value;
                CardContextChangedEvent?.Invoke();
            }
        }

        /// <summary>
        /// Accessor to the global CardChannel object.
        /// </summary>
        public static ICardChannel CardChannel
        {
            get
            {
                if (!IsValidChannel)
                {
                    throw new ChannelNotInitializedException();
                }
                return _cardChannel;
            }
            set
            {
                _cardChannel = value;
                CardChannelChangedEvent?.Invoke();
            }
        }

        /// <summary>
        /// True if <see cref="CardContext"/> is valid.
        /// </summary>
        public static Boolean IsValidContext => _cardContext != null;

        /// <summary>
        /// True if <see cref="CardChannel"/> is valid.
        /// </summary>
        public static Boolean IsValidChannel => _cardChannel != null;

        #endregion

        #region >> events

        /// <summary>
        /// Event sent after <see cref="CardContext"/> object has been changed.
        /// </summary>
        public static event CardContextChangedEventHandler CardContextChangedEvent;

        /// <summary>
        /// Event sent after <see cref="CardChannel"/> object has been changed.
        /// </summary>
        public static event CardChannelChangedEventHandler CardChannelChangedEvent;

        #endregion
    }
}
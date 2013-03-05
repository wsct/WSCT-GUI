using System;
using System.Collections.Generic;
using System.Text;

namespace WSCT.GUI.Plugins
{
    /// <summary>
    /// Exception to be raised when PC/SC is used but not initialized
    /// </summary>
    public class ChannelNotInitializedException : Exception
    {
        /// <summary>
        /// Default constructor
        /// </summary>
        public ChannelNotInitializedException()
            : base("Error: SharedData.cardChannel not initialized.")
        {
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="message"><inheritdoc cref="Exception(String)"/></param>
        public ChannelNotInitializedException(String message)
            : base(message)
        {
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="message"><inheritdoc cref="Exception(String,Exception)"/></param>
        /// <param name="inner"><inheritdoc cref="Exception(String,Exception)"/></param>
        public ChannelNotInitializedException(String message, Exception inner)
            : base(message, inner)
        {
        }
    }
}

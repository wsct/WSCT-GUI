using System;
using System.Collections.Generic;
using System.Text;

namespace WSCT.GUI.Plugins
{
    /// <summary>
    /// Exception to be raised when PC/SC is used but not initialized
    /// </summary>
    public class ContextNotInitializedException : Exception
    {
        /// <summary>
        /// Default constructor
        /// </summary>
        public ContextNotInitializedException()
            : base("Error: SharedData.cardContext not initialized.")
        {
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="message"><inheritdoc cref="Exception(String)"/></param>
        public ContextNotInitializedException(String message)
            : base(message)
        {
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="message"><inheritdoc cref="Exception(String,Exception)"/></param>
        /// <param name="inner"><inheritdoc cref="Exception(String,Exception)"/></param>
        public ContextNotInitializedException(String message, Exception inner)
            : base(message, inner)
        {
        }
    }
}

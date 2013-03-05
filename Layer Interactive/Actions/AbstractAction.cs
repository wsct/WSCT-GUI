using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WSCT.Layers.Interactive.Actions
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class AbstractAction
    {
        #region >> Properties

        /// <summary>
        /// Name of the action (can be used when deserializing a concrete action)
        /// </summary>
        public String name
        { get; set; }

        #endregion

        #region >> Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        /// <param name="name">Name of the action</param>
        public AbstractAction(String name)
        {
            this.name = name;
        }

        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WSCT.Layers.Interactive
{
    /// <summary>
    /// Enumeration for mode
    /// </summary>
    public enum InteractiveMode
    {
        /// <summary>
        /// Layer only acts as a transparent proxy
        /// </summary>
        TRANSPARENT,
        /// <summary>
        /// Layer acts as a transparent proxy and stores the actions 
        /// </summary>
        RECORD,
        /// <summary>
        /// Layer acts as an automatic responder; no actions is send to next layers
        /// </summary>
        REPLAY,
        /// <summary>
        /// Layer is piloted by a plugin
        /// </summary>
        EMULATOR
    }
}
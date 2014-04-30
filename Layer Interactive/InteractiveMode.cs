namespace WSCT.Layers.Interactive
{
    /// <summary>
    /// Enumeration for mode.
    /// </summary>
    public enum InteractiveMode
    {
        /// <summary>
        /// Layer only acts as a transparent proxy.
        /// </summary>
        Transparent,

        /// <summary>
        /// Layer acts as a transparent proxy and stores the actions.
        /// </summary>
        Record,

        /// <summary>
        /// Layer acts as an automatic responder; no actions is send to next layers.
        /// </summary>
        Replay,

        /// <summary>
        /// Layer is piloted by a plugin.
        /// </summary>
        Emulator
    }
}
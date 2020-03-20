namespace WSCT.GUI
{
    /// <summary>
    /// Possible connection states of channel.
    /// </summary>
    public enum ChannelStatusType
    {
        /// <summary>
        /// Channel is connected.
        /// </summary>
        Connected,

        /// <summary>
        /// Channel is disconnected
        /// </summary>
        Disconnected,

        /// <summary>
        /// An error occured.
        /// </summary>
        Error
    }
}
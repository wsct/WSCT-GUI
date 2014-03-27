namespace WSCT.GUI.Plugins.ISO7816Tools
{
    /// <summary>
    /// 
    /// </summary>
    internal enum CommonCardManagementCommands
    {
        DELETE_FILE = 0xE4,
        DEACTIVATE_FILE = 0x04,
        ACTIVATE_FILE = 0x44,
        TERMINATE_DF = 0xE6,
        TERMINATE_EF = 0xE8
    }
}
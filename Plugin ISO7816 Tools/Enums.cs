namespace WSCT.GUI.Plugins.ISO7816Tools
{
    /// <summary>
    /// 
    /// </summary>
    internal enum CommonCardManagementCommands
    {
        DeleteFile = 0xE4,
        DeactivateFile = 0x04,
        ActivateFile = 0x44,
        TerminateDF = 0xE6,
        TerminateEF = 0xE8
    }
}
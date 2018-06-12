using System;
using System.Drawing;
using WSCT.Wrapper;

namespace WSCT.GUI
{
    public interface IWinSCardGui
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="text"></param>
        void AppendLineToLog(string text);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="action"></param>
        void InvokeOnUiThread(Action action);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="color"></param>
        void SetLogForeColor(Color color);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="attribute"></param>
        void UpdateAttribute(byte[] attribute);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="error"></param>
        void UpdateLastError(ErrorCode error);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="status"></param>
        void UpdateChannelStatus(ChannelStatusType status);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="readerName"></param>
        void UpdateReaderInUse(string readerName);

        /// <summary>
        /// Called when new context established: update GUI
        /// </summary>
        void UpdateContextEstablished();

        /// <summary>
        /// Called when context is released: updateGUI
        /// </summary>
        void UpdateContextReleased();
    }
}
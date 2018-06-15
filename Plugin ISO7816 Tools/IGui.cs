using System;
using WSCT.Core.APDU;
using WSCT.ISO7816;

namespace WSCT.GUI.Plugins.ISO7816Tools
{
    public interface IGui
    {

        /// <summary>
        /// 
        /// </summary>
        /// <param name="action"></param>
        void InvokeOnUiThread(Action action);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="rApdu"></param>
        void UpdateStatusWord(ResponseAPDU rApdu);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="command"></param>
        /// <returns></returns>
        void UpdateCommandApdu(ICardCommand command);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="response"></param>
        void UpdateResponseApdu(ICardResponse response);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="command"></param>
        /// <param name="response"></param>
        void UpdateHistoric(ICardCommand command, ICardResponse response);
    }
}
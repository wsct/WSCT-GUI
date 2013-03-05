using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using WSCT;
using WSCT.ISO7816;
using WSCT.Helpers;

namespace WSCT.GUI.Plugins.ISO7816Tools
{
    /// <summary>
    /// 
    /// </summary>
    public partial class GUI : Form
    {
        CardObserver cardObserver;

        List<Core.APDU.ICardCommand> historicCAPDU;
        List<Core.APDU.ICardResponse> historicRAPDU;

        ISO7816.ProtocolT _protocolT;

        ISO7816.StatusWord.StatusWordDictionary statusWordDictionary;

        /// <summary>
        ///
        /// </summary>
        public GUI()
        {
            InitializeComponent();

            _protocolT = ISO7816.ProtocolT.T_0;

            statusWordDictionary = SerializedObject<ISO7816.StatusWord.StatusWordDictionary>.loadFromXml(@"Dictionary.StatusWord.xml");

            guiSelectP1.DataSource = Enum.GetValues(typeof(ISO7816.Commands.SelectCommand.SelectionMode));

            guiSelectFileOccurence.DataSource = Enum.GetValues(typeof(ISO7816.Commands.SelectCommand.FileOccurrence));

            guiSelectFCI.DataSource = Enum.GetValues(typeof(ISO7816.Commands.SelectCommand.FileControlInformation));

            guiReadRecordSearchMode.DataSource = Enum.GetValues(typeof(ISO7816.Commands.ReadRecordCommand.SearchMode));

            guiWriteRecordTarget.DataSource = Enum.GetValues(typeof(ISO7816.Commands.WriteRecordCommand.Target));

            guiParametersProtocolT.DataSource = Enum.GetValues(typeof(ISO7816.ProtocolT));

            // Install event to reinstal chennel observer if channel changes
            SharedData.cardChannelChangedEvent += observeChannel;

            // Create the card observer instance
            cardObserver = new CardObserver(this);

            // Install the observer on channel
            observeChannel();

            // Initialize the historic
            historicCAPDU = new List<Core.APDU.ICardCommand>();
            historicRAPDU = new List<Core.APDU.ICardResponse>();
        }

        #region >> update*

        /// <summary>
        /// 
        /// </summary>
        /// <param name="rAPDU"></param>
        internal void updateStatusWord(ISO7816.ResponseAPDU rAPDU)
        {
            if (rAPDU != null)
                guiStatusStatusWord.Text = String.Format("StatusWord: {0:X2}-{1:X2} ({2})", rAPDU.sw1, rAPDU.sw2, statusWordDictionary.getDescription(rAPDU.sw1, rAPDU.sw2));
            else
                guiStatusStatusWord.Text = "";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cAPDU"></param>
        /// <returns></returns>
        internal void updateCAPDU(Core.APDU.ICardCommand cAPDU)
        {
            guiCLA.Text = String.Format("{0:X2}", ((ISO7816.CommandAPDU)cAPDU).cla);
            guiINS.Text = String.Format("{0:X2}", ((ISO7816.CommandAPDU)cAPDU).ins);
            guiP1.Text = String.Format("{0:X2}", ((ISO7816.CommandAPDU)cAPDU).p1);
            guiP2.Text = String.Format("{0:X2}", ((ISO7816.CommandAPDU)cAPDU).p2);
            if (((ISO7816.CommandAPDU)cAPDU).isCC3 || ((ISO7816.CommandAPDU)cAPDU).isCC4)
                guiLc.Text = String.Format("{0:X2}", ((ISO7816.CommandAPDU)cAPDU).lc);
            else
                guiLc.Text = "";
            if (((ISO7816.CommandAPDU)cAPDU).isCC2 || ((ISO7816.CommandAPDU)cAPDU).isCC4)
                guiLe.Text = String.Format("{0:X2}", ((ISO7816.CommandAPDU)cAPDU).le);
            else
                guiLe.Text = "";
            guiUDC.Text = ((ISO7816.CommandAPDU)cAPDU).udc.toHexa();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="rAPDU"></param>
        internal void updateRAPDU(Core.APDU.ICardResponse rAPDU)
        {
            if (rAPDU != null)
                guiRAPDU.Text = rAPDU.ToString();
            else
                guiRAPDU.Text = "";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cAPDU"></param>
        /// <param name="rAPDU"></param>
        internal void updateHistoric(Core.APDU.ICardCommand cAPDU, Core.APDU.ICardResponse rAPDU)
        {
            historicCAPDU.Add(cAPDU);
            historicRAPDU.Add(rAPDU);
            ListViewItem listViewItem = new ListViewItem();
            listViewItem.Text = historicCAPDU.Count.ToString();
            listViewItem.SubItems.Add(cAPDU.stringCommand);
            guiCRPHistoric.Items.Add(listViewItem);
        }

        #endregion

        #region >> *_Click

        private void guiParametersAttachObserver_Click(object sender, EventArgs e)
        {
            if (SharedData.validChannel)
            {
                Stack.ICardChannelLayer channelLayer = ((Stack.ICardChannelStack)SharedData.cardChannel).requestLayer(null, WSCT.Stack.SearchMode.top);
                if (channelLayer is Core.ICardChannelObservable)
                    cardObserver.observeChannel((Core.ICardChannelObservable)channelLayer);
            }
        }

        private void guiParametersReleaseObserver_Click(object sender, EventArgs e)
        {
            // TODO: !
            //if (SharedData.validChannel)
            //{
            //    Core.Stack.ICardChannelLayer channelLayer = ((Core.Stack.ICardChannelStack)SharedData.cardChannel).requestLayer(null, WSCT.Stack.SearchMode.top);
            //    cardObserver.stopObserveChannel((Core.ICardChannelObservable)channelLayer);
            //}
        }

        private void guiSelectExecute_Click(object sender, EventArgs e)
        {
            CommandResponsePair crp = new CommandResponsePair(
                new ISO7816.Commands.SelectCommand(
                    (ISO7816.Commands.SelectCommand.SelectionMode)guiSelectP1.SelectedItem,
                    (ISO7816.Commands.SelectCommand.FileOccurrence)guiSelectFileOccurence.SelectedItem,
                    (ISO7816.Commands.SelectCommand.FileControlInformation)guiSelectFCI.SelectedItem,
                    guiSelectUDC.Text.fromHexa()
                )
            );
            crp.transmit(SharedData.cardChannel);
        }

        private void guiGetResponseExecute_Click(object sender, EventArgs e)
        {
            CommandResponsePair crp = new CommandResponsePair(
                new ISO7816.Commands.GetResponseCommand(Convert.ToUInt32(guiGetResponseLe.Text, 16))
            );
            crp.transmit(SharedData.cardChannel);
        }

        private void guiReadRecordExecute_Click(object sender, EventArgs e)
        {
            CommandResponsePair crp = new CommandResponsePair();
            UInt32 le;
            if (guiReadRecordLe.Text.Length == 0)
                le = 0;
            else
                le = Convert.ToUInt32(guiReadRecordLe.Text, 16);

            crp.cAPDU = new ISO7816.Commands.ReadRecordCommand(
                Convert.ToByte(guiReadRecordP1.Text, 16),
                Convert.ToByte(guiReadRecordSFI.Text, 16),
                (ISO7816.Commands.ReadRecordCommand.SearchMode)guiReadRecordSearchMode.SelectedItem,
                le
            );
            crp.transmit(SharedData.cardChannel);
        }

        private void guiAppendRecordExecute_Click(object sender, EventArgs e)
        {
            CommandResponsePair crp = new CommandResponsePair(
                new ISO7816.Commands.AppendRecordCommand(
                    Byte.Parse(guiAppendRecordSFI.Text, System.Globalization.NumberStyles.HexNumber),
                    guiAppendRecordUDC.Text.fromHexa()
                )
            );
            crp.transmit(SharedData.cardChannel);
        }

        private void guiWriteRecordExecute_Click(object sender, EventArgs e)
        {
            Byte record;

            if ((ISO7816.Commands.WriteRecordCommand.Target)guiWriteRecordTarget.SelectedItem == ISO7816.Commands.WriteRecordCommand.Target.RECORD_NUMBER_IN_P1)
                record = Convert.ToByte(guiWriteRecordP1.Text, 16);
            else
                record = 0;

            CommandResponsePair crp = new CommandResponsePair(
                new ISO7816.Commands.WriteRecordCommand(record,
                    Convert.ToByte(guiWriteRecordSFI.Text, 16),
                    (ISO7816.Commands.WriteRecordCommand.Target)guiWriteRecordTarget.SelectedItem,
                    guiWriteRecordUDC.Text.fromHexa()
                )
            );
            crp.transmit(SharedData.cardChannel);
        }

        private void guiReadBinaryExecute_Click(object sender, EventArgs e)
        {
            CommandResponsePair crp = new CommandResponsePair();
            UInt32 le;
            if (guiReadBinaryLe.Text.Length == 0)
                le = 0;
            else
                le = Convert.ToUInt32(guiReadBinaryLe.Text, 16);

            crp.cAPDU = new ISO7816.Commands.ReadBinaryCommand(le);
            crp.transmit(SharedData.cardChannel);
        }

        private void guiSendCAPDU_Click(object sender, EventArgs e)
        {
            ISO7816.CardChannelISO7816 card = new ISO7816.CardChannelISO7816(SharedData.cardChannel);

            String stringAPDU = guiCLA.Text + guiINS.Text + guiP1.Text + guiP2.Text + guiLc.Text + guiUDC.Text + guiLe.Text;
            Core.APDU.ICardCommand cAPDU = new ISO7816.CommandAPDU(stringAPDU);
            Core.APDU.ICardResponse rAPDU = new ISO7816.ResponseAPDU();

            card.transmit(cAPDU, rAPDU);
        }

        #endregion

        #region >> *_SelectedIndexChanged

        private void guiWriteRecordTarget_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((ISO7816.Commands.WriteRecordCommand.Target)guiWriteRecordTarget.SelectedItem == ISO7816.Commands.WriteRecordCommand.Target.RECORD_NUMBER_IN_P1)
                guiWriteRecordP1.Enabled = true;
            else
                guiWriteRecordP1.Enabled = false;
        }

        private void guiCommandTabProtocolT_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox box = (ComboBox)sender;
            _protocolT = (ISO7816.ProtocolT)box.SelectedItem;
        }

        #endregion

        #region >> *_FormClosing

        private void GUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            SharedData.cardChannelChangedEvent -= observeChannel;

            // TODO: !
            //            if (SharedData.validChannel)
            //                ((Core.Observer.ICardChannelObservable)SharedData.cardChannel).removeObserver(cardObserver);
        }

        #endregion

        private void observeChannel()
        {
            // Attach to the top layer
            if (SharedData.validChannel)
            {
                //if (SharedData.cardChannel is Core.ICardChannelObservable)
                //    cardObserver.observeChannel((Core.ICardChannelObservable)SharedData.cardChannel);
                Stack.ICardChannelLayer channelLayer = ((Stack.ICardChannelStack)SharedData.cardChannel).requestLayer(null, WSCT.Stack.SearchMode.top);
                if (channelLayer is Core.ICardChannelObservable)
                    cardObserver.observeChannel((Core.ICardChannelObservable)channelLayer);
            }
        }

        private void guiCRPHistoric_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView listView = (ListView)sender;
            if (listView.SelectedItems.Count > 0)
            {
                Int32 index = Int32.Parse(guiCLA.Text = listView.SelectedItems[0].Text);
                updateCAPDU(historicCAPDU[index - 1]);
                updateRAPDU(historicRAPDU[index - 1]);
            }
        }
    }
}
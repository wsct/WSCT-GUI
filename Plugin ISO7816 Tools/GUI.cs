using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;
using WSCT.Core;
using WSCT.Core.APDU;
using WSCT.Helpers;
using WSCT.ISO7816;
using WSCT.ISO7816.Commands;
using WSCT.ISO7816.StatusWord;
using WSCT.Stack;

namespace WSCT.GUI.Plugins.ISO7816Tools
{
    /// <summary>
    /// 
    /// </summary>
    public partial class GUI : Form
    {
        private readonly CardObserver cardObserver;

        private readonly List<ICardCommand> historicCAPDU;
        private readonly List<ICardResponse> historicRAPDU;

        private readonly StatusWordDictionary statusWordDictionary;

        /// <summary>
        ///
        /// </summary>
        public GUI()
        {
            InitializeComponent();

            statusWordDictionary = SerializedObject<StatusWordDictionary>.LoadFromXml(@"Dictionary.StatusWord.xml");

            guiSelectP1.DataSource = Enum.GetValues(typeof(SelectCommand.SelectionMode));

            guiSelectFileOccurence.DataSource = Enum.GetValues(typeof(SelectCommand.FileOccurrence));

            guiSelectFCI.DataSource = Enum.GetValues(typeof(SelectCommand.FileControlInformation));

            guiReadRecordSearchMode.DataSource = Enum.GetValues(typeof(ReadRecordCommand.SearchMode));

            guiWriteRecordTarget.DataSource = Enum.GetValues(typeof(WriteRecordCommand.TargetType));

            guiParametersProtocolT.DataSource = Enum.GetValues(typeof(ProtocolT));

            // Install event to reinstal chennel observer if channel changes
            SharedData.cardChannelChangedEvent += observeChannel;

            // Create the card observer instance
            cardObserver = new CardObserver(this);

            // Install the observer on channel
            observeChannel();

            // Initialize the historic
            historicCAPDU = new List<ICardCommand>();
            historicRAPDU = new List<ICardResponse>();
        }

        #region >> update*

        /// <summary>
        /// 
        /// </summary>
        /// <param name="rAPDU"></param>
        internal void updateStatusWord(ResponseAPDU rAPDU)
        {
            if (rAPDU != null)
            {
                guiStatusStatusWord.Text = String.Format("StatusWord: {0:X2}-{1:X2} ({2})", rAPDU.Sw1, rAPDU.Sw2, statusWordDictionary.GetDescription(rAPDU.Sw1, rAPDU.Sw2));
            }
            else
            {
                guiStatusStatusWord.Text = "";
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cAPDU"></param>
        /// <returns></returns>
        internal void updateCAPDU(ICardCommand cAPDU)
        {
            guiCLA.Text = String.Format("{0:X2}", ((CommandAPDU)cAPDU).Cla);
            guiINS.Text = String.Format("{0:X2}", ((CommandAPDU)cAPDU).Ins);
            guiP1.Text = String.Format("{0:X2}", ((CommandAPDU)cAPDU).P1);
            guiP2.Text = String.Format("{0:X2}", ((CommandAPDU)cAPDU).P2);
            if (((CommandAPDU)cAPDU).IsCc3 || ((CommandAPDU)cAPDU).IsCc4)
            {
                guiLc.Text = String.Format("{0:X2}", ((CommandAPDU)cAPDU).Lc);
            }
            else
            {
                guiLc.Text = "";
            }
            if (((CommandAPDU)cAPDU).IsCc2 || ((CommandAPDU)cAPDU).IsCc4)
            {
                guiLe.Text = String.Format("{0:X2}", ((CommandAPDU)cAPDU).Le);
            }
            else
            {
                guiLe.Text = "";
            }
            guiUDC.Text = ((CommandAPDU)cAPDU).Udc.ToHexa();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="rAPDU"></param>
        internal void updateRAPDU(ICardResponse rAPDU)
        {
            if (rAPDU != null)
            {
                guiRAPDU.Text = rAPDU.ToString();
            }
            else
            {
                guiRAPDU.Text = "";
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cAPDU"></param>
        /// <param name="rAPDU"></param>
        internal void updateHistoric(ICardCommand cAPDU, ICardResponse rAPDU)
        {
            historicCAPDU.Add(cAPDU);
            historicRAPDU.Add(rAPDU);
            var listViewItem = new ListViewItem { Text = historicCAPDU.Count.ToString(CultureInfo.InvariantCulture) };
            listViewItem.SubItems.Add(cAPDU.StringCommand);
            guiCRPHistoric.Items.Add(listViewItem);
        }

        #endregion

        #region >> *_Click

        private void guiParametersAttachObserver_Click(object sender, EventArgs e)
        {
            if (SharedData.validChannel)
            {
                var channelLayer = ((ICardChannelStack)SharedData.cardChannel).RequestLayer(null, SearchMode.Top);
                if (channelLayer is ICardChannelObservable)
                {
                    cardObserver.observeChannel((ICardChannelObservable)channelLayer);
                }
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
            var crp = new CommandResponsePair(
                new SelectCommand(
                    (SelectCommand.SelectionMode)guiSelectP1.SelectedItem,
                    (SelectCommand.FileOccurrence)guiSelectFileOccurence.SelectedItem,
                    (SelectCommand.FileControlInformation)guiSelectFCI.SelectedItem,
                    guiSelectUDC.Text.FromHexa()
                    )
                );
            crp.Transmit(SharedData.cardChannel);
        }

        private void guiGetResponseExecute_Click(object sender, EventArgs e)
        {
            var crp = new CommandResponsePair(
                new GetResponseCommand(Convert.ToUInt32(guiGetResponseLe.Text, 16))
                );
            crp.Transmit(SharedData.cardChannel);
        }

        private void guiReadRecordExecute_Click(object sender, EventArgs e)
        {
            var crp = new CommandResponsePair();
            UInt32 le;
            if (guiReadRecordLe.Text.Length == 0)
            {
                le = 0;
            }
            else
            {
                le = Convert.ToUInt32(guiReadRecordLe.Text, 16);
            }

            crp.CApdu = new ReadRecordCommand(
                Convert.ToByte(guiReadRecordP1.Text, 16),
                Convert.ToByte(guiReadRecordSFI.Text, 16),
                (ReadRecordCommand.SearchMode)guiReadRecordSearchMode.SelectedItem,
                le
                );
            crp.Transmit(SharedData.cardChannel);
        }

        private void guiAppendRecordExecute_Click(object sender, EventArgs e)
        {
            var crp = new CommandResponsePair(
                new AppendRecordCommand(
                    byte.Parse(guiAppendRecordSFI.Text, NumberStyles.HexNumber),
                    guiAppendRecordUDC.Text.FromHexa()
                    )
                );
            crp.Transmit(SharedData.cardChannel);
        }

        private void guiWriteRecordExecute_Click(object sender, EventArgs e)
        {
            byte record;

            if ((WriteRecordCommand.TargetType)guiWriteRecordTarget.SelectedItem == WriteRecordCommand.TargetType.RecordNumberInP1)
            {
                record = Convert.ToByte(guiWriteRecordP1.Text, 16);
            }
            else
            {
                record = 0;
            }

            var crp = new CommandResponsePair(
                new WriteRecordCommand(record,
                    Convert.ToByte(guiWriteRecordSFI.Text, 16),
                    (WriteRecordCommand.TargetType)guiWriteRecordTarget.SelectedItem,
                    guiWriteRecordUDC.Text.FromHexa()
                    )
                );
            crp.Transmit(SharedData.cardChannel);
        }

        private void guiReadBinaryExecute_Click(object sender, EventArgs e)
        {
            var crp = new CommandResponsePair();
            UInt32 le;
            if (guiReadBinaryLe.Text.Length == 0)
            {
                le = 0;
            }
            else
            {
                le = Convert.ToUInt32(guiReadBinaryLe.Text, 16);
            }

            crp.CApdu = new ReadBinaryCommand(le);
            crp.Transmit(SharedData.cardChannel);
        }

        private void guiSendCAPDU_Click(object sender, EventArgs e)
        {
            var card = new CardChannelIso7816(SharedData.cardChannel);

            var stringAPDU = guiCLA.Text + guiINS.Text + guiP1.Text + guiP2.Text + guiLc.Text + guiUDC.Text + guiLe.Text;
            ICardCommand cAPDU = new CommandAPDU(stringAPDU);
            ICardResponse rAPDU = new ResponseAPDU();

            card.Transmit(cAPDU, rAPDU);
        }

        #endregion

        #region >> *_SelectedIndexChanged

        private void guiWriteRecordTarget_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((WriteRecordCommand.TargetType)guiWriteRecordTarget.SelectedItem == WriteRecordCommand.TargetType.RecordNumberInP1)
            {
                guiWriteRecordP1.Enabled = true;
            }
            else
            {
                guiWriteRecordP1.Enabled = false;
            }
        }

        private void guiCommandTabProtocolT_SelectedIndexChanged(object sender, EventArgs e)
        {
            // var box = (ComboBox)sender;
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
                var channelLayer = ((ICardChannelStack)SharedData.cardChannel).RequestLayer(null, SearchMode.Top);
                if (channelLayer is ICardChannelObservable)
                {
                    cardObserver.observeChannel((ICardChannelObservable)channelLayer);
                }
            }
        }

        private void guiCRPHistoric_SelectedIndexChanged(object sender, EventArgs e)
        {
            var listView = (ListView)sender;
            if (listView.SelectedItems.Count > 0)
            {
                var index = Int32.Parse(guiCLA.Text = listView.SelectedItems[0].Text);
                updateCAPDU(historicCAPDU[index - 1]);
                updateRAPDU(historicRAPDU[index - 1]);
            }
        }
    }
}
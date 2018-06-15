using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;
using WSCT.Core;
using WSCT.Core.APDU;
using WSCT.GUI.Plugins.ISO7816Tools.Resources;
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
    public partial class Gui : Form, IGui
    {
        private readonly CardObserver _cardObserver;

        private readonly List<ICardCommand> _commandApduHistoric;
        private readonly List<ICardResponse> _responseApduHistoric;

        private readonly StatusWordDictionary _statusWordDictionary;

        #region >> Constructors

        /// <summary>
        ///
        /// </summary>
        public Gui()
        {
            InitializeComponent();

            Icon = Common.Resources.Icons.WSCT;

            _statusWordDictionary = SerializedObject<StatusWordDictionary>.LoadFromXml(@"Dictionary.StatusWord.xml");

            guiSelectP1.DataSource = Enum.GetValues(typeof(SelectCommand.SelectionMode));

            guiSelectFileOccurence.DataSource = Enum.GetValues(typeof(SelectCommand.FileOccurrence));

            guiSelectFCI.DataSource = Enum.GetValues(typeof(SelectCommand.FileControlInformation));

            guiReadRecordSearchMode.DataSource = Enum.GetValues(typeof(ReadRecordCommand.SearchMode));

            guiWriteRecordTarget.DataSource = Enum.GetValues(typeof(WriteRecordCommand.TargetType));

            // Install event to reinstal chennel observer if channel changes
            SharedData.CardChannelChangedEvent += ObserveChannel;

            // Create the card observer instance
            _cardObserver = new CardObserver(this);

            // Install the observer on channel
            ObserveChannel();

            // Initialize the historic
            _commandApduHistoric = new List<ICardCommand>();
            _responseApduHistoric = new List<ICardResponse>();
        }


        #endregion

        #region >> IGui

        /// <inheritdoc />
        public void InvokeOnUiThread(Action action)
        {
            if (InvokeRequired)
            {
                Invoke(action);
            }
            else
            {
                action();
            }
        }

        /// <inheritdoc />
        public void UpdateStatusWord(ResponseAPDU rApdu)
        {
            if (rApdu != null)
            {
                if (rApdu.StatusWord == 0x9000)
                {
                    guiStatusStrip.BackColor = Common.Resources.Colors.StatusSuccess;
                }
                else if ((rApdu.Sw1 & 0x90) == 0x90)
                {
                    guiStatusStrip.BackColor = Common.Resources.Colors.StatusUndefined;
                }
                else
                {
                    guiStatusStrip.BackColor = Common.Resources.Colors.StatusError;
                }

                guiStatusStripStatusWord.Text = String.Format(Lang.StatusWordIsXXXXWithDescription, rApdu.Sw1, rApdu.Sw2, _statusWordDictionary.GetDescription(rApdu.Sw1, rApdu.Sw2));
            }
            else
            {
                guiStatusStripStatusWord.Text = "";
            }
        }

        /// <inheritdoc />
        public void UpdateCommandApdu(ICardCommand command)
        {
            var cApdu = (CommandAPDU)command;

            guiCLA.Text = $"{cApdu.Cla:X2}";
            guiINS.Text = $"{cApdu.Ins:X2}";
            guiP1.Text = $"{cApdu.P1:X2}";
            guiP2.Text = $"{cApdu.P2:X2}";
            if (cApdu.IsCc3 || cApdu.IsCc4)
            {
                guiLc.Text = $"{cApdu.Lc:X2}";
            }
            else
            {
                guiLc.Text = "";
            }
            if (cApdu.IsCc2 || cApdu.IsCc4)
            {
                guiLe.Text = $"{cApdu.Le:X2}";
            }
            else
            {
                guiLe.Text = "";
            }
            guiUDC.Text = cApdu.Udc.ToHexa();
        }

        /// <inheritdoc />
        public void UpdateResponseApdu(ICardResponse response)
        {
            if (response != null)
            {
                guiRAPDU.Text = response.ToString();
            }
            else
            {
                guiRAPDU.Text = "";
            }
        }

        /// <inheritdoc />
        public void UpdateHistoric(ICardCommand command, ICardResponse response)
        {
            _commandApduHistoric.Add(command);
            _responseApduHistoric.Add(response);
            var listViewItem = new ListViewItem { Text = _commandApduHistoric.Count.ToString(CultureInfo.InvariantCulture) };
            listViewItem.SubItems.Add(command.StringCommand);
            guiCRPHistoric.Items.Add(listViewItem);
        }

        #endregion

        #region >> *_Click

        private void guiParametersAttachObserver_Click(object sender, EventArgs e)
        {
            if (SharedData.IsValidChannel)
            {
                var channelLayer = ((ICardChannelStack)SharedData.CardChannel).RequestLayer(null, SearchMode.Top);
                if (channelLayer is ICardChannelObservable channelObservable)
                {
                    _cardObserver.ObserveChannel(channelObservable);
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
            crp.Transmit(SharedData.CardChannel);
        }

        private void guiGetResponseExecute_Click(object sender, EventArgs e)
        {
            var crp = new CommandResponsePair(
                new GetResponseCommand(Convert.ToUInt32(guiGetResponseLe.Text, 16))
                );
            crp.Transmit(SharedData.CardChannel);
        }

        private void guiReadRecordExecute_Click(object sender, EventArgs e)
        {
            var crp = new CommandResponsePair();
            uint le;
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
            crp.Transmit(SharedData.CardChannel);
        }

        private void guiAppendRecordExecute_Click(object sender, EventArgs e)
        {
            var crp = new CommandResponsePair(
                new AppendRecordCommand(
                    byte.Parse(guiAppendRecordSFI.Text, NumberStyles.HexNumber),
                    guiAppendRecordUDC.Text.FromHexa()
                    )
                );
            crp.Transmit(SharedData.CardChannel);
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
            crp.Transmit(SharedData.CardChannel);
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
            crp.Transmit(SharedData.CardChannel);
        }

        private void guiSendCAPDU_Click(object sender, EventArgs e)
        {
            var card = new CardChannelIso7816(SharedData.CardChannel);

            var stringApdu = guiCLA.Text + guiINS.Text + guiP1.Text + guiP2.Text + guiLc.Text + guiUDC.Text + guiLe.Text;
            var cApdu = new CommandAPDU(stringApdu);
            var rApdu = new ResponseAPDU();

            card.Transmit(cApdu, rApdu);
        }

        #endregion

        #region >> *_SelectedIndexChanged

        private void guiWriteRecordTarget_SelectedIndexChanged(object sender, EventArgs e)
        {
            guiWriteRecordP1.Enabled = (WriteRecordCommand.TargetType)guiWriteRecordTarget.SelectedItem == WriteRecordCommand.TargetType.RecordNumberInP1;
        }

        #endregion

        #region >> *_FormClosing

        private void GUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            SharedData.CardChannelChangedEvent -= ObserveChannel;

            // TODO: !
            //            if (SharedData.validChannel)
            //                ((Core.Observer.ICardChannelObservable)SharedData.cardChannel).removeObserver(cardObserver);
        }

        #endregion

        private void ObserveChannel()
        {
            if (!SharedData.IsValidChannel)
            {
                return;
            }

            if (SharedData.CardChannel is ICardChannelObservable channel)
            {
                _cardObserver.ObserveChannel(channel);
            }
        }

        private void guiCRPHistoric_SelectedIndexChanged(object sender, EventArgs e)
        {
            var listView = (ListView)sender;
            if (listView.SelectedItems.Count > 0)
            {
                var index = int.Parse(guiCLA.Text = listView.SelectedItems[0].Text);
                UpdateCommandApdu(_commandApduHistoric[index - 1]);
                UpdateResponseApdu(_responseApduHistoric[index - 1]);
            }
        }
    }
}
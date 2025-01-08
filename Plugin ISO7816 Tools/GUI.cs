using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using WSCT.Core;
using WSCT.Core.APDU;
using WSCT.Core.Fluent.Helpers;
using WSCT.GUI.Common.Resources.Helpers;
using WSCT.GUI.Plugins.ISO7816Tools.Resources;
using WSCT.Helpers;
using WSCT.Helpers.Linq;
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

            _statusWordDictionary = SerializedObject<StatusWordDictionary>.LoadFromXml(@"ISO7816/Dictionary.StatusWord.xml");

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

            new[] { guiCLA, guiINS, guiP1, guiP2 }.DoForEach(tb =>
              {
                  tb.TextChanged += (s, e) => ValidateAndColorByteData(tb);
                  tb.SetControlBackColor(Common.Resources.Colors.StatusError);
              });
            guiLc.TextChanged += (s, e) => ValidateAndColorLc();
            guiUDC.TextChanged += (s, e) => ValidateAndColorUdc();
            guiLe.TextChanged += (s, e) => ValidateAndColorLe();
        }

        #endregion

        #region >> Properties

        private byte Cla
        {
            get => byte.TryParse(guiCLA.Text, NumberStyles.HexNumber, null, out var cla) ? cla : (byte)0;
            set => guiCLA.Text = $"{value:X2}";
        }

        private byte Ins
        {
            get => byte.TryParse(guiINS.Text, NumberStyles.HexNumber, null, out var ins) ? ins : (byte)0;
            set => guiINS.Text = $"{value:X2}";
        }

        private byte P1
        {
            get => byte.TryParse(guiP1.Text, NumberStyles.HexNumber, null, out var p1) ? p1 : (byte)0;
            set => guiP1.Text = $"{value:X2}";
        }

        private byte P2
        {
            get => byte.TryParse(guiP2.Text, NumberStyles.HexNumber, null, out var p2) ? p2 : (byte)0;
            set => guiP2.Text = $"{value:X2}";
        }

        private uint Lc
        {
            get => TryParseLc(guiLc.Text, out var lc) ? lc : 0;
            set => guiLc.Text = value < 256 ? $"{value:X2}" : $"00{value:X4}";
        }

        private uint Le
        {
            get => TryParseLe(guiLe.Text, out var le) ? le : 0;
            set => guiLe.Text = value < 256 ? $"{value:X2}" : $"00{value:X4}";
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

            Cla = cApdu.Cla;
            Ins = cApdu.Ins;
            P1 = cApdu.P1;
            P2 = cApdu.P2;

            if (cApdu.IsCc3 || cApdu.IsCc4)
            {
                guiLc.Text = EncodeLengthOn1Byte(cApdu.Lc).ToHexa();
            }
            else if (cApdu.IsCc3E || cApdu.IsCc4E)
            {
                guiLc.Text = EncodeLengthOn3Bytes(cApdu.Lc).ToHexa();
            }
            else
            {
                guiLc.Text = "";
            }

            if (cApdu.IsCc2 || cApdu.IsCc4)
            {
                guiLe.Text = EncodeLengthOn1Byte(cApdu.Le).ToHexa();
            }
            else if (cApdu.IsCc2E)
            {
                guiLe.Text = EncodeLengthOn3Bytes(cApdu.Le).ToHexa();
            }
            else if (cApdu.IsCc4E)
            {
                guiLe.Text = EncodeLengthOn2Bytes(cApdu.Le).ToHexa();
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

            UpdateStatusWord(response as ResponseAPDU);
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

        private void GuiParametersAttachObserver_Click(object sender, EventArgs e)
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

        private void GuiParametersReleaseObserver_Click(object sender, EventArgs e)
        {
            // TODO: !
            //if (SharedData.validChannel)
            //{
            //    Core.Stack.ICardChannelLayer channelLayer = ((Core.Stack.ICardChannelStack)SharedData.cardChannel).requestLayer(null, WSCT.Stack.SearchMode.top);
            //    cardObserver.stopObserveChannel((Core.ICardChannelObservable)channelLayer);
            //}
        }

        private void GuiSelectExecute_Click(object sender, EventArgs e)
        {
            var command = new SelectCommand(
                 (SelectCommand.SelectionMode)guiSelectP1.SelectedItem,
                 (SelectCommand.FileOccurrence)guiSelectFileOccurence.SelectedItem,
                 (SelectCommand.FileControlInformation)guiSelectFCI.SelectedItem,
                 guiSelectUDC.Text.FromHexa()
                 );

            if (guiSelectLe.Text.Length > 0)
            {
                command.Le = Convert.ToByte(guiSelectLe.Text, 16);
            }

            command
                .Transmit(SharedData.CardChannel);
        }

        private void GuiGetResponseExecute_Click(object sender, EventArgs e)
        {
            new GetResponseCommand(Convert.ToUInt32(guiGetResponseLe.Text, 16))
                .Transmit(SharedData.CardChannel);
        }

        private void GuiReadRecordExecute_Click(object sender, EventArgs e)
        {
            uint le = guiReadRecordLe.Text.Length switch
            {
                0 => 0,
                _ => Convert.ToByte(guiReadRecordLe.Text, 16)
            };

            new ReadRecordCommand(
                Convert.ToByte(guiReadRecordP1.Text, 16),
                Convert.ToByte(guiReadRecordSFI.Text, 16),
                (ReadRecordCommand.SearchMode)guiReadRecordSearchMode.SelectedItem,
                le
                )
                .Transmit(SharedData.CardChannel);
        }

        private void GuiAppendRecordExecute_Click(object sender, EventArgs e)
        {
            new AppendRecordCommand(
                byte.Parse(guiAppendRecordSFI.Text, NumberStyles.HexNumber),
                guiAppendRecordUDC.Text.FromHexa()
                )
                .Transmit(SharedData.CardChannel);
        }

        private void GuiWriteRecordExecute_Click(object sender, EventArgs e)
        {
            byte record = (WriteRecordCommand.TargetType)guiWriteRecordTarget.SelectedItem switch
            {
                WriteRecordCommand.TargetType.RecordNumberInP1 => Convert.ToByte(guiWriteRecordP1.Text, 16),
                _ => 0
            };

            new WriteRecordCommand(record,
                Convert.ToByte(guiWriteRecordSFI.Text, 16),
                (WriteRecordCommand.TargetType)guiWriteRecordTarget.SelectedItem,
                guiWriteRecordUDC.Text.FromHexa()
                )
                .Transmit(SharedData.CardChannel);
        }

        private void GuiReadBinaryExecute_Click(object sender, EventArgs e)
        {
            uint le = guiReadBinaryLe.Text.Length switch
            {
                0 => 0,
                _ => Convert.ToUInt32(guiReadBinaryLe.Text, 16)
            };

            new ReadBinaryCommand(le)
                .Transmit(SharedData.CardChannel);
        }

        private void GuiSendCAPDU_Click(object sender, EventArgs e)
        {
            var stringApdu = guiCLA.Text + guiINS.Text + guiP1.Text + guiP2.Text + guiLc.Text + guiUDC.Text + guiLe.Text;
            var cApdu = new CommandAPDU(stringApdu);
            var rApdu = new ResponseAPDU();

            SharedData.CardChannel.Transmit(cApdu, rApdu);
        }

        #endregion

        #region >> *_SelectedIndexChanged

        private void GuiWriteRecordTarget_SelectedIndexChanged(object sender, EventArgs e)
        {
            guiWriteRecordP1.Enabled = (WriteRecordCommand.TargetType)guiWriteRecordTarget.SelectedItem == WriteRecordCommand.TargetType.RecordNumberInP1;
        }

        private void GuiCRPHistoric_SelectedIndexChanged(object sender, EventArgs e)
        {
            var listView = (ListView)sender;
            if (listView.SelectedItems.Count > 0)
            {
                var index = int.Parse(listView.SelectedItems[0].Text);
                UpdateCommandApdu(_commandApduHistoric[index - 1]);
                UpdateResponseApdu(_responseApduHistoric[index - 1]);
            }
        }

        #endregion

        #region >> *_CheckedChanged

        private void GuiLcAutoCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            guiLc.Enabled = !guiLcAutoCheckBox.Checked;

            if (guiLcAutoCheckBox.Checked)
            {
                ValidateAndColorUdc();
            }
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


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static byte[] EncodeLengthOn1Byte(uint nx) =>
            new byte[] { (byte)nx };

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static byte[] EncodeLengthOn2Bytes(uint nx) =>
            new byte[] { (byte)((nx & 0xFF00) >> 8), (byte)(nx & 0x00FF) };

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static byte[] EncodeLengthOn3Bytes(uint nx) =>
            new byte[] { 0x00, (byte)((nx & 0xFF00) >> 8), (byte)(nx & 0x00FF) };

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static int GetNcFromLc(ReadOnlySpan<byte> lc)
        {
            return lc.Length switch
            {
                0 => 0,
                1 => lc[0],
                3 when lc[0] == 0 => (lc[1] << 8) + lc[2],
                _ => throw new ArgumentOutOfRangeException(nameof(lc), "Lc must be 1 byte 'xx' or 3 bytes '00xxxx'")
            };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static int GetNeFromLe(ReadOnlySpan<byte> le)
        {
            return le.Length switch
            {
                0 => 0,
                1 => le[0],
                2 => (le[0] << 8) + le[1],
                3 when le[0] == 0 => (le[1] << 8) + le[2],
                _ => throw new ArgumentOutOfRangeException(nameof(le), "Le must be 1 byte 'xx', 2 bytes 'xxxx' or 3 bytes '00xxxx'")
            };
        }

        private static bool TryParseLe(string hexa, out uint value)
        {
            try
            {
                value = (uint)GetNeFromLe(hexa.FromHexa());
                return true;
            }
            catch
            {
                value = 0;
                return false;
            }
        }

        private static bool TryParseLc(string hexa, out uint value)
        {
            try
            {
                value = (uint)GetNcFromLc(hexa.FromHexa());
                return true;
            }
            catch
            {
                value = 0;
                return false;
            }
        }

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

        private static void ValidateAndColorByteData(TextBox textBox)
        {
            if (!String.IsNullOrEmpty(textBox.Text) && byte.TryParse(textBox.Text, NumberStyles.HexNumber, null, out _))
            {
                textBox.ResetControlBackColor();
                return;
            }

            textBox.SetControlBackColor(Common.Resources.Colors.StatusError);
        }

        private void ValidateAndColorLe()
        {
            if (String.IsNullOrEmpty(guiLe.Text) || TryParseLe(guiLe.Text, out _))
            {
                guiLe.ResetControlBackColor();
                return;
            }

            guiLe.SetControlBackColor(Common.Resources.Colors.StatusError);
        }

        private void ValidateAndColorLc()
        {
            uint udcLength;
            try
            {
                udcLength = (uint)guiUDC.Text.FromHexa().Length;
            }
            catch (Exception)
            {
                guiUDC.SetControlBackColor(Common.Resources.Colors.StatusError);
                return;
            }

            if (Lc == udcLength)
            {
                guiLc.ResetControlBackColor();
            }
            else
            {
                guiLc.SetControlBackColor(Common.Resources.Colors.StatusError);
            }
        }

        private void ValidateAndColorUdc()
        {
            uint udcLength;
            try
            {
                udcLength = (uint)guiUDC.Text.FromHexa().Length;
                guiUDC.ResetControlBackColor();
            }
            catch (Exception)
            {
                guiUDC.SetControlBackColor(Common.Resources.Colors.StatusError);
                return;
            }

            if (guiLcAutoCheckBox.Checked)
            {
                try
                {
                    Lc = udcLength;
                    guiLc.ResetBackColor();
                }
                catch (Exception)
                {
                    guiLc.SetControlBackColor(Common.Resources.Colors.StatusError);
                }
            }
            else
            {
                ValidateAndColorLc();
            }
        }
    }
}
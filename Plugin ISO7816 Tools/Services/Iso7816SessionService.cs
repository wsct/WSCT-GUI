using WSCT.Core;
using WSCT.Core.APDU;
using WSCT.Helpers;
using WSCT.ISO7816;
using WSCT.ISO7816.StatusWord;
using WSCT.Wrapper;
using WSCT.Stack;

namespace WSCT.GUI.Plugins.ISO7816Tools.Services
{
    public class ApduExchangeItem
    {
        public int Index { get; set; }
        public ICardCommand Command { get; set; } = null!;
        public ICardResponse? Response { get; set; }
        public string CommandString => Command?.StringCommand ?? string.Empty;
        public string ResponseString => Response?.ToString() ?? string.Empty;
    }

    public class Iso7816SessionService
    {
        private readonly StatusWordDictionary _statusWordDictionary;
        private readonly CardObserver _cardObserver;

        public List<ApduExchangeItem> History { get; } = [];
        public ICardCommand? CurrentCommand { get; private set; }
        public ICardResponse? CurrentResponse { get; private set; }
        public ResponseAPDU? CurrentResponseApdu => CurrentResponse as ResponseAPDU;

        public string StatusWordText { get; private set; } = string.Empty;
        public string StatusWordBadgeClass { get; private set; } = "bg-secondary";

        public event Action? OnStateChanged;

        public Iso7816SessionService()
        {
            string dictPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ISO7816", "Dictionary.StatusWord.xml");
            if (File.Exists(dictPath))
            {
                _statusWordDictionary = SerializedObject<StatusWordDictionary>.LoadFromXml(dictPath);
            }
            else
            {
                _statusWordDictionary = new StatusWordDictionary();
            }

            _cardObserver = new CardObserver(this);
            ObserveChannel();

            SharedData.CardChannelChangedEvent += ObserveChannel;
        }

        public void ObserveChannel()
        {
            if (SharedData.IsValidChannel && SharedData.CardChannel is ICardChannelObservable channel)
            {
                _cardObserver.ObserveChannel(channel);
            }
        }

        public void UpdateCommand(ICardCommand command)
        {
            CurrentCommand = command;
            OnStateChanged?.Invoke();
        }

        public void UpdateResponse(ICardResponse? response)
        {
            CurrentResponse = response;
            UpdateStatusWord(response as ResponseAPDU);
            OnStateChanged?.Invoke();
        }

        public void UpdateStatusWord(ResponseAPDU? rApdu)
        {
            if (rApdu != null)
            {
                if (rApdu.StatusWord == 0x9000 || rApdu.Sw1 == 0x61)
                {
                    StatusWordBadgeClass = "bg-success";
                }
                else if ((rApdu.Sw1 & 0x90) == 0x90)
                {
                    StatusWordBadgeClass = "bg-warning text-dark";
                }
                else
                {
                    StatusWordBadgeClass = "bg-danger";
                }

                string desc = _statusWordDictionary.GetDescription(rApdu.Sw1, rApdu.Sw2) ?? "Unknown status";
                StatusWordText = $"Status word is {rApdu.Sw1:X2} {rApdu.Sw2:X2}: {desc}";
            }
            else
            {
                StatusWordText = string.Empty;
                StatusWordBadgeClass = "bg-secondary";
            }
        }

        public void AddToHistory(ICardCommand command, ICardResponse? response)
        {
            var item = new ApduExchangeItem
            {
                Index = History.Count + 1,
                Command = command,
                Response = response
            };
            History.Add(item);
            OnStateChanged?.Invoke();
        }

        public void Transmit(CommandAPDU cApdu, ResponseAPDU rApdu)
        {
            if (SharedData.IsValidChannel)
            {
                SharedData.CardChannel.Transmit(cApdu, rApdu);
            }
        }

        public void Transmit(ICardCommand command)
        {
            if (SharedData.IsValidChannel)
            {
                var response = new ResponseAPDU();
                SharedData.CardChannel.Transmit(command, response);
            }
        }
    }
}

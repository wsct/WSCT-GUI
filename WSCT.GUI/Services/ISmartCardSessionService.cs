using WSCT.GUI.Plugins;
using WSCT.Stack;
using WSCT.Wrapper;

namespace WSCT.GUI.Services
{
    public interface ISmartCardSessionService
    {
        bool IsContextEstablished { get; }
        string ContextStateText { get; }
        ChannelStatusType ChannelStatus { get; }
        string ChannelStatusText { get; }
        string ReaderInUse { get; }

        IReadOnlyList<string> ReaderGroups { get; }
        string? SelectedReaderGroup { get; set; }

        IReadOnlyList<string> Readers { get; }
        string? SelectedReader { get; set; }

        ShareMode SelectedShareMode { get; set; }
        Protocol SelectedProtocol { get; set; }
        Disposition SelectedDisposition { get; set; }
        Attrib SelectedAttribute { get; set; }

        string RawAttributeHex { get; }
        string StringAttribute { get; }

        ErrorCode LastErrorCode { get; }
        string LastErrorText { get; }

        CardChannelStackDescription? ChannelLayerDescriptions { get; }
        CardContextStackDescription? ContextLayerDescriptions { get; }
        IReadOnlyList<PluginInfo> DiscoveredPlugins { get; }

        event Action? OnStateChanged;

        void Initialize();
        void TryEstablishContext();
        void ReleaseContext();

        void QuickConnect();
        void WarmReset();
        void ColdReset();
        void Unpower();

        void ChannelConnect();
        void ChannelReconnect();
        void ChannelDisconnect();

        void QueryAttribute();

        void UpdateChannelStatus(ChannelStatusType status);
        void UpdateLastError(ErrorCode error);
        void UpdateReaderInUse(string readerName);
        void UpdateAttribute(byte[] attribute);
    }
}

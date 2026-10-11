using System.Reflection;
using WSCT.GUI.Plugins;
using WSCT.GUI.Resources;
using WSCT.Helpers;
using WSCT.Helpers.Linq;
using WSCT.Linq;
using WSCT.Stack;
using WSCT.Wrapper;
using WSCT.Wrapper.Desktop.Core;

namespace WSCT.GUI.Services
{
    public class SmartCardSessionService : ISmartCardSessionService
    {
        private readonly ILogService _logService;
        private readonly PluginsManager _pluginsManager;
        private CardChannelStackDescription? _channelLayers;
        private CardContextStackDescription? _contextLayers;
        private StatusChangeMonitor? _statusMonitor;
        private LogObserver? _observer;
        private LogObserver? _stackObserver;

        public bool IsContextEstablished { get; private set; }
        public string ContextStateText { get; private set; } = "Released";
        public ChannelStatusType ChannelStatus { get; private set; } = ChannelStatusType.Disconnected;
        public string ChannelStatusText { get; private set; } = "Disconnected";
        public string ReaderInUse { get; private set; } = string.Empty;

        public List<string> ReaderGroupsList { get; } = [];
        public IReadOnlyList<string> ReaderGroups => ReaderGroupsList;
        public string? SelectedReaderGroup { get; set; }

        public List<string> ReadersList { get; } = [];
        public IReadOnlyList<string> Readers => ReadersList;
        public string? SelectedReader { get; set; }

        public ShareMode SelectedShareMode { get; set; } = ShareMode.Shared;
        public Protocol SelectedProtocol { get; set; } = Protocol.Any;
        public Disposition SelectedDisposition { get; set; } = Disposition.UnpowerCard;
        public Attrib SelectedAttribute { get; set; } = Attrib.AtrString;

        public string RawAttributeHex { get; private set; } = string.Empty;
        public string StringAttribute { get; private set; } = string.Empty;

        public ErrorCode LastErrorCode { get; private set; } = ErrorCode.Success;
        public string LastErrorText => $"LastError is {LastErrorCode}";

        public CardChannelStackDescription? ChannelLayerDescriptions => _channelLayers;
        public CardContextStackDescription? ContextLayerDescriptions => _contextLayers;
        public IReadOnlyList<PluginInfo> DiscoveredPlugins => _pluginsManager.Plugins;

        public event Action? OnStateChanged;

        public SmartCardSessionService(ILogService logService, PluginsManager pluginsManager)
        {
            _logService = logService;
            _pluginsManager = pluginsManager;
        }

        public void Initialize()
        {
            try
            {
                AppDomain.CurrentDomain.AssemblyResolve += ResolveLayerAssembly;

                _observer = new LogObserver(_logService, this, Colors.LogDefaultColor);
                _stackObserver = new LogObserver(_logService, this, Colors.LogHighlightColor);

                string channelXmlPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Stack.Channel.xml");
                if (!File.Exists(channelXmlPath) && File.Exists("Stack.Channel.xml"))
                {
                    channelXmlPath = Path.GetFullPath("Stack.Channel.xml");
                }

                if (File.Exists(channelXmlPath))
                {
                    _channelLayers = SerializedObject<CardChannelStackDescription>.LoadFromXml(channelXmlPath);
                }
                else
                {
                    _channelLayers = new CardChannelStackDescription();
                }

                string contextXmlPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Stack.Context.xml");
                if (!File.Exists(contextXmlPath) && File.Exists("Stack.Context.xml"))
                {
                    contextXmlPath = Path.GetFullPath("Stack.Context.xml");
                }

                if (File.Exists(contextXmlPath))
                {
                    _contextLayers = SerializedObject<CardContextStackDescription>.LoadFromXml(contextXmlPath);
                }
                else
                {
                    _contextLayers = new CardContextStackDescription();
                }

                NormalizeLayerDescriptions(_channelLayers?.LayerDescriptions);
                NormalizeLayerDescriptions(_contextLayers?.LayerDescriptions);

                _statusMonitor = new StatusChangeMonitor();
                _statusMonitor.OnCardInsertionEvent += (s, e) =>
                {
                    _logService.Append(LogLevel.Info, "Monitor", $"Card insertion on reader: {e.ReaderState.ReaderName}", Colors.LogHighlightColor);
                    NotifyStateChanged();
                };
                _statusMonitor.OnCardRemovalEvent += (s, e) =>
                {
                    _logService.Append(LogLevel.Info, "Monitor", $"Card removal on reader: {e.ReaderState.ReaderName}", Colors.LogHighlightColor);
                    NotifyStateChanged();
                };

                _pluginsManager.DiscoverInDirectory(AppDomain.CurrentDomain.BaseDirectory);

                TryEstablishContext();
            }
            catch (Exception ex)
            {
                _logService.Append(LogLevel.Error, "Init", $"Initialization error: {ex.Message}", Colors.LogErrorColor);
            }
        }

        private static void NormalizeLayerDescriptions(IEnumerable<dynamic>? layers)
        {
            if (layers == null)
            {
                return;
            }
            string baseDir = AppDomain.CurrentDomain.BaseDirectory;
            foreach (var layer in layers)
            {
                string dllName = layer.DllName ?? string.Empty;
                if (!string.IsNullOrEmpty(dllName))
                {
                    string candidate = Path.IsPathRooted(dllName) ? dllName : Path.Combine(baseDir, dllName);
                    if (File.Exists(candidate))
                    {
                        layer.DllName = candidate;
                        layer.PathToDll = Path.GetDirectoryName(candidate) ?? baseDir;
                    }
                }
            }
        }

        private static Assembly? ResolveLayerAssembly(object? sender, ResolveEventArgs args)
        {
            try
            {
                var requestedName = new AssemblyName(args.Name).Name;
                if (string.IsNullOrEmpty(requestedName))
                {
                    return null;
                }
                string candidate = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, $"{requestedName}.dll");
                if (File.Exists(candidate))
                {
                    return Assembly.LoadFrom(candidate);
                }
            }
            catch
            {
                // Ignore resolution errors
            }
            return null;
        }

        public void TryEstablishContext()
        {
            try
            {
                if (_statusMonitor != null)
                {
                    _statusMonitor.Stop();
                }

                CreateCardContextStack();

                var lastError = SharedData.CardContext.Establish();
                UpdateLastError(lastError);

                if (lastError == ErrorCode.Success)
                {
                    IsContextEstablished = true;
                    ContextStateText = "Established";

                    ReaderGroupsList.Clear();
                    ReadersList.Clear();

                    if (SharedData.CardContext.ListReaderGroups() == ErrorCode.Success)
                    {
                        ReaderGroupsList.AddRange(SharedData.CardContext.Groups);
                        SelectedReaderGroup = ReaderGroupsList.FirstOrDefault();

                        if (!string.IsNullOrEmpty(SelectedReaderGroup) && SharedData.CardContext.ListReaders(SelectedReaderGroup) == ErrorCode.Success)
                        {
                            ReadersList.AddRange(SharedData.CardContext.Readers);
                            SelectedReader = ReadersList.FirstOrDefault();

                            if (_statusMonitor != null)
                            {
                                _statusMonitor.Context = SharedData.CardContext;
                                _statusMonitor.Start();
                            }
                        }
                    }
                }
                else
                {
                    IsContextEstablished = false;
                    ContextStateText = "An error occurred";
                }
            }
            catch (Exception ex)
            {
                IsContextEstablished = false;
                ContextStateText = "Error";
                _logService.Append(LogLevel.Error, "Context", ex.Message, Colors.LogErrorColor);
            }

            NotifyStateChanged();
        }

        public void ReleaseContext()
        {
            try
            {
                _statusMonitor?.Stop();

                if (SharedData.IsValidContext)
                {
                    var lastError = SharedData.CardContext.Release();
                    UpdateLastError(lastError);
                }

                SharedData.CardContext = null!;
                IsContextEstablished = false;
                ContextStateText = "Released";
                ReaderInUse = string.Empty;
                ReaderGroupsList.Clear();
                ReadersList.Clear();
                SelectedReaderGroup = null;
                SelectedReader = null;
                UpdateChannelStatus(ChannelStatusType.Disconnected);
            }
            catch (Exception ex)
            {
                _logService.Append(LogLevel.Error, "Release", ex.Message, Colors.LogErrorColor);
            }

            NotifyStateChanged();
        }

        private void CreateCardChannelStack()
        {
            if (_channelLayers == null || string.IsNullOrEmpty(SelectedReader))
            {
                return;
            }

            var layers = _channelLayers.LayerDescriptions
                .Select(ld => _channelLayers.CreateInstance(ld.Name))
                .ToObservableLayers()
                .ForEach(l => _observer?.ObserveChannel(l));

            var stack = new CardChannelStack(layers).ToObservableStack();
            stack.Attach(SharedData.CardContext, SelectedReader);

            _stackObserver?.ObserveChannel(stack);
            SharedData.CardChannel = stack;
        }

        private void CreateCardContextStack()
        {
            if (_contextLayers == null)
            {
                return;
            }

            var layers = _contextLayers.LayerDescriptions
                .Select(ld => _contextLayers.CreateInstance(ld.Name))
                .ToObservableLayers()
                .ForEach(l => _observer?.ObserveContext(l));

            var stack = new CardContextStack(layers).ToObservableStack();
            _stackObserver?.ObserveContext(stack);
            SharedData.CardContext = stack;
        }

        public void QuickConnect()
        {
            if (string.IsNullOrEmpty(SelectedReader))
            {
                return;
            }

            CreateCardChannelStack();
            var errorCode = SharedData.CardChannel.Connect(ShareMode.Shared, Protocol.Any);
            UpdateLastError(errorCode);
            if (errorCode == ErrorCode.Success)
            {
                UpdateReaderInUse(SelectedReader);
            }
        }

        public void WarmReset()
        {
            if (!SharedData.IsValidChannel)
            {
                return;
            }
            var error = SharedData.CardChannel.Reconnect(ShareMode.Shared, Protocol.Any, Disposition.ResetCard);
            UpdateLastError(error);
        }

        public void ColdReset()
        {
            if (!SharedData.IsValidChannel)
            {
                return;
            }
            var error = SharedData.CardChannel.Reconnect(ShareMode.Shared, Protocol.Any, Disposition.UnpowerCard);
            UpdateLastError(error);
        }

        public void Unpower()
        {
            if (!SharedData.IsValidChannel)
            {
                return;
            }
            var error = SharedData.CardChannel.Disconnect(Disposition.UnpowerCard);
            UpdateLastError(error);
            UpdateReaderInUse(string.Empty);
        }

        public void ChannelConnect()
        {
            if (string.IsNullOrEmpty(SelectedReader))
            {
                return;
            }

            CreateCardChannelStack();
            var errorCode = SharedData.CardChannel.Connect(SelectedShareMode, SelectedProtocol);
            UpdateLastError(errorCode);
            if (errorCode == ErrorCode.Success)
            {
                UpdateReaderInUse(SelectedReader);
            }
        }

        public void ChannelReconnect()
        {
            if (!SharedData.IsValidChannel)
            {
                return;
            }
            var error = SharedData.CardChannel.Reconnect(SelectedShareMode, SelectedProtocol, SelectedDisposition);
            UpdateLastError(error);
        }

        public void ChannelDisconnect()
        {
            if (!SharedData.IsValidChannel)
            {
                return;
            }
            var error = SharedData.CardChannel.Disconnect(SelectedDisposition);
            UpdateLastError(error);
        }

        public void QueryAttribute()
        {
            if (!SharedData.IsValidChannel)
            {
                return;
            }

            try
            {
                byte[]? buffer = null;
                var errorCode = SharedData.CardChannel.GetAttrib(SelectedAttribute, ref buffer);
                UpdateLastError(errorCode);
                if (errorCode == ErrorCode.Success && buffer != null)
                {
                    UpdateAttribute(buffer);
                }
            }
            catch (Exception ex)
            {
                _logService.Append(LogLevel.Error, "GetAttrib", ex.Message, Colors.LogErrorColor);
            }
        }

        public void UpdateChannelStatus(ChannelStatusType status)
        {
            ChannelStatus = status;
            ChannelStatusText = status switch
            {
                ChannelStatusType.Connected => "Connected",
                ChannelStatusType.Disconnected => "Disconnected",
                ChannelStatusType.Error => "Error",
                _ => status.ToString()
            };
            NotifyStateChanged();
        }

        public void UpdateLastError(ErrorCode error)
        {
            LastErrorCode = error;
            NotifyStateChanged();
        }

        public void UpdateReaderInUse(string readerName)
        {
            ReaderInUse = readerName;
            NotifyStateChanged();
        }

        public void UpdateAttribute(byte[] attribute)
        {
            RawAttributeHex = attribute.ToHexa();
            StringAttribute = attribute.ToAsciiString();
            NotifyStateChanged();
        }

        private void NotifyStateChanged()
        {
            OnStateChanged?.Invoke();
        }
    }
}

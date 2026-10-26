namespace WSCT.GUI.Services
{
    public class LogService : ILogService
    {
        private readonly List<LogEntry> _entries = [];
        private readonly object _lock = new();
        private const int MaxEntries = 1000;

        public IReadOnlyList<LogEntry> Entries
        {
            get
            {
                lock (_lock)
                {
                    return _entries.ToList();
                }
            }
        }

        public event Action<LogEntry>? OnLogAppended;

        public event Action? OnLogsCleared;

        public void Append(LogLevel level, string source, string message)
        {
            var entry = new LogEntry
            {
                Level = level,
                Source = source,
                Message = message
            };

            lock (_lock)
            {
                _entries.Add(entry);
                if (_entries.Count > MaxEntries)
                {
                    _entries.RemoveAt(0);
                }
            }

            OnLogAppended?.Invoke(entry);
        }

        public void Clear()
        {
            lock (_lock)
            {
                _entries.Clear();
            }

            OnLogsCleared?.Invoke();
        }
    }
}

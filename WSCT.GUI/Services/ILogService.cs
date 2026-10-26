namespace WSCT.GUI.Services
{
    public interface ILogService
    {
        IReadOnlyList<LogEntry> Entries { get; }

        event Action<LogEntry>? OnLogAppended;

        event Action? OnLogsCleared;

        void Append(LogLevel level, string source, string message);

        void Clear();
    }
}

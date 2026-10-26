namespace WSCT.GUI.Services
{
    public class LogEntry
    {
        public DateTime Timestamp { get; set; } = DateTime.Now;
        public LogLevel Level { get; set; }
        public string Source { get; set; } = string.Empty;
        public string Message { get; set; } = string.Empty;

        public string FormattedTimestamp => Timestamp.ToString("HH:mm:ss.fff");
    }
}

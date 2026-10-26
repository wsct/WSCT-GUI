using WSCT.GUI.Services;

namespace WSCT.GUI.Components
{
    public partial class LogViewer(ILogService LogService) : IDisposable
    {
        private static string GetTextClass(LogLevel level) => level switch
        {
            LogLevel.Error => "text-danger",
            LogLevel.Warning => "text-warning",
            _ => "text-light"
        };

        private static string GetBadgeClass(LogLevel level) => level switch
        {
            LogLevel.Error => "bg-danger",
            LogLevel.Warning => "bg-warning text-dark",
            _ => "bg-secondary"
        };

        protected override void OnInitialized()
        {
            LogService.OnLogAppended += HandleLogUpdate;
            LogService.OnLogsCleared += HandleLogCleared;
        }

        private void HandleLogUpdate(LogEntry entry)
        {
            InvokeAsync(StateHasChanged);
        }

        private void HandleLogCleared()
        {
            InvokeAsync(StateHasChanged);
        }

        public void Dispose()
        {
            LogService.OnLogAppended -= HandleLogUpdate;
            LogService.OnLogsCleared -= HandleLogCleared;
        }
    }
}
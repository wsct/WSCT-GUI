using WSCT.GUI.Services;

namespace WSCT.GUI.Components.Layout
{
    public partial class MainLayout(ISmartCardSessionService SessionService) : IDisposable
    {
        private bool _showAbout;

        protected override void OnInitialized()
        {
            SessionService.OnStateChanged += HandleStateChanged;
        }

        private void HandleStateChanged()
        {
            InvokeAsync(StateHasChanged);
        }

        public void Dispose()
        {
            SessionService.OnStateChanged -= HandleStateChanged;
        }
    }
}
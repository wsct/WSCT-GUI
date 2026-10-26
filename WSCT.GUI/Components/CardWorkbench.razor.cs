using WSCT.GUI.Services;

namespace WSCT.GUI.Components
{
    public partial class CardWorkbench(ISmartCardSessionService SessionService) : IDisposable
    {
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
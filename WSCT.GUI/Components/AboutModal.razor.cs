using Microsoft.AspNetCore.Components;
using System.Reflection;

namespace WSCT.GUI.Components
{
    public partial class AboutModal
    {
        [Parameter]
        public bool IsOpen { get; set; }

        [Parameter]
        public EventCallback<bool> IsOpenChanged { get; set; }

        private void Close()
        {
            IsOpen = false;
            IsOpenChanged.InvokeAsync(false);
        }

        private string AssemblyTitle =>
            typeof(AboutModal).Assembly.GetCustomAttribute<AssemblyTitleAttribute>()?.Title
            ?? "WSCT GUI";

        private string AssemblyProduct =>
            typeof(AboutModal).Assembly.GetCustomAttribute<AssemblyProductAttribute>()?.Product
            ?? "WSCT";

        private string AssemblyVersion =>
            typeof(AboutModal).Assembly.GetName().Version?.ToString()
            ?? "6.2.1";

        private string AssemblyCopyright =>
            typeof(AboutModal).Assembly.GetCustomAttribute<AssemblyCopyrightAttribute>()?.Copyright
            ?? "Sylvain Vernois / ENSICAEN";

        private string AssemblyCompany =>
            typeof(AboutModal).Assembly.GetCustomAttribute<AssemblyCompanyAttribute>()?.Company
            ?? "ENSICAEN / GREYC";

        private string AssemblyDescription =>
            typeof(AboutModal).Assembly.GetCustomAttribute<AssemblyDescriptionAttribute>()?.Description
            ?? "Extensible Graphic User Interface for using WinSCard API.";
    }
}
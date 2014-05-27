using System;
using System.Windows.Forms;

namespace WSCT.GUI.Launcher
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new WinSCardGui());

            // Force close all other existing Application.Run() 
            Application.Exit();
        }
    }
}

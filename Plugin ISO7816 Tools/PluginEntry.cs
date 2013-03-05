using System;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;

namespace WSCT.GUI.Plugins.ISO7816Tools
{
    /// <summary>
    /// 
    /// </summary>
    public class PluginEntry : IPlugin
    {
        #region >> IPlugin

        /// <summary>
        /// 
        /// </summary>
        public void show()
        {
            Thread pluginThread = new Thread(startPlugin);
            pluginThread.SetApartmentState(ApartmentState.STA);
            pluginThread.Start();
        }

        private void startPlugin()
        {
            // Use a named Mutex (available computer-wide) to check if the pluginDesc thread still exists
            using (var mutex = new Mutex(false, Assembly.GetExecutingAssembly().FullName))
            {
                // If the mutex is available, then get it and launch the pluginDesc GUI
                if (mutex.WaitOne(TimeSpan.FromSeconds(0), false))
                {
                    Application.Run(new GUI());
                }
                else
                {
                    MessageBox.Show("Only one instance of the pluginDesc is authorized", "Plugin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        #endregion
    }
}

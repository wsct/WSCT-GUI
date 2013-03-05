using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Reflection;

using WSCT.GUI.Plugins;

namespace WSCT.GUI.Plugins.LayerInteractive
{
    /// <summary>
    /// Plugin entry point
    /// </summary>
    public class PluginEntry : IPlugin
    {
        #region >> IPlugin

        /// <inheritdoc />
        public void show()
        {
            Thread pluginThread = new Thread(startPlugin);
            pluginThread.SetApartmentState(ApartmentState.STA);
            pluginThread.Start();
        }

        private void startPlugin()
        {
            // Use a named Mutex (available computer-wide) to check if the plugin thread still exists
            using (var mutex = new Mutex(false, Assembly.GetExecutingAssembly().FullName))
            {
                // If the mutex is available, then get it and launch the plugin GUI
                if (mutex.WaitOne(TimeSpan.FromSeconds(0), false))
                {
                    Application.Run(new GUI());
                }
                else
                {
                    MessageBox.Show("Only one instance of the plugin is authorized", "Plugin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        #endregion
    }
}

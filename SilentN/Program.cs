using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;
namespace SilentN
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
        // Process[] process = Process.GetProcessesByName('.)
            using (Mutex mutex = new Mutex(false,"1540bac7-c31b-4af1-a37c-c0a39d9dd6ab"))
            {
                if (!mutex.WaitOne(0, false))
                {
                    MessageBox.Show("Only one instance allowed", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                }
                else
                {
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    Application.Run(new SilentService());
                }
            }
            
        }
        
    }
}

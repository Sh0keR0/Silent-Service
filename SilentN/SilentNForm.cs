using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using ProcessManager;
using System.Threading;
namespace SilentN
{
    public partial class SilentNForm : Form
    {
        ProcessLog process;
        Thread recordThread;
        public SilentNForm()
        {
            InitializeComponent();
            
        }

        

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Process[] processes = Process.GetProcesses();
            cbProcessesList.Items.Clear();
            for(int i =0;i<processes.Length;i++)
            {
                cbProcessesList.Items.Add(processes[i].ProcessName);
            }
            
        }

        private void btnRecord_Click(object sender, EventArgs e)
        {
            process = new ProcessLog(cbProcessesList.SelectedItem.ToString(),new TimeSpan());
            recordThread = new Thread(process.StartRecording);
            recordThread.Start();
            updateTimer.Enabled = true;

        }

        private void updateTimer_Tick(object sender, EventArgs e)
        {
            if(process != null)
                lblTimeSpent.Text = string.Format("Days: {0}, Hours: {1}, Minutes: {2}, Seconds: {3}",process.GetDays(),process.GetHours(),process.GetMinutes(),process.GetSeconds());
        }

        private void SilentNForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            recordThread.Abort();
            
            
        }
    }
}

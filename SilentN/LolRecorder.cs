using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;
using ProcessManager;
using System.IO;
using Microsoft.Win32;

namespace SilentN
{
    public partial class LolRecorder : Form
    {
        Thread recordThread;
        ProcessLog lolProcess;
       const string filename = "League of Legends.xml";
        public LolRecorder()
        {
            InitializeComponent();
            
            if(File.Exists(filename))
            {
                lolProcess = SaveFile.LoadFileData(filename);
            }
            else
            {
                lolProcess = new ProcessLog("League of Legends", new TimeSpan());
            } 

            timerCheckProceses.Enabled = true; 
            UpdateTimePlayedText();
            
        }

        private void timerCheckProceses_Tick(object sender, EventArgs e)
        {
            if(lolProcess.IsRunning())
            {
                lblGameRunning.Text = "Game is running";
                lblGameRunning.ForeColor = System.Drawing.Color.Green;
                recordThread = new Thread(lolProcess.StartRecording);
                recordThread.Start();
                timerCheckProceses.Enabled = false;
                timerUpdateText.Enabled = true;
            }
            else
            {
                lblGameRunning.Text = "Game is not running";
                lblGameRunning.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void timerUpdateText_Tick(object sender, EventArgs e)
        {
            if(lolProcess.IsRunning())
            {
                UpdateTimePlayedText();
            }
            else
            {
                recordThread.Abort();
                recordThread = null;
                timerUpdateText.Enabled = false;
                timerCheckProceses.Enabled = true;
            }
        }
        private void UpdateTimePlayedText()
        {
           lblTimePlayed.Text = String.Format("Days: {0}, Hours: {1}, Minutes: {2}, Seconds: {3}", lolProcess.GetDays(), lolProcess.GetHours(), lolProcess.GetMinutes(), lolProcess.GetSeconds());
        }

        private void LolRecorder_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveFile.SaveProcessToFile(lolProcess.ProcessName, lolProcess.GetTime);
            e.Cancel = false;
        }

        private void btnResetTime_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to reset the time?", "WARNING", MessageBoxButtons.YesNo) ==
                System.Windows.Forms.DialogResult.Yes)
            {
                lolProcess.ResetTime();
                UpdateTimePlayedText();
            }
        }

        private void LolRecorder_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == WindowState)
            {
                Hide();
                notifyIcon1.BalloonTipTitle = "Lol Recorder";
                notifyIcon1.BalloonTipText = "Lol Recorder is still running in the background and will record the time you play League of Legends";
                notifyIcon1.ShowBalloonTip(5000);

            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
        }

        private void btnStartup_Click(object sender, EventArgs e)
        {
            using (RegistryKey rk = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true))
            {
                rk.SetValue("LolRecorder", "\"" + Application.ExecutablePath + "\"");
            }
        }

        private void btnRemoveStartup_Click(object sender, EventArgs e)
        {
            using (RegistryKey rk = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true))
            {
                rk.DeleteValue("LolRecorder", false);
            }
        }




    }
}

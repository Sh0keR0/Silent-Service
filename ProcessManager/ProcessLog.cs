using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading;

namespace ProcessManager
{
    public class ProcessLog
    {
        private bool IsRecording = false;
        private Stopwatch stopwatch = new Stopwatch();
        private Stopwatch lastSessioonStopwatch = new Stopwatch();
        public Process[] thisProcess { get; set; }
        public string ProcessName { get; set; }
        public TimeSpan TimeSpentBefore { get; set; }
        public bool isRecording { get { return IsRecording; } }
        public TimeSpan GetTime { get { return TimeSpentBefore + stopwatch.Elapsed; } }
        public TimeSpan LastSession { get { return lastSessioonStopwatch.Elapsed; } }

        public ProcessLog(string processName, TimeSpan time)
        {
            ProcessName = processName;
            TimeSpentBefore = time;
            thisProcess = Process.GetProcessesByName(processName);

        }

        #region Recording the process
        private void RecordProcess() // check if the process is stil running
        {
            thisProcess = Process.GetProcessesByName(ProcessName);
           if(thisProcess.Length != 0) // process still running
           {
              Thread.Sleep(350);
              RecordProcess();
           }
           else
           {
               StopRecording();
           }
               

        }
        public void StartRecording()
        {
            if(IsRecording == false)
            {
               
                IsRecording = true;
                stopwatch.Start();
                lastSessioonStopwatch = new Stopwatch();
                lastSessioonStopwatch.Start();
                RecordProcess();
            }
            
        }
        public void StopRecording()
        {
           
            stopwatch.Stop();
            lastSessioonStopwatch.Stop();
            IsRecording = false;
            Thread.CurrentThread.Abort();
        }

        #endregion

        #region Get the time spent in days, hours, minutes and seconds to string
        public string GetDays()
        {
            return GetTime.Days.ToString();      
        }
        public string GetHours()
        {
            return GetTime.Hours.ToString();
        }
        public string GetMinutes()
        {
            return GetTime.Minutes.ToString();
        }
        public string GetSeconds()
        {
            return GetTime.Seconds.ToString();
        }
        #endregion

        #region functions
        public void AddTime(TimeSpan time)
        {
            TimeSpentBefore += time;
        }
        public bool IsRunning()
        {
            thisProcess = Process.GetProcessesByName(ProcessName);
            if (thisProcess.Length != 0)
                return true;
            return false;
        }
        public void ResetTime()
        {
            stopwatch.Stop();
            TimeSpentBefore = new TimeSpan();
            stopwatch = new Stopwatch();
            if (isRecording)
                stopwatch.Start();

        }
        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using sn;
using System.Diagnostics;
using ProcessManager;
using System.Threading;
using System.IO;
using System.Media;
namespace SilentN
{
    /*
     * TO DO:
     * -- general--
     * Allow the program to record multiple games at once
     *
     * --
     * --Game Time---
     * Default game list for the user to easily add known games
     * Add new game allow you to select from the default games list
     * Imporvement of the UI
     * ------
     * --Overview--
     * Overview of: Overall game time, overall notification, longest session, highest play time game
     * Allow the user to customize his client?
     * And an about button with email information to report bugs and send suggestions
     * ---
     * -- notifications--
     * Allow the user to set notifications, there are different types of notifications options
     * - Pop up notification, a pop up will show and interrupt the player even if a game is running
     * - Sound notification, a sound will play, the user will be able to choose for how long and when it will end
     * The user can choose one of them or both
     * The user can decide if notification will show during game time
     * Set notification every X Hours/Minutes / At specific time (12:00) / After X hours/minutes of game time
     * --
     * 
    */
    public partial class SilentService : Form
    {
        Game SelectedGame;
        Game recordedGame;
        Thread recordThread;

        SoundPlayer AlertAudio = new SoundPlayer(SilentN.Properties.Resources._sweetalertsound1);

        private int AlertRecentlyPlayed = 0;

        #region Notifications vars
        public static string NotificationName;
        public static string NotificationDescription;
        public static int NotificationType;
        public static bool NotificationRepeat;
        public static bool NotificationActive;
        public static int NotificationHour;
        public static int NotificationMinute;
        public static int NotificationAlertType;
        DialogResult notificationResult;
        #endregion

        public static bool gameListUpdated = false;

        public SilentService()
        {
            InitializeComponent();
            lblVersion.Text = "Version: " + Application.ProductVersion;

            if (File.Exists(SaveFile.SaveFilePath + "\\" + SaveFile.SaveFileName))
                GameList.LoadGames(File.ReadAllText(SaveFile.SaveFilePath + "\\" + SaveFile.SaveFileName));
           
            if (File.Exists(SaveFile.SaveFilePath + "\\" + SaveFile.NotificatinosSaveFileName))
                NotificationsList.LoadNotifications(File.ReadAllText(SaveFile.SaveFilePath + "\\" + SaveFile.NotificatinosSaveFileName));

            if (GameList.Games.Count != 0)
            {
                UpdateGameListComboBox();
                UpdateSelectedGame();
            }

            timerCheckGameRunning.Enabled = true;

            #region Databinding
            dgvNotifications.RowHeadersVisible = false;
            dgvNotifications.AutoGenerateColumns = false;
            dgvNotifications.DataSource = NotificationsList.Notifications;
            dgvNotifications.Columns.Add(new DataGridViewTextBoxColumn
                {
                    HeaderText = "Name",
                    Width = 85,
                    DataPropertyName = "Name"
                });
            dgvNotifications.Columns.Add(new DataGridViewTextBoxColumn
            {

                HeaderText = "Description",
                Width = 220,
                DataPropertyName = "Description"

            });
            dgvNotifications.Columns.Add(new DataGridViewTextBoxColumn
            {
               
                HeaderText = "Time",
                Width = 60,
                DataPropertyName = "GetTime"

            });
            dgvNotifications.Columns.Add(new DataGridViewTextBoxColumn
                {
                    HeaderText = "Alert",
                    DataPropertyName = "GetAlertType"
            
                });

            dgvNotifications.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Repeat",
                Width = 75,
                DataPropertyName = "GetRepeat"

            });
            dgvNotifications.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Active",
          //      Width = 40,
                DataPropertyName = "GetIsActive"

            });

    

            #endregion

        }

        #region Updates code
        public void UpdateGameListComboBox()
        {
            cbGameList.Items.Clear();
            foreach (Game game in GameList.Games)
            {
                cbGameList.Items.Add(game.Name);
            }
            cbGameList.SelectedItem = GameList.GameByID(1).Name;
        }

        private void UpdateSelectedGame()
        {
            SelectedGame = GameList.GameByName(cbGameList.SelectedItem.ToString());
            lblGame.Text = SelectedGame.Name;
        }

        private void cbGameList_SelectionChangeCommitted(object sender, EventArgs e)
        {
            UpdateSelectedGame();
            updateUI();
        }
        private void timerUpdateUI_Tick(object sender, EventArgs e) // update the UI
        {
            updateUI();
        }

        private void updateUI()
        {
           if (SelectedGame != null)
            {
 
                if (SelectedGame != null && SelectedGame.GameProcess.IsRunning())
                {
                    lblGamingRunning.Text = "Game is running";
                    lblGamingRunning.ForeColor = System.Drawing.Color.ForestGreen;
                }
                else
                {
                    lblGamingRunning.Text = "Game not running";
                    lblGamingRunning.ForeColor = System.Drawing.Color.DarkRed;
                }

                lblTimePlayed.Text = String.Format("{0} Hours, {1} Minutes and {2} Seconds", Math.Floor(SelectedGame.GameProcess.GetTime.TotalHours), SelectedGame.GameProcess.GetMinutes(), SelectedGame.GameProcess.GetSeconds());
                lblLastSession.Text = String.Format("{0} Hours, {1} Minutes and {2} Seconds", SelectedGame.GameProcess.LastSession.Hours, SelectedGame.GameProcess.LastSession.Minutes, SelectedGame.GameProcess.LastSession.Seconds);

            }
            if (gameListUpdated == true)
            {
                UpdateGameListComboBox();
                gameListUpdated = false;
                UpdateSelectedGame();
            }
            lblMachineTime.Text = String.Format("{0}:{1}:{2}", DateTime.Now.Hour, DateTime.Now.Minute,DateTime.Now.Second);
            if(recordedGame != null) // if the recorded game is not recording set it to null
            {
                if(!recordedGame.GameProcess.isRecording)
                {
                    recordedGame = null;
                }
            }

        }
        

        #endregion

        

     /*   public static void SaveIconFromExe(string path, string iconName) // Not in use ATM
        {
            if (File.Exists(path))
            {
                Icon ico = Icon.ExtractAssociatedIcon(path);
                if (!Directory.Exists(SaveFile.SaveFilePath + SaveFile.ImagesFolder))
                    System.IO.Directory.CreateDirectory(SaveFile.SaveFilePath + SaveFile.ImagesFolder);

                FileStream stream = new System.IO.FileStream(SaveFile.SaveFilePath + SaveFile.ImagesFolder + "\\" + iconName + ".ico", System.IO.FileMode.Create);
                ico.Save(stream);
                stream.Flush();
                stream.Close();

            }
        }*/
        
        private void timerCheckGameRunning_Tick(object sender, EventArgs e) // Check if one of the games are currently running
        {
            if (recordedGame == null) // if a game is not being recorded already, currently only able to record one game at a time
            {
                foreach (Game game in GameList.Games)
                {
                    if (game.GameProcess.IsRunning() && !game.GameProcess.isRecording)
                    {
                        if (recordThread != null)
                        {
                            recordThread.Abort();
                            recordThread.Join();
                            recordThread = null;
                        }
                        recordedGame = game;
                        recordThread = new Thread(game.GameProcess.StartRecording);
                        recordThread.Start();
                        break;
                    }
                }
            }
        }

        private void SilentService_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveFile.SaveDataToFile();
            SaveFile.SaveNotificationsToFile();
            if(recordThread != null)
                 recordThread.Abort();
        }

        #region Add new game to the game's list
        private void btnAddNewGame_Click(object sender, EventArgs e)
        {
            Form addnewGameForm = new AddNewGameForm(this);
            addnewGameForm.Show();
            this.Enabled = false;
            
        }
        public static void AddNewGame(string NewGameName, string NewGameProcess)
        {
            GameList.AddNewGame(NewGameName, NewGameProcess);
        }
        #endregion

        private void btnChangeSettings_Click(object sender, EventArgs e)
        {
            Form ChangeSettingForm = new ChangeGameSettingForm(SelectedGame, this);
            ChangeSettingForm.Show();
            this.Enabled = false;
        }

        private void SilentService_Resize(object sender, EventArgs e)
        {
            if(FormWindowState.Minimized == WindowState)
            {
                Hide();
               

            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
        }


        #region notifications tab

        private void btnNewNotification_Click(object sender, EventArgs e)
        {
            Form form = new AddNewNotificationForm(AddNewNotificationForm.NEW_MODE);
            var result = form.ShowDialog();
           if(result == DialogResult.OK)
           {
               NotificationsList.AddNewNotifiction(
                   NotificationsList.Notifications.Count,
                   SilentService.NotificationName,
                   SilentService.NotificationDescription,
                   SilentService.NotificationType,
                   new TimeSpan(SilentService.NotificationHour, SilentService.NotificationMinute, 0),
                   SilentService.NotificationActive,
                   SilentService.NotificationRepeat,
                   SilentService.NotificationAlertType
                   );
           }
     

        }

        private void dgvNotifications_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Notification notificationToEdit = NotificationsList.Notifications[e.RowIndex];
                Form form = new AddNewNotificationForm(AddNewNotificationForm.EDIT_MODE, notificationToEdit);
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {

                    notificationToEdit.Name = NotificationName;
                    notificationToEdit.Description = NotificationDescription;
                    notificationToEdit.Type = NotificationType;
                    notificationToEdit.IsRepeating = NotificationRepeat;
                    notificationToEdit.IsActive = NotificationActive;
                    notificationToEdit.Time = new TimeSpan(NotificationHour, NotificationMinute, 0);
                    notificationToEdit.AlertType = NotificationAlertType;
                }
            }
            
        }


        private void DisplayNotification(Notification n, int AlertType)
        {
            if (AlertType == (int)Notification.AlertTypes.SOUND_ALERT || AlertType == (int)Notification.AlertTypes.SOUND_MESSAGE_ALERT)
            {
                AlertAudio.PlayLooping();
            }
          

            if (AlertType == (int)Notification.AlertTypes.MESSAGE_ALERT || AlertType == (int)Notification.AlertTypes.SOUND_MESSAGE_ALERT)
            {
                Show();


            }

            AlertRecentlyPlayed = 100;
           notificationResult = MessageBox.Show(n.Name + Environment.NewLine + n.Description,"Notification Alert!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            if (notificationResult == DialogResult.OK || notificationResult == DialogResult.Cancel)
                AlertAudio.Stop();

            notificationResult = DialogResult.None;
            
        }

        private void notifictionsTimer_Tick(object sender, EventArgs e)
        {
            if (AlertRecentlyPlayed > 0)
                AlertRecentlyPlayed--;
            foreach(Notification notification in NotificationsList.Notifications)
            {
                if(notification.IsActive)
                {
                    if(notification.Type == (int)Notification.NotificationType.AFTER_TIME)
                    {
                        
                        notification.TimerTickDown = notification.TimerTickDown.Subtract(new TimeSpan(0, 0, 1));
                        if(notification.TimerTickDown.TotalMinutes <= 0)
                        {
                                                   
                            if (!notification.IsRepeating)
                                notification.IsActive = false;

                            notification.TimerTickDown = new TimeSpan(0, 0, 0, (int)notification.Time.TotalSeconds); // reset the timertickdown back to the original value
                            DisplayNotification(notification,notification.AlertType);
                            
                        }

                    }else if(notification.Type == (int)Notification.NotificationType.SPECIFIC_TIME)
                    {
                        if(notification.Time.Hours == DateTime.Now.Hour && notification.Time.Minutes == DateTime.Now.Minute && AlertRecentlyPlayed <= 0)
                        {
                            
                           
                            if (!notification.IsRepeating)
                                notification.IsActive = false;

                            DisplayNotification(notification,notification.AlertType);
                            
                        }
                    }
                }
            }
        }

        private void playSoundTimer_Tick(object sender, EventArgs e) // unused
        {

            AlertAudio.Stop();

        }
        #endregion

 
    }
}

namespace SilentN
{
    partial class SilentService
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SilentService));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblGamingRunning = new System.Windows.Forms.Label();
            this.btnChangeSettings = new System.Windows.Forms.Button();
            this.lblTimePlayed = new System.Windows.Forms.Label();
            this.lblLastSession = new System.Windows.Forms.Label();
            this.lblGame = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAddNewGame = new System.Windows.Forms.Button();
            this.cbGameList = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnNewNotification = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvNotifications = new System.Windows.Forms.DataGridView();
            this.lblMachineTime = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.timerCheckGameRunning = new System.Windows.Forms.Timer(this.components);
            this.timerUpdateUI = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.notifictionsTimer = new System.Windows.Forms.Timer(this.components);
            this.playSoundTimer = new System.Windows.Forms.Timer(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotifications)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(1, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(532, 259);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(524, 233);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Overview";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.lblGamingRunning);
            this.tabPage2.Controls.Add(this.btnChangeSettings);
            this.tabPage2.Controls.Add(this.lblTimePlayed);
            this.tabPage2.Controls.Add(this.lblLastSession);
            this.tabPage2.Controls.Add(this.lblGame);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.pictureBox1);
            this.tabPage2.Controls.Add(this.btnAddNewGame);
            this.tabPage2.Controls.Add(this.cbGameList);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(524, 233);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Game Time";
            // 
            // lblGamingRunning
            // 
            this.lblGamingRunning.AutoSize = true;
            this.lblGamingRunning.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblGamingRunning.ForeColor = System.Drawing.Color.DarkRed;
            this.lblGamingRunning.Location = new System.Drawing.Point(337, 9);
            this.lblGamingRunning.Name = "lblGamingRunning";
            this.lblGamingRunning.Size = new System.Drawing.Size(178, 24);
            this.lblGamingRunning.TabIndex = 11;
            this.lblGamingRunning.Text = "Game not running";
            // 
            // btnChangeSettings
            // 
            this.btnChangeSettings.Location = new System.Drawing.Point(10, 188);
            this.btnChangeSettings.Name = "btnChangeSettings";
            this.btnChangeSettings.Size = new System.Drawing.Size(146, 23);
            this.btnChangeSettings.TabIndex = 10;
            this.btnChangeSettings.Text = "Change game settings";
            this.btnChangeSettings.UseVisualStyleBackColor = true;
            this.btnChangeSettings.Click += new System.EventHandler(this.btnChangeSettings_Click);
            // 
            // lblTimePlayed
            // 
            this.lblTimePlayed.AutoSize = true;
            this.lblTimePlayed.Location = new System.Drawing.Point(116, 131);
            this.lblTimePlayed.Name = "lblTimePlayed";
            this.lblTimePlayed.Size = new System.Drawing.Size(69, 13);
            this.lblTimePlayed.TabIndex = 9;
            this.lblTimePlayed.Text = "Not Selected";
            // 
            // lblLastSession
            // 
            this.lblLastSession.AutoSize = true;
            this.lblLastSession.Location = new System.Drawing.Point(156, 94);
            this.lblLastSession.Name = "lblLastSession";
            this.lblLastSession.Size = new System.Drawing.Size(69, 13);
            this.lblLastSession.TabIndex = 8;
            this.lblLastSession.Text = "Not Selected";
            // 
            // lblGame
            // 
            this.lblGame.AutoSize = true;
            this.lblGame.Location = new System.Drawing.Point(66, 61);
            this.lblGame.Name = "lblGame";
            this.lblGame.Size = new System.Drawing.Size(69, 13);
            this.lblGame.TabIndex = 7;
            this.lblGame.Text = "Not Selected";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.Location = new System.Drawing.Point(7, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "You\'ve Played";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.Location = new System.Drawing.Point(7, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "In The Last Session:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(7, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Game:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(374, 58);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(122, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // btnAddNewGame
            // 
            this.btnAddNewGame.Location = new System.Drawing.Point(228, 9);
            this.btnAddNewGame.Name = "btnAddNewGame";
            this.btnAddNewGame.Size = new System.Drawing.Size(103, 23);
            this.btnAddNewGame.TabIndex = 2;
            this.btnAddNewGame.Text = "Add new game";
            this.btnAddNewGame.UseVisualStyleBackColor = true;
            this.btnAddNewGame.Click += new System.EventHandler(this.btnAddNewGame_Click);
            // 
            // cbGameList
            // 
            this.cbGameList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGameList.FormattingEnabled = true;
            this.cbGameList.Location = new System.Drawing.Point(69, 11);
            this.cbGameList.Name = "cbGameList";
            this.cbGameList.Size = new System.Drawing.Size(153, 21);
            this.cbGameList.TabIndex = 1;
            this.cbGameList.SelectionChangeCommitted += new System.EventHandler(this.cbGameList_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Game list: ";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage3.Controls.Add(this.btnNewNotification);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.dgvNotifications);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(524, 233);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Notifications";
            // 
            // btnNewNotification
            // 
            this.btnNewNotification.Location = new System.Drawing.Point(10, 25);
            this.btnNewNotification.Name = "btnNewNotification";
            this.btnNewNotification.Size = new System.Drawing.Size(113, 23);
            this.btnNewNotification.TabIndex = 2;
            this.btnNewNotification.Text = "New Notification";
            this.btnNewNotification.UseVisualStyleBackColor = true;
            this.btnNewNotification.Click += new System.EventHandler(this.btnNewNotification_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Notifications:";
            // 
            // dgvNotifications
            // 
            this.dgvNotifications.AllowUserToAddRows = false;
            this.dgvNotifications.AllowUserToDeleteRows = false;
            this.dgvNotifications.AllowUserToResizeColumns = false;
            this.dgvNotifications.AllowUserToResizeRows = false;
            this.dgvNotifications.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvNotifications.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNotifications.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvNotifications.Location = new System.Drawing.Point(10, 67);
            this.dgvNotifications.MultiSelect = false;
            this.dgvNotifications.Name = "dgvNotifications";
            this.dgvNotifications.ReadOnly = true;
            this.dgvNotifications.RowHeadersVisible = false;
            this.dgvNotifications.Size = new System.Drawing.Size(500, 150);
            this.dgvNotifications.TabIndex = 0;
            this.dgvNotifications.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNotifications_CellDoubleClick);
            // 
            // lblMachineTime
            // 
            this.lblMachineTime.AutoSize = true;
            this.lblMachineTime.Location = new System.Drawing.Point(487, 265);
            this.lblMachineTime.Name = "lblMachineTime";
            this.lblMachineTime.Size = new System.Drawing.Size(34, 13);
            this.lblMachineTime.TabIndex = 0;
            this.lblMachineTime.Text = "00:00";
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Location = new System.Drawing.Point(12, 265);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(63, 13);
            this.lblVersion.TabIndex = 1;
            this.lblVersion.Text = "Version: 0.1";
            // 
            // timerCheckGameRunning
            // 
            this.timerCheckGameRunning.Interval = 1000;
            this.timerCheckGameRunning.Tick += new System.EventHandler(this.timerCheckGameRunning_Tick);
            // 
            // timerUpdateUI
            // 
            this.timerUpdateUI.Enabled = true;
            this.timerUpdateUI.Interval = 500;
            this.timerUpdateUI.Tick += new System.EventHandler(this.timerUpdateUI_Tick);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Silent Service";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // notifictionsTimer
            // 
            this.notifictionsTimer.Enabled = true;
            this.notifictionsTimer.Interval = 1000;
            this.notifictionsTimer.Tick += new System.EventHandler(this.notifictionsTimer_Tick);
            // 
            // playSoundTimer
            // 
            this.playSoundTimer.Interval = 1000;
            this.playSoundTimer.Tick += new System.EventHandler(this.playSoundTimer_Tick);
            // 
            // SilentService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 285);
            this.Controls.Add(this.lblMachineTime);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SilentService";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Silent Service";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SilentService_FormClosing);
            this.Resize += new System.EventHandler(this.SilentService_Resize);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotifications)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnChangeSettings;
        private System.Windows.Forms.Label lblTimePlayed;
        private System.Windows.Forms.Label lblLastSession;
        private System.Windows.Forms.Label lblGame;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAddNewGame;
        private System.Windows.Forms.ComboBox cbGameList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label lblMachineTime;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label lblGamingRunning;
        private System.Windows.Forms.Timer timerCheckGameRunning;
        private System.Windows.Forms.Timer timerUpdateUI;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.DataGridView dgvNotifications;
        private System.Windows.Forms.Button btnNewNotification;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer notifictionsTimer;
        private System.Windows.Forms.Timer playSoundTimer;
    }
}
namespace SilentN
{
    partial class LolRecorder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LolRecorder));
            this.lblGameRunning = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTimePlayed = new System.Windows.Forms.Label();
            this.timerCheckProceses = new System.Windows.Forms.Timer(this.components);
            this.timerUpdateText = new System.Windows.Forms.Timer(this.components);
            this.btnResetTime = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.btnStartup = new System.Windows.Forms.Button();
            this.btnRemoveStartup = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblGameRunning
            // 
            this.lblGameRunning.AutoSize = true;
            this.lblGameRunning.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblGameRunning.ForeColor = System.Drawing.Color.Red;
            this.lblGameRunning.Location = new System.Drawing.Point(12, 9);
            this.lblGameRunning.Name = "lblGameRunning";
            this.lblGameRunning.Size = new System.Drawing.Size(120, 13);
            this.lblGameRunning.TabIndex = 0;
            this.lblGameRunning.Text = "Game is not running";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Time played: ";
            // 
            // lblTimePlayed
            // 
            this.lblTimePlayed.AutoSize = true;
            this.lblTimePlayed.Location = new System.Drawing.Point(77, 156);
            this.lblTimePlayed.Name = "lblTimePlayed";
            this.lblTimePlayed.Size = new System.Drawing.Size(13, 13);
            this.lblTimePlayed.TabIndex = 2;
            this.lblTimePlayed.Text = "0";
            // 
            // timerCheckProceses
            // 
            this.timerCheckProceses.Interval = 1000;
            this.timerCheckProceses.Tick += new System.EventHandler(this.timerCheckProceses_Tick);
            // 
            // timerUpdateText
            // 
            this.timerUpdateText.Interval = 1000;
            this.timerUpdateText.Tick += new System.EventHandler(this.timerUpdateText_Tick);
            // 
            // btnResetTime
            // 
            this.btnResetTime.Location = new System.Drawing.Point(12, 109);
            this.btnResetTime.Name = "btnResetTime";
            this.btnResetTime.Size = new System.Drawing.Size(120, 23);
            this.btnResetTime.TabIndex = 3;
            this.btnResetTime.Text = "Reset Time";
            this.btnResetTime.UseVisualStyleBackColor = true;
            this.btnResetTime.Click += new System.EventHandler(this.btnResetTime_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::SilentN.Properties.Resources.pbe0521_04;
            this.pictureBox1.Location = new System.Drawing.Point(148, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(139, 136);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Lol Recorder Alpha";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // btnStartup
            // 
            this.btnStartup.Location = new System.Drawing.Point(12, 51);
            this.btnStartup.Name = "btnStartup";
            this.btnStartup.Size = new System.Drawing.Size(120, 23);
            this.btnStartup.TabIndex = 5;
            this.btnStartup.Text = "Start on Startup";
            this.btnStartup.UseVisualStyleBackColor = true;
            this.btnStartup.Click += new System.EventHandler(this.btnStartup_Click);
            // 
            // btnRemoveStartup
            // 
            this.btnRemoveStartup.Location = new System.Drawing.Point(12, 80);
            this.btnRemoveStartup.Name = "btnRemoveStartup";
            this.btnRemoveStartup.Size = new System.Drawing.Size(120, 23);
            this.btnRemoveStartup.TabIndex = 6;
            this.btnRemoveStartup.Text = "Remove from Startup";
            this.btnRemoveStartup.UseVisualStyleBackColor = true;
            this.btnRemoveStartup.Click += new System.EventHandler(this.btnRemoveStartup_Click);
            // 
            // LolRecorder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 178);
            this.Controls.Add(this.btnRemoveStartup);
            this.Controls.Add(this.btnStartup);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnResetTime);
            this.Controls.Add(this.lblTimePlayed);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblGameRunning);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "LolRecorder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lol Recorder";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LolRecorder_FormClosing);
            this.Resize += new System.EventHandler(this.LolRecorder_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGameRunning;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTimePlayed;
        private System.Windows.Forms.Timer timerCheckProceses;
        private System.Windows.Forms.Timer timerUpdateText;
        private System.Windows.Forms.Button btnResetTime;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Button btnStartup;
        private System.Windows.Forms.Button btnRemoveStartup;
    }
}
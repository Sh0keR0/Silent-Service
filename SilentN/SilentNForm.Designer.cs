namespace SilentN
{
    partial class SilentNForm
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
            this.cbProcessesList = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRecord = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTimeSpent = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.updateTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // cbProcessesList
            // 
            this.cbProcessesList.FormattingEnabled = true;
            this.cbProcessesList.Location = new System.Drawing.Point(15, 65);
            this.cbProcessesList.Name = "cbProcessesList";
            this.cbProcessesList.Size = new System.Drawing.Size(121, 21);
            this.cbProcessesList.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select a process to record";
            // 
            // btnRecord
            // 
            this.btnRecord.Location = new System.Drawing.Point(142, 65);
            this.btnRecord.Name = "btnRecord";
            this.btnRecord.Size = new System.Drawing.Size(75, 23);
            this.btnRecord.TabIndex = 2;
            this.btnRecord.Text = "Record";
            this.btnRecord.UseVisualStyleBackColor = true;
            this.btnRecord.Click += new System.EventHandler(this.btnRecord_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Time Spent:";
            // 
            // lblTimeSpent
            // 
            this.lblTimeSpent.AutoSize = true;
            this.lblTimeSpent.Location = new System.Drawing.Point(82, 109);
            this.lblTimeSpent.Name = "lblTimeSpent";
            this.lblTimeSpent.Size = new System.Drawing.Size(13, 13);
            this.lblTimeSpent.TabIndex = 4;
            this.lblTimeSpent.Text = "0";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(223, 65);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.Text = "Refresh List";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // updateTimer
            // 
            this.updateTimer.Interval = 1;
            this.updateTimer.Tick += new System.EventHandler(this.updateTimer_Tick);
            // 
            // SilentNForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 145);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.lblTimeSpent);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnRecord);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbProcessesList);
            this.Name = "SilentNForm";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SilentNForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbProcessesList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRecord;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTimeSpent;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Timer updateTimer;
    }
}


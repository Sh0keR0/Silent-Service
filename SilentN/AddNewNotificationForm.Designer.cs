namespace SilentN
{
    partial class AddNewNotificationForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbActive = new System.Windows.Forms.CheckBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbSpecificTime = new System.Windows.Forms.RadioButton();
            this.rbAfterTime = new System.Windows.Forms.RadioButton();
            this.cbRepeat = new System.Windows.Forms.CheckBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.tbHours = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbMinutes = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbAlertType = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Description:";
            // 
            // cbActive
            // 
            this.cbActive.AutoSize = true;
            this.cbActive.Checked = true;
            this.cbActive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbActive.Location = new System.Drawing.Point(85, 172);
            this.cbActive.Name = "cbActive";
            this.cbActive.Size = new System.Drawing.Size(56, 17);
            this.cbActive.TabIndex = 5;
            this.cbActive.Text = "Active";
            this.cbActive.UseVisualStyleBackColor = true;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(94, 9);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(100, 20);
            this.tbName.TabIndex = 6;
            // 
            // tbDescription
            // 
            this.tbDescription.Location = new System.Drawing.Point(94, 35);
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(100, 20);
            this.tbDescription.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbSpecificTime);
            this.groupBox1.Controls.Add(this.rbAfterTime);
            this.groupBox1.Location = new System.Drawing.Point(18, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(254, 76);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Alert";
            // 
            // rbSpecificTime
            // 
            this.rbSpecificTime.AutoSize = true;
            this.rbSpecificTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSpecificTime.Location = new System.Drawing.Point(6, 45);
            this.rbSpecificTime.Name = "rbSpecificTime";
            this.rbSpecificTime.Size = new System.Drawing.Size(131, 20);
            this.rbSpecificTime.TabIndex = 1;
            this.rbSpecificTime.Text = "At specific time";
            this.rbSpecificTime.UseVisualStyleBackColor = true;
            // 
            // rbAfterTime
            // 
            this.rbAfterTime.AutoSize = true;
            this.rbAfterTime.Checked = true;
            this.rbAfterTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.rbAfterTime.Location = new System.Drawing.Point(6, 19);
            this.rbAfterTime.Name = "rbAfterTime";
            this.rbAfterTime.Size = new System.Drawing.Size(201, 20);
            this.rbAfterTime.TabIndex = 0;
            this.rbAfterTime.TabStop = true;
            this.rbAfterTime.Text = "After the time has passed";
            this.rbAfterTime.UseVisualStyleBackColor = true;
            // 
            // cbRepeat
            // 
            this.cbRepeat.AutoSize = true;
            this.cbRepeat.Location = new System.Drawing.Point(18, 172);
            this.cbRepeat.Name = "cbRepeat";
            this.cbRepeat.Size = new System.Drawing.Size(61, 17);
            this.cbRepeat.TabIndex = 9;
            this.cbRepeat.Text = "Repeat";
            this.cbRepeat.UseVisualStyleBackColor = true;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(18, 195);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(254, 23);
            this.btnCreate.TabIndex = 10;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // tbHours
            // 
            this.tbHours.Location = new System.Drawing.Point(56, 146);
            this.tbHours.Name = "tbHours";
            this.tbHours.Size = new System.Drawing.Size(22, 20);
            this.tbHours.TabIndex = 2;
            this.tbHours.Text = "00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Time:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.Location = new System.Drawing.Point(75, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(10, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = ":";
            // 
            // tbMinutes
            // 
            this.tbMinutes.Location = new System.Drawing.Point(84, 146);
            this.tbMinutes.Name = "tbMinutes";
            this.tbMinutes.Size = new System.Drawing.Size(22, 20);
            this.tbMinutes.TabIndex = 13;
            this.tbMinutes.Text = "00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(138, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Alert:";
            // 
            // cbAlertType
            // 
            this.cbAlertType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAlertType.FormattingEnabled = true;
            this.cbAlertType.Location = new System.Drawing.Point(175, 146);
            this.cbAlertType.Name = "cbAlertType";
            this.cbAlertType.Size = new System.Drawing.Size(80, 21);
            this.cbAlertType.TabIndex = 15;
            // 
            // AddNewNotificationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 225);
            this.Controls.Add(this.cbAlertType);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbMinutes);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbHours);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.cbRepeat);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbDescription);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.cbActive);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddNewNotificationForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "New Notification";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbActive;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbSpecificTime;
        private System.Windows.Forms.RadioButton rbAfterTime;
        private System.Windows.Forms.CheckBox cbRepeat;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.TextBox tbHours;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbMinutes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbAlertType;
    }
}
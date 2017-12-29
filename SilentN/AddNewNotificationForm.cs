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
namespace SilentN
{
    public partial class AddNewNotificationForm : Form
    {
        public const int NEW_MODE = 0;
        public const int EDIT_MODE = 1;
        Notification NotificationToEdit;
        int Mode;
        public AddNewNotificationForm(int mode, Notification notificationToEdit = null)
        {
            InitializeComponent();
            Mode = mode;
            NotificationToEdit = notificationToEdit;

            cbAlertType.Items.Add("Message");
            cbAlertType.Items.Add("Sound");
            cbAlertType.Items.Add("Message + Sound");
            cbAlertType.SelectedItem = "Message";

            if (Mode == NEW_MODE)
                btnCreate.Text = "Create";
            else if (Mode == EDIT_MODE)
                btnCreate.Text = "Edit";

            if(NotificationToEdit != null && Mode == EDIT_MODE)
            {
                tbName.Text = NotificationToEdit.Name;
                tbDescription.Text = NotificationToEdit.Description;
                tbHours.Text = NotificationToEdit.Time.Hours.ToString();
                tbMinutes.Text = NotificationToEdit.Time.Minutes.ToString();
                if (NotificationToEdit.Type == (int)Notification.NotificationType.AFTER_TIME)
                    rbAfterTime.Checked = true;
                else
                    rbSpecificTime.Checked = true;

                cbActive.Checked = (NotificationToEdit.IsActive);
                cbRepeat.Checked = (NotificationToEdit.IsRepeating);
            }
            
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            

                if (String.IsNullOrWhiteSpace(tbName.Text) || String.IsNullOrWhiteSpace(tbDescription.Text))
                {
                    MessageBox.Show("Name / Description can not be empty");
                }
                else if (!ContainOnlyNumbers(tbHours.Text) || !ContainOnlyNumbers(tbMinutes.Text))
                {
                    MessageBox.Show("Invalid Hours / Minutes");
                }
                else if (Convert.ToInt32(tbHours.Text) > 24 || Convert.ToInt32(tbMinutes.Text) > 60)
                {
                    MessageBox.Show("Invalid Hours / Minutes input, please choose correct values," + Environment.NewLine + "Insert the hours and the minutes inside the textbox");
                }
                else
                {


                        SilentService.NotificationName = tbName.Text;
                        SilentService.NotificationDescription = tbDescription.Text;
                        if (rbAfterTime.Checked)
                            SilentService.NotificationType = (int)Notification.NotificationType.AFTER_TIME;
                        else
                            SilentService.NotificationType = (int)Notification.NotificationType.SPECIFIC_TIME;

                        SilentService.NotificationRepeat = cbRepeat.Checked;
                        SilentService.NotificationActive = cbActive.Checked;
                        SilentService.NotificationHour = Convert.ToInt32(tbHours.Text);
                        SilentService.NotificationMinute = Convert.ToInt32(tbMinutes.Text);
                        if ((string)cbAlertType.SelectedItem == "Message")
                            SilentService.NotificationAlertType = (int)Notification.AlertTypes.MESSAGE_ALERT;
                        else if ((string)cbAlertType.SelectedItem == "Sound")
                            SilentService.NotificationAlertType = (int)Notification.AlertTypes.SOUND_ALERT;
                        else
                            SilentService.NotificationAlertType = (int)Notification.AlertTypes.SOUND_MESSAGE_ALERT;
                        
                        this.DialogResult = DialogResult.OK;
                        this.Close();


                }
            

        }

       private bool ContainOnlyNumbers(string str)
        {
            foreach(char c in str)
            {
                if(c < '0' || c> '9')
                    return false;
            }
            return true;
        }
    }
}

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
using ProcessManager;
namespace SilentN
{
    public partial class ChangeGameSettingForm : Form
    {
        Game GameSetting;
        Form MainForm;
        public ChangeGameSettingForm(Game game, Form mainForm)
        {
            InitializeComponent();

            GameSetting = game;
            MainForm = mainForm;
            tbName.Text = game.Name;
            tbProcess.Text = game.GameProcess.ProcessName;
        }

        private void btnResetTime_Click(object sender, EventArgs e)
        {
            string GameProcessName = GameSetting.GameProcess.ProcessName;
            GameSetting.GameProcess = new ProcessLog(GameProcessName, new TimeSpan());
            MessageBox.Show("Time played has been reset");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete it from the game list?", "WARNING", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                GameList.RemoveGame(GameSetting);
                SilentService.gameListUpdated = true;
                MainForm.Enabled = true;
                MainForm.Activate();
                this.Close();
            }
            
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
           if(!String.IsNullOrWhiteSpace(tbName.Text) && !String.IsNullOrWhiteSpace(tbProcess.Text))
           {
               GameSetting.Name = tbName.Text;
               GameSetting.GameProcess.ProcessName = tbProcess.Text;


               SilentService.gameListUpdated = true;
               MainForm.Enabled = true;
               MainForm.Activate();
               this.Close();
           }
           else
           {
               MessageBox.Show("Name / Process name can not be empty");
           }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            MainForm.Enabled = true;
            MainForm.Activate();
            this.Close();
        }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SilentN
{
    public partial class AddNewGameForm : Form
    {
        Form MainForm;
        public AddNewGameForm(Form mainForm)
        {
            InitializeComponent();
            MainForm = mainForm;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            if (!String.IsNullOrWhiteSpace(tbName.Text) && !String.IsNullOrWhiteSpace(tbProcess.Text))
            {
                SilentService.AddNewGame(tbName.Text, tbProcess.Text);
                MainForm.Enabled = true;
                SilentService.gameListUpdated = true;
                this.Close();

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

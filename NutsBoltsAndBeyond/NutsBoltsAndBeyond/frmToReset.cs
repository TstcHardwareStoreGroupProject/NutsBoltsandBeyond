using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NutsBoltsAndBeyond
{
    public partial class frmToReset : Form
    {
        public frmToReset()
        {
            InitializeComponent();
        }

        String password, confirm, code;

        private void btnReset_Click(object sender, EventArgs e)
        {
            password = tbxPassword.Text;
            confirm = tbxConfirm.Text;
            code = tbxResetCode.Text;

            if (password == String.Empty || confirm == String.Empty || code == String.Empty)
            {
                MessageBox.Show("All data is required to complete user accounts", "Incomplete Fields", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                SetDefaults();
            }
            else if (password != confirm)
            {
                MessageBox.Show("Passwords do not match. Please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                SetDefaults();
            }
            else if (password == ProgOps.resetUser.Password)
            {
                MessageBox.Show("Old password and new password cannot be the same. Please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                SetDefaults();
            }
            else if (code != Utils.rng)
            {
                MessageBox.Show("Reset Code does not match the code given", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                SetDefaults();
            }
            else
            {
                ProgOps.resetUser.Password = password;
                if(ProgOps._updateUser(ProgOps.resetUser))
                {
                    MessageBox.Show("Password Successfully Reset!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    ProgOps.resetUser.ResetUser();
                }


                this.Hide();
                frmLogin login = new frmLogin();
                login.Closed += (a, args) => this.Close();
                login.Show();
            }
        }

        void SetDefaults()
        {
            tbxPassword.Text = String.Empty;
            tbxConfirm.Text = String.Empty; ;
            tbxResetCode.Text = String.Empty; ;
        }
    }
}

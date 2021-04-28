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
    public partial class frmEmployeeMenu : Form
    {
        public frmEmployeeMenu()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin login = new frmLogin();
            login.Closed += (a, args) => this.Close();
            login.Show();
        }

        private void btnCus_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAccount account = new frmAccount();
            account.Closed += (a, args) => this.Close();
            account.Show();
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmInventory inv = new frmInventory();
            inv.Closed += (a, args) => this.Close();
            inv.Show();
        }
    }
}

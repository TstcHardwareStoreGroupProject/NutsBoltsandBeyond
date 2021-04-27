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
    public partial class frmAdminMenu : Form
    {
        public frmAdminMenu()
        {
            InitializeComponent();
        }

        public static String type = String.Empty;

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin login = new frmLogin();
            login.Closed += (a, args) => this.Close();
            login.Show();
        }

        private void btnEmp_Click(object sender, EventArgs e)
        {
            type = "emp";

            this.Hide();
            frmAccount account = new frmAccount();
            account.Closed += (a, args) => this.Close();
            account.Show();
        }

        private void btnCus_Click(object sender, EventArgs e)
        {
            type = "cus";

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

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
    public partial class frmMainMenu : Form
    {
        public frmMainMenu()
        {
            InitializeComponent();
            ProgOps.ConnectDB();
        }

        private void btnShop_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmShop shop = new frmShop();
            shop.Closed += (a, args) => this.Close();
            shop.Show();
        }

        private void btnAcct_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAccount account = new frmAccount();
            account.Closed += (a, args) => this.Close();
            account.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin login = new frmLogin();
            login.Closed += (a, args) => this.Close();
            login.Show();
        }
    }
}

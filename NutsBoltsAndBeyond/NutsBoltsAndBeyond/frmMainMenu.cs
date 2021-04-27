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

        private void btnExit_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.Show();
            this.Close();
        }

        private void btnShop_Click(object sender, EventArgs e)
        {
            frmShop shop = new frmShop();
            shop.Show();
            this.Close();
        }

        private void btnAcct_Click(object sender, EventArgs e)
        {
            frmAccount account = new frmAccount();
            account.Show();
            this.Close();
        }
    }
}

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

        private void btnExit_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.Show();
            this.Close();
        }

        private void btnEmp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("COMING SOON", "UNDER CONSTRUCTION", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnCus_Click(object sender, EventArgs e)
        {
            MessageBox.Show("COMING SOON", "UNDER CONSTRUCTION", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            frmInventory inv = new frmInventory();
            inv.Show();
            this.Hide();
        }
    }
}

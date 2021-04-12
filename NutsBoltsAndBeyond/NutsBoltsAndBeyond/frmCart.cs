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
    public partial class frmCart : Form
    {
        public frmCart()
        {
            InitializeComponent();
        }

        public int _transactionid;

        private void frmCart_Load(object sender, EventArgs e)
        {
            _transactionid = Utils._IDGenerator();
            dgvCart.DataSource = ProgOps.CartTable;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            switch (ProgOps.access)
            {
                case "Customer":
                    frmMainMenu main = new frmMainMenu();
                    this.Hide();
                    main.ShowDialog();
                    break;
                case "Employee":
                    frmEmployeeMenu emp = new frmEmployeeMenu();
                    this.Hide();
                    emp.ShowDialog();
                    break;
                case "Admin":
                    frmAdminMenu admin = new frmAdminMenu();
                    this.Hide();
                    admin.ShowDialog();
                    break;
                default:
                    break;
            }
        }

        private void btnShop_Click(object sender, EventArgs e)
        {
            frmShop shop = new frmShop();
            shop.Show();
            this.Close();
        }
    }
}

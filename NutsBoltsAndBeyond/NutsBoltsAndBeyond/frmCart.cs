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
            switch (ProgOps._access)
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

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dgvCart.Rows.Count > 1)
            {
                int selected = dgvCart.CurrentCell.RowIndex;

                DialogResult dialogResult = MessageBox.Show("Are you sure you want to remove this item?", "Are you sure", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    dgvCart.Rows.RemoveAt(selected);
                    MessageBox.Show("Item added successfully removed from the cart!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else
            {
                MessageBox.Show("Please select an item and try again", "There was a problem...", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Checkout Successful... I know, we're working on it...", "Success, kinda", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

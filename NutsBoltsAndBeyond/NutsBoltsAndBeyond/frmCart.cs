using System;
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

            dgvCart.Columns[2].DefaultCellStyle.Format = "c";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            switch (ProgOps.currentUser.Designation)
            {
                case "Customer":
                    this.Hide();
                    frmMainMenu main = new frmMainMenu();
                    main.FormClosed += (a, args) => this.Close();
                    main.Show();
                    break;
                case "Employee":
                    this.Hide();
                    frmEmployeeMenu emp = new frmEmployeeMenu();
                    emp.FormClosed += (a, args) => this.Close();
                    emp.Show();
                    break;
                case "Admin":
                    this.Hide();
                    frmAdminMenu admin = new frmAdminMenu();
                    admin.FormClosed += (a, args) => this.Close();
                    admin.Show();
                    break;
                default:
                    break;
            }
        }

        private void btnShop_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmShop shop = new frmShop();
            shop.Closed += (a, args) => this.Close();
            shop.Show();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dgvCart.Rows.Count > 1)
            {
                int selected = dgvCart.CurrentCell.RowIndex;

                DataGridViewRow row = dgvCart.Rows[selected];

                int id = Int32.Parse(row.Cells[0].Value.ToString());
                int quantity = Int32.Parse(row.Cells[3].Value.ToString());

                DialogResult dialogResult = MessageBox.Show("Are you sure you want to remove this item?", "Are you sure", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    int fromCart = ProgOps.getQuantity(id);
                    if (ProgOps._updateItem((quantity + fromCart).ToString(), id.ToString()))
                    {
                        dgvCart.Rows.RemoveAt(selected);
                        MessageBox.Show("Item added successfully removed from the cart!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    
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
            ProgOps.CartTable.Clear();
            frmCart_Load(sender, e);
        }
    }
}

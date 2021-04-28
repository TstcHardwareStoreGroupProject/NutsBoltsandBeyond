using System;
using System.Globalization;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace NutsBoltsAndBeyond
{
    public partial class frmInventory : Form
    {
        public frmInventory()
        {
            InitializeComponent();
        }

        DataTable dt;

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

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAddItem itm = new frmAddItem();
            itm.Closed += (a, args) => this.Close();
            itm.Show();
        }

        private void frmInventory_Load(object sender, EventArgs e)
        {
            ProgOps.ConnectDB();
            String query = "SELECT * FROM GROUP1SP212330.ITEMS";

            dt = new DataTable();

            ProgOps._daRes = new SqlDataAdapter(query, ProgOps._dbConnect);
            ProgOps._daRes.Fill(dt);

            ProgOps.CloseDB();

            dgvInventory.DataSource = dt;

            DataGridViewRow row = dgvInventory.Rows[0];

            lblViewItem.Text = row.Cells[1].Value.ToString();
            String price = row.Cells[2].Value.ToString() + "M";
            lblViewPrice.Text = String.Format("{0:C}", price);
            lblViewQuantity.Text = row.Cells[3].Value.ToString();
            lblViewDpt.Text = row.Cells[4].Value.ToString();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int selected = dgvInventory.CurrentCell.RowIndex;

            DataGridViewRow row = dgvInventory.Rows[selected];

            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this item? All information will be lost", "Confirm", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                String id = row.Cells[0].Value.ToString();
                if (ProgOps._deleteItem(id))
                {
                    MessageBox.Show("Item successfully deleted", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    frmInventory_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("There was a problem. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvInventory_SelectionChanged(object sender, EventArgs e)
        {
            int selected = dgvInventory.CurrentCell.RowIndex;

            DataGridViewRow row = dgvInventory.Rows[selected];

            lblViewItem.Text = row.Cells[1].Value.ToString();
            String price = row.Cells[2].Value.ToString() + "M";
            lblViewPrice.Text = String.Format("{0:C}", price);
            lblViewQuantity.Text = row.Cells[3].Value.ToString();
            lblViewDpt.Text = row.Cells[4].Value.ToString();
        }
    }
}

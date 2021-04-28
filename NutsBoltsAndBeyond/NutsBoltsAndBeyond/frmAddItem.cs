using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NutsBoltsAndBeyond
{
    public partial class frmAddItem : Form
    {
        public frmAddItem()
        {
            InitializeComponent();
            ProgOps.ConnectDB();
        }

        DataTable dt; 
        Models.ItemModel newItem;

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            newItem = new Models.ItemModel();
            
            if (!String.IsNullOrEmpty(tbxItem.Text) || !String.IsNullOrEmpty(tbxPrice.Text) || !String.IsNullOrEmpty(tbxQuantity.Text))
            {
                newItem.Item_Name = tbxItem.Text.ToUpper();

                try
                {
                    newItem.Price = Convert.ToDecimal(tbxPrice.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Price should be numeric", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    ClearAll();
                    return;
                }

                if (String.IsNullOrEmpty(tbxQuantity.Text))
                {
                    MessageBox.Show("Check your information and try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    ClearAll();
                    return;
                }
                else
                    newItem.Quantity = Int32.Parse(tbxQuantity.Text);

                if (newItem.Quantity < 0)
                {
                    MessageBox.Show("Quantity cannot be less than 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    ClearAll();
                    return;
                }

                newItem.Department = cbxDepartment.GetItemText(cbxDepartment.SelectedItem);
                bool itemExist = false;

                foreach (DataRow dr in dt.Rows)
                {
                    if (dr["ITEM_NAME"].ToString() == newItem.Item_Name)
                    {
                        itemExist = true;
                        MessageBox.Show("Item already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        ClearAll();
                    }
                }

                if (itemExist == false)
                {
                    DialogResult dialogResult = MessageBox.Show("Is all of the information correct?", "Confirm", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        ProgOps._saveItems(newItem);
                        MessageBox.Show("Item Saved Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        ClearAll();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please check your information and try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void frmAddItem_Load(object sender, EventArgs e)
        {
            String query = "SELECT * FROM GROUP1SP212330.ITEMS";
            dt = new DataTable();

            //TODO: Rigged for data normalization... to be fixed...
            ProgOps._daRes = new SqlDataAdapter(query, ProgOps._dbConnect);
            ProgOps._daRes.Fill(dt);

            ProgOps.CloseDB();
            cbxDepartment.SelectedItem = "TOOLS";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmInventory inv = new frmInventory();
            inv.Closed += (a, args) => this.Close();
            inv.Show();
        }

        private void ClearAll()
        {
            tbxItem.Text = String.Empty;
            tbxPrice.Text = String.Empty;
            tbxQuantity.Text = String.Empty;
            cbxDepartment.SelectedItem = "CARPENTRY";
        }
    }
}

using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Globalization;
using System.Windows.Forms;

namespace NutsBoltsAndBeyond
{
    public partial class frmShop : Form
    {
        public frmShop()
        {
            InitializeComponent();
            ProgOps.ConnectDB();
        }

        public DataTable ShopTable;

        private void frmShop_Load(object sender, EventArgs e)
        {
            ShopTable = new DataTable();

            if (!ProgOps.CartTable.Columns.Contains("SKU"))
            {
                ProgOps.CartTable.Columns.Add("SKU", typeof(int));
                ProgOps.CartTable.Columns.Add("ITEM", typeof(String));
                ProgOps.CartTable.Columns.Add("PRICE", typeof(Double));
                ProgOps.CartTable.Columns.Add("QUANTITY", typeof(int));
                ProgOps.CartTable.Columns.Add("DEPARTMENT", typeof(String));
            }

            String query = "SELECT * FROM GROUP1SP212330.ITEMS";

            ProgOps._daRes = new SqlDataAdapter(query, ProgOps._dbConnect);
            ProgOps._daRes.Fill(ShopTable);

            ProgOps.CloseDB();

            ShopTable.Columns["ITEM_ID"].ColumnName = "SKU";
            ShopTable.Columns["ITEM_NAME"].ColumnName = "ITEM";

            dgvShop.DataSource = ShopTable;
            dgvShop.Columns[2].DefaultCellStyle.Format = "c";
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            if (dgvShop.Rows.Count != 0)
            {
                int selected = dgvShop.CurrentCell.RowIndex;

                DataGridViewRow row = dgvShop.Rows[selected];

                int sku = Int32.Parse(row.Cells[0].Value.ToString());
                String item = row.Cells[1].Value.ToString();
                double price = Double.Parse(row.Cells[2].Value.ToString());
                price.ToString("C");
                int quantity = 1;
                String department = row.Cells[4].Value.ToString();

                bool set = ProgOps.CartTable.AsEnumerable().Any(r => sku == r.Field<int>("SKU"));

                if (!set)
                {
                    ProgOps.CartTable.Rows.Add(sku, item, price, quantity, department);
                }
                else
                {
                    foreach (DataRow dr in ProgOps.CartTable.Rows)
                    {
                        if (dr["SKU"].ToString() == sku.ToString())
                        {
                            quantity = Int32.Parse(dr["QUANTITY"].ToString()) + 1;
                        }
                        dr["QUANTITY"] = quantity;
                    }
                }

                MessageBox.Show("Item added successfully to the cart!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                row.Cells[3].Value = Int32.Parse(row.Cells[3].Value.ToString()) - 1;
            }
            else
            {
                MessageBox.Show("Please select an item and try again", "There was a problem...", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnViewCart_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCart cart = new frmCart();
            cart.Closed += (a, args) => this.Close();
            cart.Show();
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
    }
}

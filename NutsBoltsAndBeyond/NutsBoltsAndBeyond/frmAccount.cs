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
    public partial class frmAccount : Form
    {
        public frmAccount()
        {
            InitializeComponent();
        }

        DataTable dt;
        String username, password, confirm, email;

        private void dgvAccount_SelectionChanged(object sender, EventArgs e)
        {
            int selected = dgvAccount.CurrentCell.RowIndex;

            DataGridViewRow row = dgvAccount.Rows[selected];

            lblViewUsername.Text = row.Cells[3].Value.ToString();
            lblViewPassword.Text = row.Cells[4].Value.ToString();
            lblViewEmail.Text = row.Cells[6].Value.ToString();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            username = tbxUsername.Text;
            password = tbxPassword.Text;
            email = tbxEmail.Text;
            confirm = tbxConfirm.Text;

            // wanna try something
            bool unameCheck = username == lblViewUsername.Text;
            bool emailCheck = email == lblViewEmail.Text;
            bool passCheck = password == lblViewPassword.Text;
            bool conf = confirm == ProgOps.currentUser.Password;

            if (unameCheck || emailCheck || passCheck)
            {
                MessageBox.Show("Duplicate data. Please check your information and try again.", "Duplicate Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (String.IsNullOrEmpty(confirm))
            {
                MessageBox.Show("To change information, please enter your password", "Enter your password", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (conf)
                {
                    DialogResult dialogResult = MessageBox.Show("Are you sure you want to update this information?", "Are you sure?", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        int selected = dgvAccount.CurrentCell.RowIndex;

                        DataGridViewRow row = dgvAccount.Rows[selected];

                        ProgOps.resetUser.ID = Int32.Parse(row.Cells[0].Value.ToString());
                        ProgOps.resetUser.Fname = row.Cells[1].Value.ToString();
                        ProgOps.resetUser.Lname = row.Cells[2].Value.ToString();

                        if (String.IsNullOrEmpty(tbxUsername.Text))
                        {
                            ProgOps.resetUser.Username = row.Cells[3].Value.ToString();
                        }
                        else
                        {
                            ProgOps.resetUser.Username = username;
                        }

                        if (String.IsNullOrEmpty(tbxPassword.Text))
                        {
                            ProgOps.resetUser.Password = row.Cells[4].Value.ToString();
                        }
                        else
                        {
                            ProgOps.resetUser.Password = password;
                        }

                        ProgOps.resetUser.Designation = row.Cells[5].Value.ToString();

                        if (String.IsNullOrEmpty(tbxEmail.Text))
                        {
                            ProgOps.resetUser.Email = row.Cells[6].Value.ToString();
                        }
                        else
                        {
                            ProgOps.resetUser.Email = email;
                        }

                        if (ProgOps._updateUser(ProgOps.resetUser))
                        {
                            MessageBox.Show("User information successfully updated", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        
                    }
                }
            }

            tbxUsername.Text = String.Empty;
            tbxPassword.Text = String.Empty;
            tbxEmail.Text = String.Empty;
            tbxConfirm.Text = String.Empty;
            frmAccount_Load(sender, e);
        }

        private void frmAccount_Load(object sender, EventArgs e)
        {
            ProgOps.ConnectDB();
            String query = "SELECT * FROM GROUP1SP212330.USERS";

            switch (ProgOps.currentUser.Designation)
            {
                case "Customer":
                    query += $" WHERE USERNAME = '{ProgOps.currentUser.Username}';";
                    break;
                case "Employee":
                    query += " WHERE DESIGNATION = 'Customer';";
                    break;
                case "Admin":
                    if (frmAdminMenu.type == "cus")
                        query += " WHERE DESIGNATION = 'Customer';";
                    else if (frmAdminMenu.type == "emp")
                        query += " WHERE DESIGNATION != 'Customer';";
                    else
                        query += ";";
                    break;
                default:
                    break;
            }

            dt = new DataTable();

            ProgOps._daRes = new SqlDataAdapter(query, ProgOps._dbConnect);
            ProgOps._daRes.Fill(dt);

            ProgOps.CloseDB();

            dgvAccount.DataSource = dt;

            DataGridViewRow row = dgvAccount.Rows[0];

            lblViewUsername.Text = row.Cells[3].Value.ToString();
            lblViewPassword.Text = row.Cells[4].Value.ToString();
            lblViewEmail.Text = row.Cells[6].Value.ToString();

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            switch (ProgOps.currentUser.Designation)
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
    }
}

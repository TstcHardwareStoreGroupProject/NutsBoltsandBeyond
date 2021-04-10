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
    public partial class frmSignup : Form
    {
        public frmSignup()
        {
            InitializeComponent();
            ProgOps.ConnectDB();
        }

        DataTable dt;
        // will need to add admin code to prevent non-admin/employees 
        String firstName, lastName, password, cfmPW, username, designation;

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            username = tbxUsername.Text;
            firstName = tbxFName.Text;
            lastName = tbxLName.Text;
            password = tbxPassword.Text;
            cfmPW = tbxCfmPW.Text;
            designation = cbxDesig.GetItemText(cbxDesig.SelectedItem);


            bool userExist = false;

            if (username == String.Empty || firstName == String.Empty
               || lastName == String.Empty || password == String.Empty || cfmPW == String.Empty)
            {
                MessageBox.Show("All data is required to complete user accounts", "Incomplete Fields", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                SetDefaults();
            }
            else if (password != cfmPW)
            {
                MessageBox.Show("Passwords do not match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                SetDefaults();
            }
            else
            {
                foreach (DataRow dr in dt.Rows)
                {
                    if (dr["USERNAME"].ToString() == username)
                    {
                        MessageBox.Show("This account already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        SetDefaults();
                        userExist = true;
                    }
                }
            }

            if (userExist == false)
            {
                int id = 0;
                ProgOps._saveUser(id, firstName, lastName, username, password, designation);
                ProgOps.CloseDB();
                SetDefaults();
                MessageBox.Show("Account Created Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                // close Form
                frmLogin login = new frmLogin();
                login.Show();
                this.Close();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.Show();
            this.Close();
        }

        private void frmSignup_Load(object sender, EventArgs e)
        {
            // loads datatable on load; Query will be global on normalization
            String query = "SELECT * FROM GROUP1SP212330.USERS";
            dt = new DataTable();

            //TODO: Rigged for data normalization... to be fixed...
            ProgOps._daRes = new SqlDataAdapter(query, ProgOps._dbConnect);
            ProgOps._daRes.Fill(dt);

            ProgOps.CloseDB();

            cbxDesig.SelectedItem = "Customer";
        }

        private void SetDefaults()
        {
            tbxUsername.Text = String.Empty;
            tbxFName.Text = String.Empty;
            tbxLName.Text = String.Empty;
            tbxPassword.Text = String.Empty;
            tbxCfmPW.Text = String.Empty;
            cbxDesig.SelectedItem = "Customer";
        }
    }
}

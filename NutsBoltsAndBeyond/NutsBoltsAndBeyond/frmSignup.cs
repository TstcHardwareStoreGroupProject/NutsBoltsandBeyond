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
        String cfmPW, adminCode;
        Models.UserModel newUser;

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            Help.ShowPopup(tbxCode, "This code would be emailed to you before you can create an account. \nFor the purposes of this assignment, Employee = emp and Admin = admin", new Point(tbxCode.Right, tbxCode.Bottom));
            newUser = new Models.UserModel();
            newUser.Username = tbxUsername.Text;
            newUser.Fname = tbxFName.Text;
            newUser.Lname = tbxLName.Text;
            newUser.Password = tbxPassword.Text;
            cfmPW = tbxCfmPW.Text;
            newUser.Email = tbxEmail.Text;
            newUser.Designation = cbxDesig.GetItemText(cbxDesig.SelectedItem);
            adminCode = tbxCode.Text;

            bool userExist = false;

            if (newUser.Username == String.Empty || newUser.Fname == String.Empty || 
                newUser.Lname == String.Empty || newUser.Password == String.Empty || 
               cfmPW == String.Empty || newUser.Email == String.Empty)
            {
                MessageBox.Show("All data is required to complete user accounts", "Incomplete Fields", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                SetDefaults();
                return;
            }
            else if (newUser.Password != cfmPW)
            {
                MessageBox.Show("Passwords do not match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                SetDefaults();
                return;
            }
            else if (newUser.Designation != "Customer")
            {
                if (newUser.Designation == "Admin" && adminCode != "admin")
                {
                    MessageBox.Show("Admin code invalid. If you feel this is an error, Please contact your supervisor", "Admin code invalid", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    SetDefaults();
                    return;
                }
                else if (newUser.Designation == "Employee" && adminCode != "emp")
                {
                    MessageBox.Show("Admin code invalid. If you feel this is an error, Please contact your supervisor", "Admin code invalid", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    SetDefaults();
                    return;
                }
            }
            else
            {
                foreach (DataRow dr in dt.Rows)
                {
                    if (dr["USERNAME"].ToString() == newUser.Username)
                    {
                        MessageBox.Show("This account already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        SetDefaults();
                        userExist = true;
                    }
                }
            }

            if (userExist == false)
            {
                ProgOps._saveUser(newUser);
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
            tbxCode.Text = String.Empty;
            tbxEmail.Text = String.Empty;
        }
    }
}

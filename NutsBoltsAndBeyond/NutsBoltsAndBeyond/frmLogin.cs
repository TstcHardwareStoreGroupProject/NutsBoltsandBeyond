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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            ProgOps.ConnectDB();
        }

        DataTable dt;
        public static String firstName, lastName;
        String username, password, access;

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            frmSignup signup = new frmSignup();
            signup.Show();
            this.Hide();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            frmReset reset = new frmReset();
            reset.Show();
            this.Hide();
        }

        public bool flag = false;

        private void btnLogin_Click(object sender, EventArgs e)
        {
            username = tbxUsername.Text;
            password = tbxPassword.Text;

            if (username == String.Empty || password == String.Empty)
            {
                MessageBox.Show("Username and Password are required", "Incomplete Fields", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                if (dt != null)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        if (dr["USERNAME"].ToString() != username)
                        {
                            continue;
                        }
                        else
                        {
                            //Determine access level; access determines menu type to load
                            access = dr.Field<String>("DESIGNATION") != null ? dr.Field<String>("DESIGNATION") : String.Empty;
                            String pwCheck = dr.Field<String>("PASSWORD") != null ? dr.Field<String>("PASSWORD") : String.Empty;
                            String user = dr.Field<String>("FNAME") != null ? dr.Field<String>("FNAME") + " " + dr.Field<String>("LNAME") : String.Empty;

                            //Check credentials against DB
                            if (password == pwCheck)
                            {
                                MessageBox.Show("Welcome to Nuts Bolts and Beyond, " + user, "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                                //Determine form to open based on access level
                                switch (access)
                                {
                                    case "Patron":
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
                            else
                            {
                                MessageBox.Show("Please check your information and try again", "Please try again", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                tbxUsername.Text = String.Empty;
                                tbxPassword.Text = String.Empty;
                            }
                            break;
                        }
                    }
                    if (flag == false)
                    {
                        MessageBox.Show("Please check your information and try again", "Please try again", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        tbxUsername.Text = String.Empty;
                        tbxPassword.Text = String.Empty;
                    }
                    else 
                    {
                        
                    }
                }
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            // loads datatable on load; Query will be global on normalization
            String query = "SELECT * FROM GROUP1SP212330.USERS";
            dt = new DataTable();

            //TODO: Rigged for data normalization... to be fixed...
            ProgOps._daRes = new SqlDataAdapter(query, ProgOps._dbConnect);
            ProgOps._daRes.Fill(dt);

            ProgOps.CloseDB();
        }
    }
}

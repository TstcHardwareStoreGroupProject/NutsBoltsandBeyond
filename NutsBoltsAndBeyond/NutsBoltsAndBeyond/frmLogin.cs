using System;
using System.Data;
using System.Data.SqlClient;
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
        String username, password;

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            frmSignup signup = new frmSignup();
            signup.Show();
            this.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            frmReset reset = new frmReset();
            reset.Show();
            this.Close();
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
                            ProgOps.currentUser.ID = dr.Field<int>("USER_ID");
                            ProgOps.currentUser.Fname = dr.Field<String>("FNAME") != null ? dr.Field<String>("FNAME") : String.Empty;
                            ProgOps.currentUser.Lname = dr.Field<String>("LNAME") != null ? dr.Field<String>("LNAME") : String.Empty;
                            ProgOps.currentUser.Username = dr.Field<String>("USERNAME") != null ? dr.Field<String>("USERNAME") : String.Empty;
                            ProgOps.currentUser.Password = dr.Field<String>("PASSWORD") != null ? dr.Field<String>("PASSWORD") : String.Empty;
                            ProgOps.currentUser.Designation = dr.Field<String>("DESIGNATION") != null ? dr.Field<String>("DESIGNATION") : String.Empty;
                            ProgOps.currentUser.Email = dr.Field<String>("EMAIL") != null ? dr.Field<String>("EMAIL") : String.Empty;

                            String name = ProgOps.currentUser.Fname + " " + ProgOps.currentUser.Lname;

                            //Check credentials against DB
                            if (password == ProgOps.currentUser.Password)
                            {
                                flag = true;
                                MessageBox.Show($"Welcome to Nuts Bolts and Beyond, {name}", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                                //Determine form to open based on access level
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
                            break;
                        }
                    }
                    if (flag == false)
                    {
                        MessageBox.Show("flag: Please check your information and try again", "Please try again", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        tbxUsername.Text = String.Empty;
                        tbxPassword.Text = String.Empty;
                    }
                }
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            // loads datatable on load; Query will be global on normalization
            String query = "SELECT * FROM GROUP1SP212330.USERS";
            dt = new DataTable();

            ProgOps._daRes = new SqlDataAdapter(query, ProgOps._dbConnect);
            ProgOps._daRes.Fill(dt);

            ProgOps.CloseDB();
        }
    }
}

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
    public partial class frmReset : Form
    {
        public frmReset()
        {
            InitializeComponent();
            ProgOps.ConnectDB();
        }

        DataTable dt;
        String username, password, cfmPW;

        private void btnReset_Click(object sender, EventArgs e)
        {
            username = tbxUsername.Text;
            password = tbxPW.Text;
            cfmPW = tbxCfmPW.Text;
            if (username == String.Empty || password == String.Empty || cfmPW == String.Empty)
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
                String firstName, lastName, designation;

                foreach (DataRow dr in dt.Rows)
                {
                    if (dr["USERNAME"].ToString() == username)
                    {
                        int id = Int32.Parse(dr["USER_ID"].ToString());
                        firstName = dr["FNAME"].ToString();
                        lastName = dr["LNAME"].ToString();
                        designation = dr["DESIGNATION"].ToString();

                        if (ProgOps._updateUser(id, firstName, lastName, username, password, designation))
                        {
                            ProgOps.CloseDB();
                            SetDefaults();
                            MessageBox.Show("PASSWORD UPDATED SUCCESSFULLY", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                            // close Form
                            frmLogin login = new frmLogin();
                            login.Show();
                            this.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please check your information and try again", "Please try again", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.Show();
            this.Close();
        }

        private void frmReset_Load(object sender, EventArgs e)
        {
            // loads datatable on load; Query will be global on normalization
            String query = "SELECT * FROM GROUP1SP212330.USERS";
            dt = new DataTable();

            //TODO: Rigged for data normalization... to be fixed...
            ProgOps._daRes = new SqlDataAdapter(query, ProgOps._dbConnect);
            ProgOps._daRes.Fill(dt);

            ProgOps.CloseDB();
        }

        private void SetDefaults()
        {
            tbxUsername.Text = String.Empty;
            tbxPW.Text = String.Empty;
            tbxCfmPW.Text = String.Empty;
        }
    }
}

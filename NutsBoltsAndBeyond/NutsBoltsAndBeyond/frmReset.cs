using System;
using System.Net;
using System.Net.Mail;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace NutsBoltsAndBeyond
{
    public partial class frmReset : Form
    {
        public frmReset()
        {
            InitializeComponent();
            ProgOps.ConnectDB();
            btnReset.Visible = false;
        }

        DataTable dt;
        String uname, email, name;
        
        private void btnReset_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmReset reset = new frmReset();
            reset.Closed += (a, args) => this.Close();
            reset.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin login = new frmLogin();
            login.Closed += (a, args) => this.Close();
            login.Show();
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

        private void btnValidate_Click(object sender, EventArgs e)
        {
            uname = tbxUsername.Text;
            email = tbxEmail.Text;

            if (uname == String.Empty || email == String.Empty)
            {
                MessageBox.Show("Please enter your Username and Email to reset", "Incomplete Fields", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                SetDefaults();
            }
            else
            {
                Boolean flag = false;
                foreach (DataRow dr in dt.Rows)
                {
                    if (dr["EMAIL"].ToString() == email)
                    {
                        if (dr["USERNAME"].ToString() == uname) 
                        {
                            ProgOps.resetUser.ID = dr.Field<int>("USER_ID");
                            ProgOps.resetUser.Fname = dr.Field<String>("FNAME") != null ? dr.Field<String>("FNAME") : String.Empty;
                            ProgOps.resetUser.Lname = dr.Field<String>("LNAME") != null ? dr.Field<String>("LNAME") : String.Empty;
                            ProgOps.resetUser.Username = dr.Field<String>("USERNAME") != null ? dr.Field<String>("USERNAME") : String.Empty;
                            ProgOps.resetUser.Password = dr.Field<String>("PASSWORD") != null ? dr.Field<String>("PASSWORD") : String.Empty;
                            ProgOps.resetUser.Designation = dr.Field<String>("DESIGNATION") != null ? dr.Field<String>("DESIGNATION") : String.Empty;
                            ProgOps.resetUser.Email = dr.Field<String>("EMAIL") != null ? dr.Field<String>("EMAIL") : String.Empty;
                            
                            name = ProgOps.resetUser.Fname + " " + ProgOps.resetUser.Lname;

                            Utils.rng = Convert.ToString(Utils._IDGenerator());

                            MailMessage mailMessage = new MailMessage();

                            String messageBody = $"Hello, {name}! \nThanks for using Nuts Bolts and Beyond \n\nYour reset code is " + Utils.rng;
                            String from = "admin@nbb.com";

                            mailMessage.To.Add(email);
                            mailMessage.From = new MailAddress(from);
                            mailMessage.Body = messageBody;
                            mailMessage.Subject = "Nuts Bolts and Beyond Password Reset";

                            var client = new SmtpClient("smtp.mailtrap.io", 2525)
                            {
                                Credentials = new NetworkCredential("079011543e154b", "e6bdb529dfe039"),
                                EnableSsl = true
                            };

                            try
                            {
                                client.Send(mailMessage);
                                MessageBox.Show("You've been emailed a reset code. Bring it back to reset!", "Send Success!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            }
                            catch (SmtpException ex)
                            {
                                throw new ApplicationException
                                    ("SmtpException has occured: " + ex.Message);
                            }
                            catch (Exception ex)
                            {
                                throw ex;
                            }

                            btnReset.Visible = true;
                            btnValidate.Enabled = false;
                            flag = true;
                            SetDefaults();
                        }
                        else
                        {
                            MessageBox.Show("Please check your information and try again", "Information invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            SetDefaults();
                        }
                    }
                }
                if (!flag)
                {
                    MessageBox.Show("Please check your information and try again", "Information invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    SetDefaults();
                }
            }
        }

        private void SetDefaults()
        {
            tbxEmail.Text = String.Empty;
            tbxUsername.Text = String.Empty;
        }
    }
}
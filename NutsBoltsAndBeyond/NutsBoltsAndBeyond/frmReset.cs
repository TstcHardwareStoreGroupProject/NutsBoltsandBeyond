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
        String password, email, name, rng;
        
        private void btnReset_Click(object sender, EventArgs e)
        {

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

        private void btnValidate_Click(object sender, EventArgs e)
        {
            password = tbxPassword.Text;
            email = tbxEmail.Text;
            if (password == String.Empty || email == String.Empty)
            {
                MessageBox.Show("PLEASE ENTER YOUR EMAIL AND PASSWORD TO RESET", "INCOMPLETE FIELDS", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                SetDefaults();
            }
            else
            {
                Boolean flag = false;
                foreach (DataRow dr in dt.Rows)
                {
                    if (dr["EMAIL"].ToString() == email)
                    {
                        if (dr["PASSWORD"].ToString() == password) 
                        {
                            name = dr.Field<String>("FNAME") != null ? dr.Field<String>("FNAME") + " " + dr.Field<String>("LNAME") : String.Empty;

                            rng = Convert.ToString(Utils._IDGenerator());

                            MailMessage mailMessage = new MailMessage();

                            String messageBody = $"Hello, {name}! \nThanks for using Nuts, Bolts, and Beyond \n\nYour reset code is " + rng;
                            String from = "admin@nbb.com";

                            mailMessage.To.Add(email);
                            mailMessage.From = new MailAddress(from);
                            mailMessage.Body = messageBody;
                            mailMessage.Subject = "Nuts, Bolts, and Beyond Password Reset";

                            var client = new SmtpClient("smtp.mailtrap.io", 2525)
                            {
                                Credentials = new NetworkCredential("079011543e154b", "e6bdb529dfe039"),
                                EnableSsl = true
                            };

                            try
                            {
                                client.Send(mailMessage);
                                MessageBox.Show("GET YOUR RESET CODE AND COME BACK TO RESET", "SEND SUCCESS!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
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
                            MessageBox.Show("PLEASE CHECK YOUR INFORMATION AND TRY AGAIN", "PLEASE TRY AGAIN", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                if (!flag)
                {
                    MessageBox.Show("PLEASE CHECK YOUR INFORMATION AND TRY AGAIN", "PLEASE TRY AGAIN", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    SetDefaults();
                }
            }
        }

        private void SetDefaults()
        {
            tbxEmail.Text = String.Empty;
            tbxPassword.Text = String.Empty;
        }
    }
}
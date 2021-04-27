using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NutsBoltsAndBeyond
{
    public partial class frmInventory : Form
    {
        public frmInventory()
        {
            InitializeComponent();
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

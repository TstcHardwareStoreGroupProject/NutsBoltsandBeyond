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

﻿using System;
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
    public partial class frmAdminMenu : Form
    {
        public frmAdminMenu()
        {
            InitializeComponent();
        }

        private void btnShop_Click(object sender, EventArgs e)
        {
            frmShop shop = new frmShop();
            shop.Show();
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEmp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("COMING SOON", "UNDER CONSTRUCTION", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnCus_Click(object sender, EventArgs e)
        {
            MessageBox.Show("COMING SOON", "UNDER CONSTRUCTION", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            MessageBox.Show("COMING SOON", "UNDER CONSTRUCTION", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
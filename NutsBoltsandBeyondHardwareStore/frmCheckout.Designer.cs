namespace NutsBoltsandBeyondHardwareStore
{
    partial class frmCheckout
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblCart = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbxCustomerOrder = new System.Windows.Forms.ListBox();
            this.gbxPayment = new System.Windows.Forms.GroupBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblZip = new System.Windows.Forms.Label();
            this.lblCreditCardNo = new System.Windows.Forms.Label();
            this.lblExpirationDate = new System.Windows.Forms.Label();
            this.lblCCV = new System.Windows.Forms.Label();
            this.tbxFirstName = new System.Windows.Forms.TextBox();
            this.tbxLastName = new System.Windows.Forms.TextBox();
            this.tbxAddress = new System.Windows.Forms.TextBox();
            this.tbxCity = new System.Windows.Forms.TextBox();
            this.tbxState = new System.Windows.Forms.TextBox();
            this.tbxZip = new System.Windows.Forms.TextBox();
            this.tbxCreditCardNo = new System.Windows.Forms.TextBox();
            this.tbxExpirationDate = new System.Windows.Forms.TextBox();
            this.tbxCCV = new System.Windows.Forms.TextBox();
            this.lblOrderTotal = new System.Windows.Forms.Label();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.gbxPayment.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCart
            // 
            this.lblCart.AutoSize = true;
            this.lblCart.Location = new System.Drawing.Point(12, 58);
            this.lblCart.Name = "lblCart";
            this.lblCart.Size = new System.Drawing.Size(61, 13);
            this.lblCart.TabIndex = 0;
            this.lblCart.Text = "Your Order:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(911, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "&About";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.exitToolStripMenuItem.Text = "E&xit";
            // 
            // lbxCustomerOrder
            // 
            this.lbxCustomerOrder.FormattingEnabled = true;
            this.lbxCustomerOrder.Location = new System.Drawing.Point(15, 74);
            this.lbxCustomerOrder.Name = "lbxCustomerOrder";
            this.lbxCustomerOrder.Size = new System.Drawing.Size(267, 355);
            this.lbxCustomerOrder.TabIndex = 2;
            // 
            // gbxPayment
            // 
            this.gbxPayment.Controls.Add(this.tbxCCV);
            this.gbxPayment.Controls.Add(this.tbxExpirationDate);
            this.gbxPayment.Controls.Add(this.tbxCreditCardNo);
            this.gbxPayment.Controls.Add(this.tbxZip);
            this.gbxPayment.Controls.Add(this.tbxState);
            this.gbxPayment.Controls.Add(this.tbxCity);
            this.gbxPayment.Controls.Add(this.tbxAddress);
            this.gbxPayment.Controls.Add(this.tbxLastName);
            this.gbxPayment.Controls.Add(this.tbxFirstName);
            this.gbxPayment.Controls.Add(this.lblCCV);
            this.gbxPayment.Controls.Add(this.lblExpirationDate);
            this.gbxPayment.Controls.Add(this.lblCreditCardNo);
            this.gbxPayment.Controls.Add(this.lblZip);
            this.gbxPayment.Controls.Add(this.lblCity);
            this.gbxPayment.Controls.Add(this.lblState);
            this.gbxPayment.Controls.Add(this.lblAddress);
            this.gbxPayment.Controls.Add(this.lblLastName);
            this.gbxPayment.Controls.Add(this.lblFirstName);
            this.gbxPayment.Location = new System.Drawing.Point(307, 58);
            this.gbxPayment.Name = "gbxPayment";
            this.gbxPayment.Size = new System.Drawing.Size(541, 292);
            this.gbxPayment.TabIndex = 3;
            this.gbxPayment.TabStop = false;
            this.gbxPayment.Text = "Payment";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(72, 43);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(60, 13);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "First Name:";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(71, 80);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(61, 13);
            this.lblLastName.TabIndex = 1;
            this.lblLastName.Text = "Last Name:";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(84, 115);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(48, 13);
            this.lblAddress.TabIndex = 2;
            this.lblAddress.Text = "Address:";
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Location = new System.Drawing.Point(97, 182);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(35, 13);
            this.lblState.TabIndex = 3;
            this.lblState.Text = "State:";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(105, 147);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(27, 13);
            this.lblCity.TabIndex = 4;
            this.lblCity.Text = "City:";
            // 
            // lblZip
            // 
            this.lblZip.AutoSize = true;
            this.lblZip.Location = new System.Drawing.Point(311, 47);
            this.lblZip.Name = "lblZip";
            this.lblZip.Size = new System.Drawing.Size(53, 13);
            this.lblZip.TabIndex = 5;
            this.lblZip.Text = "Zip Code:";
            // 
            // lblCreditCardNo
            // 
            this.lblCreditCardNo.AutoSize = true;
            this.lblCreditCardNo.Location = new System.Drawing.Point(262, 85);
            this.lblCreditCardNo.Name = "lblCreditCardNo";
            this.lblCreditCardNo.Size = new System.Drawing.Size(102, 13);
            this.lblCreditCardNo.TabIndex = 6;
            this.lblCreditCardNo.Text = "Credit Card Number:\r\n";
            // 
            // lblExpirationDate
            // 
            this.lblExpirationDate.AutoSize = true;
            this.lblExpirationDate.Location = new System.Drawing.Point(282, 124);
            this.lblExpirationDate.Name = "lblExpirationDate";
            this.lblExpirationDate.Size = new System.Drawing.Size(82, 13);
            this.lblExpirationDate.TabIndex = 7;
            this.lblExpirationDate.Text = "Expiration Date:";
            // 
            // lblCCV
            // 
            this.lblCCV.AutoSize = true;
            this.lblCCV.Location = new System.Drawing.Point(316, 160);
            this.lblCCV.Name = "lblCCV";
            this.lblCCV.Size = new System.Drawing.Size(48, 13);
            this.lblCCV.TabIndex = 8;
            this.lblCCV.Text = "CCV No:";
            // 
            // tbxFirstName
            // 
            this.tbxFirstName.Location = new System.Drawing.Point(138, 40);
            this.tbxFirstName.Name = "tbxFirstName";
            this.tbxFirstName.Size = new System.Drawing.Size(100, 20);
            this.tbxFirstName.TabIndex = 9;
            // 
            // tbxLastName
            // 
            this.tbxLastName.Location = new System.Drawing.Point(138, 77);
            this.tbxLastName.Name = "tbxLastName";
            this.tbxLastName.Size = new System.Drawing.Size(100, 20);
            this.tbxLastName.TabIndex = 10;
            // 
            // tbxAddress
            // 
            this.tbxAddress.Location = new System.Drawing.Point(138, 112);
            this.tbxAddress.Name = "tbxAddress";
            this.tbxAddress.Size = new System.Drawing.Size(100, 20);
            this.tbxAddress.TabIndex = 11;
            // 
            // tbxCity
            // 
            this.tbxCity.Location = new System.Drawing.Point(138, 144);
            this.tbxCity.Name = "tbxCity";
            this.tbxCity.Size = new System.Drawing.Size(100, 20);
            this.tbxCity.TabIndex = 12;
            // 
            // tbxState
            // 
            this.tbxState.Location = new System.Drawing.Point(138, 179);
            this.tbxState.Name = "tbxState";
            this.tbxState.Size = new System.Drawing.Size(100, 20);
            this.tbxState.TabIndex = 13;
            // 
            // tbxZip
            // 
            this.tbxZip.Location = new System.Drawing.Point(370, 44);
            this.tbxZip.Name = "tbxZip";
            this.tbxZip.Size = new System.Drawing.Size(100, 20);
            this.tbxZip.TabIndex = 14;
            // 
            // tbxCreditCardNo
            // 
            this.tbxCreditCardNo.Location = new System.Drawing.Point(370, 82);
            this.tbxCreditCardNo.Name = "tbxCreditCardNo";
            this.tbxCreditCardNo.Size = new System.Drawing.Size(100, 20);
            this.tbxCreditCardNo.TabIndex = 15;
            // 
            // tbxExpirationDate
            // 
            this.tbxExpirationDate.Location = new System.Drawing.Point(370, 121);
            this.tbxExpirationDate.Name = "tbxExpirationDate";
            this.tbxExpirationDate.Size = new System.Drawing.Size(100, 20);
            this.tbxExpirationDate.TabIndex = 16;
            // 
            // tbxCCV
            // 
            this.tbxCCV.Location = new System.Drawing.Point(370, 157);
            this.tbxCCV.Name = "tbxCCV";
            this.tbxCCV.Size = new System.Drawing.Size(100, 20);
            this.tbxCCV.TabIndex = 17;
            // 
            // lblOrderTotal
            // 
            this.lblOrderTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOrderTotal.Location = new System.Drawing.Point(337, 393);
            this.lblOrderTotal.Name = "lblOrderTotal";
            this.lblOrderTotal.Size = new System.Drawing.Size(178, 23);
            this.lblOrderTotal.TabIndex = 4;
            this.lblOrderTotal.Text = "Order Total:";
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.Location = new System.Drawing.Point(544, 393);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(75, 23);
            this.btnCheckOut.TabIndex = 5;
            this.btnCheckOut.Text = "Check Out";
            this.btnCheckOut.UseVisualStyleBackColor = true;
            // 
            // frmCheckout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 460);
            this.ControlBox = false;
            this.Controls.Add(this.btnCheckOut);
            this.Controls.Add(this.lblOrderTotal);
            this.Controls.Add(this.gbxPayment);
            this.Controls.Add(this.lbxCustomerOrder);
            this.Controls.Add(this.lblCart);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmCheckout";
            this.Text = "Checkout";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gbxPayment.ResumeLayout(false);
            this.gbxPayment.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCart;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ListBox lbxCustomerOrder;
        private System.Windows.Forms.GroupBox gbxPayment;
        private System.Windows.Forms.TextBox tbxCCV;
        private System.Windows.Forms.TextBox tbxExpirationDate;
        private System.Windows.Forms.TextBox tbxCreditCardNo;
        private System.Windows.Forms.TextBox tbxZip;
        private System.Windows.Forms.TextBox tbxState;
        private System.Windows.Forms.TextBox tbxCity;
        private System.Windows.Forms.TextBox tbxAddress;
        private System.Windows.Forms.TextBox tbxLastName;
        private System.Windows.Forms.TextBox tbxFirstName;
        private System.Windows.Forms.Label lblCCV;
        private System.Windows.Forms.Label lblExpirationDate;
        private System.Windows.Forms.Label lblCreditCardNo;
        private System.Windows.Forms.Label lblZip;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblOrderTotal;
        private System.Windows.Forms.Button btnCheckOut;
    }
}

namespace NutsBoltsAndBeyond
{
    partial class frmAccount
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
            this.dgvAccount = new System.Windows.Forms.DataGridView();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblViewUsername = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblViewPassword = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblViewEmail = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.gbxConfirm = new System.Windows.Forms.GroupBox();
            this.tbxConfirm = new System.Windows.Forms.TextBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.tbxUsername = new System.Windows.Forms.TextBox();
            this.tbxPassword = new System.Windows.Forms.TextBox();
            this.tbxEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).BeginInit();
            this.gbxConfirm.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvAccount
            // 
            this.dgvAccount.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAccount.Location = new System.Drawing.Point(12, 12);
            this.dgvAccount.Name = "dgvAccount";
            this.dgvAccount.ReadOnly = true;
            this.dgvAccount.Size = new System.Drawing.Size(560, 181);
            this.dgvAccount.TabIndex = 2;
            this.dgvAccount.SelectionChanged += new System.EventHandler(this.dgvAccount_SelectionChanged);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(472, 326);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(100, 23);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "&MAIN MENU";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblViewUsername
            // 
            this.lblViewUsername.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblViewUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblViewUsername.Location = new System.Drawing.Point(82, 222);
            this.lblViewUsername.Name = "lblViewUsername";
            this.lblViewUsername.Size = new System.Drawing.Size(140, 20);
            this.lblViewUsername.TabIndex = 9;
            this.lblViewUsername.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(9, 228);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(66, 14);
            this.lblUsername.TabIndex = 8;
            this.lblUsername.Text = "USERNAME:";
            // 
            // lblViewPassword
            // 
            this.lblViewPassword.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblViewPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblViewPassword.Location = new System.Drawing.Point(82, 257);
            this.lblViewPassword.Name = "lblViewPassword";
            this.lblViewPassword.Size = new System.Drawing.Size(140, 20);
            this.lblViewPassword.TabIndex = 11;
            this.lblViewPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(6, 263);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(69, 14);
            this.lblPassword.TabIndex = 10;
            this.lblPassword.Text = "PASSWORD:";
            // 
            // lblViewEmail
            // 
            this.lblViewEmail.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblViewEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblViewEmail.Location = new System.Drawing.Point(82, 293);
            this.lblViewEmail.Name = "lblViewEmail";
            this.lblViewEmail.Size = new System.Drawing.Size(140, 20);
            this.lblViewEmail.TabIndex = 13;
            this.lblViewEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(35, 299);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(40, 14);
            this.lblEmail.TabIndex = 12;
            this.lblEmail.Text = "EMAIL:";
            // 
            // gbxConfirm
            // 
            this.gbxConfirm.Controls.Add(this.tbxConfirm);
            this.gbxConfirm.Controls.Add(this.btnConfirm);
            this.gbxConfirm.Font = new System.Drawing.Font("Arial", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxConfirm.Location = new System.Drawing.Point(430, 220);
            this.gbxConfirm.Name = "gbxConfirm";
            this.gbxConfirm.Size = new System.Drawing.Size(142, 100);
            this.gbxConfirm.TabIndex = 14;
            this.gbxConfirm.TabStop = false;
            this.gbxConfirm.Text = "ENTER PASSWORD TO CONFIRM";
            // 
            // tbxConfirm
            // 
            this.tbxConfirm.Location = new System.Drawing.Point(7, 35);
            this.tbxConfirm.Name = "tbxConfirm";
            this.tbxConfirm.PasswordChar = '*';
            this.tbxConfirm.Size = new System.Drawing.Size(129, 17);
            this.tbxConfirm.TabIndex = 15;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(25, 67);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(100, 23);
            this.btnConfirm.TabIndex = 6;
            this.btnConfirm.Text = "&CHANGE INFO";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // tbxUsername
            // 
            this.tbxUsername.Location = new System.Drawing.Point(237, 222);
            this.tbxUsername.Name = "tbxUsername";
            this.tbxUsername.Size = new System.Drawing.Size(140, 20);
            this.tbxUsername.TabIndex = 16;
            // 
            // tbxPassword
            // 
            this.tbxPassword.Location = new System.Drawing.Point(237, 257);
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.Size = new System.Drawing.Size(140, 20);
            this.tbxPassword.TabIndex = 17;
            // 
            // tbxEmail
            // 
            this.tbxEmail.Location = new System.Drawing.Point(237, 293);
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Size = new System.Drawing.Size(140, 20);
            this.tbxEmail.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(153, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(284, 14);
            this.label3.TabIndex = 19;
            this.label3.Text = "CLICK \"CHANGE INFO\" TO CHANGE GIVEN INFORMATION";
            // 
            // frmAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbxEmail);
            this.Controls.Add(this.tbxPassword);
            this.Controls.Add(this.tbxUsername);
            this.Controls.Add(this.gbxConfirm);
            this.Controls.Add(this.lblViewEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblViewPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblViewUsername);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dgvAccount);
            this.Font = new System.Drawing.Font("Arial", 8.25F);
            this.Name = "frmAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuts Bolts and Beyond";
            this.Load += new System.EventHandler(this.frmAccount_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).EndInit();
            this.gbxConfirm.ResumeLayout(false);
            this.gbxConfirm.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAccount;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblViewUsername;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblViewPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblViewEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.GroupBox gbxConfirm;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.TextBox tbxConfirm;
        private System.Windows.Forms.TextBox tbxUsername;
        private System.Windows.Forms.TextBox tbxPassword;
        private System.Windows.Forms.TextBox tbxEmail;
        private System.Windows.Forms.Label label3;
    }
}

namespace NutsBoltsAndBeyond
{
    partial class frmMainMenu
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblDesig = new System.Windows.Forms.Label();
            this.btnShop = new System.Windows.Forms.Button();
            this.btnAcct = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(30, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(516, 44);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "NUTS BOLTS AND BEYOND";
            // 
            // lblDesig
            // 
            this.lblDesig.AutoSize = true;
            this.lblDesig.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesig.Location = new System.Drawing.Point(261, 53);
            this.lblDesig.Name = "lblDesig";
            this.lblDesig.Size = new System.Drawing.Size(89, 16);
            this.lblDesig.TabIndex = 5;
            this.lblDesig.Text = "(CUSTOMER)";
            // 
            // btnShop
            // 
            this.btnShop.Location = new System.Drawing.Point(250, 100);
            this.btnShop.Name = "btnShop";
            this.btnShop.Size = new System.Drawing.Size(100, 25);
            this.btnShop.TabIndex = 6;
            this.btnShop.Text = "&SHOP";
            this.btnShop.UseVisualStyleBackColor = true;
            this.btnShop.Click += new System.EventHandler(this.btnShop_Click);
            // 
            // btnAcct
            // 
            this.btnAcct.Location = new System.Drawing.Point(250, 145);
            this.btnAcct.Name = "btnAcct";
            this.btnAcct.Size = new System.Drawing.Size(100, 50);
            this.btnAcct.TabIndex = 7;
            this.btnAcct.Text = "MANAGE &ACCOUNT";
            this.btnAcct.UseVisualStyleBackColor = true;
            this.btnAcct.Click += new System.EventHandler(this.btnAcct_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(472, 324);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 25);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "E&XIT";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAcct);
            this.Controls.Add(this.btnShop);
            this.Controls.Add(this.lblDesig);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmMainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuts Bolts and Beyond";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDesig;
        private System.Windows.Forms.Button btnShop;
        private System.Windows.Forms.Button btnAcct;
        private System.Windows.Forms.Button btnExit;
    }
}


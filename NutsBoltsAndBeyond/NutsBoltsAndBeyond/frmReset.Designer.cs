
namespace NutsBoltsAndBeyond
{
    partial class frmReset
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
            this.lblUsername = new System.Windows.Forms.Label();
            this.tbxUsername = new System.Windows.Forms.TextBox();
            this.lblCfmPW = new System.Windows.Forms.Label();
            this.tbxCfmPW = new System.Windows.Forms.TextBox();
            this.lblPW = new System.Windows.Forms.Label();
            this.tbxPW = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(27, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(516, 44);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "NUTS BOLTS AND BEYOND";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(144, 91);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(101, 14);
            this.lblUsername.TabIndex = 7;
            this.lblUsername.Text = "ENTER USERNAME:";
            // 
            // tbxUsername
            // 
            this.tbxUsername.Location = new System.Drawing.Point(251, 85);
            this.tbxUsername.Name = "tbxUsername";
            this.tbxUsername.Size = new System.Drawing.Size(180, 20);
            this.tbxUsername.TabIndex = 6;
            // 
            // lblCfmPW
            // 
            this.lblCfmPW.AutoSize = true;
            this.lblCfmPW.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCfmPW.Location = new System.Drawing.Point(128, 157);
            this.lblCfmPW.Name = "lblCfmPW";
            this.lblCfmPW.Size = new System.Drawing.Size(117, 14);
            this.lblCfmPW.TabIndex = 9;
            this.lblCfmPW.Text = "CONFIRM PASSWORD:";
            // 
            // tbxCfmPW
            // 
            this.tbxCfmPW.Location = new System.Drawing.Point(251, 151);
            this.tbxCfmPW.Name = "tbxCfmPW";
            this.tbxCfmPW.Size = new System.Drawing.Size(180, 20);
            this.tbxCfmPW.TabIndex = 8;
            // 
            // lblPW
            // 
            this.lblPW.AutoSize = true;
            this.lblPW.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPW.Location = new System.Drawing.Point(150, 131);
            this.lblPW.Name = "lblPW";
            this.lblPW.Size = new System.Drawing.Size(95, 14);
            this.lblPW.TabIndex = 11;
            this.lblPW.Text = "NEW PASSWORD:";
            // 
            // tbxPW
            // 
            this.tbxPW.Location = new System.Drawing.Point(251, 125);
            this.tbxPW.Name = "tbxPW";
            this.tbxPW.Size = new System.Drawing.Size(180, 20);
            this.tbxPW.TabIndex = 10;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(472, 326);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(100, 23);
            this.btnBack.TabIndex = 17;
            this.btnBack.Text = "&GO BACK";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(251, 198);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(100, 43);
            this.btnReset.TabIndex = 18;
            this.btnReset.Text = "&RESET PASSWORD";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // frmReset
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblPW);
            this.Controls.Add(this.tbxPW);
            this.Controls.Add(this.lblCfmPW);
            this.Controls.Add(this.tbxCfmPW);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.tbxUsername);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmReset";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuts Bolts and Beyond";
            this.Load += new System.EventHandler(this.frmReset_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox tbxUsername;
        private System.Windows.Forms.Label lblCfmPW;
        private System.Windows.Forms.TextBox tbxCfmPW;
        private System.Windows.Forms.Label lblPW;
        private System.Windows.Forms.TextBox tbxPW;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnReset;
    }
}
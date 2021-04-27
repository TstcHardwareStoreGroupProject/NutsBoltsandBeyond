
namespace NutsBoltsAndBeyond
{
    partial class frmToReset
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
            this.lblPassword = new System.Windows.Forms.Label();
            this.tbxPassword = new System.Windows.Forms.TextBox();
            this.tbxConfirm = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.tbxResetCode = new System.Windows.Forms.TextBox();
            this.lblResetCode = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(41, 27);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(516, 44);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "NUTS BOLTS AND BEYOND";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(259, 138);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(69, 14);
            this.lblPassword.TabIndex = 5;
            this.lblPassword.Text = "PASSWORD:";
            // 
            // tbxPassword
            // 
            this.tbxPassword.Location = new System.Drawing.Point(202, 155);
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.Size = new System.Drawing.Size(180, 20);
            this.tbxPassword.TabIndex = 6;
            // 
            // tbxConfirm
            // 
            this.tbxConfirm.Location = new System.Drawing.Point(202, 195);
            this.tbxConfirm.Name = "tbxConfirm";
            this.tbxConfirm.Size = new System.Drawing.Size(180, 20);
            this.tbxConfirm.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(236, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 14);
            this.label1.TabIndex = 7;
            this.label1.Text = "CONFIRM PASSWORD:";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(244, 246);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(100, 50);
            this.btnReset.TabIndex = 19;
            this.btnReset.Text = "&RESET PASSWORD";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // tbxResetCode
            // 
            this.tbxResetCode.Location = new System.Drawing.Point(202, 115);
            this.tbxResetCode.Name = "tbxResetCode";
            this.tbxResetCode.Size = new System.Drawing.Size(180, 20);
            this.tbxResetCode.TabIndex = 21;
            // 
            // lblResetCode
            // 
            this.lblResetCode.AutoSize = true;
            this.lblResetCode.Location = new System.Drawing.Point(234, 98);
            this.lblResetCode.Name = "lblResetCode";
            this.lblResetCode.Size = new System.Drawing.Size(119, 14);
            this.lblResetCode.TabIndex = 20;
            this.lblResetCode.Text = "EMAILED RESET CODE:";
            // 
            // frmToReset
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.tbxResetCode);
            this.Controls.Add(this.lblResetCode);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.tbxConfirm);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Arial", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmToReset";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuts Bolts and Beyond";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox tbxPassword;
        private System.Windows.Forms.TextBox tbxConfirm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.TextBox tbxResetCode;
        private System.Windows.Forms.Label lblResetCode;
    }
}
namespace NutsBoltsandBeyondHardwareStore
{
    partial class frmCustomerMainMenu
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
            this.btnPlaceOrder = new System.Windows.Forms.Button();
            this.btnAccountInfo = new System.Windows.Forms.Button();
            this.btnContactUs = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPlaceOrder
            // 
            this.btnPlaceOrder.Location = new System.Drawing.Point(33, 26);
            this.btnPlaceOrder.Name = "btnPlaceOrder";
            this.btnPlaceOrder.Size = new System.Drawing.Size(147, 23);
            this.btnPlaceOrder.TabIndex = 0;
            this.btnPlaceOrder.Text = "&Place An Order";
            this.btnPlaceOrder.UseVisualStyleBackColor = true;
            // 
            // btnAccountInfo
            // 
            this.btnAccountInfo.Location = new System.Drawing.Point(33, 69);
            this.btnAccountInfo.Name = "btnAccountInfo";
            this.btnAccountInfo.Size = new System.Drawing.Size(147, 23);
            this.btnAccountInfo.TabIndex = 1;
            this.btnAccountInfo.Text = "Manage &Account Info";
            this.btnAccountInfo.UseVisualStyleBackColor = true;
            // 
            // btnContactUs
            // 
            this.btnContactUs.Location = new System.Drawing.Point(33, 112);
            this.btnContactUs.Name = "btnContactUs";
            this.btnContactUs.Size = new System.Drawing.Size(147, 23);
            this.btnContactUs.TabIndex = 2;
            this.btnContactUs.Text = "&Contact Us";
            this.btnContactUs.UseVisualStyleBackColor = true;
            // 
            // frmCustomerMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(217, 158);
            this.ControlBox = false;
            this.Controls.Add(this.btnContactUs);
            this.Controls.Add(this.btnAccountInfo);
            this.Controls.Add(this.btnPlaceOrder);
            this.Name = "frmCustomerMainMenu";
            this.Text = "Customer Main Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPlaceOrder;
        private System.Windows.Forms.Button btnAccountInfo;
        private System.Windows.Forms.Button btnContactUs;
    }
}
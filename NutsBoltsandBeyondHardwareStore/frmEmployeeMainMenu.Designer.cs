namespace NutsBoltsandBeyondHardwareStore
{
    partial class frmEmployeeMainMenu
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
            this.btnOrderProducts = new System.Windows.Forms.Button();
            this.btnInventory = new System.Windows.Forms.Button();
            this.btnManageEmployees = new System.Windows.Forms.Button();
            this.lblEmployeeOptions = new System.Windows.Forms.Label();
            this.lblManagerOptions = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOrderProducts
            // 
            this.btnOrderProducts.Location = new System.Drawing.Point(87, 127);
            this.btnOrderProducts.Name = "btnOrderProducts";
            this.btnOrderProducts.Size = new System.Drawing.Size(120, 23);
            this.btnOrderProducts.TabIndex = 0;
            this.btnOrderProducts.Text = "Order Products";
            this.btnOrderProducts.UseVisualStyleBackColor = true;
            // 
            // btnInventory
            // 
            this.btnInventory.Location = new System.Drawing.Point(87, 98);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Size = new System.Drawing.Size(120, 23);
            this.btnInventory.TabIndex = 1;
            this.btnInventory.Text = "Inventory";
            this.btnInventory.UseVisualStyleBackColor = true;
            // 
            // btnManageEmployees
            // 
            this.btnManageEmployees.Location = new System.Drawing.Point(87, 232);
            this.btnManageEmployees.Name = "btnManageEmployees";
            this.btnManageEmployees.Size = new System.Drawing.Size(120, 23);
            this.btnManageEmployees.TabIndex = 2;
            this.btnManageEmployees.Text = "Manage Employees";
            this.btnManageEmployees.UseVisualStyleBackColor = true;
            // 
            // lblEmployeeOptions
            // 
            this.lblEmployeeOptions.AutoSize = true;
            this.lblEmployeeOptions.Location = new System.Drawing.Point(84, 82);
            this.lblEmployeeOptions.Name = "lblEmployeeOptions";
            this.lblEmployeeOptions.Size = new System.Drawing.Size(95, 13);
            this.lblEmployeeOptions.TabIndex = 3;
            this.lblEmployeeOptions.Text = "Employee Options:\r\n";
            // 
            // lblManagerOptions
            // 
            this.lblManagerOptions.AutoSize = true;
            this.lblManagerOptions.Location = new System.Drawing.Point(84, 216);
            this.lblManagerOptions.Name = "lblManagerOptions";
            this.lblManagerOptions.Size = new System.Drawing.Size(91, 13);
            this.lblManagerOptions.TabIndex = 4;
            this.lblManagerOptions.Text = "Manager Options:";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(104, 321);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // frmEmployeeMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 388);
            this.ControlBox = false;
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblManagerOptions);
            this.Controls.Add(this.lblEmployeeOptions);
            this.Controls.Add(this.btnManageEmployees);
            this.Controls.Add(this.btnInventory);
            this.Controls.Add(this.btnOrderProducts);
            this.Name = "frmEmployeeMainMenu";
            this.Text = "Employee Main Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOrderProducts;
        private System.Windows.Forms.Button btnInventory;
        private System.Windows.Forms.Button btnManageEmployees;
        private System.Windows.Forms.Label lblEmployeeOptions;
        private System.Windows.Forms.Label lblManagerOptions;
        private System.Windows.Forms.Button btnBack;
    }
}
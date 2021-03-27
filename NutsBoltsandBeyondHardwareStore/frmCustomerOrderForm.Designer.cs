namespace NutsBoltsandBeyondHardwareStore
{
    partial class frmCustomerOrderForm
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
            this.dgvListofProducts = new System.Windows.Forms.DataGridView();
            this.btnAddToOrder = new System.Windows.Forms.Button();
            this.btnRemoveFromOrder = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListofProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListofProducts
            // 
            this.dgvListofProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListofProducts.Location = new System.Drawing.Point(12, 12);
            this.dgvListofProducts.Name = "dgvListofProducts";
            this.dgvListofProducts.Size = new System.Drawing.Size(776, 210);
            this.dgvListofProducts.TabIndex = 0;
            // 
            // btnAddToOrder
            // 
            this.btnAddToOrder.Location = new System.Drawing.Point(318, 277);
            this.btnAddToOrder.Name = "btnAddToOrder";
            this.btnAddToOrder.Size = new System.Drawing.Size(116, 23);
            this.btnAddToOrder.TabIndex = 1;
            this.btnAddToOrder.Text = "Add to Order";
            this.btnAddToOrder.UseVisualStyleBackColor = true;
            // 
            // btnRemoveFromOrder
            // 
            this.btnRemoveFromOrder.Location = new System.Drawing.Point(318, 306);
            this.btnRemoveFromOrder.Name = "btnRemoveFromOrder";
            this.btnRemoveFromOrder.Size = new System.Drawing.Size(116, 23);
            this.btnRemoveFromOrder.TabIndex = 2;
            this.btnRemoveFromOrder.Text = "Remove from Order";
            this.btnRemoveFromOrder.UseVisualStyleBackColor = true;
            // 
            // frmCustomerOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 493);
            this.Controls.Add(this.btnRemoveFromOrder);
            this.Controls.Add(this.btnAddToOrder);
            this.Controls.Add(this.dgvListofProducts);
            this.Name = "frmCustomerOrderForm";
            this.Text = "frmCustomerOrderForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListofProducts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListofProducts;
        private System.Windows.Forms.Button btnAddToOrder;
        private System.Windows.Forms.Button btnRemoveFromOrder;
    }
}
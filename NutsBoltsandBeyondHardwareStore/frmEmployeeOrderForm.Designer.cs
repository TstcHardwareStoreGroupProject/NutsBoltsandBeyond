namespace NutsBoltsandBeyondHardwareStore
{
    partial class frmEmployeeOrderForm
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
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblUPC = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.gbxOrder = new System.Windows.Forms.GroupBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lbxOrderList = new System.Windows.Forms.ListBox();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.gbxOrder.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(3, 37);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(78, 13);
            this.lblProductName.TabIndex = 2;
            this.lblProductName.Text = "Product Name:";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(3, 63);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(63, 13);
            this.lblDescription.TabIndex = 3;
            this.lblDescription.Text = "Description:";
            // 
            // lblUPC
            // 
            this.lblUPC.AutoSize = true;
            this.lblUPC.Location = new System.Drawing.Point(3, 89);
            this.lblUPC.Name = "lblUPC";
            this.lblUPC.Size = new System.Drawing.Size(32, 13);
            this.lblUPC.TabIndex = 4;
            this.lblUPC.Text = "UPC:";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(3, 118);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(49, 13);
            this.lblQuantity.TabIndex = 5;
            this.lblQuantity.Text = "Quantity:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(103, 37);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(195, 20);
            this.textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(103, 63);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(195, 20);
            this.textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(103, 89);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(195, 20);
            this.textBox3.TabIndex = 8;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(103, 115);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 9;
            // 
            // gbxOrder
            // 
            this.gbxOrder.Controls.Add(this.btnRemove);
            this.gbxOrder.Controls.Add(this.btnAdd);
            this.gbxOrder.Controls.Add(this.textBox1);
            this.gbxOrder.Controls.Add(this.textBox4);
            this.gbxOrder.Controls.Add(this.lblProductName);
            this.gbxOrder.Controls.Add(this.textBox3);
            this.gbxOrder.Controls.Add(this.lblDescription);
            this.gbxOrder.Controls.Add(this.textBox2);
            this.gbxOrder.Controls.Add(this.lblUPC);
            this.gbxOrder.Controls.Add(this.lblQuantity);
            this.gbxOrder.Location = new System.Drawing.Point(12, 24);
            this.gbxOrder.Name = "gbxOrder";
            this.gbxOrder.Size = new System.Drawing.Size(313, 205);
            this.gbxOrder.TabIndex = 10;
            this.gbxOrder.TabStop = false;
            this.gbxOrder.Text = "Order:";
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(167, 161);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(114, 23);
            this.btnRemove.TabIndex = 11;
            this.btnRemove.Text = "Remove from Order";
            this.btnRemove.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(25, 161);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(114, 23);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add to Order";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // lbxOrderList
            // 
            this.lbxOrderList.FormattingEnabled = true;
            this.lbxOrderList.Location = new System.Drawing.Point(331, 31);
            this.lbxOrderList.Name = "lbxOrderList";
            this.lbxOrderList.Size = new System.Drawing.Size(251, 199);
            this.lbxOrderList.TabIndex = 11;
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(159, 267);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(93, 43);
            this.btnOrder.TabIndex = 12;
            this.btnOrder.Text = "Place Order";
            this.btnOrder.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(331, 267);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(93, 43);
            this.btnBack.TabIndex = 13;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // frmEmployeeOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 358);
            this.ControlBox = false;
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.lbxOrderList);
            this.Controls.Add(this.gbxOrder);
            this.Name = "frmEmployeeOrderForm";
            this.Text = "    ";
            this.Load += new System.EventHandler(this.frmEmployeeOrderForm_Load);
            this.gbxOrder.ResumeLayout(false);
            this.gbxOrder.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblUPC;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.GroupBox gbxOrder;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListBox lbxOrderList;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnBack;
    }
}
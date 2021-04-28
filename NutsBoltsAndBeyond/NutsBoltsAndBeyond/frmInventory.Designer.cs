
namespace NutsBoltsAndBeyond
{
    partial class frmInventory
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
            this.dgvInventory = new System.Windows.Forms.DataGridView();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblViewItem = new System.Windows.Forms.Label();
            this.lblViewPrice = new System.Windows.Forms.Label();
            this.lblViewQuantity = new System.Windows.Forms.Label();
            this.lblViewDpt = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvInventory
            // 
            this.dgvInventory.AllowUserToAddRows = false;
            this.dgvInventory.AllowUserToDeleteRows = false;
            this.dgvInventory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventory.Location = new System.Drawing.Point(12, 12);
            this.dgvInventory.Name = "dgvInventory";
            this.dgvInventory.ReadOnly = true;
            this.dgvInventory.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvInventory.Size = new System.Drawing.Size(560, 200);
            this.dgvInventory.TabIndex = 3;
            this.dgvInventory.SelectionChanged += new System.EventHandler(this.dgvInventory_SelectionChanged);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(472, 326);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(100, 23);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "&MAIN MENU";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(472, 253);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(100, 23);
            this.btnRemove.TabIndex = 14;
            this.btnRemove.Text = "&REMOVE ITEM";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(472, 224);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(100, 23);
            this.btnAddItem.TabIndex = 5;
            this.btnAddItem.Text = "&ADD ITEM";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(213, 225);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 14);
            this.label1.TabIndex = 6;
            this.label1.Text = "ITEM:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(207, 250);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 14);
            this.label2.TabIndex = 7;
            this.label2.Text = "PRICE:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(124, 277);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 14);
            this.label3.TabIndex = 8;
            this.label3.Text = "QUANTITY AVAILABLE:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(170, 303);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 14);
            this.label4.TabIndex = 9;
            this.label4.Text = "DEPARTMENT:";
            // 
            // lblViewItem
            // 
            this.lblViewItem.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblViewItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblViewItem.Location = new System.Drawing.Point(251, 225);
            this.lblViewItem.Name = "lblViewItem";
            this.lblViewItem.Size = new System.Drawing.Size(140, 20);
            this.lblViewItem.TabIndex = 15;
            this.lblViewItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblViewPrice
            // 
            this.lblViewPrice.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblViewPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblViewPrice.Location = new System.Drawing.Point(251, 250);
            this.lblViewPrice.Name = "lblViewPrice";
            this.lblViewPrice.Size = new System.Drawing.Size(140, 20);
            this.lblViewPrice.TabIndex = 16;
            this.lblViewPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblViewQuantity
            // 
            this.lblViewQuantity.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblViewQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblViewQuantity.Location = new System.Drawing.Point(251, 277);
            this.lblViewQuantity.Name = "lblViewQuantity";
            this.lblViewQuantity.Size = new System.Drawing.Size(140, 20);
            this.lblViewQuantity.TabIndex = 17;
            this.lblViewQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblViewDpt
            // 
            this.lblViewDpt.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblViewDpt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblViewDpt.Location = new System.Drawing.Point(251, 303);
            this.lblViewDpt.Name = "lblViewDpt";
            this.lblViewDpt.Size = new System.Drawing.Size(140, 20);
            this.lblViewDpt.TabIndex = 18;
            this.lblViewDpt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.lblViewDpt);
            this.Controls.Add(this.lblViewQuantity);
            this.Controls.Add(this.lblViewPrice);
            this.Controls.Add(this.lblViewItem);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dgvInventory);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmInventory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmInventory";
            this.Load += new System.EventHandler(this.frmInventory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvInventory;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblViewItem;
        private System.Windows.Forms.Label lblViewPrice;
        private System.Windows.Forms.Label lblViewQuantity;
        private System.Windows.Forms.Label lblViewDpt;
    }
}
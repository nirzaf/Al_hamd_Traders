namespace AlHamd_Traders
{
    partial class View_Product_List
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
            this.dgvallproduct = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvallproduct)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvallproduct
            // 
            this.dgvallproduct.AllowUserToAddRows = false;
            this.dgvallproduct.AllowUserToDeleteRows = false;
            this.dgvallproduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvallproduct.Location = new System.Drawing.Point(12, 49);
            this.dgvallproduct.Name = "dgvallproduct";
            this.dgvallproduct.ReadOnly = true;
            this.dgvallproduct.Size = new System.Drawing.Size(950, 460);
            this.dgvallproduct.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(449, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ALL PRODUCTS";
            // 
            // view_product_list
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 521);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvallproduct);
            this.Name = "view_product_list";
            this.Text = "view_product_list";
            this.Load += new System.EventHandler(this.view_product_list_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvallproduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvallproduct;
        private System.Windows.Forms.Label label1;
    }
}
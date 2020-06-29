namespace AlHamd_Traders
{
    partial class Manage_Category
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.dgvsearchcategory = new System.Windows.Forms.DataGridView();
            this.btnaddcategory = new System.Windows.Forms.Button();
            this.btnupdatecategory = new System.Windows.Forms.Button();
            this.btnremovecategory = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvsearchcategory)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(418, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "SEARCH :";
            // 
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(481, 62);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(162, 20);
            this.txtsearch.TabIndex = 1;
            this.txtsearch.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
            // 
            // dgvsearchcategory
            // 
            this.dgvsearchcategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvsearchcategory.Location = new System.Drawing.Point(1, 88);
            this.dgvsearchcategory.Name = "dgvsearchcategory";
            this.dgvsearchcategory.Size = new System.Drawing.Size(653, 235);
            this.dgvsearchcategory.TabIndex = 2;
            // 
            // btnaddcategory
            // 
            this.btnaddcategory.Location = new System.Drawing.Point(12, 329);
            this.btnaddcategory.Name = "btnaddcategory";
            this.btnaddcategory.Size = new System.Drawing.Size(166, 77);
            this.btnaddcategory.TabIndex = 3;
            this.btnaddcategory.Text = "ADD CATEGORY";
            this.btnaddcategory.UseVisualStyleBackColor = true;
            this.btnaddcategory.Click += new System.EventHandler(this.btnaddcategory_Click);
            // 
            // btnupdatecategory
            // 
            this.btnupdatecategory.Location = new System.Drawing.Point(241, 329);
            this.btnupdatecategory.Name = "btnupdatecategory";
            this.btnupdatecategory.Size = new System.Drawing.Size(166, 77);
            this.btnupdatecategory.TabIndex = 4;
            this.btnupdatecategory.Text = "UPDATE CATEGORY";
            this.btnupdatecategory.UseVisualStyleBackColor = true;
            this.btnupdatecategory.Click += new System.EventHandler(this.btnupdatecategory_Click);
            // 
            // btnremovecategory
            // 
            this.btnremovecategory.Location = new System.Drawing.Point(477, 329);
            this.btnremovecategory.Name = "btnremovecategory";
            this.btnremovecategory.Size = new System.Drawing.Size(166, 77);
            this.btnremovecategory.TabIndex = 5;
            this.btnremovecategory.Text = "REMOVE CATEGORY";
            this.btnremovecategory.UseVisualStyleBackColor = true;
            this.btnremovecategory.Click += new System.EventHandler(this.btnremovecategory_Click);
            // 
            // Manage_Category
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 418);
            this.Controls.Add(this.btnremovecategory);
            this.Controls.Add(this.btnupdatecategory);
            this.Controls.Add(this.btnaddcategory);
            this.Controls.Add(this.dgvsearchcategory);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.label1);
            this.Name = "Manage_Category";
            this.Text = "Manage_Category";
            ((System.ComponentModel.ISupportInitialize)(this.dgvsearchcategory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.DataGridView dgvsearchcategory;
        private System.Windows.Forms.Button btnaddcategory;
        private System.Windows.Forms.Button btnupdatecategory;
        private System.Windows.Forms.Button btnremovecategory;
    }
}
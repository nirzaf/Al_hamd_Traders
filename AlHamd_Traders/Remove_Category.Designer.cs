namespace AlHamd_Traders
{
    partial class Remove_Category
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
            this.btndeletecategory = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtcategoryname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtcategoryid = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvdeletecategory = new System.Windows.Forms.DataGridView();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdeletecategory)).BeginInit();
            this.SuspendLayout();
            // 
            // btndeletecategory
            // 
            this.btndeletecategory.Location = new System.Drawing.Point(281, 380);
            this.btndeletecategory.Name = "btndeletecategory";
            this.btndeletecategory.Size = new System.Drawing.Size(225, 91);
            this.btndeletecategory.TabIndex = 0;
            this.btndeletecategory.Text = "DELETE CATEGORY";
            this.btndeletecategory.UseVisualStyleBackColor = true;
            this.btndeletecategory.Click += new System.EventHandler(this.btndeletecategory_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(278, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "DELETE KRNY WALA CODE KRO IDHR YRR";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtcategoryname);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtcategoryid);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(67, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(355, 123);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SELECTED CATEGORY :";
            // 
            // txtcategoryname
            // 
            this.txtcategoryname.Location = new System.Drawing.Point(82, 84);
            this.txtcategoryname.Name = "txtcategoryname";
            this.txtcategoryname.ReadOnly = true;
            this.txtcategoryname.Size = new System.Drawing.Size(260, 20);
            this.txtcategoryname.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(235, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "CATEGORY NAME :";
            // 
            // txtcategoryid
            // 
            this.txtcategoryid.Location = new System.Drawing.Point(81, 36);
            this.txtcategoryid.Name = "txtcategoryid";
            this.txtcategoryid.ReadOnly = true;
            this.txtcategoryid.Size = new System.Drawing.Size(260, 20);
            this.txtcategoryid.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(255, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "CATEGORY ID :";
            // 
            // dgvdeletecategory
            // 
            this.dgvdeletecategory.AllowUserToAddRows = false;
            this.dgvdeletecategory.AllowUserToDeleteRows = false;
            this.dgvdeletecategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdeletecategory.Location = new System.Drawing.Point(55, 167);
            this.dgvdeletecategory.Name = "dgvdeletecategory";
            this.dgvdeletecategory.ReadOnly = true;
            this.dgvdeletecategory.Size = new System.Drawing.Size(644, 180);
            this.dgvdeletecategory.TabIndex = 12;
            this.dgvdeletecategory.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdeletecategory_CellClick);
            // 
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(489, 141);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(210, 20);
            this.txtsearch.TabIndex = 11;
            this.txtsearch.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(486, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "SEARCH :";
            // 
            // Remove_Category
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 492);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvdeletecategory);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btndeletecategory);
            this.Name = "Remove_Category";
            this.Text = "Remove_Category";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdeletecategory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btndeletecategory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtcategoryname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtcategoryid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvdeletecategory;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.Label label2;
    }
}
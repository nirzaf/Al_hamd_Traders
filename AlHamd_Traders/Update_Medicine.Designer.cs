namespace AlHamd_Traders
{
    partial class Update_Medicine
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
            this.lblpid = new System.Windows.Forms.Label();
            this.txtstock = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnclearall = new System.Windows.Forms.Button();
            this.btnupdateproduct = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdounavailable = new System.Windows.Forms.RadioButton();
            this.rdoavailable = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxcategory = new System.Windows.Forms.ComboBox();
            this.txtproductname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtpurchaseprice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtsaleprice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbarcode = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvmanageproducts = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvmanageproducts)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(428, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "PERFORM UPDATION HERE";
            // 
            // lblpid
            // 
            this.lblpid.AutoSize = true;
            this.lblpid.Location = new System.Drawing.Point(127, 44);
            this.lblpid.Name = "lblpid";
            this.lblpid.Size = new System.Drawing.Size(80, 13);
            this.lblpid.TabIndex = 37;
            this.lblpid.Text = "PRODUCT ID :";
            // 
            // txtstock
            // 
            this.txtstock.Location = new System.Drawing.Point(97, 201);
            this.txtstock.Name = "txtstock";
            this.txtstock.Size = new System.Drawing.Size(138, 20);
            this.txtstock.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 201);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 36;
            this.label7.Text = "Stock :";
            // 
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(615, 99);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(226, 20);
            this.txtsearch.TabIndex = 34;
            this.txtsearch.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(496, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 35;
            this.label6.Text = "SEARCH :";
            // 
            // btnclearall
            // 
            this.btnclearall.Location = new System.Drawing.Point(240, 351);
            this.btnclearall.Name = "btnclearall";
            this.btnclearall.Size = new System.Drawing.Size(96, 80);
            this.btnclearall.TabIndex = 32;
            this.btnclearall.Text = "Clear All";
            this.btnclearall.UseVisualStyleBackColor = true;
            this.btnclearall.Click += new System.EventHandler(this.btnclearall_Click);
            // 
            // btnupdateproduct
            // 
            this.btnupdateproduct.Location = new System.Drawing.Point(27, 351);
            this.btnupdateproduct.Name = "btnupdateproduct";
            this.btnupdateproduct.Size = new System.Drawing.Size(208, 80);
            this.btnupdateproduct.TabIndex = 31;
            this.btnupdateproduct.Text = "UPDATE Product";
            this.btnupdateproduct.UseVisualStyleBackColor = true;
            this.btnupdateproduct.Click += new System.EventHandler(this.btnupdateproduct_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdounavailable);
            this.groupBox1.Controls.Add(this.rdoavailable);
            this.groupBox1.Location = new System.Drawing.Point(21, 285);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(304, 63);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // rdounavailable
            // 
            this.rdounavailable.AutoSize = true;
            this.rdounavailable.Location = new System.Drawing.Point(186, 19);
            this.rdounavailable.Name = "rdounavailable";
            this.rdounavailable.Size = new System.Drawing.Size(81, 17);
            this.rdounavailable.TabIndex = 1;
            this.rdounavailable.TabStop = true;
            this.rdounavailable.Text = "Unavailable";
            this.rdounavailable.UseVisualStyleBackColor = true;
            // 
            // rdoavailable
            // 
            this.rdoavailable.AutoSize = true;
            this.rdoavailable.Location = new System.Drawing.Point(6, 19);
            this.rdoavailable.Name = "rdoavailable";
            this.rdoavailable.Size = new System.Drawing.Size(68, 17);
            this.rdoavailable.TabIndex = 0;
            this.rdoavailable.TabStop = true;
            this.rdoavailable.Text = "Available";
            this.rdoavailable.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 33;
            this.label5.Text = "Category :";
            // 
            // cbxcategory
            // 
            this.cbxcategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxcategory.FormattingEnabled = true;
            this.cbxcategory.Items.AddRange(new object[] {
            "sabzi",
            "electrronics",
            "stationary",
            "home",
            "school"});
            this.cbxcategory.Location = new System.Drawing.Point(97, 246);
            this.cbxcategory.Name = "cbxcategory";
            this.cbxcategory.Size = new System.Drawing.Size(138, 21);
            this.cbxcategory.TabIndex = 25;
            // 
            // txtproductname
            // 
            this.txtproductname.Location = new System.Drawing.Point(97, 104);
            this.txtproductname.Name = "txtproductname";
            this.txtproductname.Size = new System.Drawing.Size(138, 20);
            this.txtproductname.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Product Name";
            // 
            // txtpurchaseprice
            // 
            this.txtpurchaseprice.Location = new System.Drawing.Point(97, 139);
            this.txtpurchaseprice.Name = "txtpurchaseprice";
            this.txtpurchaseprice.Size = new System.Drawing.Size(138, 20);
            this.txtpurchaseprice.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Purchase Price";
            // 
            // txtsaleprice
            // 
            this.txtsaleprice.Location = new System.Drawing.Point(97, 165);
            this.txtsaleprice.Name = "txtsaleprice";
            this.txtsaleprice.Size = new System.Drawing.Size(138, 20);
            this.txtsaleprice.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Sale Price";
            // 
            // txtbarcode
            // 
            this.txtbarcode.Location = new System.Drawing.Point(97, 78);
            this.txtbarcode.Name = "txtbarcode";
            this.txtbarcode.Size = new System.Drawing.Size(138, 20);
            this.txtbarcode.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 78);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Barcode";
            // 
            // dgvmanageproducts
            // 
            this.dgvmanageproducts.AllowUserToAddRows = false;
            this.dgvmanageproducts.AllowUserToDeleteRows = false;
            this.dgvmanageproducts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvmanageproducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvmanageproducts.Location = new System.Drawing.Point(385, 139);
            this.dgvmanageproducts.Name = "dgvmanageproducts";
            this.dgvmanageproducts.ReadOnly = true;
            this.dgvmanageproducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvmanageproducts.Size = new System.Drawing.Size(589, 337);
            this.dgvmanageproducts.TabIndex = 30;
            this.dgvmanageproducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvmanageproducts_CellClick);
            // 
            // Update_Medicine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 517);
            this.Controls.Add(this.lblpid);
            this.Controls.Add(this.txtstock);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnclearall);
            this.Controls.Add(this.btnupdateproduct);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbxcategory);
            this.Controls.Add(this.txtproductname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtpurchaseprice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtsaleprice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtbarcode);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dgvmanageproducts);
            this.Controls.Add(this.label1);
            this.Name = "Update_Medicine";
            this.Text = "Update_Medicine";
            this.Load += new System.EventHandler(this.Update_Medicine_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvmanageproducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblpid;
        private System.Windows.Forms.TextBox txtstock;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnclearall;
        private System.Windows.Forms.Button btnupdateproduct;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdounavailable;
        private System.Windows.Forms.RadioButton rdoavailable;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxcategory;
        private System.Windows.Forms.TextBox txtproductname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtpurchaseprice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtsaleprice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbarcode;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgvmanageproducts;
    }
}
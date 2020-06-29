namespace AlHamd_Traders
{
    partial class Add_New_Medicine
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
            this.btnclearall = new System.Windows.Forms.Button();
            this.btnaddproduct = new System.Windows.Forms.Button();
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
            this.dgvmedicine = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvmedicine)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(391, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "jo sir ny add wala sysytenm kraya hy wohi krna hy";
            // 
            // lblpid
            // 
            this.lblpid.AutoSize = true;
            this.lblpid.Location = new System.Drawing.Point(130, 47);
            this.lblpid.Name = "lblpid";
            this.lblpid.Size = new System.Drawing.Size(57, 13);
            this.lblpid.TabIndex = 37;
            this.lblpid.Text = "SEARCH :";
            // 
            // txtstock
            // 
            this.txtstock.Location = new System.Drawing.Point(101, 204);
            this.txtstock.Name = "txtstock";
            this.txtstock.Size = new System.Drawing.Size(137, 20);
            this.txtstock.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 204);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 36;
            this.label7.Text = "Stock :";
            // 
            // btnclearall
            // 
            this.btnclearall.Location = new System.Drawing.Point(244, 354);
            this.btnclearall.Name = "btnclearall";
            this.btnclearall.Size = new System.Drawing.Size(95, 77);
            this.btnclearall.TabIndex = 32;
            this.btnclearall.Text = "Clear All";
            this.btnclearall.UseVisualStyleBackColor = true;
            this.btnclearall.Click += new System.EventHandler(this.btnclearall_Click);
            // 
            // btnaddproduct
            // 
            this.btnaddproduct.Location = new System.Drawing.Point(31, 354);
            this.btnaddproduct.Name = "btnaddproduct";
            this.btnaddproduct.Size = new System.Drawing.Size(186, 77);
            this.btnaddproduct.TabIndex = 28;
            this.btnaddproduct.Text = "ADD Product";
            this.btnaddproduct.UseVisualStyleBackColor = true;
            this.btnaddproduct.Click += new System.EventHandler(this.btnaddproduct_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdounavailable);
            this.groupBox1.Controls.Add(this.rdoavailable);
            this.groupBox1.Location = new System.Drawing.Point(25, 288);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(303, 60);
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
            this.label5.Location = new System.Drawing.Point(22, 249);
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
            this.cbxcategory.Location = new System.Drawing.Point(101, 249);
            this.cbxcategory.Name = "cbxcategory";
            this.cbxcategory.Size = new System.Drawing.Size(137, 21);
            this.cbxcategory.TabIndex = 25;
            // 
            // txtproductname
            // 
            this.txtproductname.Location = new System.Drawing.Point(101, 107);
            this.txtproductname.Name = "txtproductname";
            this.txtproductname.Size = new System.Drawing.Size(137, 20);
            this.txtproductname.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Product Name";
            // 
            // txtpurchaseprice
            // 
            this.txtpurchaseprice.Location = new System.Drawing.Point(101, 142);
            this.txtpurchaseprice.Name = "txtpurchaseprice";
            this.txtpurchaseprice.Size = new System.Drawing.Size(137, 20);
            this.txtpurchaseprice.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Purchase Price";
            // 
            // txtsaleprice
            // 
            this.txtsaleprice.Location = new System.Drawing.Point(101, 168);
            this.txtsaleprice.Name = "txtsaleprice";
            this.txtsaleprice.Size = new System.Drawing.Size(137, 20);
            this.txtsaleprice.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Sale Price";
            // 
            // txtbarcode
            // 
            this.txtbarcode.Location = new System.Drawing.Point(101, 81);
            this.txtbarcode.Name = "txtbarcode";
            this.txtbarcode.Size = new System.Drawing.Size(137, 20);
            this.txtbarcode.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 81);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Barcode";
            // 
            // dgvmedicine
            // 
            this.dgvmedicine.AllowUserToAddRows = false;
            this.dgvmedicine.AllowUserToDeleteRows = false;
            this.dgvmedicine.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvmedicine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvmedicine.Location = new System.Drawing.Point(389, 142);
            this.dgvmedicine.Name = "dgvmedicine";
            this.dgvmedicine.ReadOnly = true;
            this.dgvmedicine.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvmedicine.Size = new System.Drawing.Size(574, 330);
            this.dgvmedicine.TabIndex = 30;
            // 
            // Add_New_Medicine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 519);
            this.Controls.Add(this.lblpid);
            this.Controls.Add(this.txtstock);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnclearall);
            this.Controls.Add(this.btnaddproduct);
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
            this.Controls.Add(this.dgvmedicine);
            this.Controls.Add(this.label1);
            this.Name = "Add_New_Medicine";
            this.Text = "Add_New_Medicine";
            this.Load += new System.EventHandler(this.Add_New_Medicine_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvmedicine)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblpid;
        private System.Windows.Forms.TextBox txtstock;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnclearall;
        private System.Windows.Forms.Button btnaddproduct;
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
        private System.Windows.Forms.DataGridView dgvmedicine;
    }
}
namespace AlHamd_Traders
{
    partial class Sale_Invoice
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
            this.btnsaveprint = new System.Windows.Forms.Button();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dgvsalesinvoice = new System.Windows.Forms.DataGridView();
            this.p_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.p_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtquantity = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtpid = new System.Windows.Forms.TextBox();
            this.txtpstock = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtpprice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtpname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtdatetime = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvsalesinvoice)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnsaveprint
            // 
            this.btnsaveprint.Location = new System.Drawing.Point(643, 403);
            this.btnsaveprint.Name = "btnsaveprint";
            this.btnsaveprint.Size = new System.Drawing.Size(190, 49);
            this.btnsaveprint.TabIndex = 31;
            this.btnsaveprint.Text = "&Save && Print";
            this.btnsaveprint.UseVisualStyleBackColor = true;
            this.btnsaveprint.Click += new System.EventHandler(this.btnsaveprint_Click);
            // 
            // txttotal
            // 
            this.txttotal.Location = new System.Drawing.Point(643, 365);
            this.txttotal.Name = "txttotal";
            this.txttotal.ReadOnly = true;
            this.txttotal.Size = new System.Drawing.Size(190, 20);
            this.txttotal.TabIndex = 30;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(673, 326);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 13);
            this.label9.TabIndex = 29;
            this.label9.Text = "TOTAL :";
            // 
            // dgvsalesinvoice
            // 
            this.dgvsalesinvoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvsalesinvoice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.p_id,
            this.p_name,
            this.price,
            this.qty,
            this.amount});
            this.dgvsalesinvoice.Location = new System.Drawing.Point(67, 281);
            this.dgvsalesinvoice.Name = "dgvsalesinvoice";
            this.dgvsalesinvoice.Size = new System.Drawing.Size(569, 171);
            this.dgvsalesinvoice.TabIndex = 28;
            this.dgvsalesinvoice.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvsalesinvoice_CellEndEdit);
            // 
            // p_id
            // 
            this.p_id.HeaderText = "Product id";
            this.p_id.Name = "p_id";
            this.p_id.ReadOnly = true;
            // 
            // p_name
            // 
            this.p_name.HeaderText = "Product Name";
            this.p_name.Name = "p_name";
            this.p_name.ReadOnly = true;
            // 
            // price
            // 
            this.price.HeaderText = "Price";
            this.price.Name = "price";
            this.price.ReadOnly = true;
            // 
            // qty
            // 
            this.qty.HeaderText = "quantity";
            this.qty.Name = "qty";
            // 
            // amount
            // 
            this.amount.HeaderText = "Amount";
            this.amount.Name = "amount";
            this.amount.ReadOnly = true;
            // 
            // txtquantity
            // 
            this.txtquantity.Location = new System.Drawing.Point(144, 201);
            this.txtquantity.Name = "txtquantity";
            this.txtquantity.Size = new System.Drawing.Size(149, 20);
            this.txtquantity.TabIndex = 27;
            this.txtquantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtquantity_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(64, 204);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "QUANTITY :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtpid);
            this.groupBox1.Controls.Add(this.txtpstock);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtpprice);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtpname);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(485, 136);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(372, 133);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PRODUCT INFO :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "pID :";
            // 
            // txtpid
            // 
            this.txtpid.Location = new System.Drawing.Point(17, 32);
            this.txtpid.Name = "txtpid";
            this.txtpid.ReadOnly = true;
            this.txtpid.Size = new System.Drawing.Size(124, 20);
            this.txtpid.TabIndex = 12;
            // 
            // txtpstock
            // 
            this.txtpstock.Location = new System.Drawing.Point(275, 82);
            this.txtpstock.Name = "txtpstock";
            this.txtpstock.ReadOnly = true;
            this.txtpstock.Size = new System.Drawing.Size(48, 20);
            this.txtpstock.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(264, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "STOCK :";
            // 
            // txtpprice
            // 
            this.txtpprice.Location = new System.Drawing.Point(174, 82);
            this.txtpprice.Name = "txtpprice";
            this.txtpprice.ReadOnly = true;
            this.txtpprice.Size = new System.Drawing.Size(74, 20);
            this.txtpprice.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "NAME :";
            // 
            // txtpname
            // 
            this.txtpname.Location = new System.Drawing.Point(15, 82);
            this.txtpname.Name = "txtpname";
            this.txtpname.ReadOnly = true;
            this.txtpname.Size = new System.Drawing.Size(124, 20);
            this.txtpname.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(171, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "PRICE :";
            // 
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(144, 143);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(149, 20);
            this.txtsearch.TabIndex = 24;
            this.txtsearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsearch_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "SEARCH :";
            // 
            // txtdatetime
            // 
            this.txtdatetime.Location = new System.Drawing.Point(570, 84);
            this.txtdatetime.Name = "txtdatetime";
            this.txtdatetime.ReadOnly = true;
            this.txtdatetime.Size = new System.Drawing.Size(176, 20);
            this.txtdatetime.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(484, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "DateTime :";
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(144, 80);
            this.txtusername.Name = "txtusername";
            this.txtusername.ReadOnly = true;
            this.txtusername.Size = new System.Drawing.Size(149, 20);
            this.txtusername.TabIndex = 20;
            this.txtusername.TextChanged += new System.EventHandler(this.txtusername_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "username :";
            // 
            // sale_invoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 524);
            this.Controls.Add(this.btnsaveprint);
            this.Controls.Add(this.txttotal);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dgvsalesinvoice);
            this.Controls.Add(this.txtquantity);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtdatetime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.label1);
            this.Name = "sale_invoice";
            this.Text = "sale_invoice";
            this.Load += new System.EventHandler(this.sale_invoice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvsalesinvoice)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnsaveprint;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgvsalesinvoice;
        private System.Windows.Forms.DataGridViewTextBoxColumn p_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn p_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount;
        private System.Windows.Forms.TextBox txtquantity;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtpid;
        private System.Windows.Forms.TextBox txtpstock;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtpprice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtpname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtdatetime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.Label label1;
    }
}
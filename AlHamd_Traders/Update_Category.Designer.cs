namespace AlHamd_Traders
{
    partial class Update_Category
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
            this.dgvupdatedata = new System.Windows.Forms.DataGridView();
            this.txtcategoryid = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnupdatedata = new System.Windows.Forms.Button();
            this.txtcategoryname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdounavailable = new System.Windows.Forms.RadioButton();
            this.rdoavailable = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvupdatedata)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(278, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "code kro idhr update category krny ka yrr";
            // 
            // dgvupdatedata
            // 
            this.dgvupdatedata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvupdatedata.Location = new System.Drawing.Point(12, 234);
            this.dgvupdatedata.Name = "dgvupdatedata";
            this.dgvupdatedata.Size = new System.Drawing.Size(660, 228);
            this.dgvupdatedata.TabIndex = 30;
            // 
            // txtcategoryid
            // 
            this.txtcategoryid.Location = new System.Drawing.Point(12, 82);
            this.txtcategoryid.Name = "txtcategoryid";
            this.txtcategoryid.Size = new System.Drawing.Size(360, 20);
            this.txtcategoryid.TabIndex = 29;
            this.txtcategoryid.TextChanged += new System.EventHandler(this.txtcategoryid_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "CATEGORY ID :";
            // 
            // btnupdatedata
            // 
            this.btnupdatedata.Location = new System.Drawing.Point(393, 151);
            this.btnupdatedata.Name = "btnupdatedata";
            this.btnupdatedata.Size = new System.Drawing.Size(279, 77);
            this.btnupdatedata.TabIndex = 27;
            this.btnupdatedata.Text = "UPDATE DATA";
            this.btnupdatedata.UseVisualStyleBackColor = true;
            this.btnupdatedata.Click += new System.EventHandler(this.btnupdatedata_Click);
            // 
            // txtcategoryname
            // 
            this.txtcategoryname.Location = new System.Drawing.Point(12, 137);
            this.txtcategoryname.Name = "txtcategoryname";
            this.txtcategoryname.Size = new System.Drawing.Size(360, 20);
            this.txtcategoryname.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "CATEGORY NAME :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdounavailable);
            this.groupBox1.Controls.Add(this.rdoavailable);
            this.groupBox1.Location = new System.Drawing.Point(12, 163);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(360, 65);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "STATUS :";
            // 
            // rdounavailable
            // 
            this.rdounavailable.AutoSize = true;
            this.rdounavailable.Location = new System.Drawing.Point(185, 19);
            this.rdounavailable.Name = "rdounavailable";
            this.rdounavailable.Size = new System.Drawing.Size(98, 17);
            this.rdounavailable.TabIndex = 1;
            this.rdounavailable.Text = "UNAVAILABLE";
            this.rdounavailable.UseVisualStyleBackColor = true;
            // 
            // rdoavailable
            // 
            this.rdoavailable.AutoSize = true;
            this.rdoavailable.Checked = true;
            this.rdoavailable.Location = new System.Drawing.Point(18, 19);
            this.rdoavailable.Name = "rdoavailable";
            this.rdoavailable.Size = new System.Drawing.Size(82, 17);
            this.rdoavailable.TabIndex = 0;
            this.rdoavailable.TabStop = true;
            this.rdoavailable.Text = "AVAILABLE";
            this.rdoavailable.UseVisualStyleBackColor = true;
            // 
            // Update_Category
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 474);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvupdatedata);
            this.Controls.Add(this.txtcategoryid);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnupdatedata);
            this.Controls.Add(this.txtcategoryname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Update_Category";
            this.Text = "Update_Category";
            this.Load += new System.EventHandler(this.Update_Category_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvupdatedata)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvupdatedata;
        private System.Windows.Forms.TextBox txtcategoryid;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnupdatedata;
        private System.Windows.Forms.TextBox txtcategoryname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdounavailable;
        private System.Windows.Forms.RadioButton rdoavailable;
    }
}
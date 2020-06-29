namespace AlHamd_Traders
{
    partial class Add_New_Category
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
            this.dgvcategory = new System.Windows.Forms.DataGridView();
            this.btnaddcategory = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdounavailable = new System.Windows.Forms.RadioButton();
            this.rdoavailable = new System.Windows.Forms.RadioButton();
            this.txtcategoryname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcategory)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(154, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "CATEGORY ADD KRNY KA CODE KRO YARR IDHRRR";
            // 
            // dgvcategory
            // 
            this.dgvcategory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvcategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcategory.Location = new System.Drawing.Point(310, 25);
            this.dgvcategory.Name = "dgvcategory";
            this.dgvcategory.Size = new System.Drawing.Size(316, 355);
            this.dgvcategory.TabIndex = 9;
            // 
            // btnaddcategory
            // 
            this.btnaddcategory.Location = new System.Drawing.Point(86, 306);
            this.btnaddcategory.Name = "btnaddcategory";
            this.btnaddcategory.Size = new System.Drawing.Size(131, 81);
            this.btnaddcategory.TabIndex = 8;
            this.btnaddcategory.Text = "ADD CATEGORY";
            this.btnaddcategory.UseVisualStyleBackColor = true;
            this.btnaddcategory.Click += new System.EventHandler(this.btnaddcategory_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdounavailable);
            this.groupBox1.Controls.Add(this.rdoavailable);
            this.groupBox1.Location = new System.Drawing.Point(12, 174);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(293, 46);
            this.groupBox1.TabIndex = 7;
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
            // txtcategoryname
            // 
            this.txtcategoryname.Location = new System.Drawing.Point(12, 127);
            this.txtcategoryname.Name = "txtcategoryname";
            this.txtcategoryname.Size = new System.Drawing.Size(205, 20);
            this.txtcategoryname.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "CATEGORY NAME : ";
            // 
            // Add_New_Category
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 392);
            this.Controls.Add(this.dgvcategory);
            this.Controls.Add(this.btnaddcategory);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtcategoryname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Add_New_Category";
            this.Text = "7";
            ((System.ComponentModel.ISupportInitialize)(this.dgvcategory)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvcategory;
        private System.Windows.Forms.Button btnaddcategory;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdounavailable;
        private System.Windows.Forms.RadioButton rdoavailable;
        private System.Windows.Forms.TextBox txtcategoryname;
        private System.Windows.Forms.Label label2;
    }
}
namespace AlHamd_Traders
{
    partial class Remove_Role
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
            this.btndeleteroll = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtrollname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtrollid = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvremoveroll = new System.Windows.Forms.DataGridView();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvremoveroll)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "ROLES REMOVE KRNY KA CODE KRO IDHHR YRR";
            // 
            // btndeleteroll
            // 
            this.btndeleteroll.Location = new System.Drawing.Point(174, 361);
            this.btndeleteroll.Name = "btndeleteroll";
            this.btndeleteroll.Size = new System.Drawing.Size(339, 54);
            this.btndeleteroll.TabIndex = 10;
            this.btndeleteroll.Text = "DELETE ROLL";
            this.btndeleteroll.UseVisualStyleBackColor = true;
            this.btndeleteroll.Click += new System.EventHandler(this.btndeleteroll_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtrollname);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtrollid);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(24, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(355, 123);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SELECTED ROLL :";
            // 
            // txtrollname
            // 
            this.txtrollname.Location = new System.Drawing.Point(161, 84);
            this.txtrollname.Name = "txtrollname";
            this.txtrollname.ReadOnly = true;
            this.txtrollname.Size = new System.Drawing.Size(180, 20);
            this.txtrollname.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(265, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "ROLL NAME :";
            // 
            // txtrollid
            // 
            this.txtrollid.Location = new System.Drawing.Point(160, 36);
            this.txtrollid.Name = "txtrollid";
            this.txtrollid.ReadOnly = true;
            this.txtrollid.Size = new System.Drawing.Size(181, 20);
            this.txtrollid.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(284, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "ROLL ID :";
            // 
            // dgvremoveroll
            // 
            this.dgvremoveroll.AllowUserToAddRows = false;
            this.dgvremoveroll.AllowUserToDeleteRows = false;
            this.dgvremoveroll.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvremoveroll.Location = new System.Drawing.Point(12, 175);
            this.dgvremoveroll.Name = "dgvremoveroll";
            this.dgvremoveroll.ReadOnly = true;
            this.dgvremoveroll.Size = new System.Drawing.Size(644, 180);
            this.dgvremoveroll.TabIndex = 8;
            this.dgvremoveroll.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvremoveroll_CellClick);
            // 
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(446, 149);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(210, 20);
            this.txtsearch.TabIndex = 7;
            this.txtsearch.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(443, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "SEARCH :";
            // 
            // Remove_Role
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 439);
            this.Controls.Add(this.btndeleteroll);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvremoveroll);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Remove_Role";
            this.Text = "Remove_Role";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvremoveroll)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btndeleteroll;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtrollname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtrollid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvremoveroll;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.Label label2;
    }
}
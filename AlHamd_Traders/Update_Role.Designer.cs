namespace AlHamd_Traders
{
    partial class Update_Role
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
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvupdateroll = new System.Windows.Forms.DataGridView();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnupdateroll = new System.Windows.Forms.Button();
            this.txtrollname = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtrollid = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvupdateroll)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, -19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "ENTER USER ID :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(411, -19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Password  :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(222, -19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "UserName :";
            // 
            // dgvupdateroll
            // 
            this.dgvupdateroll.AllowUserToAddRows = false;
            this.dgvupdateroll.AllowUserToDeleteRows = false;
            this.dgvupdateroll.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvupdateroll.Location = new System.Drawing.Point(12, 75);
            this.dgvupdateroll.Name = "dgvupdateroll";
            this.dgvupdateroll.ReadOnly = true;
            this.dgvupdateroll.Size = new System.Drawing.Size(716, 172);
            this.dgvupdateroll.TabIndex = 38;
            this.dgvupdateroll.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvupdateroll_CellClick);
            // 
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(459, 49);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(269, 20);
            this.txtsearch.TabIndex = 37;
            this.txtsearch.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(456, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "SEARCH :";
            // 
            // btnupdateroll
            // 
            this.btnupdateroll.Location = new System.Drawing.Point(508, 320);
            this.btnupdateroll.Name = "btnupdateroll";
            this.btnupdateroll.Size = new System.Drawing.Size(184, 75);
            this.btnupdateroll.TabIndex = 35;
            this.btnupdateroll.Text = "UPDATE ROLL";
            this.btnupdateroll.UseVisualStyleBackColor = true;
            this.btnupdateroll.Click += new System.EventHandler(this.btnupdateroll_Click);
            // 
            // txtrollname
            // 
            this.txtrollname.Location = new System.Drawing.Point(268, 348);
            this.txtrollname.Name = "txtrollname";
            this.txtrollname.Size = new System.Drawing.Size(139, 20);
            this.txtrollname.TabIndex = 31;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(265, 314);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "Roll Name :";
            // 
            // txtrollid
            // 
            this.txtrollid.Location = new System.Drawing.Point(47, 348);
            this.txtrollid.Name = "txtrollid";
            this.txtrollid.Size = new System.Drawing.Size(139, 20);
            this.txtrollid.TabIndex = 40;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 314);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 39;
            this.label4.Text = "Roll id :";
            // 
            // Update_Role
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 463);
            this.Controls.Add(this.txtrollid);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvupdateroll);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnupdateroll);
            this.Controls.Add(this.txtrollname);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Name = "Update_Role";
            this.Text = "Update_Role";
            ((System.ComponentModel.ISupportInitialize)(this.dgvupdateroll)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvupdateroll;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnupdateroll;
        private System.Windows.Forms.TextBox txtrollname;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtrollid;
        private System.Windows.Forms.Label label4;
    }
}
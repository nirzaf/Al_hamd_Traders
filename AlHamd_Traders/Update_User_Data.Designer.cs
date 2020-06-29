namespace AlHamd_Traders
{
    partial class Update_User_Data
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
            this.btnupdatedata = new System.Windows.Forms.Button();
            this.txtrollid = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtuserid = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvupdateuserdata = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvupdateuserdata)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(375, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "USER KA DATA UPDATE KRNA HY YAHAH PR SB CODE BNAO YRRRRR";
            // 
            // btnupdatedata
            // 
            this.btnupdatedata.Location = new System.Drawing.Point(220, 201);
            this.btnupdatedata.Name = "btnupdatedata";
            this.btnupdatedata.Size = new System.Drawing.Size(184, 75);
            this.btnupdatedata.TabIndex = 17;
            this.btnupdatedata.Text = "UPDATE DATA";
            this.btnupdatedata.UseVisualStyleBackColor = true;
            this.btnupdatedata.Click += new System.EventHandler(this.btnupdatedata_Click);
            // 
            // txtrollid
            // 
            this.txtrollid.Location = new System.Drawing.Point(420, 172);
            this.txtrollid.Name = "txtrollid";
            this.txtrollid.Size = new System.Drawing.Size(139, 20);
            this.txtrollid.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(416, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Roll ID  :";
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(421, 107);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.PasswordChar = '#';
            this.txtpassword.Size = new System.Drawing.Size(139, 20);
            this.txtpassword.TabIndex = 14;
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(231, 107);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(139, 20);
            this.txtusername.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(417, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Password  :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(228, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "UserName :";
            // 
            // txtuserid
            // 
            this.txtuserid.Location = new System.Drawing.Point(33, 107);
            this.txtuserid.Name = "txtuserid";
            this.txtuserid.Size = new System.Drawing.Size(139, 20);
            this.txtuserid.TabIndex = 19;
            this.txtuserid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtuserid_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "ENTER USER ID :";
            // 
            // dgvupdateuserdata
            // 
            this.dgvupdateuserdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvupdateuserdata.Location = new System.Drawing.Point(-5, 282);
            this.dgvupdateuserdata.Name = "dgvupdateuserdata";
            this.dgvupdateuserdata.Size = new System.Drawing.Size(586, 163);
            this.dgvupdateuserdata.TabIndex = 20;
            // 
            // Update_User_Data
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 446);
            this.Controls.Add(this.dgvupdateuserdata);
            this.Controls.Add(this.txtuserid);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnupdatedata);
            this.Controls.Add(this.txtrollid);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Update_User_Data";
            this.Text = "Update_User_Data";
            ((System.ComponentModel.ISupportInitialize)(this.dgvupdateuserdata)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnupdatedata;
        private System.Windows.Forms.TextBox txtrollid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtuserid;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvupdateuserdata;
    }
}
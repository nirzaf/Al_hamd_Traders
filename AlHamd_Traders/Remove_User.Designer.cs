namespace AlHamd_Traders
{
    partial class Remove_User
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtsearchbyidname = new System.Windows.Forms.TextBox();
            this.dgvremoveuser = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtrollid = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtuserid = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btndeleteuser = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvremoveuser)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(159, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "USER KO REMOVE KRNY KA CODE YAHAN PR KRO YRRR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(487, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "USER ID OR NAME :";
            // 
            // txtsearchbyidname
            // 
            this.txtsearchbyidname.Location = new System.Drawing.Point(434, 137);
            this.txtsearchbyidname.Name = "txtsearchbyidname";
            this.txtsearchbyidname.Size = new System.Drawing.Size(210, 20);
            this.txtsearchbyidname.TabIndex = 2;
            this.txtsearchbyidname.TextChanged += new System.EventHandler(this.txtsearchbyidname_TextChanged);
            // 
            // dgvremoveuser
            // 
            this.dgvremoveuser.AllowUserToAddRows = false;
            this.dgvremoveuser.AllowUserToDeleteRows = false;
            this.dgvremoveuser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvremoveuser.Location = new System.Drawing.Point(0, 163);
            this.dgvremoveuser.Name = "dgvremoveuser";
            this.dgvremoveuser.ReadOnly = true;
            this.dgvremoveuser.Size = new System.Drawing.Size(644, 180);
            this.dgvremoveuser.TabIndex = 3;
            this.dgvremoveuser.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvremoveuser_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtrollid);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtpassword);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtusername);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtuserid);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(355, 123);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SELECTED USER :";
            // 
            // txtrollid
            // 
            this.txtrollid.Location = new System.Drawing.Point(238, 80);
            this.txtrollid.Name = "txtrollid";
            this.txtrollid.ReadOnly = true;
            this.txtrollid.Size = new System.Drawing.Size(111, 20);
            this.txtrollid.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(295, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "ROLL  id:";
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(24, 80);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.ReadOnly = true;
            this.txtpassword.Size = new System.Drawing.Size(180, 20);
            this.txtpassword.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(128, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "PASSWORD :";
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(23, 32);
            this.txtusername.Name = "txtusername";
            this.txtusername.ReadOnly = true;
            this.txtusername.Size = new System.Drawing.Size(181, 20);
            this.txtusername.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(130, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "USERNAME :";
            // 
            // txtuserid
            // 
            this.txtuserid.Location = new System.Drawing.Point(238, 32);
            this.txtuserid.Name = "txtuserid";
            this.txtuserid.ReadOnly = true;
            this.txtuserid.Size = new System.Drawing.Size(111, 20);
            this.txtuserid.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(295, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "USER id :";
            // 
            // btndeleteuser
            // 
            this.btndeleteuser.Location = new System.Drawing.Point(162, 349);
            this.btndeleteuser.Name = "btndeleteuser";
            this.btndeleteuser.Size = new System.Drawing.Size(339, 54);
            this.btndeleteuser.TabIndex = 5;
            this.btndeleteuser.Text = "DELETE USER";
            this.btndeleteuser.UseVisualStyleBackColor = true;
            this.btndeleteuser.Click += new System.EventHandler(this.btndeleteuser_Click);
            // 
            // Remove_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 415);
            this.Controls.Add(this.btndeleteuser);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvremoveuser);
            this.Controls.Add(this.txtsearchbyidname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Remove_User";
            this.Text = "Remove_User";
            ((System.ComponentModel.ISupportInitialize)(this.dgvremoveuser)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtsearchbyidname;
        private System.Windows.Forms.DataGridView dgvremoveuser;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtrollid;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtuserid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btndeleteuser;
    }
}
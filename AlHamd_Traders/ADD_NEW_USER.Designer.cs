namespace AlHamd_Traders
{
    partial class ADD_NEW_USER
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
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtrollid = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btncreatenew = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(130, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "NEW USER ADD KRNY KA TAREWEKA LAGAO";
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(183, 158);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.PasswordChar = '#';
            this.txtpassword.Size = new System.Drawing.Size(139, 20);
            this.txtpassword.TabIndex = 7;
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(182, 87);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(139, 20);
            this.txtusername.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(179, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Password  :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(179, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "UserName :";
            // 
            // txtrollid
            // 
            this.txtrollid.Location = new System.Drawing.Point(182, 223);
            this.txtrollid.Name = "txtrollid";
            this.txtrollid.Size = new System.Drawing.Size(139, 20);
            this.txtrollid.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(178, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Roll ID  :";
            // 
            // btncreatenew
            // 
            this.btncreatenew.Location = new System.Drawing.Point(160, 261);
            this.btncreatenew.Name = "btncreatenew";
            this.btncreatenew.Size = new System.Drawing.Size(184, 75);
            this.btncreatenew.TabIndex = 10;
            this.btncreatenew.Text = "CREATE NEW";
            this.btncreatenew.UseVisualStyleBackColor = true;
            this.btncreatenew.Click += new System.EventHandler(this.btncreatenew_Click);
            // 
            // ADD_NEW_USER
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 357);
            this.Controls.Add(this.btncreatenew);
            this.Controls.Add(this.txtrollid);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "ADD_NEW_USER";
            this.Text = "ADD_NEW_USER";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtrollid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btncreatenew;
    }
}
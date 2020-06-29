namespace AlHamd_Traders
{
    partial class Add_Role
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
            this.btncreatenew = new System.Windows.Forms.Button();
            this.txtrollname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(190, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ROLES ADD KRNY KA CODE KRO IDHHR YRR";
            // 
            // btncreatenew
            // 
            this.btncreatenew.Location = new System.Drawing.Point(226, 253);
            this.btncreatenew.Name = "btncreatenew";
            this.btncreatenew.Size = new System.Drawing.Size(184, 75);
            this.btncreatenew.TabIndex = 17;
            this.btncreatenew.Text = "CREATE NEW";
            this.btncreatenew.UseVisualStyleBackColor = true;
            this.btncreatenew.Click += new System.EventHandler(this.btncreatenew_Click);
            // 
            // txtrollname
            // 
            this.txtrollname.Location = new System.Drawing.Point(243, 138);
            this.txtrollname.Name = "txtrollname";
            this.txtrollname.Size = new System.Drawing.Size(139, 20);
            this.txtrollname.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(240, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Roll Name :";
            // 
            // Add_Role
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 381);
            this.Controls.Add(this.btncreatenew);
            this.Controls.Add(this.txtrollname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Add_Role";
            this.Text = "Add_Role";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btncreatenew;
        private System.Windows.Forms.TextBox txtrollname;
        private System.Windows.Forms.Label label3;
    }
}
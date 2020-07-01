namespace AlHamd_Traders
{
    partial class Change_Calculation
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
            this.btncancel = new System.Windows.Forms.Button();
            this.btnok = new System.Windows.Forms.Button();
            this.txtcashrecieved = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtreturn = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txttotalbill = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btncancel
            // 
            this.btncancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btncancel.Location = new System.Drawing.Point(197, 202);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(124, 48);
            this.btncancel.TabIndex = 15;
            this.btncancel.Text = "CANCEL";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // btnok
            // 
            this.btnok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnok.Location = new System.Drawing.Point(41, 202);
            this.btnok.Name = "btnok";
            this.btnok.Size = new System.Drawing.Size(124, 48);
            this.btnok.TabIndex = 14;
            this.btnok.Text = "OK";
            this.btnok.UseVisualStyleBackColor = true;
            this.btnok.Click += new System.EventHandler(this.btnok_Click);
            // 
            // txtcashrecieved
            // 
            this.txtcashrecieved.Location = new System.Drawing.Point(171, 97);
            this.txtcashrecieved.Name = "txtcashrecieved";
            this.txtcashrecieved.Size = new System.Drawing.Size(100, 20);
            this.txtcashrecieved.TabIndex = 13;
            this.txtcashrecieved.TextChanged += new System.EventHandler(this.txtcashrecieved_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "CASH RECIEVED";
            // 
            // txtreturn
            // 
            this.txtreturn.Location = new System.Drawing.Point(171, 132);
            this.txtreturn.Name = "txtreturn";
            this.txtreturn.ReadOnly = true;
            this.txtreturn.Size = new System.Drawing.Size(100, 20);
            this.txtreturn.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "RETURN";
            // 
            // txttotalbill
            // 
            this.txttotalbill.Location = new System.Drawing.Point(171, 58);
            this.txttotalbill.Name = "txttotalbill";
            this.txttotalbill.ReadOnly = true;
            this.txttotalbill.Size = new System.Drawing.Size(100, 20);
            this.txttotalbill.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "TOTAL BILL ";
            // 
            // changecalculation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 314);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnok);
            this.Controls.Add(this.txtcashrecieved);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtreturn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txttotalbill);
            this.Controls.Add(this.label1);
            this.Name = "changecalculation";
            this.Text = "changecalculation";
            this.Load += new System.EventHandler(this.changecalculation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Button btnok;
        private System.Windows.Forms.TextBox txtcashrecieved;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtreturn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txttotalbill;
        private System.Windows.Forms.Label label1;
    }
}
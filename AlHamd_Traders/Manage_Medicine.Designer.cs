namespace AlHamd_Traders
{
    partial class Manage_Medicine
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Manage_Medicine));
            this.btnaddnewmedicine = new System.Windows.Forms.Button();
            this.btnviewproductlist = new System.Windows.Forms.Button();
            this.btnsearchmedicine = new System.Windows.Forms.Button();
            this.btnupdatemedicine = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnaddnewmedicine
            // 
            this.btnaddnewmedicine.Location = new System.Drawing.Point(72, 42);
            this.btnaddnewmedicine.Name = "btnaddnewmedicine";
            this.btnaddnewmedicine.Size = new System.Drawing.Size(161, 116);
            this.btnaddnewmedicine.TabIndex = 0;
            this.btnaddnewmedicine.Text = "ADD NEW MEDICINE";
            this.btnaddnewmedicine.UseVisualStyleBackColor = true;
            this.btnaddnewmedicine.Click += new System.EventHandler(this.btnaddnewmedicine_Click);
            // 
            // btnviewproductlist
            // 
            this.btnviewproductlist.Location = new System.Drawing.Point(407, 230);
            this.btnviewproductlist.Name = "btnviewproductlist";
            this.btnviewproductlist.Size = new System.Drawing.Size(161, 116);
            this.btnviewproductlist.TabIndex = 1;
            this.btnviewproductlist.Text = "VIEW PRODUCT LIST";
            this.btnviewproductlist.UseVisualStyleBackColor = true;
            this.btnviewproductlist.Click += new System.EventHandler(this.btnviewproductlist_Click);
            // 
            // btnsearchmedicine
            // 
            this.btnsearchmedicine.Location = new System.Drawing.Point(72, 230);
            this.btnsearchmedicine.Name = "btnsearchmedicine";
            this.btnsearchmedicine.Size = new System.Drawing.Size(161, 116);
            this.btnsearchmedicine.TabIndex = 2;
            this.btnsearchmedicine.Text = "SEARCH MEDICINE";
            this.btnsearchmedicine.UseVisualStyleBackColor = true;
            this.btnsearchmedicine.Click += new System.EventHandler(this.btnsearchmedicine_Click);
            // 
            // btnupdatemedicine
            // 
            this.btnupdatemedicine.Location = new System.Drawing.Point(407, 42);
            this.btnupdatemedicine.Name = "btnupdatemedicine";
            this.btnupdatemedicine.Size = new System.Drawing.Size(161, 116);
            this.btnupdatemedicine.TabIndex = 3;
            this.btnupdatemedicine.Text = "UPDATE MEDICINE";
            this.btnupdatemedicine.UseVisualStyleBackColor = true;
            this.btnupdatemedicine.Click += new System.EventHandler(this.btnupdatemedicine_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(138, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(364, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "VIEW REPORT BAAD MN CUT KRDENA HY SHAYAD AGR NA HUA TW";
            // 
            // Managemedicine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 395);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnupdatemedicine);
            this.Controls.Add(this.btnsearchmedicine);
            this.Controls.Add(this.btnviewproductlist);
            this.Controls.Add(this.btnaddnewmedicine);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Managemedicine";
            this.Text = "Managemedicine";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnaddnewmedicine;
        private System.Windows.Forms.Button btnviewproductlist;
        private System.Windows.Forms.Button btnsearchmedicine;
        private System.Windows.Forms.Button btnupdatemedicine;
        private System.Windows.Forms.Label label1;
    }
}
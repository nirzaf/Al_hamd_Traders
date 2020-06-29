namespace AlHamd_Traders
{
    partial class Manage_Users
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
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.dgvsearch = new System.Windows.Forms.DataGridView();
            this.btnaddnew = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnremove = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvsearch)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(450, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "SEARCH :";
            // 
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(513, 58);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(207, 20);
            this.txtsearch.TabIndex = 1;
            this.txtsearch.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
            // 
            // dgvsearch
            // 
            this.dgvsearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvsearch.Location = new System.Drawing.Point(1, 97);
            this.dgvsearch.Name = "dgvsearch";
            this.dgvsearch.Size = new System.Drawing.Size(756, 238);
            this.dgvsearch.TabIndex = 2;
            // 
            // btnaddnew
            // 
            this.btnaddnew.Location = new System.Drawing.Point(24, 350);
            this.btnaddnew.Name = "btnaddnew";
            this.btnaddnew.Size = new System.Drawing.Size(184, 75);
            this.btnaddnew.TabIndex = 3;
            this.btnaddnew.Text = "ADD NEW";
            this.btnaddnew.UseVisualStyleBackColor = true;
            this.btnaddnew.Click += new System.EventHandler(this.btnaddnew_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(274, 350);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(184, 75);
            this.btnupdate.TabIndex = 4;
            this.btnupdate.Text = "UPDATE";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btnremove
            // 
            this.btnremove.Location = new System.Drawing.Point(536, 350);
            this.btnremove.Name = "btnremove";
            this.btnremove.Size = new System.Drawing.Size(184, 75);
            this.btnremove.TabIndex = 5;
            this.btnremove.Text = "REMOVE";
            this.btnremove.UseVisualStyleBackColor = true;
            this.btnremove.Click += new System.EventHandler(this.btnremove_Click);
            // 
            // Manage_Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 437);
            this.Controls.Add(this.btnremove);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btnaddnew);
            this.Controls.Add(this.dgvsearch);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.label1);
            this.Name = "Manage_Users";
            this.Text = "Manage_Users";
            ((System.ComponentModel.ISupportInitialize)(this.dgvsearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.DataGridView dgvsearch;
        private System.Windows.Forms.Button btnaddnew;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btnremove;
    }
}
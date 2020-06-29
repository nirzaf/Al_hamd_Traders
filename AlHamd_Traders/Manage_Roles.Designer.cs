namespace AlHamd_Traders
{
    partial class Manage_Roles
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
            this.btnremoveroll = new System.Windows.Forms.Button();
            this.btnupdateroll = new System.Windows.Forms.Button();
            this.btnaddroll = new System.Windows.Forms.Button();
            this.dgvsearchroll = new System.Windows.Forms.DataGridView();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvsearchroll)).BeginInit();
            this.SuspendLayout();
            // 
            // btnremoveroll
            // 
            this.btnremoveroll.Location = new System.Drawing.Point(501, 314);
            this.btnremoveroll.Name = "btnremoveroll";
            this.btnremoveroll.Size = new System.Drawing.Size(166, 77);
            this.btnremoveroll.TabIndex = 11;
            this.btnremoveroll.Text = "REMOVE ROLL";
            this.btnremoveroll.UseVisualStyleBackColor = true;
            this.btnremoveroll.Click += new System.EventHandler(this.btnremoverole_Click);
            // 
            // btnupdateroll
            // 
            this.btnupdateroll.Location = new System.Drawing.Point(264, 314);
            this.btnupdateroll.Name = "btnupdateroll";
            this.btnupdateroll.Size = new System.Drawing.Size(166, 77);
            this.btnupdateroll.TabIndex = 10;
            this.btnupdateroll.Text = "UPDATE ROLL";
            this.btnupdateroll.UseVisualStyleBackColor = true;
            this.btnupdateroll.Click += new System.EventHandler(this.btnupdaterole_Click);
            // 
            // btnaddroll
            // 
            this.btnaddroll.Location = new System.Drawing.Point(35, 314);
            this.btnaddroll.Name = "btnaddroll";
            this.btnaddroll.Size = new System.Drawing.Size(166, 77);
            this.btnaddroll.TabIndex = 9;
            this.btnaddroll.Text = "ADD ROLL";
            this.btnaddroll.UseVisualStyleBackColor = true;
            this.btnaddroll.Click += new System.EventHandler(this.btnaddrole_Click);
            // 
            // dgvsearchroll
            // 
            this.dgvsearchroll.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvsearchroll.Location = new System.Drawing.Point(24, 73);
            this.dgvsearchroll.Name = "dgvsearchroll";
            this.dgvsearchroll.Size = new System.Drawing.Size(653, 235);
            this.dgvsearchroll.TabIndex = 8;
            // 
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(504, 47);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(162, 20);
            this.txtsearch.TabIndex = 7;
            this.txtsearch.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(441, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "SEARCH :";
            // 
            // Manage_Roles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 399);
            this.Controls.Add(this.btnremoveroll);
            this.Controls.Add(this.btnupdateroll);
            this.Controls.Add(this.btnaddroll);
            this.Controls.Add(this.dgvsearchroll);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.label1);
            this.Name = "Manage_Roles";
            this.Text = "Manage_Roles";
            ((System.ComponentModel.ISupportInitialize)(this.dgvsearchroll)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnremoveroll;
        private System.Windows.Forms.Button btnupdateroll;
        private System.Windows.Forms.Button btnaddroll;
        private System.Windows.Forms.DataGridView dgvsearchroll;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.Label label1;
    }
}
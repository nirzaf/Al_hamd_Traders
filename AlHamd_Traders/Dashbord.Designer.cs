namespace AlHamd_Traders
{
    partial class Dashbord
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashbord));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.stockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msmanagemedicine = new System.Windows.Forms.ToolStripMenuItem();
            this.companyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageRolesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.staffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msmanageusers = new System.Windows.Forms.ToolStripMenuItem();
            this.categoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mANAGECATEGORYToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbtnadduser = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnaddstock = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnsave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnexit = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lblglobalsetdata = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stockToolStripMenuItem,
            this.companyToolStripMenuItem,
            this.staffToolStripMenuItem,
            this.categoryToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(904, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // stockToolStripMenuItem
            // 
            this.stockToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msmanagemedicine});
            this.stockToolStripMenuItem.Name = "stockToolStripMenuItem";
            this.stockToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.stockToolStripMenuItem.Text = "Stock";
            // 
            // msmanagemedicine
            // 
            this.msmanagemedicine.Name = "msmanagemedicine";
            this.msmanagemedicine.Size = new System.Drawing.Size(183, 22);
            this.msmanagemedicine.Text = "MANAGE MADICINE";
            this.msmanagemedicine.Click += new System.EventHandler(this.msmanagemedicine_Click);
            // 
            // companyToolStripMenuItem
            // 
            this.companyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageRolesToolStripMenuItem});
            this.companyToolStripMenuItem.Name = "companyToolStripMenuItem";
            this.companyToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.companyToolStripMenuItem.Text = "Roles";
            // 
            // manageRolesToolStripMenuItem
            // 
            this.manageRolesToolStripMenuItem.Name = "manageRolesToolStripMenuItem";
            this.manageRolesToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.manageRolesToolStripMenuItem.Text = "Manage Roles";
            this.manageRolesToolStripMenuItem.Click += new System.EventHandler(this.manageRolesToolStripMenuItem_Click);
            // 
            // staffToolStripMenuItem
            // 
            this.staffToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msmanageusers});
            this.staffToolStripMenuItem.Name = "staffToolStripMenuItem";
            this.staffToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.staffToolStripMenuItem.Text = "Staff";
            // 
            // msmanageusers
            // 
            this.msmanageusers.Name = "msmanageusers";
            this.msmanageusers.Size = new System.Drawing.Size(160, 22);
            this.msmanageusers.Text = "MANAGE USERS";
            this.msmanageusers.Click += new System.EventHandler(this.msmanageusers_Click);
            // 
            // categoryToolStripMenuItem
            // 
            this.categoryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mANAGECATEGORYToolStripMenuItem});
            this.categoryToolStripMenuItem.Name = "categoryToolStripMenuItem";
            this.categoryToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.categoryToolStripMenuItem.Text = "Category";
            // 
            // mANAGECATEGORYToolStripMenuItem
            // 
            this.mANAGECATEGORYToolStripMenuItem.Name = "mANAGECATEGORYToolStripMenuItem";
            this.mANAGECATEGORYToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.mANAGECATEGORYToolStripMenuItem.Text = "MANAGE CATEGORY";
            this.mANAGECATEGORYToolStripMenuItem.Click += new System.EventHandler(this.mANAGECATEGORYToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnadduser,
            this.toolStripSeparator1,
            this.tsbtnaddstock,
            this.toolStripSeparator3,
            this.tsbtnsave,
            this.toolStripSeparator4,
            this.tsbtnexit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(904, 38);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbtnadduser
            // 
            this.tsbtnadduser.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnadduser.Image")));
            this.tsbtnadduser.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnadduser.Name = "tsbtnadduser";
            this.tsbtnadduser.Size = new System.Drawing.Size(65, 35);
            this.tsbtnadduser.Text = "ADD USER";
            this.tsbtnadduser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtnadduser.Click += new System.EventHandler(this.tsbtnadduser_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 38);
            // 
            // tsbtnaddstock
            // 
            this.tsbtnaddstock.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnaddstock.Image")));
            this.tsbtnaddstock.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnaddstock.Name = "tsbtnaddstock";
            this.tsbtnaddstock.Size = new System.Drawing.Size(74, 35);
            this.tsbtnaddstock.Text = "ADD STOCK";
            this.tsbtnaddstock.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtnaddstock.Click += new System.EventHandler(this.tsbtnaddstock_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 38);
            // 
            // tsbtnsave
            // 
            this.tsbtnsave.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnsave.Image")));
            this.tsbtnsave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnsave.Name = "tsbtnsave";
            this.tsbtnsave.Size = new System.Drawing.Size(85, 35);
            this.tsbtnsave.Text = "SALE INVOICE";
            this.tsbtnsave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtnsave.Click += new System.EventHandler(this.tsbtnsave_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 38);
            // 
            // tsbtnexit
            // 
            this.tsbtnexit.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnexit.Image")));
            this.tsbtnexit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnexit.Name = "tsbtnexit";
            this.tsbtnexit.Size = new System.Drawing.Size(34, 35);
            this.tsbtnexit.Text = "EXIT";
            this.tsbtnexit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtnexit.Click += new System.EventHandler(this.tsbtnexit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(717, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 3;
            // 
            // lblglobalsetdata
            // 
            this.lblglobalsetdata.AutoSize = true;
            this.lblglobalsetdata.Location = new System.Drawing.Point(748, 11);
            this.lblglobalsetdata.Name = "lblglobalsetdata";
            this.lblglobalsetdata.Size = new System.Drawing.Size(0, 13);
            this.lblglobalsetdata.TabIndex = 4;
            // 
            // Dashbord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 426);
            this.Controls.Add(this.lblglobalsetdata);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Dashbord";
            this.Text = "Dashbord";
            this.Load += new System.EventHandler(this.Dashbord_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem stockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem msmanagemedicine;
        private System.Windows.Forms.ToolStripMenuItem companyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem staffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbtnadduser;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbtnaddstock;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tsbtnsave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton tsbtnexit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem msmanageusers;
        private System.Windows.Forms.ToolStripMenuItem mANAGECATEGORYToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageRolesToolStripMenuItem;
        private System.Windows.Forms.Label lblglobalsetdata;
    }
}
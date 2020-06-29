using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlHamd_Traders
{
    public partial class Dashbord : Form
    {
        public Dashbord()
        {
            InitializeComponent();
        }

        private void msmanagemedicine_Click(object sender, EventArgs e)
        {
            Managemedicine managemedicine = new Managemedicine();
            managemedicine.ShowDialog();
        }

        private void msmanageusers_Click(object sender, EventArgs e)
        {
            Manage_Users manageusers = new Manage_Users();
            manageusers.ShowDialog();
        }

        private void mANAGECATEGORYToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Manage_Category managecategory = new Manage_Category();
            managecategory.ShowDialog();
        }

        private void manageRolesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Manage_Roles manageroles = new Manage_Roles();
            manageroles.ShowDialog();
        }

        private void tsbtnsave_Click(object sender, EventArgs e)
        {
            sale_invoice saleinvoice = new sale_invoice();
            saleinvoice.ShowDialog();
        }

        private void Dashbord_Load(object sender, EventArgs e)
        {
            MessageBox.Show("WELCOME : " + globals.username);
            lblglobalsetdata.Text = "username : " + globals.username;
        }

        private void tsbtnadduser_Click(object sender, EventArgs e)
        {
            ADD_NEW_USER addnewuser = new ADD_NEW_USER();
            addnewuser.ShowDialog();
        }

        private void tsbtnaddstock_Click(object sender, EventArgs e)
        {
            Add_New_Medicine addnewmedicine = new Add_New_Medicine();
            addnewmedicine.ShowDialog();
        }

        private void tsbtnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

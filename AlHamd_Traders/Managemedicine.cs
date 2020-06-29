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
    public partial class Managemedicine : Form
    {
        public Managemedicine()
        {
            InitializeComponent();
        }

        private void btnaddnewmedicine_Click(object sender, EventArgs e)
        {
            Add_New_Medicine addnewmedicine = new Add_New_Medicine();
            addnewmedicine.ShowDialog();
        }

        private void btnsearchmedicine_Click(object sender, EventArgs e)
        {
            Search_Medicine searchmedicine = new Search_Medicine();
            searchmedicine.ShowDialog();
        }

        private void btnupdatemedicine_Click(object sender, EventArgs e)
        {
            Update_Medicine updatemedicine = new Update_Medicine();
            updatemedicine.ShowDialog();
        }

        private void btnviewproductlist_Click(object sender, EventArgs e)
        {
            view_product_list vpl = new view_product_list();
            vpl.ShowDialog();
        }
    }
}

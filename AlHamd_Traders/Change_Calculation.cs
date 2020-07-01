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
    public partial class Change_Calculation : Form
    {
        int totalbill;
        public Change_Calculation(int totalbill)
        {
            InitializeComponent();
            this.totalbill = totalbill;
        }

        private void changecalculation_Load(object sender, EventArgs e)
        {
            txttotalbill.Text = totalbill.ToString();
            txtcashrecieved.Focus();
        }

        private void txtcashrecieved_TextChanged(object sender, EventArgs e)
        {
            if(txtcashrecieved.Text.Length==0)
            {
                return;
            }
            else
            {
                int casshpaid = Convert.ToInt32(txtcashrecieved.Text);
                if (casshpaid < 0)
                {
                    return;
                }

            }
            int cashpaid = Convert.ToInt32(txtcashrecieved.Text);
            int change = cashpaid - totalbill;
            txtreturn.Text = change.ToString();
        }

        private void btnok_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Configuration;

namespace AlHamd_Traders
{
    public partial class Add_New_Category : Form
    {
        public Add_New_Category()
        {
            InitializeComponent();
        }

        private void btnaddcategory_Click(object sender, EventArgs e)
        {
            String catname = txtcategoryname.Text.Trim();
            int catstatus;
            if (rdoavailable.Checked)
            {
                catstatus = 1;
            }
            else
            {
                catstatus = 0;
            }
            String connstr = ConfigurationManager.ConnectionStrings["dbpath"].ConnectionString;
            SqlConnection con = new SqlConnection(connstr);
            con.Open();

            String query = "INSERT INTO category(catname,catstatus) VALUES (@catname,@catstatus)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.Add(new SqlParameter("catname", catname));
            cmd.Parameters.Add(new SqlParameter("catstatus", catstatus));
            int n = cmd.ExecuteNonQuery();
            if (n > 0)
            {
                MessageBox.Show("category added successfully");
                String query2 = "SELECT * FROM category";
                SqlCommand cmd2 = new SqlCommand(query2, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd2);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvcategory.DataSource = dt;
                dgvcategory.Refresh();
            }
            else
            {
                MessageBox.Show("failed to add category");
            }
            con.Close();
        }
    }
}

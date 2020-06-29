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
    public partial class Manage_Category : Form
    {
        public Manage_Category()
        {
            InitializeComponent();
        }

        private void btnaddcategory_Click(object sender, EventArgs e)
        {
            Add_New_Category addnewcategory = new Add_New_Category();
            addnewcategory.ShowDialog();
        }

        private void btnupdatecategory_Click(object sender, EventArgs e)
        {
            Update_Category updatecategory = new Update_Category();
            updatecategory.ShowDialog();
        }

        private void btnremovecategory_Click(object sender, EventArgs e)
        {
            Remove_Category removecategory = new Remove_Category();
            removecategory.ShowDialog();
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            String input = txtsearch.Text.Trim();
            if (Regex.IsMatch(input, "^[0-9]+$"))
            {
                int catid = Convert.ToInt32(input);
                String connstr = ConfigurationManager.ConnectionStrings["dbpath"].ConnectionString;
                SqlConnection con = new SqlConnection(connstr);
                con.Open();

                String query = "SELECT * FROM category WHERE cat_id LIKE @catid";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.Add(new SqlParameter("catid", catid + "%"));
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    dgvsearchcategory.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("invalid input");
                    return;
                }

                con.Close();
            }
            else
            {
                //MessageBox.Show("input is alphanumeric");
                String connstr = ConfigurationManager.ConnectionStrings["dbpath"].ConnectionString;
                SqlConnection con = new SqlConnection(connstr);
                con.Open();

                String query = "SELECT * FROM category WHERE catname LIKE @input";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.Add(new SqlParameter("input", "%" + input + "%"));
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    dgvsearchcategory.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("invalid input");
                    return;
                }

                con.Close();
            }
        }
    }
}

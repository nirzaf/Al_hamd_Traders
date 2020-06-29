using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Text.RegularExpressions;
using System.Data.SqlClient;

namespace AlHamd_Traders
{
    public partial class Remove_Category : Form
    {
        public Remove_Category()
        {
            InitializeComponent();
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
                    dgvdeletecategory.DataSource = dt;
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
                    dgvdeletecategory.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("invalid input");
                    return;
                }

                con.Close();
            }
        }

        private void dgvdeletecategory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex;
            txtcategoryid.Text = dgvdeletecategory.Rows[rowindex].Cells["cat_id"].Value.ToString();
            txtcategoryname.Text = dgvdeletecategory.Rows[rowindex].Cells["catname"].Value.ToString();
        }

        private void btndeletecategory_Click(object sender, EventArgs e)
        {
            ///deletion using id
            if (txtcategoryid.Text.Length == 0)
            {
                MessageBox.Show("please select some category");
            }
            else
            {
                int catid = Convert.ToInt32(txtcategoryid.Text);
                String connstr = ConfigurationManager.ConnectionStrings["dbpath"].ConnectionString;
                SqlConnection con = new SqlConnection(connstr);
                con.Open();

                String query = "DELETE FROM category WHERE cat_id=@catid";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.Add(new SqlParameter("catid", catid));
                int n = cmd.ExecuteNonQuery();
                con.Close();
                if (n > 0)
                {
                    MessageBox.Show("category deleted successfully");
                    txtcategoryid.Clear();
                    txtcategoryname.Clear();
                    txtsearch.Clear();
                    txtsearch.Focus();
                    dgvdeletecategory.Refresh();
                }
                else
                {
                    MessageBox.Show("category deletion failed");
                    txtcategoryid.Clear();
                    txtcategoryname.Clear();
                    txtsearch.Clear();
                    txtsearch.Focus();
                    dgvdeletecategory.Refresh();
                }
            }
        }
    }
    }

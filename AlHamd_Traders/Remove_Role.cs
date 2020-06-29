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
using System.Configuration;
using System.Text.RegularExpressions;

namespace AlHamd_Traders
{
    public partial class Remove_Role : Form
    {
        public Remove_Role()
        {
            InitializeComponent();
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            String input = txtsearch.Text.Trim();
            if (Regex.IsMatch(input, "^[0-9]+$"))
            {
                int rollid = Convert.ToInt32(input);
                String connstr = ConfigurationManager.ConnectionStrings["dbpath"].ConnectionString;
                SqlConnection con = new SqlConnection(connstr);
                con.Open();

                String query = "SELECT * FROM roles WHERE roll_id LIKE @rollid";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.Add(new SqlParameter("rollid", rollid + "%"));
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    dgvremoveroll.DataSource = dt;
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

                String query = "SELECT * FROM roles WHERE rollname LIKE @input";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.Add(new SqlParameter("input", "%" + input + "%"));
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    dgvremoveroll.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("invalid input");
                    return;
                }

                con.Close();
            }


        }

        private void dgvremoveroll_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex;
            txtrollid.Text = dgvremoveroll.Rows[rowindex].Cells["roll_id"].Value.ToString();
            txtrollname.Text = dgvremoveroll.Rows[rowindex].Cells["rollname"].Value.ToString();
        }

        private void btndeleteroll_Click(object sender, EventArgs e)
        {
            ///deletion using id
            if (txtrollid.Text.Length == 0)
            {
                MessageBox.Show("please select some roll");
            }
            else
            {
                int rollid = Convert.ToInt32(txtrollid.Text);
                String connstr = ConfigurationManager.ConnectionStrings["dbpath"].ConnectionString;
                SqlConnection con = new SqlConnection(connstr);
                con.Open();

                String query = "DELETE FROM roles WHERE roll_id=@rollid";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.Add(new SqlParameter("rollid", rollid));
                int n = cmd.ExecuteNonQuery();
                con.Close();
                if (n > 0)
                {
                    MessageBox.Show("ROLL deleted successfully");
                    txtrollid.Clear();
                    txtrollname.Clear();
                    txtsearch.Clear();
                    txtsearch.Focus();
                    dgvremoveroll.Refresh();
                }
                else
                {
                    MessageBox.Show("user deletion failed");
                    txtrollid.Clear();
                    txtrollname.Clear();
                    txtsearch.Clear();
                    txtsearch.Focus();
                    dgvremoveroll.Refresh();
                }
            }
        }
    }
}

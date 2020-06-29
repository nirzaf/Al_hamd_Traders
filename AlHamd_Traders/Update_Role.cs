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
    public partial class Update_Role : Form
    {
        public Update_Role()
        {
            InitializeComponent();
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            //MessageBox.Show("i am update button");


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
                    dgvupdateroll.DataSource = dt;
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
                    dgvupdateroll.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("invalid input");
                    return;
                }

                con.Close();
            }
        
        
        }

        private void btnupdateroll_Click(object sender, EventArgs e)
        {
            if (txtrollid.Text.Length == 0)
            {
                MessageBox.Show("please enter rollid");
                return;
            }
            else if (txtrollname.Text.Length == 0)
            {
                MessageBox.Show("please enter rollname");
                return;
            }
            else
            {
                String rollname = txtrollname.Text.Trim();
                int rollid = Convert.ToInt32(txtrollid.Text.Trim());

                String connstr = ConfigurationManager.ConnectionStrings["dbpath"].ConnectionString;
                SqlConnection con = new SqlConnection(connstr);
                con.Open();
                String query = "UPDATE roles SET rollname=@rollname WHERE roll_id=@rollid";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.Add(new SqlParameter("rollname", rollname));
                cmd.Parameters.Add(new SqlParameter("rollid", rollid));
                int n = cmd.ExecuteNonQuery();
                con.Close();
                if (n > 0)
                {
                    MessageBox.Show("roll data updated");
                    dgvupdateroll.Refresh();
                }
                else
                {
                    MessageBox.Show("roll data NOT updated");
                    dgvupdateroll.Refresh();
                }

            }
        }

        private void dgvupdateroll_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex;
            txtrollid.Text = dgvupdateroll.Rows[rowindex].Cells["roll_id"].Value.ToString();
            txtrollname.Text = dgvupdateroll.Rows[rowindex].Cells["rollname"].Value.ToString();
        }
    }
}

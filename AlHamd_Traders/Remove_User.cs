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
    public partial class Remove_User : Form
    {
        public Remove_User()
        {
            InitializeComponent();
        }

        private void txtsearchbyidname_TextChanged(object sender, EventArgs e)
        {
            String input = txtsearchbyidname.Text.Trim();
            if (Regex.IsMatch(input, "^[0-9]+$"))
            {
                int userid = Convert.ToInt32(input);
                String connstr = ConfigurationManager.ConnectionStrings["dbpath"].ConnectionString;
                SqlConnection con = new SqlConnection(connstr);
                con.Open();

                String query = "SELECT * FROM user_info WHERE user_id LIKE @userid";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.Add(new SqlParameter("userid", userid + "%"));
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    dgvremoveuser.DataSource = dt;
                }
                else
                {
                    //MessageBox.Show("invalid input");
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

                String query = "SELECT * FROM user_info WHERE username LIKE @input";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.Add(new SqlParameter("input", "%" + input + "%"));
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    dgvremoveuser.DataSource = dt;
                }
                else
                {
                    //MessageBox.Show("invalid input");
                    return;
                }

                con.Close();
            }

        }

        private void dgvremoveuser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            /// MessageBox.Show("Cell clicked");
            int rowindex = e.RowIndex;
            txtuserid.Text = dgvremoveuser.Rows[rowindex].Cells["user_id"].Value.ToString();
            txtusername.Text = dgvremoveuser.Rows[rowindex].Cells["username"].Value.ToString();
            txtpassword.Text = dgvremoveuser.Rows[rowindex].Cells["password"].Value.ToString();
            txtrollid.Text = dgvremoveuser.Rows[rowindex].Cells["roll_id"].Value.ToString();
            
        }

        private void btndeleteuser_Click(object sender, EventArgs e)
        {
            ///deletion using id
            if (txtuserid.Text.Length == 0)
            {
                MessageBox.Show("please select some user");
            }
            else
            {
                String userid = txtuserid.Text;
                String connstr = ConfigurationManager.ConnectionStrings["dbpath"].ConnectionString;
                SqlConnection con = new SqlConnection(connstr);
                con.Open();

                String query = "DELETE FROM user_info WHERE user_id=@userid";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.Add(new SqlParameter("userid", userid));
                int n = cmd.ExecuteNonQuery();
                con.Close();
                if (n > 0)
                {
                    MessageBox.Show("user deleted successfully");
                    txtuserid.Clear();
                    txtusername.Clear();
                    txtpassword.Clear();
                    txtrollid.Clear();
                    txtsearchbyidname.Clear();
                    txtsearchbyidname.Focus();
                    dgvremoveuser.Refresh();
               }
                else
                {
                    MessageBox.Show("user deletion failed");
                    txtuserid.Clear();
                    txtusername.Clear();
                    txtpassword.Clear();
                    txtrollid.Clear();
                    txtsearchbyidname.Clear();
                    txtsearchbyidname.Focus();
                    dgvremoveuser.Refresh();
                }
            }
        }
    }
}

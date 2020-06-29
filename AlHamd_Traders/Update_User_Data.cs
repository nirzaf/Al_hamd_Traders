using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Configuration;
using System.Data.SqlClient;

namespace AlHamd_Traders
{
    public partial class Update_User_Data : Form
    {
        public Update_User_Data()
        {
            InitializeComponent();
        }

        private void btnupdatedata_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("i am update button");
            if (txtusername.Text.Length == 0)
            {
                MessageBox.Show("please enter user name");
                return;
            }
            else if (txtpassword.Text.Length == 0)
            {
                MessageBox.Show("please enter password");
                return;
            }
            else if (txtrollid.Text.Length == 0)
            {
                MessageBox.Show("please enter roll id");
                return;
            }
            else
            {
                String userid = txtuserid.Text.Trim();
                String username = txtusername.Text.Trim();
                String password = txtpassword.Text.Trim();
                int rollid = Convert.ToInt32(txtrollid.Text.Trim());

                String connstr = ConfigurationManager.ConnectionStrings["dbpath"].ConnectionString;
                SqlConnection con = new SqlConnection(connstr);
                con.Open();
                String query = "UPDATE user_info SET username=@username,password=@password,roll_id=@rollid WHERE user_id=@userid";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.Add(new SqlParameter("userid", userid));
                cmd.Parameters.Add(new SqlParameter("username", username));
                cmd.Parameters.Add(new SqlParameter("password", password));
                cmd.Parameters.Add(new SqlParameter("rollid", rollid));
                int n = cmd.ExecuteNonQuery();
                con.Close();
                if (n > 0)
                {
                    MessageBox.Show("user data updated");
                    dgvupdateuserdata.Refresh();


                }
            }
        }

        private void txtuserid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtuserid.Text.Length == 0)
            {
                return;
            }
            String input = txtuserid.Text;
            if (Regex.IsMatch(input, "^[0-9]+$"))
            {
                int userid;
                bool result = int.TryParse(input, out userid);
                if (result)
                {
                    String connstr = ConfigurationManager.ConnectionStrings["dbpath"].ConnectionString;
                    SqlConnection con = new SqlConnection(connstr);
                    con.Open();
                    String query = "SELECT * FROM user_info WHERE user_id=@userid";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.Add(new SqlParameter("userid", userid));
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    con.Close();
                    if (dt.Rows.Count > 0)
                    {
                        MessageBox.Show("user data found");
                        dgvupdateuserdata.DataSource = dt;
                        txtuserid.Text = dgvupdateuserdata.Rows[0].Cells["user_id"].Value.ToString();
                        txtusername.Text = dgvupdateuserdata.Rows[0].Cells["username"].Value.ToString();
                        txtpassword.Text = dgvupdateuserdata.Rows[0].Cells["password"].Value.ToString();
                        txtrollid.Text = dgvupdateuserdata.Rows[0].Cells["roll_id"].Value.ToString();
                        dgvupdateuserdata.Refresh();
                    }
                    else
                    {
                        MessageBox.Show("user id does not exist");
                    }
                }

            }
            else
            {
                MessageBox.Show("ENTER VALID USER ID");
            }
        }
    }
    }

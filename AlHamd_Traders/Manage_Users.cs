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
using System.Data.SqlClient;
using System.Configuration;
namespace AlHamd_Traders
{
    public partial class Manage_Users : Form
    {
        public Manage_Users()
        {
            InitializeComponent();
        }

        private void btnaddnew_Click(object sender, EventArgs e)
        {
            ADD_NEW_USER addnewuser = new ADD_NEW_USER();
            addnewuser.ShowDialog();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            Update_User_Data updateuserdata = new Update_User_Data();
            updateuserdata.ShowDialog();
        }

        private void btnremove_Click(object sender, EventArgs e)
        {
            Remove_User removeuser = new Remove_User();
            removeuser.ShowDialog();
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            String input = txtsearch.Text.Trim();
            if(Regex.IsMatch(input,"^[0-9]+$"))
            {
                int userid = Convert.ToInt32(input);
                String connstr = ConfigurationManager.ConnectionStrings["dbpath"].ConnectionString;
                SqlConnection con = new SqlConnection(connstr);
                con.Open();

                String query = "SELECT * FROM user_info WHERE user_id LIKE @userid";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.Add(new SqlParameter("userid",userid+"%"));
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if(dt.Rows.Count>0)
                {
                    dgvsearch.DataSource = dt;
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
                cmd.Parameters.Add(new SqlParameter("input", "%"+input+"%"));
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    dgvsearch.DataSource = dt;
                }
                else
                {
                    //MessageBox.Show("invalid input");
                    return;
                }

                con.Close();
            }
        }
    }
}

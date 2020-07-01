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

namespace AlHamd_Traders
{
    public partial class Add_New_User : Form
    {
        public Add_New_User()
        {
            InitializeComponent();
        }

        private void btncreatenew_Click(object sender, EventArgs e)
        {
            if (txtusername.Text.Length == 0)
            {
                MessageBox.Show("please enter username");
            }
            else if (txtpassword.Text.Length == 0)
            {
                MessageBox.Show("please enter password");
            }
            else if (txtrollid.Text.Length == 0)
            {
                MessageBox.Show("please enter roll id");
            }
            else
            {



                String username = txtusername.Text;
                String password = txtpassword.Text;
                String rollid = txtrollid.Text;
                String connstr = ConfigurationManager.ConnectionStrings["dbpath"].ConnectionString;
                SqlConnection con = new SqlConnection(connstr);
                con.Open();

                String query = "INSERT INTO user_info (username,password,roll_id) VALUES(@u,@p,@r)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.Add(new SqlParameter("u", username));
                cmd.Parameters.Add(new SqlParameter("p", password));
                cmd.Parameters.Add(new SqlParameter("r", rollid));
                int n = cmd.ExecuteNonQuery();

                con.Close();
                if (n > 0)
                {
                    MessageBox.Show("user added successfully");
                    txtusername.Clear();
                    txtpassword.Clear();
                    txtrollid.Clear();
                    txtusername.Focus();
                }

            }
        }
    }
}

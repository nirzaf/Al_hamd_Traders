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
    public partial class Add_Role : Form
    {
        public Add_Role()
        {
            InitializeComponent();
        }

        private void btncreatenew_Click(object sender, EventArgs e)
        {
            if (txtrollname.Text.Length == 0)
            {
                MessageBox.Show("please enter rollname");
            }
            else
            { 
                String rollname = txtrollname.Text;
                String connstr = ConfigurationManager.ConnectionStrings["dbpath"].ConnectionString;
                SqlConnection con = new SqlConnection(connstr);
                con.Open();

                String query = "INSERT INTO roles (rollname) VALUES(@rollname)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.Add(new SqlParameter("rollname", rollname));
                int n = cmd.ExecuteNonQuery();

                con.Close();
                if (n > 0)
                {
                    MessageBox.Show("roll added successfully");
                    txtrollname.Clear();
                    txtrollname.Focus();
                }

            }
        }
    }
}

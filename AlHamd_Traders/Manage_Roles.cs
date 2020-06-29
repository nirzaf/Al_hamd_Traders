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
    public partial class Manage_Roles : Form
    {
        public Manage_Roles()
        {
            InitializeComponent();
        }

        private void btnaddrole_Click(object sender, EventArgs e)
        {
            Add_Role addrole = new Add_Role();
            addrole.ShowDialog();
        }

        private void btnupdaterole_Click(object sender, EventArgs e)
        {
            Update_Role updaterole = new Update_Role();
            updaterole.ShowDialog();
        }

        private void btnremoverole_Click(object sender, EventArgs e)
        {
            Remove_Role removerole = new Remove_Role();
            removerole.ShowDialog();
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
                    dgvsearchroll.DataSource = dt;
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
                    dgvsearchroll.DataSource = dt;
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

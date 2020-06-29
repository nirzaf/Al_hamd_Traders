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
    public partial class Update_Category : Form
    {
        public Update_Category()
        {
            InitializeComponent();
        }

        private void Update_Category_Load(object sender, EventArgs e)
        {

        }
        private void loaddgv()
        {
            String connstr = ConfigurationManager.ConnectionStrings["dbpath"].ConnectionString;
            SqlConnection con = new SqlConnection(connstr);
            con.Open();
            String query = "SELECT * FROM category";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            dgvupdatedata.DataSource = dt;
            dgvupdatedata.Refresh();
        }

        private void txtcategoryid_TextChanged(object sender, EventArgs e)
        {
            if (txtcategoryid.Text.Length == 0)
            {
                return;
            }
            String input = txtcategoryid.Text;
            if (Regex.IsMatch(input, "^[0-9]+$"))
            {
                int categoryid;
                bool result = int.TryParse(input, out categoryid);
                if (result)
                {
                    String connstr = ConfigurationManager.ConnectionStrings["dbpath"].ConnectionString;
                    SqlConnection con = new SqlConnection(connstr);
                    con.Open();
                    String query = "SELECT * FROM category WHERE cat_id=@catid";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.Add(new SqlParameter("catid", categoryid));
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    con.Close();
                    if (dt.Rows.Count > 0)
                    {
                        MessageBox.Show("category data found");
                        dgvupdatedata.DataSource = dt;
                        dgvupdatedata.Refresh();
                        txtcategoryid.Text = dgvupdatedata.Rows[0].Cells["cat_id"].Value.ToString();
                        txtcategoryname.Text = dgvupdatedata.Rows[0].Cells["catname"].Value.ToString();

                    }
                    else
                    {
                        MessageBox.Show("category id does not exist");
                    }
                }

            }
            else
            {
                MessageBox.Show("ENTER VALID category ID");
            }
        }

        private void btnupdatedata_Click(object sender, EventArgs e)
        {
            if (txtcategoryid.Text.Length == 0)
            {
                MessageBox.Show("please enter category name");
                return;
            }
            else if (txtcategoryname.Text.Length == 0)
            {
                MessageBox.Show("please enter category name");
                return;
            }
            else
            {
                String catid = txtcategoryid.Text.Trim();
                String catname = txtcategoryname.Text.Trim();
                int catstatus;
                if (rdoavailable.Checked)
                {
                    catstatus = 1;
                }
                else
                {
                    catstatus = 0;
                }
                String connstr = ConfigurationManager.ConnectionStrings["dbpath"].ConnectionString;
                SqlConnection con = new SqlConnection(connstr);
                con.Open();
                String query = "UPDATE category SET catname=@catname,catstatus=@catstatus WHERE cat_id=@catid";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.Add(new SqlParameter("catid", catid));
                cmd.Parameters.Add(new SqlParameter("catname", catname));
                cmd.Parameters.Add(new SqlParameter("catstatus", catstatus));
                int n = cmd.ExecuteNonQuery();
                con.Close();
                if (n > 0)
                {
                    loaddgv();
                    dgvupdatedata.Refresh();
                    MessageBox.Show("category data updated");
                }
                else
                {
                    MessageBox.Show("category data NOT updated");
                }
            }
        }
    }
}

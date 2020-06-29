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
    public partial class Search_Medicine : Form
    {
        public Search_Medicine()
        {
            InitializeComponent();
        }
        private void loadproducts()
        {
            String connstr = ConfigurationManager.ConnectionStrings["dbpath"].ConnectionString;
            SqlConnection con = new SqlConnection(connstr);
            con.Open();

            String query = "SELECT * FROM product";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvsearch.DataSource = dt;
            dgvsearch.Refresh();

            con.Close();
        }
        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            if (txtsearch.Text.Length == 0)
            {
                MessageBox.Show("enter some text");
                return;
            }
            String input = txtsearch.Text;
            String connstr = ConfigurationManager.ConnectionStrings["dbpath"].ConnectionString;
            SqlConnection con = new SqlConnection(connstr);
            con.Open();
            SqlCommand cmd;
            if (Regex.IsMatch(input, "^[0-9]+$"))
            ///int.tryparse
            {
                ///MessageBox.Show("input is nimeric");
                int ninput;
                bool result = int.TryParse(input, out ninput);
                if (result)
                {
                    String query = "SELECT * FROM product WHERE p_id LIKE @pid OR pbarcode=@barcode";
                    cmd = new SqlCommand(query, con);
                    cmd.Parameters.Add(new SqlParameter("pid", ninput + "%"));
                    cmd.Parameters.Add(new SqlParameter("barcode", ninput));
                }
                else
                {
                    String query = "SELECT * FROM product WHERE pbarcode=@barcode";
                    cmd = new SqlCommand(query, con);
                    cmd.Parameters.Add(new SqlParameter("barcode", input));
                }
            }
            else
            {
                ///MessageBox.Show("input is alphanumeric yrrr");
                String query = "SELECT * FROM product WHERE pname LIKE @pname OR pbarcode=@barcode";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.Add(new SqlParameter("pname", "%" + input + "%"));
                cmd.Parameters.Add(new SqlParameter("barcode", input));

            }
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            dgvsearch.DataSource = dt;
            dgvsearch.Refresh();
        }

        private void Search_Medicine_Load(object sender, EventArgs e)
        {
            loadproducts();
        }
    }
}

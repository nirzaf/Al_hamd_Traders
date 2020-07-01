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
    public partial class View_Product_List : Form
    {
        public View_Product_List()
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
           dgvallproduct.DataSource = dt;
            dgvallproduct.Refresh();

            con.Close();
        }
        private void view_product_list_Load(object sender, EventArgs e)
        {
            loadproducts();
        }
    }
}

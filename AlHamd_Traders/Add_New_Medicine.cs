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
    public partial class Add_New_Medicine : Form
    {
        public Add_New_Medicine()
        {
            InitializeComponent();
        }

        private void Add_New_Medicine_Load(object sender, EventArgs e)
        {
            loadcategories();
            loadproducts();
        }
        private void reset()
        {
            txtbarcode.Clear();
            txtproductname.Clear();
            txtstock.Clear();
            txtpurchaseprice.Clear();
            txtsaleprice.Clear();
            cbxcategory.SelectedIndex = 1;
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
            dgvmedicine.DataSource = dt;
            dgvmedicine.Refresh();

            con.Close();
        }
        private void loadcategories()
        {
            String connstr = ConfigurationManager.ConnectionStrings["dbpath"].ConnectionString;
            SqlConnection con = new SqlConnection(connstr);
            con.Open();

            String query = "SELECT * FROM category WHERE catstatus=1";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cbxcategory.DataSource = dt;
            cbxcategory.DisplayMember = "catname";
            cbxcategory.ValueMember = "cat_id";

            con.Close();
        }
        private void btnaddproduct_Click(object sender, EventArgs e)
        {
            if (txtbarcode.Text.Length == 0)
            {
                MessageBox.Show("enter barcode");
                return;
            }
            else if (txtproductname.Text.Length == 0)
            {
                MessageBox.Show("enter product name");
                return;
            }
            else if (txtpurchaseprice.Text.Length == 0)
            {
                MessageBox.Show("enter purchase price");
                return;
            }
            else if (txtsaleprice.Text.Length == 0)
            {
                MessageBox.Show("enter sale price");
                return;
            }
            else if(txtstock.Text.Length == 0)
            {
                MessageBox.Show("enter purchase price");
                return;
            }

            String barcode = txtbarcode.Text;
            String productname = txtproductname.Text;
            int purchaseprice;
            purchaseprice = Convert.ToInt32(txtpurchaseprice.Text);
            int saleprice = Convert.ToInt32(txtsaleprice.Text);
            int status;
            if (rdoavailable.Checked)
            {
                status = 1;
            }
            else
            {
                status = 2;
            }
            int catid = Convert.ToInt32(cbxcategory.SelectedValue.ToString());
            int stock = Convert.ToInt32(txtstock.Text);
            String connstr = ConfigurationManager.ConnectionStrings["dbpath"].ConnectionString;
            SqlConnection con = new SqlConnection(connstr);
            con.Open();

            String query = "INSERT INTO product (pname,purchaseprice,saleprice,pstatus,pbarcode,cat_id,pstock) VALUES (@pname,@purchaseprice,@saleprice,@pstatus,@pbarcode,@catid,@stock)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.Add(new SqlParameter("pname", productname));
            cmd.Parameters.Add(new SqlParameter("purchaseprice", purchaseprice));
            cmd.Parameters.Add(new SqlParameter("saleprice", saleprice));
            cmd.Parameters.Add(new SqlParameter("pstatus", status));
            cmd.Parameters.Add(new SqlParameter("pbarcode", barcode));
            cmd.Parameters.Add(new SqlParameter("catid", catid));
            cmd.Parameters.Add(new SqlParameter("stock", stock));
            int n = cmd.ExecuteNonQuery();

            con.Close();
            if (n > 0)
            {
                MessageBox.Show("inserted successfully");
                loadproducts();
                reset();
                txtproductname.Focus();
            }
            else
            {
                MessageBox.Show("not inserted hahahahahha failed");
            }
        }

        private void btnclearall_Click(object sender, EventArgs e)
        {
            reset();
        }
        //lecture 10

    }
}

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
    public partial class Update_Product : Form
    {
        public Update_Product()
        {
            InitializeComponent();
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
            dgvmanageproducts.DataSource = dt;
            dgvmanageproducts.Refresh();

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
            dgvmanageproducts.DataSource = dt;
            dgvmanageproducts.Refresh();
        }

        private void btnupdateproduct_Click(object sender, EventArgs e)
        {
            int pid = Convert.ToInt32(lblpid.Text);
            String barcode = txtbarcode.Text;
            String pname = txtproductname.Text;
            int purchaseprice = Convert.ToInt32(txtpurchaseprice.Text);
            int stock = Convert.ToInt32(txtstock.Text);
            int saleprice = Convert.ToInt32(txtsaleprice.Text);
            int status;
            if (rdoavailable.Checked)
            {
                status = 1;
            }
            else
            {
                status = 0;
            }
            int catid = Convert.ToInt32(cbxcategory.SelectedValue);

            String connstr = ConfigurationManager.ConnectionStrings["dbpath"].ConnectionString;
            SqlConnection con = new SqlConnection(connstr);
            con.Open();

            String query = "UPDATE product SET pstatus=@status , pname=@pname , pbarcode=@barcode , purchaseprice=@purchaseprice , saleprice=@saleprice , cat_id=@catid, pstock=@stock WHERE p_id=@pid";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.Add(new SqlParameter("pname", pname));
            cmd.Parameters.Add(new SqlParameter("barcode", barcode));
            cmd.Parameters.Add(new SqlParameter("purchaseprice", purchaseprice));
            cmd.Parameters.Add(new SqlParameter("saleprice", saleprice));
            cmd.Parameters.Add(new SqlParameter("catid", catid));
            cmd.Parameters.Add(new SqlParameter("status", status));
            cmd.Parameters.Add(new SqlParameter("pid", pid));
            cmd.Parameters.Add(new SqlParameter("stock", stock));

            int n = cmd.ExecuteNonQuery();
            if (n > 0)
            {
                MessageBox.Show("product updated successfully");
                loadcategories();
                loadproducts();
                reset();
            }
            else
            {
                MessageBox.Show("failed to update produket");
            }
            con.Close();
        }

        private void btnclearall_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void dgvmanageproducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex;
            lblpid.Text = dgvmanageproducts.Rows[rowindex].Cells["p_id"].Value.ToString();
            txtbarcode.Text = dgvmanageproducts.Rows[rowindex].Cells["pbarcode"].Value.ToString();
            txtpurchaseprice.Text = dgvmanageproducts.Rows[rowindex].Cells["purchaseprice"].Value.ToString();
            txtsaleprice.Text = dgvmanageproducts.Rows[rowindex].Cells["saleprice"].Value.ToString();
            txtproductname.Text = dgvmanageproducts.Rows[rowindex].Cells["pname"].Value.ToString();
            txtstock.Text = dgvmanageproducts.Rows[rowindex].Cells["pstock"].Value.ToString();
            Boolean status = Boolean.Parse(dgvmanageproducts.Rows[rowindex].Cells["pstatus"].Value.ToString());
            ///Boolean status = Convert.ToBoolean(dgvmanageproducts.Rows[rowindex].Cells["p_status"].Value);
            if (status)
            {
                rdoavailable.Checked = true;
            }
            else
            {
                rdounavailable.Checked = true;
            }
            int catid = Convert.ToInt32(dgvmanageproducts.Rows[rowindex].Cells["cat_id"].Value);
            for (int i = 0; i < cbxcategory.Items.Count; i++)
            {
                MessageBox.Show("i am in for loop"+i);
                DataRowView drv = (DataRowView)cbxcategory.Items[i];
                if (Convert.ToInt32(drv.Row["cat_id"]) == catid)
                {
                    cbxcategory.SelectedIndex = i;
                    break;
                }

            }
        }

        private void Update_Medicine_Load(object sender, EventArgs e)
        {
            loadcategories();
            loadproducts();
        }
    }
}

    
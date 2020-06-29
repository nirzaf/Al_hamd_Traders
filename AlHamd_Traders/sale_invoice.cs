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
    public partial class sale_invoice : Form
    {
        public sale_invoice()
        {
            InitializeComponent();
        }

        private void sale_invoice_Load(object sender, EventArgs e)
        {
            txtusername.Text = globals.username.ToString();
            txtdatetime.Text = DateTime.Now.ToString("dd-mmmm-yyyy hh:mm:ss tt");
            txtsearch.Focus();
        }

        private void txtsearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)Keys.Enter)
            {
                String input = txtsearch.Text.ToString().Trim();
                if (input.Length == 0)
                {
                    return;
                }
                else
                {
                    String connstr = ConfigurationManager.ConnectionStrings["dbpath"].ConnectionString;
                    SqlConnection con = new SqlConnection(connstr);
                    con.Open();
                    SqlCommand cmd;
                    if (Regex.IsMatch(input, "^[0-9]+$"))
                    {
                        int ninput;
                        bool result = int.TryParse(input, out ninput);
                        if (result)
                        {
                            String query = "SELECT * FROM product WHERE p_id LIKE @pid OR pbarcode=@barcode";
                            cmd = new SqlCommand(query, con);
                            cmd.Parameters.Add(new SqlParameter("pid", ninput + "%"));
                            cmd.Parameters.Add(new SqlParameter("barcode", ninput));
                            SqlDataAdapter da = new SqlDataAdapter(cmd);
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            if (dt.Rows.Count == 0)
                            {
                                MessageBox.Show("product not milli");
                                txtsearch.Clear();
                                txtquantity.Text = "1";
                                txtpname.Clear();
                                txtpprice.Clear();
                                txtpstock.Clear();
                                txtsearch.Focus();
                            }
                            else if (dt.Rows.Count == 1)
                            {
                                txtpname.Text = dt.Rows[0]["pname"].ToString();
                                txtpprice.Text = dt.Rows[0]["saleprice"].ToString();
                                txtpstock.Text = dt.Rows[0]["pstock"].ToString();
                                txtpid.Text = dt.Rows[0]["p_id"].ToString();
                                ///dgvsalesinvoice.DataSource=dt;
                                txtquantity.Focus();

                            }
                            else
                            {
                                MessageBox.Show("this else will b done later");
                                ///will be done later
                            }
                        }
                        else
                        {
                            String query = "SELECT * FROM product WHERE pbarcode=@barcode";
                            cmd = new SqlCommand(query, con);
                            cmd.Parameters.Add(new SqlParameter("barcode", input));
                            SqlDataAdapter da = new SqlDataAdapter(cmd);
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            if (dt.Rows.Count == 0)
                            {
                                MessageBox.Show("product not milli");
                                txtsearch.Clear();
                                txtquantity.Text = "1";
                                txtpname.Clear();
                                txtpprice.Clear();
                                txtpstock.Clear();
                                txtsearch.Focus();
                            }
                            else if (dt.Rows.Count == 1)
                            {
                                txtpname.Text = dt.Rows[0]["pname"].ToString();
                                txtpprice.Text = dt.Rows[0]["saleprice"].ToString();
                                txtpstock.Text = dt.Rows[0]["pstock"].ToString();
                                txtpid.Text = dt.Rows[0]["p_id"].ToString();
                                ///dgvsalesinvoice.DataSource=dt;
                                txtquantity.Focus();

                            }
                            else
                            {
                                MessageBox.Show("this else will b done later");
                                ///will be done later
                            }
                        }
                    }
                    else
                    {
                        ///query againast barcode and productname
                        String query = "SELECT * FROM product WHERE pbarcode=@barcode OR pname LIKE @pname";
                        cmd = new SqlCommand(query, con);
                        cmd.Parameters.Add(new SqlParameter("barcode", input));
                        cmd.Parameters.Add(new SqlParameter("pname", "%" + input + "%"));
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        if (dt.Rows.Count == 0)
                        {
                            MessageBox.Show("product not milli");
                            txtsearch.Clear();
                            txtquantity.Text = "1";
                            txtpname.Clear();
                            txtpprice.Clear();
                            txtpstock.Clear();
                            txtsearch.Focus();
                        }
                        else if (dt.Rows.Count == 1)
                        {
                            txtpname.Text = dt.Rows[0]["pname"].ToString();
                            txtpprice.Text = dt.Rows[0]["saleprice"].ToString();
                            txtpstock.Text = dt.Rows[0]["pstock"].ToString();
                            txtpid.Text = dt.Rows[0]["p_id"].ToString();
                            ///dgvsalesinvoice.DataSource=dt;
                            txtquantity.Focus();

                        }
                        else
                        {
                            MessageBox.Show("this else will b done later");
                            ///will be done later
                        }

                    }
                    con.Close();
                }

            }
        }

        private void txtquantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)Keys.Enter)
            {
                if (txtquantity.Text.Length == 0)
                {
                    return;
                }
                else
                {
                    int qty = Convert.ToInt32(txtquantity.Text);
                    int stock = Convert.ToInt32(txtpstock.Text);
                    if (qty > stock)
                    {
                        MessageBox.Show("insufficient stock yrra");
                    }
                    else
                    {
                        int pid = Convert.ToInt32(txtpid.Text);
                        String name = txtpname.Text;
                        int price = Convert.ToInt32(txtpprice.Text);
                        int amount = qty * price;
                        dgvsalesinvoice.Rows.Add(pid, name, price, qty, amount);
                        calculatebill();
                        txtsearch.Clear();
                        txtquantity.Text = "1";
                        txtpid.Clear();
                        txtpname.Clear();
                        txtpprice.Clear();
                        txtpstock.Clear();
                        txtsearch.Focus();


                    }
                }
            }

        }
        private void calculatebill()
        {
            int totalbill = 0;
            for (int i = 0; i < dgvsalesinvoice.Rows.Count; i++)
            {
                totalbill = totalbill + Convert.ToInt32(dgvsalesinvoice.Rows[i].Cells["amount"].Value);
            }
            txttotal.Text = totalbill.ToString();
        }

        private void dgvsalesinvoice_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                int qty = Convert.ToInt32(dgvsalesinvoice.Rows[e.RowIndex].Cells["qty"].Value);
                int price = Convert.ToInt32(dgvsalesinvoice.Rows[e.RowIndex].Cells["price"].Value);
                int amount = qty * price;
                dgvsalesinvoice.Rows[e.RowIndex].Cells["amount"].Value = amount;
                calculatebill();
            }
        }

        private void btnsaveprint_Click(object sender, EventArgs e)
        {
            if (txtquantity.Text.Length == 0)
            {
                return;
            }
            int userid = globals.userid;
            DateTime invoicedate = DateTime.Now;
            int totalamount = Convert.ToInt32(txttotal.Text);

            changecalculation changecalculation = new changecalculation(totalamount);
            DialogResult dr = changecalculation.ShowDialog();
            if (dr == DialogResult.Cancel)
            {
                return;
            }

        
            String connstr = ConfigurationManager.ConnectionStrings["dbpath"].ConnectionString;
            SqlConnection con = new SqlConnection(connstr);
            con.Open();
            String query = "INSERT INTO sale_invoice (user_id,invoicedate,totalamount) output INSERTED.invoice_id VALUES (@userid,@invoicedate,@totalamount)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.Add(new SqlParameter("userid", userid));
            cmd.Parameters.Add(new SqlParameter("invoicedate", invoicedate));
            cmd.Parameters.Add(new SqlParameter("totalamount", totalamount));
            ///convert.toint32 bhi kr skty hn yahan jani
            int invoiceid = (int)cmd.ExecuteScalar();
            if (invoiceid > 0)
            {
                for (int i = 0; i < dgvsalesinvoice.Rows.Count; i++)
                {
                    query = "INSERT INTO sale_invoice_items (invoice_id,p_id,price,qty) VALUES (@invoiceid,@pid,@price,@qty)";
                    SqlCommand cmd2 = new SqlCommand(query, con);
                    cmd2.Parameters.Add(new SqlParameter("invoiceid", invoiceid));
                    cmd2.Parameters.Add(new SqlParameter("pid", Convert.ToInt32(dgvsalesinvoice.Rows[i].Cells["p_id"].Value)));
                    cmd2.Parameters.Add(new SqlParameter("price", Convert.ToInt32(dgvsalesinvoice.Rows[i].Cells["price"].Value)));
                    cmd2.Parameters.Add(new SqlParameter("qty", Convert.ToInt32(dgvsalesinvoice.Rows[i].Cells["qty"].Value)));
                    cmd2.ExecuteNonQuery();


                    int qty = Convert.ToInt32(dgvsalesinvoice.Rows[i].Cells["qty"].Value);
                    int p_id = Convert.ToInt32(dgvsalesinvoice.Rows[i].Cells["p_id"].Value);

                    String query2 = "UPDATE product SET pstock=pstock-@qty WHERE p_id=@p_id";
                    SqlCommand cmd3 = new SqlCommand(query2, con);
                    cmd3.Parameters.Add(new SqlParameter("qty", qty));
                    cmd3.Parameters.Add(new SqlParameter("p_id", p_id));
                    cmd3.ExecuteNonQuery();

                }
                txtsearch.Clear();
                txtquantity.Clear();
                txtpprice.Clear();
                txtpstock.Clear();
                txtpname.Clear();
                txtpid.Clear();
                txtdatetime.Text = DateTime.Now.ToString();
                dgvsalesinvoice.Rows.Clear();
                MessageBox.Show("invoice saved succesfully");
                purchasereciept open = new purchasereciept();
                open.ShowDialog();
            }
        }

        private void txtusername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

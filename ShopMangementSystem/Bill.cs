using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopMangementSystem
{
    public partial class Bill : Form
    {
        public Bill()
        {
            InitializeComponent();
            DispalyBill();
            GetCusId();
            DispalyProduct();
            this.StartPosition = FormStartPosition.CenterScreen;

        }
        readonly SqlConnection Con = new SqlConnection(connectionString: @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\maksy\OneDrive\Документи\ShopManagementSystem.mdf;Integrated Security=True;Connect Timeout=30 ");

        private void DispalyBill()
        {
            try
            {
                Con.Open();
                string Querry = "select * from [Bill]";
                SqlDataAdapter adapter = new SqlDataAdapter(Querry, Con);
                SqlCommandBuilder scb = new SqlCommandBuilder(adapter);
                var ds = new DataSet();
                adapter.Fill(ds);
                BillDgv.DataSource = ds.Tables[0];
                Con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Con.Close();
            }

        }
        private void DispalyProduct()
        {
            try
            {
                Con.Open();
                string Querry = "select * from [Product]";
                SqlDataAdapter adapter = new SqlDataAdapter(Querry, Con);
                SqlCommandBuilder scb = new SqlCommandBuilder(adapter);
                var ds = new DataSet();
                adapter.Fill(ds);
                ProductDgv.DataSource = ds.Tables[0];
                Con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Con.Close();
            }

        }
        private void GetCusId()
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("Select CusId from Customer", Con);
                SqlDataReader Rdr;
                Rdr = cmd.ExecuteReader(); 
                DataTable dt = new DataTable();
                dt.Columns.Add("CusId", typeof(int));
                dt.Load(Rdr);
                CusIdCb.ValueMember = ("CusId");
                CusIdCb.DataSource = dt;
                Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Con.Close();
            }
        }
        string Cname;

        void DispalyCusName()
        {
            try
            {
                Con.Open();
                string ss = "select * from Customer where CusId=" + CusIdCb.SelectedValue.ToString();
                SqlCommand cmd = new SqlCommand(ss, Con);
                DataTable dt = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    Cname = dr["CusName"].ToString();
                    CusNameTb.Text = Cname;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Con.Close();
            }
        }


        private void CrossBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            BillIdTb.Text = "";
            ProNameCb.Text = "";
            CusIdCb.Text = "";
            CusNameTb.Text = "";
            ProQuanTb.Text = "";
            UPTb.Text = "";
            PriceTb.Text = "";
        }

        private void Bill_Load(object sender, EventArgs e)
        {
            DispalyCusName();
        }

        int flag = 0;
        int stock;

        private void ProductDgv_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                ProNameCb.Text = ProductDgv.SelectedRows[0].Cells[1].Value.ToString();
                UPTb.Text = ProductDgv.SelectedRows[0].Cells[4].Value.ToString();
                stock = Convert.ToInt32(ProductDgv.SelectedRows[0].Cells[3].Value);
                flag = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Con.Close();
            }
        }

        int sum;
        private void AddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (BillIdTb.Text=="" || ProQuanTb.Text=="" || UPTb.Text=="")
                {
                    MessageBox.Show("Missing Information");
                }else if (Convert.ToInt32(ProQuanTb.Text) > stock)
                {
                    MessageBox.Show("Not Enough Stock Available");
                }
                else
                {
                    Con.Open();
                    int Total = Convert.ToInt32(ProQuanTb.Text) * Convert.ToInt32(UPTb.Text);
                    sum = sum + Total;
                    PriceTb.Text = sum.ToString();
                    String query = "insert into [Bill] values('" + BillIdTb.Text + "', '"+ProNameCb.Text+"', '"+CusIdCb.Text+"', '"+CusNameTb.Text+"', '"+ProQuanTb.Text+"', '"+UPTb.Text+"', '"+PriceTb.Text+"')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    Con.Close();
                    MessageBox.Show("Record Entered Successfully");
                    DispalyBill();
                    UpdateProduct();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Con.Close();
            }
        }
        void UpdateProduct()
        {
            try
            {
                string id = ProductDgv.SelectedRows[0].Cells[0].Value.ToString();
                int Qty = stock - Convert.ToInt32(ProQuanTb.Text);
                if(Qty < 0)
                {
                    MessageBox.Show("Operation Failed");
                }
                else
                {
                    Con.Open();
                    string query = "update Product set Quantity = '" + Qty + "'Where ProId='" + id + "';";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    Con.Close ();
                    DispalyProduct();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Con.Close();
            }
        }

        private void Customerlbl_Click(object sender, EventArgs e)
        {
            Customer obj = new Customer();
            obj.Show();
            this.Hide();
        }

        private void Productlbl_Click(object sender, EventArgs e)
        {
            Product obj = new Product();
            obj.Show();
            this.Hide();
        }

        private void Logoutlbl_Click(object sender, EventArgs e)
        {
            Login obj = new Login();
            obj.Show();
            this.Hide();
        }

        private void DelBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (BillIdTb.Text == "")
                {
                    MessageBox.Show("Missing information");
                }
                else
                {
                    Con.Open();
                    string query = "delete from Bill where BillId= '" + BillIdTb.Text + "'";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    Con.Close();
                    MessageBox.Show("Record Deleted Successfully");
                    DispalyBill();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Con.Close();
            }
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (BillIdTb.Text == "" || ProNameCb.Text == "" || CusIdCb.Text == "" || CusNameTb.Text == "" || ProQuanTb.Text == "" || UPTb.Text == "" || PriceTb.Text == "")
                {
                    MessageBox.Show("Missing information");
                }
                else
                {
                    Con.Open();

                    int quantity = Convert.ToInt32(ProQuanTb.Text);
                    int unitPrice = Convert.ToInt32(UPTb.Text);
                    int total = quantity * unitPrice;


                    string query = "update [Bill] set Product=@PN, CusId=@CI, CusName=@CN, Quantity=@Q, UnitPrice=@UP, Total=@T Where BillId=@BI";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.Parameters.AddWithValue(@"BI", BillIdTb.Text);
                    cmd.Parameters.AddWithValue(@"PN", ProNameCb.Text);
                    cmd.Parameters.AddWithValue(@"CI", CusIdCb.Text);
                    cmd.Parameters.AddWithValue(@"CN", CusNameTb.Text);
                    cmd.Parameters.AddWithValue(@"Q", ProQuanTb.Text);
                    cmd.Parameters.AddWithValue(@"UP", UPTb.Text);
                    cmd.Parameters.AddWithValue(@"T", total);
                    cmd.ExecuteNonQuery();
                    Con.Close();
                    MessageBox.Show("Record Updated Successfully");
                    DispalyBill();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Con.Close();
            }
        }

        private void BillDgv_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                BillIdTb.Text = BillDgv.SelectedRows[0].Cells[0].Value.ToString();
                ProNameCb.Text = BillDgv.SelectedRows[0].Cells[1].Value.ToString();
                CusIdCb.Text = BillDgv.SelectedRows[0].Cells[2].Value.ToString();
                CusNameTb.Text = BillDgv.SelectedRows[0].Cells[3].Value.ToString();
                ProQuanTb.Text = BillDgv.SelectedRows[0].Cells[4].Value.ToString();
                UPTb.Text = BillDgv.SelectedRows[0].Cells[5].Value.ToString();
                PriceTb.Text = BillDgv.SelectedRows[0].Cells[6].Value.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Con.Close();
            }
        }

        private void CusIdCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            DispalyCusName();
        }
    }         
}


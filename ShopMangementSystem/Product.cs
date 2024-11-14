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
    public partial class Product : Form
    {
        public Product()
        {
            InitializeComponent();
            DispalyProduct();
        }
        readonly SqlConnection Con = new SqlConnection(connectionString: @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\maksy\OneDrive\Документи\ShopManagementSystem.mdf;Integrated Security=True;Connect Timeout=30 ");

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
        private void ResetBtn_Click(object sender, EventArgs e)
        {

        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {

        }

        private void AddBtn_Click(object sender, EventArgs e)
        {

        }

        private void DelBtn_Click(object sender, EventArgs e)
        {

        }

        private void CrossBtn_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CrossBtn_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ResetBtn_Click_1(object sender, EventArgs e)
        {
            ProIdTb.Text = "";
            ProNameCb.Text = "";
            ProCatCb.Text = "";
            ProQuanTb.Text = "";
            UPTb.Text = "";
        }

        private void AddBtn_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (ProIdTb.Text == " " || ProNameCb.Text == " " || ProCatCb.Text == " " || ProQuanTb.Text == " " || UPTb.Text == " ")
                {
                    MessageBox.Show("Missing information");
                }
                else
                {
                    Con.Open();
                    string query = "insert into [Product] values('" + ProIdTb.Text + "', '" + ProNameCb.Text + "', '" + ProCatCb.Text + "', '" + ProQuanTb.Text + "', '" + UPTb.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    Con.Close();
                    MessageBox.Show("Record Entered Successfully");
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

        private void UpdateBtn_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (ProIdTb.Text == " " || ProNameCb.Text == " " || ProCatCb.Text == " " || ProQuanTb.Text == " " || UPTb.Text == " ")
                {
                    MessageBox.Show("Missing information");
                }
                else
                {
                    Con.Open();
                    string query = "update [Product] set ProName=@PN, ProCategory=@PC, Quantity=@Q, UnitPrice=@UP Where ProId=@PI";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.Parameters.AddWithValue(@"PI", ProIdTb.Text);
                    cmd.Parameters.AddWithValue(@"PN", ProNameCb.Text);
                    cmd.Parameters.AddWithValue(@"PC", ProCatCb.Text);
                    cmd.Parameters.AddWithValue(@"Q", ProQuanTb.Text);
                    cmd.Parameters.AddWithValue(@"UP", UPTb.Text);
                    cmd.ExecuteNonQuery();
                    Con.Close();
                    MessageBox.Show("Record Updated Successfully");
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

        private void DelBtn_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (ProIdTb.Text == "")
                {
                    MessageBox.Show("Missing information");
                }
                else
                {
                    Con.Open();
                    string query = "delete from Product where ProId= '" + ProIdTb.Text + "'";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    Con.Close();
                    MessageBox.Show("Record Deleted Successfully");
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

        private void ProductDgv_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                ProIdTb.Text = ProductDgv.SelectedRows[0].Cells[0].Value.ToString();
                ProNameCb.Text = ProductDgv.SelectedRows[0].Cells[1].Value.ToString();
                ProCatCb.Text = ProductDgv.SelectedRows[0].Cells[2].Value.ToString();
                ProQuanTb.Text = ProductDgv.SelectedRows[0].Cells[3].Value.ToString();
                UPTb.Text = ProductDgv.SelectedRows[0].Cells[4].Value.ToString();
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

        private void Billlbl_Click(object sender, EventArgs e)
        {
            Bill obj = new Bill();
            obj.Show();
            this.Hide();   
        }

        private void Logoutlbl_Click(object sender, EventArgs e)
        {
            Login obj = new Login();    
            obj.Show();
            this.Hide();
        }
    }
}

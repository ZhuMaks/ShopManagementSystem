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
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
            DispalyCustomer();
        }
        readonly SqlConnection Con = new SqlConnection(connectionString: @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\maksy\OneDrive\Документи\ShopManagementSystem.mdf;Integrated Security=True;Connect Timeout=30 ");

        private void DispalyCustomer()
        {
            try
            {
                Con.Open();
                string Querry = "select * from [Customer]";
                SqlDataAdapter adapter = new SqlDataAdapter(Querry,Con);
                SqlCommandBuilder scb = new SqlCommandBuilder(adapter);
                var ds = new DataSet();
                adapter.Fill(ds);
                CustomerDgv.DataSource = ds.Tables[0];
                Con.Close();

            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Con.Close();
            }
        }

        private void UNameTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if(CusIdTb.Text==" " ||CusNameTb.Text==" " ||CusPhoneTb.Text==" ")
                {
                    MessageBox.Show("Missing information");
                }
                else
                {
                    Con.Open();
                    string query = "insert into [Customer] values('"+CusIdTb.Text+"', '"+CusNameTb.Text+"', '"+CusPhoneTb.Text+"')";
                    SqlCommand cmd = new SqlCommand(query,Con);
                    cmd.ExecuteNonQuery();
                    Con.Close();
                    MessageBox.Show("Record Entered Successfully");
                    DispalyCustomer();
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
            CusIdTb.Text = "";
            CusNameTb.Text = "";
            CusPhoneTb.Text = "";
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (CusIdTb.Text == " " || CusNameTb.Text == " " || CusPhoneTb.Text == " ")
                {
                    MessageBox.Show("Missing information");
                }
                else
                {
                    Con.Open();
                    string query = "update [Customer] set CusName=@CN, CusPhone=@CP Where CusId=@CI";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.Parameters.AddWithValue(@"CI", CusIdTb.Text);
                    cmd.Parameters.AddWithValue(@"CN", CusNameTb.Text);
                    cmd.Parameters.AddWithValue(@"CP", CusPhoneTb.Text);
                    cmd.ExecuteNonQuery();
                    Con.Close();
                    MessageBox.Show("Record Updated Successfully");
                    DispalyCustomer();
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

        private void DelBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if(CusIdTb.Text == "")
                {
                    MessageBox.Show("Missing information");
                }
                else
                {
                    Con.Open();
                    string query = "delete from Customer where CusId= '" + CusIdTb.Text + "'";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    Con.Close();
                    MessageBox.Show("Record Deleted Successfully");
                    DispalyCustomer();
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

        private void CustomerDgv_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                CusIdTb.Text= CustomerDgv.SelectedRows[0].Cells[0].Value.ToString();
                CusNameTb.Text = CustomerDgv.SelectedRows[0].Cells[1].Value.ToString();
                CusPhoneTb.Text = CustomerDgv.SelectedRows[0].Cells[2].Value.ToString();
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

        private void Productlbl_Click(object sender, EventArgs e)
        {
            Product obj = new Product();
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

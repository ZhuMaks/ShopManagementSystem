using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopMangementSystem
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

            PasswordTb.UseSystemPasswordChar = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                PasswordTb.UseSystemPasswordChar = false;
            }
            else
            {
                PasswordTb.UseSystemPasswordChar = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UNameTb.Text = "";
            PasswordTb.Text = "";
        }

        private void LogBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (UNameTb.Text == " " && PasswordTb.Text == " ")
                {
                    MessageBox.Show("Missing Information");
                } else if (UNameTb.Text == "Admin" && PasswordTb.Text == "Password")
                {
                    MessageBox.Show("Login Succesfully!");
                    Customer obj = new Customer();
                    obj.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Please Enter correct Username and Password");
                }
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

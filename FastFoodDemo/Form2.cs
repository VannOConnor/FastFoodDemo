using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastFoodDemo
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(guna2TextBox1.Text == "admin" || guna2TextBox2.Text == "admin")

            {
                this.Hide();
                Form1 suksesLogin = new Form1();
                suksesLogin.Show();
            }else
            {
                MessageBox.Show("Username dan password anda salah");
            }
            if(guna2TextBox1.Text == "" || guna2TextBox2.Text == "")
            {
                MessageBox.Show("Username dan password tidak boleh kosong");
            }
        
        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pondcalc_dale_smallwood_130089872_lv4_2020
//all images used where gatherd from https://unsplash.com/ 
{
    public partial class Form1 : Form
    {
        string[] AdminUsers = { "Admin"}; //Admin usernames
        string[] AdminPassword = { "Admin123"}; // Admin Sasswords
        string[] StaffUsers = {"Dale", "Jeff", "Frank" };//Staff Usernames
        string[] StaffPassword = { "Staff123" }; //Staff Passwords
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text == AdminUsers[0] && txtPassword.Text == AdminPassword[0]) 
            {
                new Form2().Show();
                this.Hide();
            }

            else 
            {
                MessageBox.Show("Invaild Username or Password, Try user:Admin Password:Admin123");
                txtUserName.Clear();
                txtPassword.Clear();
                txtUserName.Focus();
            }

            
            if (txtUserName.Text == StaffUsers[0] && txtPassword.Text == StaffPassword[0])
            {
                new PondInput().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invaild Username or Password, Try user:Dale Password:Staff123");
                txtUserName.Clear();
                txtPassword.Clear();
                txtUserName.Focus();

            }
        }   

        private void Clear_Click(object sender, EventArgs e)
        {
            txtUserName.Clear();
            txtPassword.Clear();
            txtUserName.Focus();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

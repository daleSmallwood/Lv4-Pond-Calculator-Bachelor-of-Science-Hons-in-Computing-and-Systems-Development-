using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login_system
{
    public partial class Form1 : Form
    {
        int recordNum;
        string[] users = { "Guest","Admin", "Dale", "Bob", "Jeff", "Bobby", "Paul" };
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtUsername.Text = users[recordNum].ToString();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            recordNum--;
            txtUsername.Text = users[recordNum].ToString();

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            recordNum++;
            txtUsername.Text = users[recordNum].ToString();
        }
    }
}

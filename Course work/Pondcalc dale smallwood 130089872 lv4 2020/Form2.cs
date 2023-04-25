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
{
    public partial class Form2 : Form
    {
        string[] SubmitConfirm = { "Admin123" }; //Admin Confermation input
        public Form2()
        {
            InitializeComponent();
        }

        private void NewUser_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void Remove_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void None_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void PhraseSubmit_Click(object sender, EventArgs e)
        {//Disables uneeded infomation for required actions
            if (NewUser.Checked && Confirmation.Text == SubmitConfirm[0])
            {
                GroupBoxNewUser.Enabled = true;
                GroupBoxRemoveUser.Enabled = false;
                ExistingUsers.Enabled = false;
                RemoveUser.Enabled = false;
                SubmitNewUser.Enabled = true;
                Continue.Enabled = false;

            }

            if (Remove.Checked && Confirmation.Text == SubmitConfirm[0])
            {
                GroupBoxNewUser.Enabled = false;
                GroupBoxRemoveUser.Enabled = true;
                ExistingUsers.Enabled = true;
                RemoveUser.Enabled = true;
                SubmitNewUser.Enabled = false;
                Continue.Enabled = false;

            }
            if (None.Checked && Confirmation.Text == SubmitConfirm[0])
            {
                GroupBoxNewUser.Enabled = false;
                GroupBoxRemoveUser.Enabled = false;
                ExistingUsers.Enabled = false;
                RemoveUser.Enabled = false;
                SubmitNewUser.Enabled = false;
                Continue.Enabled = true;
            }


        }

        private void Confirmation_TextChanged(object sender, EventArgs e)
        {

        }

        private void GroupBoxNewUser_Enter(object sender, EventArgs e)
        {

        }

        private void SubmitNewUser_Click(object sender, EventArgs e)
        {
            Continue.Enabled = true;
        }

        private void GroupBoxRemoveUser_Enter(object sender, EventArgs e)
        {

        }

        private void RemoveUser_Click(object sender, EventArgs e)
        {
            Continue.Enabled = true;
        }

        private void AdminProgress_Click(object sender, EventArgs e)
        {
           

            
               
        }

      
        
        private void AdminMenuTimer_Tick(object sender, EventArgs e)
        {
            this.AdminProgress.Increment(1);
        }

        private void Continue_Click(object sender, EventArgs e)
        {
            this.AdminMenuTimer.Start();

            if (AdminProgress.Value >= AdminProgress.Maximum)
            {
                // Stop timer
                AdminMenuTimer.Stop();


                new PondInput().Show();
                this.Hide();



            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }   

}

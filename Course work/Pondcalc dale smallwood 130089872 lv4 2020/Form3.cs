using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Pondcalc_dale_smallwood_130089872_lv4_2020
{
    public partial class PondInput : Form
    {
        private PrintDocument printDocument1;
        private object printPreviewDialog1;

        public PondInput()
        {
            InitializeComponent();
        }

        private void Caculate_Click(object sender, EventArgs e)
        {
            Boolean alertcheck = false;
            bool ok = true;

            //client name validation
            if (Name.Text == "")
            {
                MessageBox.Show("Please input clients name");
                alertcheck = true;
                ok = false;
                return;
            }
            //client adress validation
            if (Address.Text == "")
            {
                MessageBox.Show("Please input clients Address");
                alertcheck = true;
                ok = false;
                return;
            }
            /*static bool PhoneNumb(string number) 
             * This section is comment'd out as i currently do not have c# 8.0 i am on 7.3
             * but this statment is to check if a moblie phone number is input'd into the pondcalc under the client moblie section.

            {
                return number[0] == '0' &number[1] == '7' && number.Length == 11 && IsDigit(number);
            }
            static bool IsDigit(string input)
            {
                foreach (char c in input)
                {
                    if (c < '0' || c > '9')
                        return false;
                }
                return true;
                    
            }*/
            string clientEmail = Email.Text;
            {
               /* if(ValidEmail(clientEmail))
                {
                    alertcheck = false;
                    ok = true;
                    return;

                }
                else
                {
                    MessageBox.Show("Email is Invalid");
                    alertcheck = true;
                    ok = false;
                    return;
                }
               /*private static bool ValidEmail(string clientEmail)
                {
                    try
                    {
                        MailAdress mail = new MailAdress(clientEmail);
                        return true;
                    }
                    catch (Exception e)
                    {
                        return false;
                    }

                }*/
            }
            float PondLength = 0;
            if (!float.TryParse(tbPondLength.Text, out PondLength))
            {
                /*Validation for length of pond */
                if (alertcheck == false)

                {

                    MessageBox.Show("Please enter the desired length");
                    alertcheck = true;
                    ok = false;
                    return;

                }
            }
            if (PondLength < 1f)
            {
                if (alertcheck == false)
                {
                    MessageBox.Show("Length cannot be smaller than 1 metre.");
                    alertcheck = true;
                    ok = false;
                    return;
                }
            }
            if (PondLength > 10f)
            {
                if (alertcheck == false)
                {
                    MessageBox.Show("Length cannot be greater than 10 metre.");
                    alertcheck = true;
                    ok = false;
                    return;
                }
            }
            else if (PondLength < 1f)
            {
                MessageBox.Show("Length must be greater than 1");
                ok = false;
                return;
            }
            float PondWidth = 0;
            if (!float.TryParse(tbPondWidth.Text, out PondWidth))
            {
                /*Validation for Width of pond */
                if (alertcheck == false)
                {
                    MessageBox.Show("Please enter the desired Width");
                    alertcheck = true;
                    ok = false;
                    return;

                }
            }
            if (PondWidth < 1f)
            {
                if (alertcheck == false)
                {
                    MessageBox.Show("Width cannot be smaller than 1 metre.");
                    alertcheck = true;
                    ok = false;
                    return;
                }
            }
            if (PondWidth > 10f)
            {
                if (alertcheck == false)
                {
                    MessageBox.Show("Width cannot be greater than 10 metre.");
                    alertcheck = true;
                    ok = false;
                    return;
                }
            }
            else if (PondWidth < 1f)
            {
                MessageBox.Show("Width must be greater than 1");
                ok = false;
                return;
            }
            float PondDepth = 0;
            if (!float.TryParse(tbPondDepth.Text, out PondDepth))
            {
                /*Validation for Depth of pond */
                if (alertcheck == false)
                {
                    MessageBox.Show("Please enter the desired Depth");
                    alertcheck = true;
                    ok = false;
                    return;
                }
            }
            if (PondDepth < 1f)
            {
                if (alertcheck == false)
                {
                    MessageBox.Show("Depth cannot be smaller than 1 metre.");
                    alertcheck = true;
                    ok = false;
                    return;
                }
            }
            if (PondDepth > 10f)
            {
                if (alertcheck == false)
                {
                    MessageBox.Show("Depth cannot be greater than 10 metre.");
                    alertcheck = true;
                    ok = false;
                    return;
                }
            }
            else if (PondDepth < 1f)
            {
                MessageBox.Show("Depth must be greater than 1.");
                ok = false;
                return;
            }

            if (ok == true)
            {


                // Mesurment var's


                float Perimeter = 0.0f;
                float Area = 0.0f;
                float Volume = 0.0f;
                //calculation
                Perimeter = 2 * (PondLength + PondWidth);
                Area = (PondLength * PondWidth);
                Volume = (PondLength * PondWidth * PondDepth);

                //Dig cost calculation
                float DigCost = PondLength * PondWidth * PondDepth * 50.00f;
                tbDigCost.Text = "£" + DigCost.ToString("0.00");
                //Liner calculation
                float Liner = (PondLength + 2 * PondDepth + 1) * (PondWidth + 2 * PondDepth + 1) * 3.00f;
                tbLinerCost.Text = "£" + Liner.ToString("0.00");
                //Underlay calculation
                float Underlay = (PondLength + 2 * PondDepth + 1) * (PondWidth + 2 * PondDepth + 1) * 2.00f;
                tbUnderlayCost.Text = "£" + Underlay.ToString("0.00");
                //Edge calculations
                float edgeCost = 0;
                //Edge var's
                if (PondEdge.Text == "Concrete paving 0.5m x 0.5m") { edgeCost = (Perimeter * 2) * 0.75f; }
                if (PondEdge.Text == "Stone paving 0.5m x 0.5m") { edgeCost = (Perimeter * 2) * 2.20f; }
                if (PondEdge.Text == "Stone paving 0.5m x 0.75m") { edgeCost = (Perimeter * 2) * 3.50f; }
                if (PondEdge.Text == "Plain concrete 0.5m") { edgeCost = (Perimeter * 2) * 4.00f; }
                if (PondEdge.Text == "Brick paving 0.5m") { edgeCost = (Perimeter * 2) * 20.00f; }
                if (PondEdge.Text == "Decking 0.5m") { edgeCost = (Perimeter * 2) * 20.00f; }   
                if (PondEdge.Text == "Wall 0.5m") { edgeCost = (Perimeter * 2) * 60.00f; }
               // else if (PondEdge.Text) "" { MessageBox.Show("Please select a Edge."); alertcheck = true; ok = false; } <- this var needs fixing

                //Edge result
                tbEdging.Text = "£" + edgeCost.ToString("0.00");
                //Extra features calculation
                float ExtraCost = 0;
                if (Pump.Checked == true) { ExtraCost += +100f; }
                if (Lights.Checked == true) { ExtraCost += +75f; }
                if (Filter.Checked == true) { ExtraCost += +20f; }
                if (OxygenPlant.Checked == true) { ExtraCost = (Volume * 5) * 0.75f; }
                if (Lilles.Checked == true) { ExtraCost = (float)Math.Floor(Area * 2); }
                if (Invert.Checked == true) { ExtraCost = (float)Math.Floor(Area * 3); }
                if (Mermaid_Plant.Checked == true) { ExtraCost = Perimeter * 4 * 2; }
                if (Fish.Checked == true) { ExtraCost = Volume * 10 * 0.5f; }
                
                //Display extra cost
                tbExtraCost.Text = "£" + ExtraCost.ToString("0.00");
                //labour
                float labour = 200f;
                tbLabourCost.Text = "£" + labour.ToString("0.00");
                //Markup 
                float Markup = (Liner + edgeCost + Underlay + ExtraCost /100) * 0.25f ;
                tbMarkup.Text = "£" + Markup.ToString("0.00");
                //vat
                float VAT = (DigCost + Liner + Underlay +ExtraCost + edgeCost +labour + Markup /100) * 0.20f;
                tbVatCost.Text = "£" + VAT.ToString("0.00");
                //total
                float Total = (DigCost + Liner + Underlay + ExtraCost + edgeCost + labour + Markup + VAT);
                tbTotalCost.Text = "£" + Total.ToString("0.00");








            }

        }



        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void PondLength_TextChanged(object sender, EventArgs e)
        {

        }

        private void PondDepth_TextChanged(object sender, EventArgs e)
        {

        }

        private void PondWidth_TextChanged(object sender, EventArgs e)
        {

        }

        private void PondEdge_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //calculations




        //Extra's calculation 


        private void Lilles_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Mermaid_Plant_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void New_Click(object sender, EventArgs e)
        {
            Name.Clear();
            Address.Clear();
            PhoneNumb.Clear();
            Email.Clear();
            tbPondLength.Clear();
            tbPondDepth.Clear();
            tbPondWidth.Clear();
            PondEdge.ResetText();
            ExtraBox.ResetText();
            tbDigCost.Clear();
            tbEdging.Clear();
            tbExtraCost.Clear();
            tbLabourCost.Clear();
            tbVatCost.Clear();
            tbTotalCost.Clear();
            tbLinerCost.Clear();
            tbUnderlayCost.Clear();
            tbMarkup.Clear();



        }

        private void Name_TextChanged(object sender, EventArgs e)
        {

        }

        private void DigCost_TextChanged(object sender, EventArgs e)
        {

        }

        private void ExtraTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void Save_Click(object sender, EventArgs e)
        {
           // Output.add()
        }

        private void Load_Click(object sender, EventArgs e)
        {
            string FilePath = @"C:\Users\dales\Dropbox\My PC (LAPTOP-D0497OJ7)\Desktop\Dales course work\year 1\greg program fundamentals\codin\Pond Calc lv4 infomation input.txt";

           // string[] Input = File.ReadAllLines(FilePath);     

            List<string> Input = new List<string>();
            Input = File.ReadAllLines(FilePath).ToList();
            foreach (string line in Input)
            {
                
            }
        }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(this.QuoteDate.Text, this.QuoteDate.Font, Brushes.Black, new Point(10, 10));
        }

        private void Print_Click(object sender, EventArgs e)
        {
           // PrintPreviewDialog.Document = printDocument1;
           // PrintPreviewDialog.ShowDialog(); printDocument1.PrintPage += printDocument1_PrintPage;
        }
    }
}

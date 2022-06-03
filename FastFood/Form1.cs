using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastFood
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Datelbl.Text = DateTime.Now.ToLongTimeString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Datelbl.Text = DateTime.Now.ToLongDateString();
            timer1.Start();
        }

        private void FriesCb_CheckedChanged(object sender, EventArgs e)
        {
            if(FriesCb.Checked == true)
            {
                FriesTb.Enabled = true;
            }
            if (FriesCb.Checked == false)
            {
                FriesTb.Enabled = false;
                FriesTb.Text = "0";
            }

        }

        private void BurgerCb_CheckedChanged(object sender, EventArgs e)
        {
            if (FriesCb.Checked == true)
            {
                BurgerTb.Enabled = true;
            }
            if (BurgerCb.Checked == false)
            {
                BurgerTb.Enabled = false;
                BurgerTb.Text = "0";
            }
        }

        private void SaladCb_CheckedChanged(object sender, EventArgs e)
        {
            if (SaladCb.Checked == true)
            {
                SaladTb.Enabled = true;
            }
            if (SaladCb.Checked == false)
            {
                SaladTb.Enabled = false;
                SaladTb.Text = "0";
            }
        }

        private void SandwichCb_CheckedChanged(object sender, EventArgs e)
        {
            if (SandwichCb.Checked == true)
            {
                SandwichTb.Enabled = true;
            }
            if (SandwichCb.Checked == false)
            {
                SandwichTb.Enabled = false;
                SandwichTb.Text = "0";
            }
        }

        private void ChickenCb_CheckedChanged(object sender, EventArgs e)
        {
            if (ChickenCb.Checked == true)
            {
                ChickenTb.Enabled = true;
            }
            if (ChickenCb.Checked == false)
            {
                ChickenTb.Enabled = false;
                ChickenTb.Text = "0";
            }
        }


        private void TeaCb_CheckedChanged(object sender, EventArgs e)
        {
            if (TeaCb.Checked == true)
            {
                TeaTb.Enabled = true;
            }
            if (TeaCb.Checked == false)
            {
                TeaTb.Enabled = false;
                TeaTb.Text = "0";
            }
        }

        private void ColaCb_CheckedChanged(object sender, EventArgs e)
        {
            if (ColaCb.Checked == true)
            {
                ColaTb.Enabled = true;
            }
            if (ColaCb.Checked == false)
            {
                ColaTb.Enabled = false;
                ColaTb.Text = "0";
            }
        }

        private void WaterCb_CheckedChanged(object sender, EventArgs e)
        {
            if (WaterCb.Checked == true)
            {
                WaterTb.Enabled = true;
            }
            if (WaterCb.Checked == false)
            {
                WaterTb.Enabled = false;
                WaterTb.Text = "0";
            }
        }

        private void ChocolateCb_CheckedChanged(object sender, EventArgs e)
        {
            if (ChocolateCb.Checked == true)
            {
                ChocolateTb.Enabled = true;
            }
            if (ChocolateCb.Checked == false)
            {
                ChocolateTb.Enabled = false;
                ChocolateTb.Text = "0";
            }
        }

        private void PancakesCb_CheckedChanged(object sender, EventArgs e)
        {
            if (PancakesCb.Checked == true)
            {
                PancakesTb.Enabled = true;
            }
            if (PancakesCb.Checked == false)
            {
                PancakesTb.Enabled = false;
                PancakesTb.Text = "0";
            }
        }

        private void Closelbl_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void flowLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        //Declare unit price to different meal and drinks
        double friesup = 50, burgerup = 80, saladup = 100, sandwichup = 75, chickenup = 80, cheeseup = 80;
        double waterup = 15, teaup = 15, cocaup = 20, chocolateup = 25, pancakesup = 30, orangeup = 25;

        

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(ReceiptTb.Text+" Subtotal "+Subtotallbl.Text+"Tax: "+ taxlbl.Text+"Grand Total "+Grdtotallbl.Text, new Font("Century Gothic", 12, FontStyle.Regular), Brushes.Blue, new Point(130));
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if(printPreviewDialog1.ShowDialog()==DialogResult.OK)
            {
                printDocument1.Print();
            }
        }
        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FriesCb.Checked = false;
            BurgerCb.Checked = false;
            SaladCb.Checked = false;
            SandwichCb.Checked = false;
            ChickenCb.Checked = false;
            CheeseCb.Checked = false;
            WaterCb.Checked = false;
            TeaCb.Checked = false;
            ColaCb.Checked = false;
            ChocolateCb.Checked = false;
            PancakesCb.Checked = false;
            OrangeCb.Checked = false;
            ReceiptTb.Text = "";

        }

        //Declare variable to hold total price for each drinks and meals
        double friestp, burgertp, saladtp, sandwichtp, chickentp;
        double cheesetp;
        double watertp, teatp, cocatp, chocolatetp, pancakestp; 
        double orangetp;
        double Subtotal = 0, tax, grdtotal;
        private void button2_Click(object sender, EventArgs e)
        {
            friestp = friesup * Convert.ToDouble(FriesTb.Text);
            burgertp = burgerup * Convert.ToDouble(BurgerTb.Text);
            saladtp = saladup * Convert.ToDouble(SaladTb.Text);
            sandwichtp = sandwichup * Convert.ToDouble(SandwichTb.Text);
            chickentp = chickenup * Convert.ToDouble(ChickenTb.Text);
            cheesetp = cheeseup * Convert.ToDouble(CheeseTb.Text);
            //Now for drinks
            watertp = waterup * Convert.ToDouble(WaterTb.Text);
            teatp = teaup * Convert.ToDouble(TeaTb.Text);
            cocatp = cocaup * Convert.ToDouble(ColaTb.Text);
            chocolatetp = chocolateup * Convert.ToDouble(ChocolateTb.Text);
            pancakestp = pancakesup * Convert.ToDouble(PancakesTb.Text);
            orangetp = orangeup * Convert.ToDouble(OrangeTb.Text);
            //Now Add products on the receipt

            ReceiptTb.Clear();
            Subtotal = 0;
            tax = 0;
            grdtotal = 0;
            ReceiptTb.AppendText(Environment.NewLine);
            ReceiptTb.AppendText("\t\t\tJust a cat's restaurant\t\t" + Datelbl.Text+Environment.NewLine);
            ReceiptTb.AppendText("\t\t\t*************************************"+Environment.NewLine);
            if(FriesCb.Checked == true)
            {
                ReceiptTb.AppendText("\tFries:\t" + friestp + "Rs" + Environment.NewLine);
                Subtotal = Subtotal + friestp;
                Subtotallbl.Text = "" + Subtotal;
            }

            if (BurgerCb.Checked == true)
            {
                ReceiptTb.AppendText("\tBurger:\t" + burgertp + "Rs" + Environment.NewLine);
                Subtotal = Subtotal + burgertp;
                Subtotallbl.Text = "" + Subtotal;
            }
            if (SaladCb.Checked == true)
            {
                ReceiptTb.AppendText("\tSalad:\t" + saladtp + "Rs" + Environment.NewLine);
                Subtotal = Subtotal + saladtp;
                Subtotallbl.Text = "" + Subtotal;
            }
            if (SandwichCb.Checked == true)
            {
                ReceiptTb.AppendText("\tSandwich:\t" + sandwichtp + "Rs" + Environment.NewLine);
                Subtotal = Subtotal + sandwichtp;
                Subtotallbl.Text = "" + Subtotal;
            }

            if (ChickenCb.Checked == true)
            {
                ReceiptTb.AppendText("\tChicken:\t" + chickentp + "Rs" + Environment.NewLine);
                Subtotal = Subtotal + chickentp;
                Subtotallbl.Text = "" + Subtotal;
            }

            if (CheeseCb.Checked == true)
            {
                ReceiptTb.AppendText("\tCheese:\t" + cheesetp + "Rs" + Environment.NewLine);
                Subtotal = Subtotal + cheesetp;
                Subtotallbl.Text = "" + Subtotal;
            }
            //Drinks and Dessert
            if (TeaCb.Checked == true)
            {
                ReceiptTb.AppendText("\tTea:\t" + teatp + "Rs" + Environment.NewLine);
                Subtotal = Subtotal + teatp;
                Subtotallbl.Text = "" + Subtotal;
            }

            if (ColaCb.Checked == true)
            {
                ReceiptTb.AppendText("\tCola:\t" + cocatp + "Rs" + Environment.NewLine);
                Subtotal = Subtotal + cocatp;
                Subtotallbl.Text = "" + Subtotal;
            }
            if (WaterCb.Checked == true)
            {
                ReceiptTb.AppendText("\tWater:\t" + watertp + "Rs" + Environment.NewLine);
                Subtotal = Subtotal + watertp;
                Subtotallbl.Text = "" + Subtotal;
            }
            if (ChocolateCb.Checked == true)
            {
                ReceiptTb.AppendText("\tChocolate:\t" + chocolatetp + "Rs" + Environment.NewLine);
                Subtotal = Subtotal + chocolatetp;
                Subtotallbl.Text = "" + Subtotal;
            }
            if (PancakesCb.Checked == true)
            {
                ReceiptTb.AppendText("\tPancakes:\t" + pancakestp + "Rs" + Environment.NewLine);
                Subtotal = Subtotal + pancakestp;
                Subtotallbl.Text = "" + Subtotal;
            }
            if (OrangeCb.Checked == true)
            {
                ReceiptTb.AppendText("\tOrange:\t" + orangetp + "Rs" + Environment.NewLine);
                Subtotal += orangetp;
                Subtotallbl.Text = "" + Subtotal;
            }

            tax = Subtotal * 0.16;//16% tax calculation;
            grdtotal = Subtotal + tax;
            taxlbl.Text = "Rs" + tax;
            Grdtotallbl.Text = "Rs" + grdtotal;
        }

        private void ReceiptTb_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

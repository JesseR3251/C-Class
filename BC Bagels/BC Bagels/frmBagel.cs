using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BC_Bagels
{
    public partial class frmBagel : Form
    {
        //module level variables
        double total, salad, bagel, creamCheese, lox, soda, spinach, chef;

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Are you sure you want to quit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }

        }

        private void chkSalad_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSalad.Checked)
            {
                salad = 5.75;
                grpSalad.Visible = true;
            }
            else
            {
                grpSalad.Visible = false;
                salad = 0;
                // uncheck both toppings
                rdoSpinach.Checked = false;
                rdoChef.Checked = false;
            }
            DisplayTotal();
        }

        private void chkSoda_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSoda.Checked)
            {
                soda = 1.50;
                grpSoda.Visible = true;
            }
            else
            {
                grpSoda.Visible = false;
                soda = 0;
                // uncheck both toppings
                rdoRegularSoda.Checked = false;
                rdoDietSoda.Checked = false;
            }
            DisplayTotal();
        }

        private void chkCreamCheese_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCreamCheese.Checked)
            {
                creamCheese = 1.50;

            }
            else
            {
                creamCheese = 0;
            }
            DisplayTotal();
        }

        private void rdoSpinach_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoSpinach.Checked)
            {
                spinach = .25;
            }
            else
            {
                spinach = 0;
            }
            DisplayTotal();
        }

        private void rdoChef_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoChef.Checked)
            {
                chef = .50;
            }
            else
            {
                chef = 0;
            }
            DisplayTotal();
        }

        private void chkLox_CheckedChanged(object sender, EventArgs e)
        {
            if (chkLox.Checked)
            {
                lox = 3.5;

            }
            else
            {
                lox = 0.0;

            }
            DisplayTotal();
        }

        private void chkBagel_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBagel.Checked)
            {
                grpToppings.Visible = true;
                bagel = 1.25;
            }
            else
            {
                grpToppings.Visible = false;
                bagel = 0;
                // uncheck both toppings
                chkLox.Checked = false;
                chkCreamCheese.Checked = false;
            }
            DisplayTotal();
        }

        // method to calculate and display the total
        void DisplayTotal()
        {
            total = bagel + salad + creamCheese + lox + spinach + soda + chef;
            lblTotal.Text = total.ToString("C"); // Display as currency
        }

        public frmBagel()
        {
            //Constructor
            InitializeComponent();
            GenerateRandom();
            // Initialize all variables
            total = salad = bagel = creamCheese = lox = soda = spinach = chef = 0.0;
        }

        //Method to randomly generate the order number
        void GenerateRandom()
        {
            //declare an instance of a random object
            Random rnd = new Random();

            //Generate a random Int between 1 and 1000 for order number
            int orderNumber = rnd.Next(1,1000);
            //Display that number in the label
            lblOrderNumber.Text = orderNumber.ToString();
        }

        private void picBCLogo_Click(object sender, EventArgs e)
        {

        }

        private void lblOrderNumber_Click(object sender, EventArgs e)
        {

        }
    }
}

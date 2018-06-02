using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CateringCompany
{
    public partial class frmCateringCompany : Form
    {
        double total, primeRib, chicken, pasta, openBar, wineDinner;

        bool IsDigitsOnly(string str)
        {
            foreach (char c in str)
            {
                if (c < '0' || c > '9')
                    return false;
            }

            return true;
        }

        private void rdoPrimeRib_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoPrimeRib.Checked)
            {
                primeRib = 25.95;
            }
            else
            {
                primeRib = 0;
            }
        }

        private void rdoChicken_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoChicken.Checked)
            {
                chicken = 18.95;
            }
            else
            {
                chicken = 0;
            }
        }

        private void rdoPasta_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoPasta.Checked)
            {
                pasta = 12.95;
            }
            else
            {
                pasta = 0;
            }
        }

        private void chkOpenBar_CheckedChanged(object sender, EventArgs e)
        {
            if (chkOpenBar.Checked)
            {
                openBar = 25.00;
            }
            else
            {
                openBar = 0;
            }
        }

        private void chkWineDinner_CheckedChanged(object sender, EventArgs e)
        {
            if (chkWineDinner.Checked)
            {
                wineDinner = 8.00;
            }
            else
            {
                wineDinner = 0;
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (IsDigitsOnly(txtGuests.Text) == false || txtGuests.Text == "" || txtGuests.Text == null)
            {
                MessageBox.Show("Please enter a number.");
            }
            else if (Double.Parse(txtGuests.Text) >= 10 && Double.Parse(txtGuests.Text) <= 100)
            {
                total = (primeRib * Double.Parse(txtGuests.Text)) + (chicken * Double.Parse(txtGuests.Text)) + (pasta * Double.Parse(txtGuests.Text)) + (openBar * Double.Parse(txtGuests.Text)) +( wineDinner * Double.Parse(txtGuests.Text));
                lblTotal.Visible = true;
                lblTotalText.Visible = true;
                lblTotal.Text = total.ToString("C"); // Display as currency
            }
            else MessageBox.Show("Please enter a number 10 through 100.");

 
        }


        public frmCateringCompany()
        {
            InitializeComponent();
            total = chicken = pasta = openBar = wineDinner = 0.0;
            primeRib = 25.95;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtGuests.Text = "10";
            rdoPrimeRib.Checked = true;
            //primeRib = 0;
            rdoChicken.Checked = false;
            //chicken = 0;
            rdoPasta.Checked = false;
            //pasta = 0;
            chkOpenBar.Checked = false;
            //openBar = 0;
            chkWineDinner.Checked = false;
            //wineDinner = 0;
            lblTotal.Visible = false;
            lblTotalText.Visible = false;
            lblTotal.Text = "$0";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Are you sure you want to quit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}

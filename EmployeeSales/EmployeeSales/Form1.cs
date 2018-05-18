using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeSales
{
    public partial class frm_EmpSales : Form
    {
        // Variables
        double grossPay, deductions, netPay;


        public frm_EmpSales()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Clearing values
            txtEmpName.Clear();
            txtSaleAmt.Clear();
            txtGrossPay.Clear();
            txtDeductions.Clear();
            txtNetPay.Clear();
        }

        private void btnCalcPay_Click(object sender, EventArgs e)
        {
            // Parsing gross pay to double
            grossPay = Double.Parse(txtSaleAmt.Text);
            // Checking to see if the value entered is positive
            if (grossPay < 0)
            {
                MessageBox.Show("Please enter a positive value.");
            }
            else { 
            // Rest of the code to execute
            // Setting the variables values
            deductions = grossPay * .18;
            netPay = grossPay - deductions;

            // Appending a dollar sign to the start, setting the value to the textbox
            txtGrossPay.Text = "$" + grossPay.ToString();
            txtDeductions.Text = "$" + deductions.ToString();
            txtNetPay.Text = "$" + netPay.ToString();
            }
        }
    }
}

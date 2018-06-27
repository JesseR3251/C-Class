using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lists_and_validation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listSimpsons_SelectedIndexChanged(object sender, EventArgs e)
        {
            // populating the image box with the name selected in the list.
            picCharacter.Image = imgCharacterList.Images[listSimpsons.SelectedItem + ".jpg"];
        }

        private void btnPopulate_Click(object sender, EventArgs e)
        {
            // Add 1 - 10 to the combo box
            for (int i = 1; i <= listSimpsons.Items.Count; i++)
            {
                cmbNames.Items.Add(i.ToString());
            }
        }

        private void cmbNames_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cmbNames.Items.Add(cmbNames.Text);
        }

        private void cmbNames_Validating(object sender, CancelEventArgs e)
        {

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int i = 0;
            // selected index
            i = listSimpsons.SelectedIndex;

            if (i != -1)
            {
                listSimpsons.Items.RemoveAt(i);
            }
            if (listSimpsons.Items.Count != 0)
            {
                listSimpsons.SelectedIndex = 0;
            }

            listSimpsons.Focus();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            if (listSimpsons.SelectedIndex != -1)
            {
                MessageBox.Show(listSimpsons.SelectedItem.ToString());
            }
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            listSimpsons.Sorted = true;
            cmbNames.Sorted = true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            listSimpsons.Items.Clear();
            cmbNames.Items.Clear();
            txtPhoneNum.Clear();
        }
        // valdiation method for phone number
        public bool IsValidPhone(String phone)
        {
            if (phone.Length != 12)
                return false;

            if (phone[3] != '-' || phone[7] != '-')
                return false;

            for (int i = 0; i < 3; i++)
            {
                if (!char.IsDigit(phone[i]))
                    return false;
            }

            for (int i = 4; i < 7; i++)
            {
                if (!char.IsDigit(phone[i]))
                    return false;
            }

            for (int i = 8; i < 12; i++)
            {
                if (!char.IsDigit(phone[i]))
                    return false;
            }
            return true;
        }

        private void txtPhoneNum_Validating(object sender, CancelEventArgs e)
        {
            if (!IsValidPhone(txtPhoneNum.Text))
            {
                MessageBox.Show("Please enter a valid phone number.");
                txtPhoneNum.Focus();
                txtPhoneNum.SelectAll();
            }
           
        }
        bool IsValidZip(String zip)
        {
            string tempZip;
            tempZip = @"^\decimal{5}(\-\decimal{4})?";
            Regex myRegex = new Regex(tempZip);
            return myRegex.IsMatch(zip);
        }
        private void txtZipNum_Validating(object sender, CancelEventArgs e)
        {
           if (!IsValidZip(txtZipNum.Text))
            {
                MessageBox.Show("Please enter a valid zip number.");
                txtZipNum.Focus();
                txtZipNum.SelectAll();
            }
        }
    }
}

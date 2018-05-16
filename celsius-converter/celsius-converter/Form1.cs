using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace celsius_converter
{
    public partial class frmCelsiusConverter : Form
    {
        // Class Level Variables
        double celcius, fahrenheit;
        public frmCelsiusConverter()
        {
            InitializeComponent();
            celcius = 0.0;
            fahrenheit = 0.0;
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            // Store the value entered into the celcius textbox in the variable celsius
            celcius = Convert.ToDouble(txtCelcius.Text);

            // Convert celcius to fahrenheit, use the fahrenheitConvert method
            fahrenheit = FahrenheitConvert(celcius);

            // Use a messagebox to display the fahrenheit temp
            MessageBox.Show("Fahrenheit: " + fahrenheit.ToString());

            //MessageBox.Show("Hello", "Caption");
            //MessageBox.Show("Hello", "Caption", MessageBoxButtons.OKCancel);


            picWeather.Visible = true;

            if(fahrenheit < 50)
            {
                picWeather.Image = lstPictures.Images["cold.jpg"];
            }
            else if (fahrenheit > 80)
            {
                picWeather.Image = lstPictures.Images["cold.jpg"];
            }
            else
            {
                picWeather.Image = lstPictures.Images["snowy.gif"];
            }
        }

        private void picWeather_Click(object sender, EventArgs e)
        {

        }

        // Method to convert celcius to fahrenheit
        private double FahrenheitConvert(double cels)
        {
            return 1.8 * cels + 32;
        }

        
    }
}

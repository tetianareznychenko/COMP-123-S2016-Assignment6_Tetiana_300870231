using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2016_Assignment06_300870231_Tetiana
{
    public partial class BMICalculatorForm : Form
    {
        public BMICalculatorForm()
        {
            InitializeComponent();
        }

        //calculate BMI
        private void BMICalculatorButton_Click(object sender, EventArgs e)
        {
            double result;
            //check if it is not empty and user put data
            double weight = string.IsNullOrEmpty(WeightTextBox.Text) ? 1 : double.Parse(WeightTextBox.Text);
            double height = string.IsNullOrEmpty(HeightTextBox.Text) ? 1 : double.Parse(HeightTextBox.Text);
            //if user do not put data
            if (weight == 0) {
                MessageBox.Show("Please enter your weight");
            }
            if (height == 0)
            {
                MessageBox.Show("Please enter your height");
            }

            //to check te radio buttons

            if ((InchesRadioButton.Checked) && (PoundsRadioButton.Checked))
            {
                result = (weight * 703) / (height * height);
                BMITextBox.Text = Math.Round(result, 2).ToString();
            }
            if ((MetresRadioButton.Checked) && (KilogramsRadioButton.Checked))
            {
                result = (weight) / (height * height);
                BMITextBox.Text = Math.Round(result, 2).ToString();
            }

            //the description of the BMI
            string BMI_description = string.Empty;


        }
    }
}

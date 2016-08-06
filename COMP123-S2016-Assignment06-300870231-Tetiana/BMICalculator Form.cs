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
            string BMI_description = string.Empty;
            //check if it is not empty and user put data
            double weight = string.IsNullOrEmpty(WeightTextBox.Text) ? 1 : double.Parse(WeightTextBox.Text);
            double height = string.IsNullOrEmpty(HeightTextBox.Text) ? 1 : double.Parse(HeightTextBox.Text);
            //if user do not put data
            if (weight == 0)
            {
                MessageBox.Show("Please enter your weight");
            }
            if (height == 0)
            {
                MessageBox.Show("Please enter your height");
            }

            //to check te radio buttons
            //if Inches

            if (InchesRadioButton.Checked) //&& (PoundsRadioButton.Checked))
            {
                result = (weight * 703 * 10000) / (height * height);
                result = Math.Round(result, 2);
                ResultTextBox.Text = Math.Round(result, 4).ToString();
                //the description of the BMI
                if (result <= 18.5)
                {
                    BMI_description = "Underweight";
                }
                if ((result > 18.5) && (result < 25))
                {
                    BMI_description = "Normal";
                }
                if ((result > 25) && (result < 30))
                {
                    BMI_description = "Overweight";
                }
                if (result > 30)
                {
                    BMI_description = "Obese";
                }
                ResultTextBox.Text = string.Format("Your Body Mass Index (BMI) is: {0}. This would be considered {1}.", result, BMI_description);
            }

            //if centimetres
            if (MetresRadioButton.Checked) //&& (KilogramsRadioButton.Checked))
            {
                result = (weight*10000) / (height * height);
                result = Math.Round(result, 2);
                ResultTextBox.Text = Math.Round(result, 4).ToString();
                if (result <= 18.5)
                {
                    BMI_description = "Underweight";
                }
                if ((result > 18.5) && (result < 25))
                {
                    BMI_description = "Normal";
                }
                if ((result > 25) && (result < 30))
                {
                    BMI_description = "Overweight";
                }
                if (result > 30)
                {
                    BMI_description = "Obese";
                }
                ResultTextBox.Text = string.Format("BMI is: {0}. This would be considered {1}.", result, BMI_description);
            }




        }
    }
}

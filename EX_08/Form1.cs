/*
 * @Author: Ricardo Monreal Rubio
 * Grand Canyon University
 * CST-117
 * Exercise 8
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EX_08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label_Fat_Click(object sender, EventArgs e)
        {

        }
        // Calculate calories from fat
        private void button_Fat_Click(object sender, EventArgs e)
        {
            // declare variables
            double fat;
            double value;

            // convert string to double
            fat = double.Parse(textBox_ValueInGrams.Text);
            // calls method with fat as arguments
            value = FatCalories(fat);
            // display results as Messagebox
            MessageBox.Show($"The number of calories from fat are:  {value} ");

            
        }
        // Calculate calories from carbs
        private void button_Carbs_Click(object sender, EventArgs e)
        {
            // declare variables
            double carbs;
            double cal;
            // converts string to double
            carbs = double.Parse(textBox_ValueInGrams.Text);
            // calls method with carbs as arguments
            cal = CarbCalories(carbs);
            // display results as messagebox
            MessageBox.Show($"The number of calories from Carbs are: {cal}");
        }

        // Fat method
        private double FatCalories(double fat)
        {
            // calories from fat formula
            return (fat * 9);
        }

        // Carbs method
        private double CarbCalories(double carbs)
        {
            // calories from carbs formula
            return (carbs * 4);
        }

       

        private void textBox_Fat_TextChanged(object sender, EventArgs e)
        {

        }
        // close application
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}

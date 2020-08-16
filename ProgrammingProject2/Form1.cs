/**
 * 
 * CST-117 Programming Project #2
 * Ricardo Monreal Rubio
 * 
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgrammingProject2
{
    public partial class ProgrammingProject2 : Form
    {
        public ProgrammingProject2()
        {
            InitializeComponent();
        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton_cone_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Order_Click(object sender, EventArgs e)
        {
            // string will be used to store selected toppings
            string selectedToppings = "";

            // add selected items to string
            foreach (var itemChecked in checkedListBox_toppings.CheckedItems)
            {
                selectedToppings += itemChecked + " ";
            }

            // check which radio button was checked and display appropiate info for each.
            String coneSelected = (radioButton_cup.Checked) ? "Cup" : (radioButton_cone.Checked) ? "Cone" : "ice cream";

            // print the selections 
            MessageBox.Show("Your order of " + listBox_Flavors.Text + " ice cream, served on a " + 
                coneSelected + " with " + selectedToppings + " mixed in, will be available for pick up shortly!"); ;

        }

        private void checkedListBox_toppings_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


    }
}

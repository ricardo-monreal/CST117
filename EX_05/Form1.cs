using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EX_05
{
    public partial class Ex_05 : Form
    {
        public Ex_05()
        {
            InitializeComponent();
        }
        
        private void btn_Calculate_Click(object sender, EventArgs e)
        {
            // variable that holds the user input
            int termsEntered;

            // exception handling
            bool calculation = Int32.TryParse(txt_termsEntered.Text, out termsEntered);

            if (calculation)
            {

                double pi = 0;
                double d = 1;

                for (int i = 1; i <= termsEntered; i++)
                {
                    // check for odd numbers
                    if (i % 2 != 0)
                    {
                        pi += (4 / d);
                    }
                    else
                    {
                        pi -= (4 / d);
                    }

                    // increase denominator by 2 after each loop, so 3, 5, 7, 9, 11 etc
                    d += 2;
                }
                lbl_calculationTerms.Text = "Approximate value of PI after " + termsEntered + " terms.";
                lbl_calculationResult.Text = "= " + pi.ToString();

                //double pi = 0;
                //double s = 1;
                //int n = termsEntered;

                //for (int i = 0; i < n; i++)
                //{
                //    pi += s / i;
                //    s = -s;
                //}
                //lbl_calculationTerms.Text = "Approximate value of PI after " + termsEntered + " terms.";
                //lbl_calculationResult.Text = "= " + pi*4;

            }
            else
            {
                MessageBox.Show("Please enter only numbers.");
            }

            
        }

    }
}

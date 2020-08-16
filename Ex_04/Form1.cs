using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex_04
{
    public partial class SecondsConverter : Form
    {
        double seconds;
       


        public SecondsConverter()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txt_EnterSeconds_TextChanged(object sender, EventArgs e)
        {

        }

        //private void txt_DisplayResult_TextChanged(object sender, EventArgs e)
        //{

        //}

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            // exception  handler
            try
            {
                seconds = Convert.ToDouble(txt_EnterSeconds.Text);
            }
            catch (Exception)
            {

                MessageBox.Show("Invalid Character. Please enter only numbers");
                txt_EnterSeconds.Clear();

            }

            // convert seconds to minutes
            if (seconds >= 60 && seconds < 3600)
            {
                double minutes = seconds / 60;
                ResulTextLabel();
                lbl_DisplayResult.Text = Math.Round(minutes,2).ToString() + " minutes.";
            }

            // convert seconds to hours
            else if (seconds >= 3600 && seconds < 86400)
            {
                double hours = seconds / 3600;
                ResulTextLabel();
                lbl_DisplayResult.Text = Math.Round(hours,2).ToString() + " hours.";
            }

            // convert seconds to hours
            else if (seconds >= 86400)
            {
                double days = seconds / 86400;
                ResulTextLabel();
                lbl_DisplayResult.Text = Math.Round(days,2).ToString() + " days.";
            }

            // if seconds entered < 60, display number entered.
            else
            {
                ResulTextLabel();
                lbl_DisplayResult.Text = seconds + " seconds.";
            }


        }

        // clear forms
        private void btn_Clear_Click(object sender, EventArgs e)
        {
            lbl_DisplayResult.Text = "";
            txt_EnterSeconds.Text = "";
            lbl_Results_Text.Visible = false;
        }

        private void SecondsConverter_Load(object sender, EventArgs e)
        {

        }
        // method to display on invisible Label
        private void ResulTextLabel()
        {
            lbl_Results_Text.Visible = true;
            lbl_DisplayResult.Visible = true;
            lbl_Results_Text.Text = "The number of seconds entered equals to: ";
        }

      
        // FontAwesome logo
        private void img_logo_Click(object sender, EventArgs e)
        {

        }
    }
}

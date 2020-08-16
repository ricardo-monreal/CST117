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
        double minutes;
        double hours;
        double days;
        double totalSeconds;


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

        private void txt_DisplayResult_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            seconds = Convert.ToDouble(txt_EnterSeconds.Text);
            if (seconds >= 60 && seconds < 3600)
            {
                double minutes = seconds / 60;
                ResulTextLabel();
                lbl_DisplayResult.Text = Math.Round(minutes,2).ToString() + " minutes.";
            }

            else if (seconds >= 3600 && seconds < 86400)
            {
                double hours = seconds / 3600;
                ResulTextLabel();
                lbl_DisplayResult.Text = Math.Round(hours,2).ToString() + " hours.";

            }

            else if (seconds >= 86400)
            {
                double days = seconds / 86400;
                ResulTextLabel();
                lbl_DisplayResult.Text = Math.Round(days,2).ToString() + " days.";
            }

            else
            {
                // exceptino handler if something other than numbers are entered
                MessageBox.Show("Invalid Character. Please enter only numbers");
            }

        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            lbl_DisplayResult.Text = "";
            txt_EnterSeconds.Text = "";
            lbl_Results_Text.Visible = false;
        }

        private void SecondsConverter_Load(object sender, EventArgs e)
        {

        }

        private void ResulTextLabel()
        {
            lbl_Results_Text.Visible = true;
            lbl_DisplayResult.Visible = true;
            lbl_Results_Text.Text = "The number of seconds entered equals to: ";
        }

      

        private void img_logo_Click(object sender, EventArgs e)
        {

        }
    }
}

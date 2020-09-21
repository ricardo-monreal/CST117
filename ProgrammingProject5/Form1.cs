using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgrammingProject5
{
    public partial class Form1 : Form

    {

        //DateTime dateFrom = new DateTime(dateTimePicker1);

        public Form1()
        {
            InitializeComponent();
        }

        //public DateTime DateFrom { get => dateFrom; set => dateFrom = value; }

        private void btn_getLucky_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(dateTimePicker1.Text);

            int year = int.Parse(comboBox_year.Text);
            int month = int.Parse(comboBox_month.Text);
            int day = int.Parse(comboBox_day.Text);

            int sum = (year + month + day) / (13 % 7);


            Form2 form2 = new Form2(sum);
            this.Hide();
            form2.ShowDialog();
            
            //MessageBox.Show("you selected " + sum);


            //comboBox_year.Text + " " + comboBox_month.Text + " " + comboBox_day.Text);
        }

        //private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        //{
        //    //ateTimePicker1.Format = DateTimePickerFormat.Custom;
        //    //dateTimePicker1.CustomFormat = "yyyy/MM/dd";
        //    //dateTimePicker1.Value  = new DateTime();
        //    //DateTime dateTo = new DateTime(2020, 9, 20);

        //    //MessageBox.Show("you selected " + dateTimePicker1);



        //}

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_month_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_month.SelectedIndex == 0 || comboBox_month.SelectedIndex == 2 || comboBox_month.SelectedIndex == 4 || comboBox_month.SelectedIndex == 6 || comboBox_month.SelectedIndex == 7 || comboBox_month.SelectedIndex == 9 || comboBox_month.SelectedIndex == 11)
            {
                //comboBox_day.Text = "1";
                comboBox_day.Items.AddRange(Enumerable.Range(1, 31).Select(i => (object)i).ToArray());
            }
            else if(comboBox_month.SelectedIndex == 3 || comboBox_month.SelectedIndex == 5 || comboBox_month.SelectedIndex == 8 || comboBox_month.SelectedIndex == 10)
            {
                comboBox_day.Items.AddRange(Enumerable.Range(1, 30).Select(i => (object)i).ToArray());

            }
            else if(comboBox_month.SelectedIndex == 1 && int.Parse(comboBox_year.Text) % 4 == 0 && int.Parse(comboBox_year.Text) % 100 != 0 && int.Parse(comboBox_year.Text) % 400 == 0)
            {
                
                
                comboBox_day.Items.AddRange(Enumerable.Range(1, 29).Select(i => (object)i).ToArray());

                
                
            }
            else
            {
                comboBox_day.Items.AddRange(Enumerable.Range(1, 28).Select(i => (object)i).ToArray());

            }

        }
    }
}

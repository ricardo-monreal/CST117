using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ProgrammingProject3
{
    public partial class ProgrammingProject3 : Form
    {
        public ProgrammingProject3()
        {
            InitializeComponent();
        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                //MessageBox.Show("you clicked then open button.");
                //textBox1.Text = inputFile; 

                StreamReader reader = new StreamReader(dlg.FileName, Encoding.Default);
                textBox1.Text = reader.ReadToEnd();
                //reader.Close();
            }
            else
            {
                //MessageBox.Show("you clicked the cancel button.");
                MessageBox.Show("operation canceled.");
            }



             

            //strText = openFileDialog1.ToString();

            //openFileDialog1.Title = "Open a Text File.";
            //openFileDialog1.InitialDirectory = "/";

            //textBox1.Text = strText;
        }

        // method to convert file contents to lower case
        private void ConvertToLower()
        {
            string toLower = textBox1.Text.ToLower();
            textBox1.Text = toLower;
        }

        private void FindFirstAndLast()
        {
            
            
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
           this.Close();
        }

        private void btn_process_Click(object sender, EventArgs e)
        {
            ConvertToLower();
        }
    }
}

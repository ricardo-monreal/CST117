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
    public partial class Form2 : Form
    {
        public Form2(int s)
        {
            InitializeComponent();
            label_lucky_number.Text = s.ToString();
        }


    }
}

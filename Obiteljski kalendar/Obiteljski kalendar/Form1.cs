using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Obiteljski_kalendar
{
    public partial class Form1 : Form
    {

        public static int _year, _month;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private showDays( int month, int year)
        {
            flowLayoutPanel1.Controls.Clear();

            _year = year; 
            _month = month;
            string monthname = new DateTimeFormat().GetMonthName(month);
        }
    }
}

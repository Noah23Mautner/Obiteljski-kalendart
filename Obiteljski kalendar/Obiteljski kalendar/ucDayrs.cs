﻿using System;
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
    public partial class ucDayrs : UserControl
    {
        string _day,date, weekday;
      
        public ucDayrs(string day)
        {
            InitializeComponent();
            _day = day;
            label1.Text = day;
            checkBox1.Hide();

        }

        private void u(object sender, EventArgs e)
        {

        }
    }
}

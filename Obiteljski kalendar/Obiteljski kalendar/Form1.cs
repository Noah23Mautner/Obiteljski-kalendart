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
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            displaDay();
        }
        private void displaDay()
        {
            DateTime now = DateTime.Now;
            DateTime startofthemonth = new DateTime(now.Year, now.Month, 1);
            int days = DateTime.DaysInMonth(now.Year, now.Month);
            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d")) +1; 

            for(int i = 0; i < dayoftheweek;i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                dayconteiner.Controls.Add(ucblank);

            }
        }
    }
}

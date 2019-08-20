using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10TaiwanCalendarFunction
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TaiwanCalendar taiwanCalender = new TaiwanCalendar();
            DateTime datetime = DateTime.Parse(dateTimePicker1.Text);
            int taiwanCalendarYear = taiwanCalender.GetYear(datetime);
            label3.Text = taiwanCalendarYear.ToString();
        }
    }
}

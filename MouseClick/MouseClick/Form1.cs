using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MouseClick
{
    public partial class Form1 : Form
    {
        int times = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            times++;

            timeslabel.Text = "你已經按了" + times + "次";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            times = 0;

            timeslabel.Text = "你已經按了" + times + "次";
        }
    }
}

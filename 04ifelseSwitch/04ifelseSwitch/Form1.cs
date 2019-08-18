using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04ifelseSwitch
{
    public partial class Form1 : Form
    {
        int value1;
        int value2;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            value1 = 0;
            function();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            value1 = 1;
            function();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            value1 = 0;
            function();
        }
        private void function()
        {
            if(value1 == 0)
            {
                MessageBox.Show("死路");
                value2 = 0;
            }
            else
            {
                MessageBox.Show("GOGOGO");
                value2 = 1;
            }

            switch (value2)
            {
                case 0:
                    MessageBox.Show("你死了");
                    break;
                default:
                    MessageBox.Show("你贏了");
                    break;
            }
        }
    }
}

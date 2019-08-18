using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _05Loop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ShowString = "";
            int day = 31;

            for(int i = 1; i < day; i++)
            {
                ShowString += "過了" + i + "天 => 距離月底還有" + (day - i) + "天" + Environment.NewLine;
            }
            MessageBox.Show(ShowString);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _17Random
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int power = 100;
            Random random = new Random();

            //int injured = random.Next(power);  //100以內亂數
            int injured = random.Next(50, power); //50~99

            MessageBox.Show("受到傷害" + injured + "點");
        }
    }
}

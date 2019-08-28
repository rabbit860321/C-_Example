using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _23Constant
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            double r = 2.0;
            //Math.PI = 3.5;
            //Math.myheight = 200;
            double area = Math.PI * r * r;


            MessageBox.Show("" + area);

            double atk = 10.0;
            double damage = atk * GameEngine.DAMAGE_MULTIPLIER;

            MessageBox.Show("" + damage);
        }
    }
}

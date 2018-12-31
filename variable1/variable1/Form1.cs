using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace variable1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int number;
            float fnumber;
            double dnumber;
            Boolean a;

            number = 321;
            number += 20;
            number++;

            fnumber = 20.1f;

            dnumber = 20.1;

            a = true;

            MessageBox.Show("number = " + number + "\n" + "fnumber = " + fnumber + "\n" + "dnumber = " + dnumber + "\n" + "a = " + a);
        }
    }
}

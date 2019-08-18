using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03String
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Hello = "Hello C#!";
            string name = "YaoRen";
            int age = 22;
            MessageBox.Show(Hello + Environment.NewLine + "我的名字是:" + name + Environment.NewLine + "我的年齡是:" + age);
        }
    }
}

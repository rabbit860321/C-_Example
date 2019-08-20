using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _14static
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(textBox1.Text) && !String.IsNullOrEmpty(textBox2.Text)){
                int a = Convert.ToInt32(textBox1.Text);
                int b = Convert.ToInt32(textBox2.Text);
                label1.Text = Convert.ToString(Math.Max(a, b));
                //不須再new一個Math物件 因Max是靜態方法
            }
            else
            {
                MessageBox.Show("不可為空");
            }
        }
    }
}

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

        private void button2_Click(object sender, EventArgs e)
        {
            string ShowString = "";
            int start = 1;
            int end = 31;
            do
            {
                ShowString += "2019/8/" + start + Environment.NewLine;
                start++;
            } while (start <= end);
            MessageBox.Show(ShowString);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string ShowString = "";
            int start = 22;
            int end = 30;
            while(start < end)
            {
                ShowString += start+"歲 "+"還有" + (end - start) + "年 成為大法師"+Environment.NewLine;
                start++;
                if(start == 30)
                {
                    ShowString += "恭喜成為大法師";
                }
            }
            MessageBox.Show(ShowString);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string ShowString = "";
            int[] arr = new int[] { 10,9,8,7,6,5,4,3,2,1 };
            foreach(int i in arr)
            {
                ShowString += i + Environment.NewLine;
            }
            MessageBox.Show(ShowString);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _09Calculate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string beforeValue;
        string mathematical;  //運算符

        private void buttonNumber_Click(object sender, EventArgs e)
        {
            Button ButtonNumber = sender as Button;
            //sender代表引發事件的object
            //數字按鈕點擊時的觸發事件
            if(textBox1.Text == "0")
            {
                textBox1.Text = ButtonNumber.Text;
            }
            else
            {
                textBox1.Text += ButtonNumber.Text;
            }
        }

        private void buttonMathematical_Click(object sender, EventArgs e)
        {
            Button ButtonMathematical = sender as Button;
            mathematical = ButtonMathematical.Text; //點擊的運算符
            beforeValue = textBox1.Text;  //運算式前一個數字的內容
            label1.Text = beforeValue + mathematical;
            textBox1.Text = "";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Double GetBeforeValue = Double.Parse(beforeValue); //運算符前的數字
            Double GetAfterValue = Double.Parse(textBox1.Text); //運算符後的數字
            Double Result = 0;

            switch (mathematical)
            {
                case "+":
                    Result = GetBeforeValue + GetAfterValue;
                    break;
                case "-":
                    Result = GetBeforeValue - GetAfterValue;
                    break;
                case "*":
                    Result = GetBeforeValue * GetAfterValue;
                    break;
                case "/":
                    Result = GetBeforeValue / GetAfterValue;
                    break;
            }
            textBox1.Text = Result.ToString();
            label1.Text = "";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            label1.Text = "";
        }
    }
}

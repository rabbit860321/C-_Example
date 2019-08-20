using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace _07Array
{
    public partial class Form1 : Form
    {
        string[] BoxArray = new string[10];
        int count = 10;
        int countArrayKey = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label3.Text = BoxArray.Length.ToString();
            label4.Text = count.ToString();
            ArrayData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string SaveName = Interaction.InputBox("存入物品名稱", "存入", "", -1, -1);

            if (!String.IsNullOrEmpty(SaveName))
            {
                try
                {
                    BoxArray[countArrayKey] = SaveName;
                    count--;
                    countArrayKey++;
                    label4.Text = count.ToString();
                }catch(IndexOutOfRangeException)
                {
                    MessageBox.Show("容量不足", "Error");
                }
            }
            else
            {
                MessageBox.Show("不可為空");
            }
            ArrayData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                countArrayKey--;
                count++;
                BoxArray[countArrayKey] = "";
                ArrayData();
                label4.Text = count.ToString();
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("此陣列為全空");
            }
        }
        private bool IsNumber(string TextBoxValue)
        {
            try
            {
                int i = Convert.ToInt32(TextBoxValue); //string=>int
                return true;
            }
            catch
            {
                return false;
            }
        }
        private void ArrayData()
        {
            string tmpString = "";
            for (int i = 0; i < BoxArray.Length; i++)
            {
                tmpString += "BoxArray[" + i + "]=" + BoxArray[i] + Environment.NewLine;
            }
            label5.Text = tmpString;
        }
    }
}

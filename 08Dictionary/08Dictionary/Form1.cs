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

namespace _08Dictionary
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Dictionary<string, string> BoxArray = new Dictionary<string, string>();
        int count = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            ArrayData();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string SaveKey = Interaction.InputBox("輸入Key值", "Key", "",-1, -1);
            string SaveValue = Interaction.InputBox("輸入Value值", "Value", "", -1, -1);

            if (!String.IsNullOrEmpty(SaveKey) && !String.IsNullOrEmpty(SaveValue))
            {
                try
                {
                    BoxArray.Add(SaveKey, SaveValue);
                }
                catch (ArgumentException)
                {
                    MessageBox.Show("Key值重複");
                }
            }
            else
            {
                MessageBox.Show("不可為空");
            }
            ArrayData();
        }

        private void ArrayData()
        {
            string tmpString = "";

            foreach(KeyValuePair<string,string> GetBoxArray in BoxArray)
            {
                tmpString += "Key:" + GetBoxArray.Key + "  Value=>" + GetBoxArray.Value + Environment.NewLine;
            }
            label3.Text = BoxArray.Count.ToString();
            label5.Text = tmpString;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string GetString = Interaction.InputBox("輸入Key值", "Key", "", -1, -1);

            try
            {
                MessageBox.Show("取出"+BoxArray[GetString]);
                BoxArray.Remove(GetString);
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            ArrayData();
        }
    }
}

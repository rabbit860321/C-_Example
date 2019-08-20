using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _12StudentClass
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Student s1 = new Student();
            s1.StudentID = 123;
            s1.Name = "YaoRen";
            s1.Grade = 3;
            Student s2 = new Student();
            s2.StudentID = 456;
            s2.Name = "小明";
            s2.Grade = 4;

            MessageBox.Show(s1.Say());
            s1.Upgrade();
            MessageBox.Show(s1.Say());
            MessageBox.Show(s1.Talk(s2));
        }
    }
}

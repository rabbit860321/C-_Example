using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _13Constructor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Student s1 = new Student(123, "yaoren", 4);
            MessageBox.Show(s1.say());
            MessageBox.Show(s1.talk(new Student("阿明", 5)));
        }
    }
}

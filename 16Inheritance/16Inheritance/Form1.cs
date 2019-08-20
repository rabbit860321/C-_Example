using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _16Inheritance
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Villager v1 = new Villager();
            Monster m1 = new Monster();

            //v1.Injured(m1.Attack());
            m1.Attack(v1);

            MessageBox.Show(""+v1.GetHP());
        }
    }
}

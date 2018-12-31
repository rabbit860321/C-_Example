using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ifelse
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int score = 65;

            if (score >= 90) MessageBox.Show("A++");
            else if (score < 90 && score >= 80) MessageBox.Show("A+");
            else if (score < 80 && score >= 70) MessageBox.Show("A");
            else MessageBox.Show("B++");
          

        }
    }
}

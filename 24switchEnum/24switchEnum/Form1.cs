using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _24switchEnum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Monster monster = new Monster();

            monster.move(1);
            monster.move(3);
            monster.Move1(Direction.DOWN);
            monster.Move1(Direction.LEFT);

            MessageBox.Show(monster.ReportPosition());
        }
    }
}

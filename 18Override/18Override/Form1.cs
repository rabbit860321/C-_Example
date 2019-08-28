using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _18Override
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Player player = new Player(textBox1.Text);
            Monster monster = new Monster("史萊姆");
            Villager villager = new Villager("村民1");

            if (String.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("請輸入名字");
            }
            else
            {
                MessageBox.Show(monster.move());
                MessageBox.Show(player.move());
                MessageBox.Show(player.attack(monster));
                MessageBox.Show(villager.attack(player));
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _06class
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public class BraveActionClass
        {
            public void Back()
            {
                MessageBox.Show("正在前往村子...");
            }
            public void LotteryMember()
            {
                string member = "";

                Random random = new Random();
                int returnInt = random.Next(1, 5);

                switch (returnInt)
                {
                    case 1:
                        member = "子丑";
                        break;
                    case 2:
                        member = "寅卯";
                        break;
                    case 3:
                        member = "辰巳";
                        break;
                    case 4:
                        member = "午未";
                        break;
                    case 5:
                        member = "申酉";
                        break;
                }
                MessageBox.Show("招攬夥伴:"+member);
            }
        }

        private BraveActionClass BraveActionList = new BraveActionClass();

        private void button1_Click(object sender, EventArgs e)
        {
            BraveActionList.Back();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BraveActionList.LotteryMember();
        }
    }
}

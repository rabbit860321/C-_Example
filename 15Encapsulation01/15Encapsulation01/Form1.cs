using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _15Encapsulation01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            User user = new User("rabbit860321","1234");
            string result = "";

            if (user.comparePassword("123"))
                result = "密碼正確";
            else
                result = "密碼錯誤";
            MessageBox.Show(result+ Environment.NewLine +user.getUsername());
        }
    }
}

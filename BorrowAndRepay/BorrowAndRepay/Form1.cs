using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BorrowAndRepay
{
    public partial class Form1 : Form
    {
        Person me, friend;
        public Form1()
        {
            InitializeComponent();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(MynameInput.Text) && !String.IsNullOrEmpty(FriendnameInput.Text))
            {
                me = new Person(MynameInput.Text, 0);
                friend = new Person(FriendnameInput.Text, 200000);
                MynameInput.Enabled = false;
                FriendnameInput.Enabled = false;
                SubmitButton.Enabled = false;

                BorrowButton.Text = "跟" + friend.name + "借$1000";
                RepayButton.Text = "還給" + friend.name + "$1000";

                BorrowButton.Enabled = true;
                RepayButton.Enabled = true;

                MynameLabel.Text = me.name;
                FriendnameLabel.Text = friend.name;
                updateMoney();
            }
            else
            {
                MessageBox.Show("不可為空");
            }
        }

        private void RepayButton_Click(object sender, EventArgs e)
        {
            me.repay(friend, 1000);
            updateMoney();
        }

        private void BorrowButton_Click(object sender, EventArgs e)
        {
            me.borrow(friend, 1000);
            updateMoney();
        }
        private void updateMoney()
        {
            MymoneyLabel.Text = Convert.ToString(me.money);
            FriendmoneyLabel.Text = Convert.ToString(friend.money);
        }
    }
}

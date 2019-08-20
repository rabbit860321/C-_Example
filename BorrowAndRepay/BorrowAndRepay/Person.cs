using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BorrowAndRepay
{
    class Person
    {
        public String name;
        public int money;

        public Person(string name,int money)
        {
            this.name = name;
            this.money = money;
        }

        public void borrow(Person lender,int money)
        {
            if(lender.money >= money)
            {
                lender.money -= money;
                this.money += money;
            }
        }

        public void repay(Person lender,int money)
        {
            if(this.money >= money)
            {
                this.money -= money;
                lender.money += money;
            }
            
        }
    }
}

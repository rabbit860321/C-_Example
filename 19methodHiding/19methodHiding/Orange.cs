using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19methodHiding
{
    class Orange : Fruit
    {
        public new string say()
        {
            return "我是橘子";
            //method hiding 
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16Inheritance
{
    class Monster : Createure
    {
        public void Attack(Createure c)
        {
            c.Injured(10);
        }
    }
}

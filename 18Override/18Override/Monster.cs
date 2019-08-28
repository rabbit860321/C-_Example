using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18Override
{
    class Monster : Creature
    {
        public Monster(string name)
        {
            this.name = name;
        }

        public override string move()
        {
            return this.name + "往前跳";
        }
    }
}

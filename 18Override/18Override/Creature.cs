using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18Override
{
    class Creature
    {
        public string name;

        public virtual string move()
        {
            return this.name + "向前走";
        }

        public virtual string attack(Creature target)
        {
            return this.name + "攻擊了" + target.name;
        }
    }
}

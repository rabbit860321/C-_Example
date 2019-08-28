using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18Override
{
    class Villager : Creature
    {
        public Villager(string name)
        {
            this.name = name;
        }
        public override string attack(Creature target)
        {
            return this.name + "不能攻擊其他生物";
        }
    }
}

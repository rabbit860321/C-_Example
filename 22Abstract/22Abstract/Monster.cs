using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22Abstract
{
    abstract class Monster
    {
        protected int hp = 100;
        private string name;

        public Monster(string name)
        {
            this.name = name;
        }

        public abstract string attack();

        public int getHp()
        {
            return hp;
        }
    }
}

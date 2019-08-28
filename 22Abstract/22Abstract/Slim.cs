using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22Abstract
{
    class Slim : Monster
    {
        public Slim(string name) : base(name) { }

        public override string attack()
        {
            return "史萊姆正在攻擊";
        }
    }
}

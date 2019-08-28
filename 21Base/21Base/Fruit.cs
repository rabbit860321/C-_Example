using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21Base
{
    class Fruit
    {
        private string name;

        public Fruit(string name)
        {
            this.name = name;
        }
        public string getName()
        {
            return name;
        }
        public string saysomething()
        {
            return "我是水果";
        }
    }
}

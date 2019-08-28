using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21Base
{
    class Apple : Fruit
    {
        public Apple(string name) : base(name)
        {
            
        }
        public string talk()
        {
            return base.saysomething() + "-蘋果";
        }
    }
}

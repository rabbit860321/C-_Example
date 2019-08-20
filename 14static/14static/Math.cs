using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14static
{
    class Math
    {
        public static int Max(int a,int b)
        {
            int result;
            if (a > b)
            {
                result = a;
            }
            else
            {
                result = b;
            }
            return result;
        }
    }
}

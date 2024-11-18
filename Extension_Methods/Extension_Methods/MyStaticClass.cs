using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extension_Methods
{
    static class MyStaticClass
    {
        //after binding the staic method with any class or struct then they convert into non static or instance method
        public static void Func3(this Program p, int i)//binding parameter, func3 belongs to program class //int i is not binding parameter
        {
            Console.WriteLine("this is func3.." + i);
        }

        public static bool IsGreaterThan(this int i, int value)
        {
            return i > value;
        }
    }
}

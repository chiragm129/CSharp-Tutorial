using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boxing_UnBoxing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 10;//value type
            object obj1 = num1;//implicit value to reference type (Boxing)
            int num2 = (int)obj1;//Explicit referrence to value type (UnBoxing)

        }
    }
}

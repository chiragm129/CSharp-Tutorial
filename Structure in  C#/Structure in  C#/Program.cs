using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structure_in__C_
{
    struct Program
    {
        int a;
        public void func1()
        {
            Console.WriteLine("this is func1.." + a);
        }
        static void Main(string[] args)
        {
            Program p = new Program(); //no need new keyword while creating object of struct 
            p.a = 10;
            p.func1();

            Console.ReadLine();
        }
    }
}

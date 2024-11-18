using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extension_Methods
{
    class Program//we can make this class sealed also
    {
        public void Func1()
        {
            Console.WriteLine("this is func1");
        } 
        public void Func2()
        {
            Console.WriteLine("this is func2");
        } 
        
        static void Main(string[] args)
        { 
            Program p = new Program();
            p.Func1();
            p.Func2();

            Console.ReadLine();
        }
    }
}

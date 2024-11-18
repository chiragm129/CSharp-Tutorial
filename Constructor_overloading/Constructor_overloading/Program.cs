using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_overloading
{
     class Program
    {
        //constructor overloading : if we want to muliplt constrctor with the same class its called constrctor overloading
       //we cant make two same default constructor
       //parameter will be different
        public Program()
        {
            Console.WriteLine("this is a first constructor");
        }
        public Program(int a, int b)
        {
            Console.WriteLine("this is a second constructor  {0}", (a+b));
        }
        public Program(int a, int b, int c)
        {
            Console.WriteLine("this is a third constructor  {0}", (a+b+c));
        }
        public Program(string a, string b, string c)
        {
            Console.WriteLine("this is a fourth constructor  {0}", (a+b+c));
        }
        
        static void Main(string[] args)
        {
            Program p = new Program();//1st const
            Program q = new Program(20,20);//2nd const
            Program r = new Program(20,20,10);//3rd const
            Program s = new Program("A","B","C");//4th const
            Console.ReadLine();

        }
    }
}

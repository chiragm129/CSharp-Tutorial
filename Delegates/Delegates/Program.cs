using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
 //single cast delegates : means point to single method at a time(like only addition method)
 //in this the delegates is assigned to a single method at a time.


    //when we want to encapsulate our method and called it indirectly than will use delegates suppose there is many metho like addition, sub, multi
    public delegate void Calc(int a, int b);//we can create delegates without parameters
    //there is no body  for delegates
    //by using delegates in .net application the exection will happen fast
    class Program
    {
        public static void Addition(int a, int b)
        {
            int result = a + b;
            Console.WriteLine("add result is {0}", result);

        }
        public static void Substract(int a, int b)
        {
            int result = a - b;
            Console.WriteLine("sub result is {0}", result);

        }
        public static void Multiply(int a, int b)
        {
            int result = a * b;
            Console.WriteLine("mul result is {0}", result);

        }
        public static void Division(int a, int b)
        {
            int result = a / b;
            Console.WriteLine("divide result is {0}", result);

        }
        static void Main(string[] args)
        {

            Calc c = new Calc(Program.Addition);
           // c.Invoke(6, 3);
            c(6, 3);//9
            c = Substract;
            c(10, 4);//6
            c = Multiply;
            c(3, 4);//12
            c = Division;
            c(12, 4);//3

            Console.ReadLine();
            
        }

    }
}

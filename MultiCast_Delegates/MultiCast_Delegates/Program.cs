using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiCast_Delegates
{
    //its same as normal delegates means when delegates is wrapped from more than one method that is multi cast delegates
    //but here we can use += and -= assignment operator to implemnt multi cast delegates

    public delegate void Calc(int a, int b);
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

            Calc c = new Calc(Addition);
            c += Substract;
            c += Multiply;
            c -= Division;//if we use -= operator so division method will not run
            c(200, 100);// op 300, 100, 20000, 2

            Console.ReadLine();

        }

    }
}

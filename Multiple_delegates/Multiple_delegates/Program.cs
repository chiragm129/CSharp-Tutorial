using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Multiple_delegates
{
    //multiple delegates : in c# user can invoke multiple delegates within a single program
    //depending on the delegates name or the type of parameter passed to the delegate, the appropiate delegate is invoked.

    public delegate void Calc(int a, int b);
    public delegate void Show_Delegate();
    public delegate void Calc2(int num);
    class Program
    {
        public static void Square(int num)//this method will call by calc2 delgates
        {
            int square = num * num;
            Console.WriteLine("square of {0} is {1}", num, square);
        } 
        public static void Cube(int num)//this method will call by calc2 delgates
        {
            int cube = num * num * num ;
            Console.WriteLine("cube of {0} is {1}", num, cube);
        }
        public static void Show()
        {
            Console.WriteLine("this is show method");//this method is call show_delegate coz both have no parameter
        }
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
            c.Invoke(2, 3);//5


            Show_Delegate sd = new Show_Delegate(Show);
            sd.Invoke();//this is show method
            
            Calc2 c2 = new Calc2(Square);
            c2.Invoke(12);//144
            c2 = Cube;
            c2(3);//27
           
            

            Console.ReadLine();

        }

    }
}

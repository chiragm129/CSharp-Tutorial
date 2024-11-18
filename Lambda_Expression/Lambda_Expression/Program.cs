using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_Expression
{
    //anonymouse functio launched in c# 2.0
    //after that they launched lambda expression for more optimize
    public delegate int MyDelegate(int num);
    public delegate int MyDelegate2(int num1, int num2);
    class Program
    {
        static void Main(string[] args)
        {
            //Expression lambda
            MyDelegate md = (a) => a * a;
            MyDelegate md2 = (a) => a * a * a;
            
            Console.WriteLine(md.Invoke(5));//25
            Console.WriteLine(md2.Invoke(5));//125

            MyDelegate2 mdd = (a,b) => a + b;
            Console.WriteLine(mdd.Invoke(2,3));//5

            //Statement lambda
            //lambda operator (=>) : left side data call input or paramter and in right side data we can write expression and statement both
            //MyDelegate md =  (a) =>
            //{
            //    a += 5;
            //    return a;

            //};

            //Console.WriteLine(md.Invoke(5));

            Console.ReadLine();

        }
    }
}

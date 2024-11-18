using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator_overloading
{
    class NewClass
    {
        public string str;
        public int num;

        //syntax for operator overloadig function
        public static NewClass operator + (NewClass obj1, NewClass obj2)
        {
            NewClass obj3 = new NewClass();
            obj3.str = obj1.str + obj2.str;
            obj3.num = obj1.num + obj2.num;
            return obj3;

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            NewClass obj1 = new NewClass();
            obj1.str = "chirag";
            obj1.num = 20;
             
            NewClass obj2 = new NewClass();
            obj2.str = "Mali";
            obj2.num = 30;

            NewClass obj3 = new NewClass();
            obj3 = obj1 + obj2;

            Console.WriteLine(obj3.str);
            Console.WriteLine(obj3.num);

            Console.ReadLine();


        }
    }
}

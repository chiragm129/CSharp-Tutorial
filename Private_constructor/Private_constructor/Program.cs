using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Private_constructor
{
    class Example
    {

        public static int a;

        //default constructor, we cant make deafault constructor with private constructor(parameterless)
        //public Example()
        //{

        //}

        private Example()//private constructor, we can make parameter here but no need now
        {

        }

        public static int getIncrement()
        {
            return ++a;
        }
        public static void getTime()
        {
            Console.WriteLine(DateTime.Now);
        }

    }

    //class Example2 : Example// we cant make derive class due to private
    //{

    //}
    class Program
    {
        static void Main(string[] args)
        {

            // Example e = new Example();//cant create object of private constructo
            Example.getTime();
            Example.a = 20;
            Console.WriteLine(Example.getIncrement());
            Console.ReadLine();
        
        }
    }
}

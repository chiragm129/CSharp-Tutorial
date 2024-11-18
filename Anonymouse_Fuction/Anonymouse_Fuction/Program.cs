using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anonymouse_Fuction
{
    public delegate void MyDelegate(int num);

    class Program
    {
        public static void Mymethod(MyDelegate del,int a)
        {
            a += 10;//a = 15
            del.Invoke(a);//b = 25
            
        }
        static void Main(string[] args)
        {
            //Anonymous function can be passes as parameter

            Program.Mymethod(delegate (int b) { b += 10; Console.WriteLine(b); },5);


            //anonymous function - we are storing anonymous method with delegate object
            //it simple anony function without Mymethod
            //MyDelegate md = delegate (int a)
            //{
            //    a += 10;
            //    return a;
            //};

            //Console.WriteLine(md(5));//15
            //Console.WriteLine(md.Invoke(5));//15

            Console.ReadLine();

        }
    }
}

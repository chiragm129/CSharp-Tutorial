using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismAndMethodOerloading
{
     class Program
    {
        //mrthod overloading method name same but parameters different
        public void Add()
        {
            int a = 20;
            int b = 10;
            int c = a + b;
            Console.WriteLine(c);
        }
        public void Add(int a,int b)
        {
            int c = a + b;
            Console.WriteLine(c);
        } 
        //public int Add(int a,int b) //cannot oerloaded if we only change return type
        //{
        //    int c = a + b;
        //    return c;
        //}
        public void Add(string a,string b)
        {
            string c = a + " " + b;
            Console.WriteLine(c);
        }
        public void Add(float a,float b)
        {
            float c = a + b;
            Console.WriteLine(c);
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Add();
            p.Add(2,3);
            p.Add("chirag", "mali");
            p.Add(2.5f, 2.3f);

            Console.ReadLine();
        }
    }
}

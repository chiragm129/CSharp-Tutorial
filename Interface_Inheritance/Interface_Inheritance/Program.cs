using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Inheritance
{
    interface i1
    {
        void print();
    }
    interface i2
    {
        void print1();
    }
    interface i3 : i1, i2 // interface inheritance chain
    {
        void print2();
    }


    class Program : i3
    {
        public void print()
        {
            Console.WriteLine("this is method of i1");
        }
        public void print1()
        {
            Console.WriteLine("this is method of i2");
        }
        public void print2()
        {
            Console.WriteLine("this is method of i3");
        }
        static void Main(string[] args)
        {
            Program p = new Program();  
            p.print();
            p.print();
            p.print2();

            i3 myinterface = new Program();//child class object
           //we can not make the object of interface
            myinterface.print();
            myinterface.print1();
            myinterface.print2();



            Console.ReadLine();


        }
    }
}

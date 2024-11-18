using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Similarity_between_AbstractClass_Interface
{
    interface i1
    {

    }
    interface i2
    {
        
    }
    interface MyInterface : i1, i2//inherting multiple interface
    {
        void print();
    }
    abstract class myClass : i1, i2//inherting multiple interface
    {
        public abstract void print1();
    }

    class Example : myClass, MyInterface
    {
        public void print()
        {
            Console.WriteLine("interface myinterface method");
        }

        public override void print1()
        {
            Console.WriteLine("abstract myclass method");
        }
    }
    class Program 
    {
        static void Main(string[] args)
        {
            Example example = new Example();
            example.print1();
            example.print();

            Console.ReadLine();
        }
    }
}

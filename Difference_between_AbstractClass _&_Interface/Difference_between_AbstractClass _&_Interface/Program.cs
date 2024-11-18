using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Difference_between_AbstractClass____Interface
{
    class Example
    {

    }

    interface i1
    {

    }
    interface i2
    {

    }

    interface myinterface : i1, i2//we cannot inhert class in interface
    {
        void show();//we cannot make body{}
        
    }
    abstract class Myclass : Example, i1, i2
    {
        public Myclass()//constructr
        {
            Console.WriteLine("abstract class constructor..");
        }

        ~Myclass()
        {
            Console.WriteLine("abstract class destructor..");
        }
        public abstract void show();

    }

    class Myclass2 : Myclass, myinterface
    {
        public override void show()
        {
            Console.WriteLine("abstract class method");
        }

        public void print()
        {
            Console.WriteLine("interface method");
        }

    }
    class Program
    {
        
        static void Main(string[] args)
        {
            Myclass2 m = new Myclass2();
            
            Console.ReadLine();//to run detructor will comment this line
        }
    }
}

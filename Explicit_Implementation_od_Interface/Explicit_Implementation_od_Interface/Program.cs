using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Explicit_Implementation_od_Interface
{
    interface i1
    {
        void show();
    }
    interface i2 
    {
        void show();
    }
    class MyClass : i1, i2
    {
        //implicit interface
        public void show()
        {
            Console.WriteLine("method of i1 interface");
        }

        //explicit interface
        void i2.show()//here its by default public we cant mark it as public in explicit interface
        {
            Console.WriteLine("method of i2 interface");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //1st way
            MyClass mc = new MyClass();
            mc.show();//its diectly calling implicit interface(i1)
            ((i2)mc).show();//here we are doing casting for explicit interface(i2)   
            
            //for explicit interface
            i2 obj1 = new MyClass();//child class object
            obj1.show();

            Console.ReadLine();
        
        }
    }
}

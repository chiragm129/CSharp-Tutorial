using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sealed_Method
{
    //sealed method only be implementing with method overriding concept
    class A
    {
        public virtual void print()
        {
            Console.WriteLine("this is method of class A");
        }
    } 
    class B : A
    {
        //if we want dont  use this method for overriding again than will make this method Sealed
        public sealed override void print()
        {
            Console.WriteLine("this is method of class B");
        }
    }

    //class C : B
    //{
    //    public override void print()//we cant override class B method
    //    {
    //        Console.WriteLine("this is method of class C");
    //    }

    //}
    class Program
    {
        static void Main(string[] args)
        {
            B obj = new B();
            obj.print();

            Console.ReadLine();
        }
    }
}

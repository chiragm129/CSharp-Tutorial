using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_overriding
{
    //method overriding
    // when we have to run the only child class method than we will use method overriding
    //and when we want to enable child class method different(unique) its also reason of method overriding
    class parent
    {
       //using virtual keyword we are hiding this base class method
       //and giving the permision to the child class to override the method 
        public virtual void print()
        {
            Console.WriteLine("this is mehtod of parent class");
        }

    }

    class child : parent
    {
        //here using override keyword we are overriding the virtual class method
        public override void print()
        {
          // base.print();//using this we can call parent class method
            Console.WriteLine("this is mehtod of child class");
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            child c  = new child();
            c.print();//op child method

            parent p = new child();
            p.print();//op child method

            Console.ReadLine();

        }
    }
}

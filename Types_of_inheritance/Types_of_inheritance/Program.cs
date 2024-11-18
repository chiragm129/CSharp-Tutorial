using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Types_of_inheritance
{
    class BaseClass
    {
        public void Show1()
        {
            Console.WriteLine("this is a method of base class..");
        }
    }

    class DrivedClass1 : BaseClass //single
    {
        public void Show2()
        {
            Console.WriteLine("this is a method of 1st derived class..");
        }
    }

   // class DrivedClass2 : BaseClass //hierarchical

    class DrivedClass2 : DrivedClass1 //multilevel
    {
        public void Show3()
        {
            Console.WriteLine("this is a method of 2nd derived class..");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            DerivedClass3 dc3 = new DerivedClass3();
          //dc2.Show2();//for call it  we have to create object of deriverd 1 class(hierarchil inheritance)
            dc3.Show1 ();
            dc3.Show2 ();//its happenig due to multilevel 
            dc3.Show3 ();//its happenig due to multilevel 
            dc3.Show4 ();
            Console.ReadLine();


        }
    }
}

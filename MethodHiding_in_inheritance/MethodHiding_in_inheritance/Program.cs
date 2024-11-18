using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodHiding_in_inheritance
{
    class parent
    {
        public void show()
        {
            Console.WriteLine("parent class method");
        }

    }

    class child : parent
    {
        // use of new keyword is  intended that we are hiding the method of parent class
        // if we dont use new keyword it will give only warning, but program will work fine
        public new void show()
        {
            //base.show();//using base we can call the parent(base) class method

            Console.WriteLine("child class method");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            child c = new child();//derived class object
            c.show();//op will be child class method 
           //so here child class is hiding the method of his parent class its called method hiding

           //((parent)c).show();//using type casting we can also call the base class method
           

            //using this type of object creation we can call the parent class method
            //coz reference is parent class
            // we cannot write this child c = new parent() 
           
            //parent p = new child();
            //p.show();
            
            Console.ReadLine();
        }
    }
}

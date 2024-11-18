using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiple_inheritance
{
    //multiple inheritance is a feature in which a class can inherit characterstics and 
    //features from more than one parent class.

    // we cannot do multiple inheritance using classes
    // we can do multiple inheritance using Interface

    //in 2 parent class one will be class and 2nd will be interface
   // means child class inherit only one parent class but can inherit mutiple interface
    class person
    {
        //public void show1()
        //{
        //    Console.WriteLine("method of person class");
        //}

        public void show()
        {
            Console.WriteLine("method of person class");
        }
    }
    interface employee
    {
        //void show2();

        void show();
    }
    interface employee1
    {
        //void show2();

        void show();
    }

    class teacher : person, employee, employee1
    {
        //public void show2()
        //{
        //    Console.WriteLine("method of employee interface");
        //}

        void employee.show()//if method name same than we use explicit implementation
        {
            Console.WriteLine("method of emp interface");
        }
        void employee1.show()//if method name same than we use explicit implementation
        {
            Console.WriteLine("method of emp1 interface");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            //teacher t = new teacher();
            //t.show1();
            //t.show2();

            employee e = new teacher();
            e.show(); //for emp interface if method name same

            employee1 e1 = new teacher();
            e1.show();//for emp1 interface if method name same

            Console.ReadLine();
        }
    }
}

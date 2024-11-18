using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_constructor
{
    class Person
    {
        public static string personName;
        public static int personAge;

        static Person()//static constror its only run once
        {
            personName = "chirag";
            personAge = 23;
            Console.WriteLine("static constructor invoked...");
        }

        public Person()//default constructor it will run acording to the number of object
        {
            Console.WriteLine("default constructor invoked..");
        }

        public static void getDetails()
        {
            Console.WriteLine("person name is {0}",personName);
            Console.WriteLine("person age is {0}",personAge);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            Person q = new Person();
            Console.ReadLine();
        }
    }
}

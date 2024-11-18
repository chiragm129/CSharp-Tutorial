using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace copy_constructor
{
    class Example
    {
        string name;
        int age;


        public Example(string name, int age)//parameterized constructor
        {
            this.name = name;
            this.age = age;
        }

        public Example(Example e)//copy constructor
        {
            this.name = e.name;
            this.age = e.age;
        }
        public void getData()
        {
            Console.WriteLine("name is {0}",name);
            Console.WriteLine("age is {0}",age);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Example ex = new Example("chirag", 24);
            ex.getData();

            Example ex2 = new Example(ex);//here copy constructor is calling
            ex2.getData();

            Console.ReadLine();

        }
    }
}

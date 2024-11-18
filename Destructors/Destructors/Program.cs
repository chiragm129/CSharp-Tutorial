using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Destructors
{
    class Person
    {
        public string Name;
        public int Age;

        public Person(string Name, int Age)
        {
            this.Name = Name;
            this.Age = Age;

        }

        public string getName ()
        {
            return this.Name;
        }

        public int getAge()
        {
           return this.Age;
        }

        ~Person()//Destructor (it will run after destroying the memory of object)
        {
            Console.WriteLine("destructor invoked...");

        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Person chi = new Person("chirag",24);
            Person ali = new Person("mali", 21);
            Console.WriteLine(chi.getName());
            Console.WriteLine(chi.getAge());
            Console.WriteLine("=========");
            Console.WriteLine(ali.getName());
            Console.WriteLine(ali.getAge());

            //Console.ReadLine();//by this line destructor will not run
        }
    }
}

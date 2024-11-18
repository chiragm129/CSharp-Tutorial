using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace encapsulation
{
    class Person
    {
        //create private data
        private string Name;
        private int Age;

        //create public method to related data
        public void setName(string Name)
        {
            if(string.IsNullOrEmpty(Name) == true)
            {
                Console.WriteLine("name is required");
            }
            else
            {
                 this.Name = Name;
            }
        }

        public void  getName()
        {
            if (string.IsNullOrEmpty(this.Name) == true)
            {

            }
            else
            {
                 Console.WriteLine("your name is : " + this.Name);
            }
        }

        public void setAge(int Age)
        {
            if(Age > 0)
            {
                 this.Age = Age;
            }
            else 
            {
                Console.WriteLine("age should not be negative or zero..");
            }
        }

        public void  getAge()
        {
            if (Age > 0)
            {
                Console.WriteLine("your Age is : " + this.Age);
                
            }
            else
            {
                
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.setName("chirag");
            p.getName();

            p.setAge(27);
            p.getAge();

            Console.ReadLine();
        }
    }
}

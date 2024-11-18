using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace method__hiding2
{
    class employee
    {
        public string firstName;
        public string lastName;
        public void PrintFullName()
        {
            Console.WriteLine(firstName + " " + lastName);
        }
    }

    class PartTimeEmployee : employee
    {
        public new void PrintFullName()
        {
            base.PrintFullName();//parent class will be print
            //Console.WriteLine(firstName + " " + firstName + "PTE");
        }
    }

    class FullTimeEmployee : employee
    {
        public new void PrintFullName()
        {
            Console.WriteLine(firstName + " " + firstName + "FTE");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            PartTimeEmployee pte = new PartTimeEmployee();
            pte.firstName = "chirag";
            pte.lastName = "mali";
            pte.PrintFullName();//op pte method

            Console.ReadLine();

        }
    }
}

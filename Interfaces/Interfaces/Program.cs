using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    //in IEmployee I is prefix that is represnt to interface
    interface IEmployee
    {
        void show(); //here this method is by default abstract and public
    }

    class PartTimeEmployee : IEmployee
    {
        public void show() //implicit interface implementation
        {
            Console.WriteLine("this is a method of IEmployee interface...");

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            PartTimeEmployee pte = new PartTimeEmployee();
            pte.show();

            Console.ReadLine();
        }
    }
}

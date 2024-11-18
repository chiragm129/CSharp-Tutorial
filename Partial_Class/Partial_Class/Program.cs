using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partial_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentPartial obj = new StudentPartial();
            obj.FirstName = "chirag";
            obj.LastName = "mali";
            Console.WriteLine("Full name is: " + obj.GetFullName());

            Console.ReadLine();
        }
    }
}

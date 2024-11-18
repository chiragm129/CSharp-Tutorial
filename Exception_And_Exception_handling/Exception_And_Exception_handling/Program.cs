using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_And_Exception_handling
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number: ");
            int num2 = int.Parse(Console.ReadLine());
            try
            {
                int result = num1 / num2;
                Console.WriteLine("Division result is: " + result);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("you cannot divide a number by zero..");
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("Remaining statement 1");
            Console.WriteLine("Remaining statement 2");
            Console.WriteLine("Remaining statement 3");

            Console.ReadLine();
        }
    }
}

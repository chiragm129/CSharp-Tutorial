using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormatExceptionProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter  a number");
            string number = Console.ReadLine();
            try
            {
                int num = int.Parse(number);//if we pass string variable then we got the exception
                Console.WriteLine("Number is: " + num);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("string format not allowed");
                Console.WriteLine(ex.Message);
            }

        }
    }
}

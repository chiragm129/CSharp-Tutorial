using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IS_VS_AS_Keyword
{
    class Program
    {
        static void Main(string[] args)
        {
            //IS keyowrd used to check the data type of any object
            //object a = "chirag";
            //bool check = a is string;//is return true or false
            //Console.WriteLine(check);

            //Console.ReadLine();

            //AS Keyword used for type casting
            //if conversion is failed using AS then it will return null while debugging
            object a = "chirag";
            string str = a as string;//as used for conversion
            Console.WriteLine(str);

        }
    }
}

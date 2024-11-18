using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genrics_And_Genrics_methods
{
    class example
    {
        //use of genrics is that we can write a classs or methods that can work with any datatype of data float int string double 
        
        //1st example
        //T stands for genric placeholder
        //public static void ShowArray<T>(T[] arr)
        //{
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        Console.WriteLine(arr[i]);
        //    }
        //}   

        //2nd example
        public static bool Check<T>(T a, T b)
        {
            bool c = a.Equals(b);
            return c;

           // Console.WriteLine((typeof(T));//it will return the type of datatype of T 
        }

    }
    class Program
    {
        static void Main(string[] args)
        { 
            //2nd example
            Console.WriteLine(example.Check(11, 11));//true
            Console.WriteLine(example.Check("chirag", "chirag"));//true
            Console.WriteLine(example.Check("9.0", "8.0"));//false
 
            //1st example
            //string[] Name = { "chi", "ram", "krishna"};
            //double[] points = {2.2, 2.3, 3.3};

            //example.ShowArray(num);//directly calling through class name coz its static
            //example.ShowArray(Name);
            //example.ShowArray(points);

            Console.ReadLine();
        }
    }
}
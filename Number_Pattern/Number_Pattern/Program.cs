using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_Pattern
{
     class Program
    {
        static void Main(string[] args)
        {
            //number pattern 1 to 5
            int n = 5;

            //for (int i = 1; i <= n; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write(j);
            //    }
            //    Console.WriteLine();
            //}


            ////inverted pattern 1 to 5
            //for (int i = n; i >= 1; i--)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write(j);
            //    }
            //    Console.WriteLine();
            //}


            ////Inverted Decreasing Number Pattern(54321 to 1)
            //for (int i = n; i >= 1; i--)
            //{
            //    for (int j = i; j >= 1; j--)
            //    {
            //        Console.Write(j);
            //    }
            //    Console.WriteLine();
            //}


            //inverted decresing number pattern in pyramid format
            for (int i = n; i >= 1; i--)
            {
                // Print spaces before numbers
                for (int k = 1; k <= n - i; k++)
                {
                    Console.Write(" ");
                }

                // Print numbers in decreasing order
                for (int j = i; j >= 1; j--)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }
}

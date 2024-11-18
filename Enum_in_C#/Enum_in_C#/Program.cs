using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Enum_in_C_
{
    enum Days
    {
        Sunday = 1,//
        Monday,//2
        Tuesday,//3
        Wednesday,//4
        Thursday,//5
        Friday,//6
        Saturday//7 
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Enum with switch
            //we can use int instead of Days also

            Days myday = Days.Tuesday;
            //int  myday = (int)Days.Tuesday;
            switch (myday)
            {
                case Days.Sunday:
                    Console.WriteLine("this is sunday");
                    break;
                case Days.Monday:
                    Console.WriteLine("this is monday");
                    break;
                case Days.Tuesday:
                    Console.WriteLine("this is tuesday");
                    break;
                case Days.Wednesday:
                    Console.WriteLine("this is wednesday");
                    break;
                case Days.Thursday:
                    Console.WriteLine("this is thursday");
                    break;
                case Days.Friday:
                    Console.WriteLine("this is friday");
                    break;
                case Days.Saturday:
                    Console.WriteLine("this is saturday");
                    break;
                default:
                    break;
            }



            //int[] values = (int[])Enum.GetValues(typeof(Days));

            //foreach (int value in values)
            //{
            //    Console.WriteLine(value);
            //}


            //string[] members = Enum.GetNames(typeof(Days)); 

            //foreach (string member in members) 
            //{
            //    Console.WriteLine(member);
            //}

            //Console.WriteLine("Enter your name");
            //string name = Console.ReadLine();

            //Console.WriteLine("Enter your day sunday = 1, monday = 2, tuesday = 3");
            //int value = int.Parse(Console.ReadLine());

            //Days myday = (Days)value;
            //Console.WriteLine("My name is: " + name + " and my birth day is: " + myday);


            //Days myDay = (Days)9;//add explicit cast
            //Console.WriteLine(myDay);//friday

            //int value = (int)Days.Tuesday;//add explicit cast
            //Console.WriteLine(value);//2

            //Days birthday = Days.Friday;
            //Console.WriteLine(birthday);

            //Console.WriteLine(Days.Sunday);

            //ENUM is used when we want to change the color of console statement.M
            //below are the built in ENUM
            //Console.BackgroundColor = ConsoleColor.Green;
            //Console.ForegroundColor = ConsoleColor.Red;

            //Console.WriteLine("My name is chirag mali");


            Console.ReadLine();
        }
    }
}

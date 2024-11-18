using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticProperties
{
    class University
    {
        private static string UniName;
        private static string DepartmentName;
        
        //private int Age;//we cant initialize instance filed with static property

        //public static int _Age
        //{
        //    set
        //    {
        //        Age = value;//getting error creating property of non static variable
        //    }
        //    get
        //    {
        //        return Age;
        //    }
        //}

        public static string _UniName
        {
            set
            {
                if(string.IsNullOrEmpty(value)==true)
                {
                    Console.WriteLine("you cant null or empty..");
                }
                else
                {
                    UniName = value;
                }
            }

            get
            {
                return UniName;
            }
        }

        public static string _DepartmentName
        {
            set
            {
                if (string.IsNullOrEmpty(value) == true)
                {
                    Console.WriteLine("you cant null or empty..");
                }
                else
                {
                    DepartmentName = value;
                }
            }

            get
            {
                return DepartmentName;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            University._UniName = "Rgpv";
            Console.WriteLine("University name is {0}",University._UniName);
            University._DepartmentName = "CS";
            Console.WriteLine("DepartmentName is {0}",University._DepartmentName);




            Console.ReadLine();
        }
    }
}

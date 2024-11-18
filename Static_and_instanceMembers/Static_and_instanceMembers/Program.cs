using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_and_instanceMembers
{
    class Student
    {
        //instance variabler : 
        public int rollNO;
        public string firstName;
        public string lastName;
        public int standard;

        //static variable 
        public static string schoolName = "ABC school";
        public static int fees = 4000;

        //but in the instance method we can use both static and instance
        public void printFullName()
        {
            string fullname = this.firstName + " " + this.lastName;
            Console.WriteLine("your full name is {0}", fullname);

        }

        //in static method we can only use static method
        public static int getFees()
        {
            return fees;
        }
        public static int getFeesAnnualIncrement(int fee)
        {
            return fee / 10;
        }

        static void Main(string[] args)
        {
            //callig instance variable by creating the objects
            Student chi = new Student();
            chi.rollNO = 1;
            chi.firstName = "chirag";
            chi.lastName = "mali";
            chi.standard = 2;

            Student ali = new Student();
            ali.rollNO = 3;
            ali.firstName = "ram";
            ali.lastName = "sharma";
            ali.standard = 4;

            Console.WriteLine(chi.rollNO);
            Console.WriteLine(chi.firstName);
            Console.WriteLine(chi.lastName);
            Console.WriteLine(chi.standard);
            chi.printFullName();
            Console.WriteLine("==============");

            Console.WriteLine(ali.rollNO);
            Console.WriteLine(ali.firstName);
            Console.WriteLine(ali.lastName);
            Console.WriteLine(ali.standard);
            ali.printFullName();


            //calling static variable directly through class name
            Console.WriteLine(Student.schoolName);
            Console.WriteLine(Student.getFees());
            Console.WriteLine(Student.getFeesAnnualIncrement(3000)); ;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class_Abstract_method
{
   //we cant make the object of abstract class
   //if we have abstract method so we have to create abstract class also
   //abstract class can use as base/parent class only
    abstract class person
    {
        public string FirstName;
        public string lasstName;
        public int age;
        public long phoneNum;

        public static string clgName = "SKITM";
        public abstract void PrintDetails();//abstract method have not body

    }
    //hierarchy inheritance one parent multiple child
    class student : person
    {
        public int RollNo;
        public int Fees;

        public override void PrintDetails()
        {
            string name = this.FirstName + " " + this.lasstName;
            Console.WriteLine("student name is :{0}", name);
            Console.WriteLine("student age is : {0}", this.age);
            Console.WriteLine("student phone number is :{0}", this.phoneNum);
            Console.WriteLine("student roll num is :{0}", this.RollNo);
            Console.WriteLine("student fees is :{0}", this.Fees);
        }

    }
    class teacher : person
    {
        public string qualification;
        public int salary;
        public override void PrintDetails()
        {
            string name = this.FirstName + " " + this.lasstName;
            Console.WriteLine("Teacher name is :{0}", name);
            Console.WriteLine("Teacher age is : {0}", this.age);
            Console.WriteLine("Teacher phone number is :{0}", this.phoneNum);
            Console.WriteLine("Teacher qualification is :{0}", this.qualification);
            Console.WriteLine("Teacher salary is :{0}", this.salary);
        }
  
    }
    class Program
    {
        static void Main(string[] args)
        {
            student chi = new student();
            chi.FirstName = "chirag";
            chi.lasstName = "mali";
            chi.age = 23;
            chi.phoneNum = 2362333630;
            chi.RollNo = 11;
            chi.Fees = 70000;
            chi.PrintDetails();

            Console.WriteLine("------------");

            teacher te = new teacher();
            te.FirstName = "Jyoti";
            te.lasstName = "jain";
            te.age = 30;
            te.phoneNum = 4255252353;
            te.qualification = "msc";
            te.salary = 30000;
            te.PrintDetails();

            Console.ReadLine();
        }
    }
}

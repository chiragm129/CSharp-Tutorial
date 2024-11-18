using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes_And_Object
{
    public class Student
    {
        int rollNo;
        string name;
        int age;
        int standard;

        public void setStudent(int rollNo, string name, int age, int standard)
        {
            this.rollNo = rollNo; //here this keyword is refere to the property of class that we made
            this.name = name;
            this.age = age;
            this.standard = standard;
        }

        public void getStudent()
        {
            Console.WriteLine("your roll no is :{0}",this.rollNo);
            Console.WriteLine("your name is :{0}",this.name);
            Console.WriteLine("your age is :{0}",this.age);
            Console.WriteLine("your class is :{0}",this.standard);
        }
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter roll no:");
            //int roll = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter name:");
            //string name = (Console.ReadLine());;
            //Console.WriteLine("Enter age:");
            //int age = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter class:");
            //int stand = int.Parse(Console.ReadLine());
            
            Student s1 = new Student();
            s1.setStudent(11,"chirag",19,2);
            s1.getStudent();

            Console.WriteLine("------------");//we can create muliple object of one class ike this

            Student s2 = new Student();
            s1.setStudent(13, "mali", 29, 1);
            s1.getStudent();
            Console.ReadLine();
            
        }   
    }
}

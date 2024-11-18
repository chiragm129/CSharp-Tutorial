using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    class Student
    {
        //private int _StdId; //write only property
        //private string _Name;//read and write propert
        //private int _TotalMarks = 100;//read only property

        //read only property
        //public int TotalMarks
        //{
        //    get
        //    {
        //        return this._TotalMarks;
        //    }
        //}

        //write only property


        //public int StdId //property
        //{
        //    set
        //    {
        //        this._StdId = value;

        //    }
        //}

        // read and write property
        //public string Name
        //{
        //    set
        //    {
        //        if(string.IsNullOrEmpty(value) == true)
        //        {
        //            Console.WriteLine("please enter your name");
        //        }
        //        else
        //        {
        //             this._Name = value;
        //        }
        //    }
        //    get
        //    {
        //        return this._Name;
        //    }
        //} 

        //auto implemented property without validation like if else
        public string firstName { get; private set; }// here the use of private is that another class member cannot change its property
        public string lastName { get;private set; }

        //student constructor hi private data ki value set krva skta hai
        public Student(string fname, string lname)
        {
            firstName = fname;
            lastName = lname;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student("chirag", "mali");

            //Console.WriteLine(s.TotalMarks);//read only property(get)

            //s.StdId = 21;//write only propert(set)

            //read and write property
            //s.Name = "chirag";//(set)
            //Console.WriteLine(s.Name);//(get)

            //auto implemented property 
            //s.firstName = "chirag"; //without private set
            //s.lastName = "mali"; //without private set

            Console.WriteLine(s.firstName + " " + s.lastName);

            Console.ReadLine();
        }
    }
}

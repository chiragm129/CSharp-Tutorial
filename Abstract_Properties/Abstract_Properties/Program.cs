using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Properties
{
    abstract class person
    {
        //uint means unsign we can not give neg value
        public abstract uint id { get; set; }
        public abstract string Name { get; set; }
    }

    class student : person
    {
        uint StuId;
        string StuName;

        public override uint id
        {
            set
            {
                if(value == 0)
                {
                    Console.WriteLine("id cant be zero");
                }
                else
                {
                    this.id = value;
                }
            }
            get
            {
                return this.id;
            }
        }

        public override string Name
        {
            set
            {
                if(string.IsNullOrEmpty(value) == true)
                {
                    Console.WriteLine("cant be empty");
                }
                else
                {
                     this.Name = value;
                }
            }
            get
            {
                return this.Name;
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            student s = new student();
            s.id = 22;
           // s.id = -22;//due to uint
            s.Name = "chirag";
            Console.WriteLine(s.id);
            Console.WriteLine(s.Name);

            Console.ReadLine();
        }
    }
}

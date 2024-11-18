using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_Class
{
    class Example<T>
    {
        T box;

        //using properties
        public T Box
        {
            set
            {
               this.box = value;

            }
            get
            {
                return this.box;

            }
        }


        //using constructor
        //public Example(T a) 
        //{
        //    this.box = a;
        //}

        //public T getBox()
        //{
        //    return this.box;
        //}
    }

    class Program
    {
        static void Main(string[] args)
        {
            //using properties

            Example<int> e = new Example<int>(); 
            Example<string> e1 = new Example<string>(); 
            Example<char> e2 = new Example<char>(); 
            e.Box = 20;
            Console.WriteLine(e.Box);
            e1.Box = "chirag";
            Console.WriteLine(e1.Box);
            e2.Box = 'A';
            Console.WriteLine(e2.Box);

            ////using constructor
            //Example<int> e = new Example<int>(20);//at the time of object declaration will declare which type of data type we want to print
            //Example<string> e1 = new Example<string>("chirag");
            //Example<double> e2 = new Example<double>(3.0);
            //Example<char> e3 = new Example<char>('A');
            //Console.WriteLine(e.getBox());
            //Console.WriteLine(e1.getBox());
            //Console.WriteLine(e2.getBox());
            //Console.WriteLine(e3.getBox());

            Console.ReadLine();
        }
    }
}

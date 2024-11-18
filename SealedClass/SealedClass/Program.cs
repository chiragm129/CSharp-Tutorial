using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealedClass
{
    //after using sealed we cant inherit the class
    //means sealed class cannot be parent class
    sealed class BaseClass
    {
        public void Show1()
        {
            Console.WriteLine("method of base class");
        }

    }

    class DerivedClass // : BaseClass cannot inherit it
    {
        public void Show2()
        {
            Console.WriteLine("method of derived class");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            BaseClass bc = new BaseClass();
            bc.Show1();

            Console.ReadLine();
        }
    }
}

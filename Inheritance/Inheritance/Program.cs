using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class VisitingEmployee : Employee // vistingEmployee is derived/child class
    {
        public int VisitingSalary;
        public int VisitingHours;
    }

    class PermanentEmployee : Employee //permanentEmployee is derived/child class
    {
        public int PermanentSalary;
        public int PermanentHours;
    }

    class Employee
    {
        public int EmpId;
        public string EmpName;
        public int EmpAge;
        public int EmpContNo;

        public void show()
        {
            Console.WriteLine("this is a method of base class");
        }
    }
     class Program
    {
        static void Main(string[] args)
        {
            PermanentEmployee chi = new PermanentEmployee();
            chi.EmpId = 1;
            Console.WriteLine(chi.EmpId);
            chi.show();

            VisitingEmployee ram = new VisitingEmployee();
            ram.EmpId = 2;
            Console.WriteLine(ram.EmpId);

            Console.ReadLine();
        }
    }
}

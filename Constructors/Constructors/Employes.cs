using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    class Employes
    {
        //instance variable
        int EmpId;
        string EmpName;
        int EmpAge;

        //parametrized constructor
        public Employes(int EmpId, string EmpName, int EmpAge)
        {
            this.EmpId = EmpId;
            this.EmpName = EmpName;
            this.EmpAge = EmpAge;

        }

        public int getId()
        {
            return this.EmpId;
        }

        public string getName()
        {
            return this.EmpName;
        }

        public int getAge()
        {
            return this.EmpAge;
        }

        //default constructor no parameter here
        //public Program()
        //{
        //    Console.WriteLine("constructor invokes!!");
        //}

        static void Main(string[] args)
        {
            //it run for emplyees class of every object
            Employes emp = new Employes(11,"chirag",22);
            Employes chi = new Employes(12, "mali", 23);

            Console.WriteLine("employe id is {0}",emp.getId());
            Console.WriteLine("chirag id is {0}",emp.getId());
            Console.WriteLine("employe name is {0}", emp.getName());
            Console.WriteLine("chirag name is {0}", chi.getName());
            Console.WriteLine("employe Age is {0}", emp.getAge());
            Console.WriteLine("chirag Age is {0}", chi.getAge());
            Console.ReadLine();
        }
    }
}

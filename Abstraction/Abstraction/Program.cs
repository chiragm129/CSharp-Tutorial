using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    class Employee
    {
        public int EmpId;
        public string EmpName;
        public double GrossPay;
        double TaxDeduction = 0.1;//10%
        double netSalary;

        public Employee(int Eid, string Ename, double Egrosspay)
        {
            this.EmpId = Eid;
            this.EmpName = Ename;
            this.GrossPay = Egrosspay;
                
        }

        private void CalcSalary()
        {
            if(GrossPay >= 30000)
            {
                netSalary = GrossPay - (TaxDeduction * GrossPay);
                Console.WriteLine("your salary is {0}",netSalary);
            }
            else
            {
                Console.WriteLine("your salary is {0}", GrossPay);
            }
        }

        public void ShowEmpDetails()
        {
            Console.WriteLine("Employee id is: {0}", this.EmpId);
            Console.WriteLine("Employee name is: {0}", this.EmpName);
            this.CalcSalary();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee e = new Employee(12,"chirag",40000);
            
            e.ShowEmpDetails();

            Console.ReadLine();
          
        }
    }
}

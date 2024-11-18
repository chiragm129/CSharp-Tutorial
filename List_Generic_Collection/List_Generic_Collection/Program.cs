using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_Generic_Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee()
            {
                name = "chirag",
                age = 24,
                designation = "manager"
            };

            Employee emp2 = new Employee()
            {
                name = "Ram",
                age = 23,
                designation = "engineer"
            };

            Employee emp3 = new Employee()
            {
                name = "shyam",
                age = 18,
                designation = "Leader"
            };

            List<Employee> empList = new List<Employee>();    //here data will be employee class
            empList.Add(emp1);
            empList.Add(emp2);
            empList.Add(emp3);

            Employee[] emps = empList.ToArray();//convert into array

            foreach (Employee emp in emps)
            {
                Console.WriteLine("Employee name is: {0} Age is: {1} Designation is: {2}", emp.name, emp.age, emp.designation);
            }

            List<Employee> myEmps = emps.ToList();//again convert aaray to list

            foreach (Employee emp in emps)
            {
                Console.WriteLine("Employee name is: {0} Age is: {1} Designation is: {2}", emp.name, emp.age, emp.designation);
            }

            //Console.WriteLine(empList.Find(e => e.age > 20));//search the element with codition with 1st occurance

            //Console.WriteLine(empList.FindLast(e => e.age > 20));//search the element with codition with lasst occurance

            //Console.WriteLine(empList.FindIndex(e => e.age > 20));//search the index of element with codition with 1st occurance

            //Console.WriteLine(empList.FindLastIndex(e => e.age > 20));//search index of element with codition with lasst occurance

            //List<Employee> emps = empList.FindAll(e => e.age > 20);//search the element with codition with lasst occurance

            //foreach (Employee emp in emps)
            //{
            //    Console.WriteLine("Employee name is: {0} Age is: {1} Designation is: {2}", emp.name, emp.age, emp.designation);
            //}

            //Console.WriteLine("Employee name is: {0} Age is: {1} Designation is: {2}", emp.name, emp.age, emp.designation);

            //  Console.WriteLine(empList.Exists(emp => emp.name.StartsWith("R")));//if name start with A then it will return true else false

            //foreach (Employee emp in empList)
            //{
            //    Console.WriteLine("Employee name is: {0} Age is: {1} Designation is: {2}", emp.name, emp.age, emp.designation);
            //}

            //empList.RemoveAll(emp => emp.age > 20);//remove all item that match the condition

            //Console.WriteLine("==============");

            //foreach (Employee emp in empList)
            //{
            //    Console.WriteLine("Employee name is: {0} Age is: {1} Designation is: {2}", emp.name, emp.age, emp.designation);
            //}


            //List<int> num = new List<int>();
            //num.Add(1);
            //num.Add(2);
            //num.Add(3);
            //num.Add(4);
            //num.Add(5);//4 index
            //num.Add(5);
            //num.Add(5);//6 index

            //Console.WriteLine(num.IndexOf(5,4));//it will return 5 from zero index first  means 5 is on 4 index

            //Console.WriteLine(num.LastIndexOf(33));//it will return 5 from last zero index means 5 is on 6 index

            //Console.WriteLine(num[1]);//accessed by index number

            //Console.WriteLine(num.Contains(4));//return true

            //Console.WriteLine(num.Count);//return count

            //foreach (int item in num)
            //{
            //    Console.WriteLine(item);
            //}

            //num.Clear();//remmove all

            //num.Reverse();//reverse the list



            //Console.WriteLine("----------");

            //num.Sort();//sort the data

            //num.AddRange(num);//add item to the list suppose we have 5 item then again it will add 5 item

            //num.Insert(1, 10);//insert item at specified index

            //num.InsertRange(2, num);//5 more item will add on 2 index

            //num.Remove(4); //1st occurenace remove, suppose we have muliple 4, so 1st 4 will be remove only

            //num.RemoveAt(3);//remove via index, index 3 element will remove

            //num.RemoveRange(2, 3);//op 1,2 (after index 2, three value will be return)

            //foreach (int item in num)
            //{
            //    Console.WriteLine(item);
            //}

            //List<string> names = new List<string>();
            //names.Add("Chirag");
            //names.Add("Mali");
            //names.Add("Ram");
            //names.Add("Ram");
            //names.Add(null);
            //names.Add("Shyam");

            //foreach (string item in names)
            //{
            //    Console.WriteLine(item);
            //}

            Console.ReadLine();
        }
    }
}

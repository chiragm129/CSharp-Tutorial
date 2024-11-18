using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Dictionary_Generic__Collection
{
     class Program
    {
        static void Main(string[] args)
        {

            //Employee emp1 = new Employee()
            //{
            //    Id = 1,
            //     name = "chirag",
            //     designation = "manager",
            //     salary = 15000
            // };

            // Employee emp2 = new Employee()
            // {
            //     Id = 2,
            //     name = "Ram",
            //     designation = "engineer",
            //     salary = 12000
            // };

            // Employee emp3 = new Employee()
            // {
            //     Id=3,
            //     name = "shyam",
            //     designation = "Leader",
            //     salary = 8000
            // };

            // Dictionary<int,Employee> myemp = new Dictionary<int,Employee>();
            // myemp.Add(emp1.Id, emp1);
            // myemp.Add(emp2.Id, emp2);
            // myemp.Add(emp3.Id, emp3);

            // Console.WriteLine(myemp.Count(emp => emp.Value.salary > 10000));//op=2//return count with specific condition

            // Console.WriteLine(myemp.Count(emp => emp.Value.name.StartsWith("s")));//op=1//return count with specific condition

            Dictionary<string, string> dict = new Dictionary<string, string>();
            dict.Add("name", "chirag");
            dict.Add("lname", "mali");
            dict.Add("class", "fifth");
            dict.Add("religion", "hindu");
            dict.Add("religion", "muslim");//same key not allowed give argument exception
            //dict.Add(null, "hindu");//can not allow null key
            //dict.Add("religion", null);//but  allow null value

            //string value;
            //if (dict.TryGetValue("name", out value))
            //{
            //    Console.WriteLine(value);
            //}
            //else
            //{
            //    Console.WriteLine("key not found");
            //}

            //string value;
            //dict.TryGetValue("name",out value);//out parameter
            //Console.WriteLine(value);

            //Console.WriteLine(dict.ContainsKey("name"));//return true if name key there else false

            //Console.WriteLine(dict.ContainsValue("mali"));//return true if mali value there else false

            //Console.WriteLine(dict["name"]);

            //Console.WriteLine(dict.Count);//return count

            //Dictionary<int, string> dict2 = new Dictionary<int, string>();
            //dict2.Add(1, "chirag");

            //foreach (KeyValuePair<string, string> item in dict) //retur key value
            //{
            //    Console.WriteLine("key is: " + item.Key + " " + "value is: " + item.Value);
            //}

            ////dict.Remove("name");//remove specify key

            //dict.Clear();//remove all

            //Console.WriteLine("===========");

            //foreach (KeyValuePair<string, string> item in dict) //retur key value
            //{
            //    Console.WriteLine("key is: " + item.Key + " " + "value is: " + item.Value);
            //}

            //foreach (string key in dict.Keys)//return key
            //{
            //    Console.WriteLine(key);
            //}

            //foreach (string value in dict.Values)//return value
            //{
            //    Console.WriteLine(value);
            //}

            Console.ReadLine();

        }
    }
}

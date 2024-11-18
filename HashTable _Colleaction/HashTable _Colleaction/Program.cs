using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable__Colleaction
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add("Id", 124);//here we can use integer value also instead of id, name, salary etc.
            ht.Add("name", "chirag");
            ht.Add("salary", 35000.00);
            ht.Add("Designation", "manager");
            ht.Add("IsMarried", false);
           

            // Console.WriteLine(ht["Designation"]);

            Console.WriteLine(ht.Contains("Age"));//if age key theree it will return true else false
            Console.WriteLine(ht.ContainsKey("Id"));//return true for Id key
            Console.WriteLine(ht.ContainsValue("chirag"));//retturn true for chirag value
           
            Console.WriteLine("chirag".GetHashCode());//will return the hash code for the chirag key

            Console.WriteLine(ht.Count);//will return the count of key/value

            //foreach (object key in ht.Keys)
            //{
            //    Console.WriteLine(key + " : " + ht[key]);//it will return key value and data was not return into the particular order the reason is that hash code coz hash code is generated randomly
            //}

            //ht.Remove("Id");

            //Console.WriteLine("=============");
            //foreach (object key in ht.Keys)
            //{
            //    Console.WriteLine(key + " : " + ht[key]);//it will return key valuee
            //}

            // ht.Clear();//remove all

            //foreach (object key in ht.Keys)
            //{
            //    Console.WriteLine(key + " : " + ht[key]);//it will return key valuee
            //}


            //have another way to call the data
            //Hashtable ht = new Hashtable()
            //{
            //    { "Id",124 },
            //    { "name","chirag"},
            //    { "Age",27}
            //};
            //Console.WriteLine(ht["Age"]);


            Console.ReadLine();
        }
    }
}

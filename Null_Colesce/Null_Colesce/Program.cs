using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Null_Colesce
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruit1 = null;
            string fruit2 = "Banana";
            string fruit3 = "Mango";

            string result = fruit1 ?? fruit2 ?? fruit3;//?? pick up first non null value
            Console.WriteLine(result);//Banana

            //string name = "Chirag";
            //string result = name ?? "Anonymous"; //if name have null value then ?? operator replace the name with right side value
            //Console.WriteLine(result);

            Console.ReadLine();
        }
    }
}

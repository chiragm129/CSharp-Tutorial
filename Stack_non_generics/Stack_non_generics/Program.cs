using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_non_generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack st = new Stack();
            st.Push("chirag");
            st.Push(24);
            st.Push(5.11);
            st.Push(false);
            st.Push("mali");
            //  st.Push(null);
            //st.Push("mali");

            Console.WriteLine(st.Contains("chirag"));//id chirag there and it will return true else false

            Console.WriteLine(st.Count);//count of stack

            Console.WriteLine(st.Peek()); // return the last data (Mali)

            Console.WriteLine("------------");


            foreach (object item in st)
            {
                Console.WriteLine(item);//last in first out here

            }

            //st.Clear();//clear the stack

            Console.WriteLine(st.Pop()); // remove and return the data items from the top of stack


            Console.WriteLine("------------");

            foreach (object item in st)
            {
                Console.WriteLine(item);//last in first out here

            }

            Console.ReadLine();
        }
    }
}

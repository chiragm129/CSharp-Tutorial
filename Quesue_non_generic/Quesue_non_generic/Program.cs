using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue_non_generic
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue qu = new Queue();//here first in first out concept 
            qu.Enqueue("chirag");//to insert data use enqueue method
            qu.Enqueue('A');
            qu.Enqueue(25);
           //qu.Enqueue(null);
            //qu.Enqueue(25);
            qu.Enqueue(true);
            qu.Enqueue(5.9);

            Console.WriteLine(qu.Contains("chirag"));//if chirag there then it will return true else false

            Console.WriteLine(qu.Count);//return the count of items

            //while(qu.Count > 0) 
            //{
            //    Console.WriteLine(qu.Dequeue());//retuen and remove all the item by while loop
            //}

            //Console.WriteLine("++++++++++++++++++++++++++");

           // Console.WriteLine(qu.Count);//now count will be 0 after executing while loop

            Console.WriteLine(qu.Peek());//return first element from the queue 

            //foreach (object item in qu)
            //{
            //    Console.WriteLine(item);
            //}

           // qu.Clear();//remove all the item from the queue

            //qu.Dequeue();//remove the first item and return the remaining item

            //Console.WriteLine("=========");

            //foreach (object item in qu)
            //{
            //    Console.WriteLine(item);
            //}

            Console.ReadLine();
        }
    }
}

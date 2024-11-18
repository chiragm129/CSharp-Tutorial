using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection_and_Array_List
{
     class Program
    {
        static void Main(string[] args)
        {
            //ArrayList MyList = new ArrayList(8);//here 2 means capacity start with 2, we have no need to put initial capcacity its just for knowledge
            
            ArrayList MyList = new ArrayList();
            Console.WriteLine(MyList.Capacity);//tells the number of items = 0
            MyList.Add(10);
            Console.WriteLine(MyList.Capacity);//4
            MyList.Add(20);
            MyList.Add(30);
            MyList.Add(40);
            Console.WriteLine(MyList.Capacity);//tells the number of items = 4
            MyList.Add(50);
            Console.WriteLine(MyList.Capacity);//tells the number of items = 8 after 4 it will do doubling and its doubling mechanism called Auto-Resizing

            foreach (object obj in MyList)//basicalyy foreach loop we used with array list and collection
            {
                Console.Write(obj + "   ");    
            }
            Console.WriteLine();
            
            MyList.Insert(2,25);
            foreach (object obj in MyList)//basicalyy foreach loop we used with array list and collection
            {
                Console.Write(obj + "   ");
            }
            Console.WriteLine();

            //MyList.Remove(40);//deleting via direct value
            MyList.RemoveAt(4);//deleting via index number
            foreach (object obj in MyList)//basicalyy foreach loop we used with array list and collection
            {
                Console.Write(obj + "   ");
            }
            Console.WriteLine();


            //MyList.Add("chirag");
            //MyList.Add(10.32);
            //MyList.Add('A');



            //int[] MyArray = new int[3];
            //MyArray[0] = 10;
            //MyArray[1] = 20;
            //MyArray[2] = 30;

            //Array.Resize(ref MyArray, 4);  //resize is destroy old array and create new array with new length

            //MyArray[3] = 40;

            Console.ReadLine();
        }
    }
}

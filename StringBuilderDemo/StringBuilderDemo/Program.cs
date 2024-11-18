using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuilderDemo
{
     class Program
    {
        //both are immutable(unchangeble) mean we can change but it will not change in the same address block
        
        //diff b/w string and string builder is in string if we add new string than data will create in new block in heap memory
        //so to overcome this drawback here string builder comes to the picture
        //stringBuilder is faster than string

        static void Main(string[] args)
        {

            //String s1 = "chirag";
            //Stopwatch sw1 = new Stopwatch();
            //sw1.Start();
            //for (int i = 0; i < 100000; i++)
            //{
            //    s1 = s1+ i;
            //}
            //sw1.Stop();
            //Console.WriteLine("Time of String : "+ sw1.ElapsedMilliseconds);


            //StringBuilder sb = new StringBuilder();
            //sb.AppendFormat("{0:X}",25); // X means hexadecimal value

            StringBuilder sb = new StringBuilder("Hello World");
            // sb.Insert(5,"C#"); //insert value at specified index

            // sb.Remove(6,5);//strt with 6 index and remove 5 character

            //sb.Replace("World", "Chirag");//replace world with chirag

            string str = sb.ToString();//get string from stringBuilder //convert stringbuilder to string
            Console.WriteLine(str);

            //Console.WriteLine(sb);

            //sb.Append("hello");//add the string
            //sb.AppendLine("world");//append the string with new line at the end
            //sb.Append("enjoy");//enjoy will append in next line
            //Console.WriteLine(sb);




            Console.ReadLine(); 
        }
    }
}

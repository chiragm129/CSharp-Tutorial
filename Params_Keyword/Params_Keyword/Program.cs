using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Params_Keyword
{
    class Program
    {
        // params keyword use is when we have to add multiple without knowing the specific number(10,20,30,40,50)
        //it is useful when programmer dont have any prior knowledge about the number of parameter to be used
        //only one params keyword is allowed
        //params parameter will be in last(int,params int[] nums so here int a = 10 and params are = 20,30,40
        //params lenegth will be zero if no argument passed

        //here difference between array and params is that array needs to pass at least 1 argument to method to work but 
        //params can work without argument 

        public static int add(params int[] nums)
        {
            int sum = 0;

            foreach (int i in nums)
            {
                sum = sum + i;
            }

            return sum;
        }
        static void Main(string[] args)
        {
            //static class ko class k name se call krte hai
            Console.WriteLine(Program.add(10,20,30,40));
        }
    }
}

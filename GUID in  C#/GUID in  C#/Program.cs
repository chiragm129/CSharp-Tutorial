using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUID_in__C_
{
    class Program
    {
        static void Main(string[] args)
        {
            //GUID is a structure
            //globally unique identifier

            Guid g = Guid.NewGuid();//everytime it will return new value

            //Console.WriteLine(g.ToString().Replace("-", string.Empty));//remove the - from the values
            
            //Console.WriteLine(g.ToString("N"));//it also remove -
            
            Console.WriteLine(g.ToString("N").Substring(0,15));//return only from 0-15 characters

            Console.ReadLine();
        }
    }
}

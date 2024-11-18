using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extension_Methods
{
    class TestExtensionMethod
    {
        static void Main()
        {
            //after binding the staic method with any class or struct then they convert into non static or instance method
            //thats why here we are calling staic method by object.
            Program p = new Program();
            //p.Func3(20);//here we are using func3() method only for binding // here 3 is calling for int i parameter

            //create struct here 
            int i = 20;
            bool result = i.IsGreaterThan(50);
            Console.WriteLine(result);

            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Try_with_muliple_catchBlock_And_Finally_Block
{
    class Program
    {
        static void Main(string[] args)
        {
            //there is four ways of exception
            //Default throw and default catch -  handling by C# compiler without try catch
            //default throw and our catch - throwing by C# compiler and handling by our catch block
            //our throw and default catch - we will throw the exception and hadling catch by C# compiler(without try and catch only, use throw keyword for exception)
            //our throw and our catch


            //our throw and default catch
            //Console.WriteLine("Enter your age: ");
            //int age = int.Parse(Console.ReadLine());

            //if(age >= 18)
            //{
            //    Console.WriteLine("you can cast vote");
            //}
            //else
            //{
            //    throw new Exception("can not cast the vote");//throw keyword use for throw the exception by ourself;
            //}


            //our throw and our catch
            int ac_balance = 5000;
            int withdrwal_amnt = 6000;//if its grater than ac balance then throw exception

            try
            {
                if (ac_balance < withdrwal_amnt)
                {
                    throw new Exception("insufficient balance");
                }           
                else
                {
                    ac_balance = ac_balance - withdrwal_amnt;
                    Console.WriteLine("balance is: " + ac_balance);
                    Console.WriteLine("Transaction successfully done");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


            //Default throw and default catch
            //default throw and our catch
            //try
            //{
            //At a time only one exception is occured and at a time only one catch bloclk is executed.
            //All catch blocks must be ordered from most specific to most general(means we have to put in order divide null and etc)
            //if we run 3 concept together and got exception in first one so only first one will run remaining will not run

            //int a = 10;
            //int b = 0;
            //int c = a / b; //its dividezeroexception

            //string s = null;
            //Console.WriteLine(s.Length);//null reference exception

            //int[] arr = new int[2];
            //arr[0] = 1;
            //arr[1] = 2;
            //arr[2] = 3;
            //arr[3] = 4;//it will handle by exception class(indexoutofrangeexceptio)

            //catch (DivideByZeroException ex)
            //{
            //             Console.WriteLine(ex.Message);
            //         }
            //catch (NullReferenceException ex)
            //{
            //             Console.WriteLine(ex.Message);
            //         }
            //catch (Exception ex)
            //{
            //             Console.WriteLine(ex.Message);
            //         }

            //we can use finally keyword without catch block also.
            //finally//it will executes everytime if exceptio occurs or not
            //{
            //    Console.WriteLine("finally block executed");
            //}

            Console.ReadLine();
        }
    }
}

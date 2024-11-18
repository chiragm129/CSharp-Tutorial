using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Multi_Threading
{
    class Program
    {
        public static void func1()
        {
            for (int i = 0; i <=50; i++)
            {
                Console.WriteLine("Func1= " + i);
            }
        }
        
        public static void func2()
        {
            for (int i = 0; i <=50; i++)
            {
                Console.WriteLine("Func2= " + i);
                if (i == 25)
                {
                    Console.WriteLine("thread is going sleep for 8 seconds...");
                    Thread.Sleep(8000);
                }
            }
        }
        
        public static void func3()
        {
            for (int i = 0; i <=50; i++)
            {
                Console.WriteLine("Func3= " + i);
            }
        }
        static void Main(string[] args)
        {
            //here single thread is working in sequemtial format
            //suppose fun2 have  logic  it takes more time to execution so fun3 will be im delay state
            //so to overcome this problem here we used multi threading

            Thread t1 = new Thread(func1);  
            Thread t2 = new Thread(func2);
            Thread t3 = new Thread(func3);
            
            //here simultaneously switched the thread by OS(Time Sharing)
            t1.Start();
            t2.Start();
            t3.Start();
            
            //Program.func1();
            //Program.func2();
            //Program.func3();

            //Thread t = Thread.CurrentThread;
            //t.Name = "Main Thread";
            //Console.WriteLine("Currrent executing thread is : " + Thread.CurrentThread.Name);

            Console.ReadLine();

        }
    }
}

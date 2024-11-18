using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependecy__Injection_Using__Properties
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace Dependency_Injection_Using_Constructor
    {
        public interface IAccount
        {
            void PrintDetails();
        }
        class CurrentAccount : IAccount
        {
            public void PrintDetails()
            {
                Console.WriteLine("details of current account");
            }
        }
        class SavingAccount : IAccount
        {
            public void PrintDetails()
            {
                Console.WriteLine("Details of saving account");
            }
        }

        class Account
        {
            public IAccount account { get; set; }//property

            public void PrintAccount()
            {
                account.PrintDetails();
            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                //here is also we are not depending on account class 
                //we are processing this thruugh IAccount property
                Account sa = new Account();
                sa.account = new SavingAccount();//child class object
                sa.PrintAccount();

                Account ca = new Account();
                ca.account = new CurrentAccount();//child class object
                ca.PrintAccount();


                Console.ReadLine();
            }
        }
    }

}

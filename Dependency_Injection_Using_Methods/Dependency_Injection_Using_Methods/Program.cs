using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Injection_Using_Methods
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
        public void PrintAccounts(IAccount account)//parameterized method
        {
            account.PrintDetails();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //here is also not dependent on account class coz here we are using method injector(IAccount)   
            Account sa = new Account();
            sa.PrintAccounts(new SavingAccount());

            Account ca = new Account();
            ca.PrintAccounts(new CurrentAccount());

            Console.ReadLine();
        }
    }
}

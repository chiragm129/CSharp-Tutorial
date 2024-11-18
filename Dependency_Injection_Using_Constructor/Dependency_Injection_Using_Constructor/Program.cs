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
        private IAccount account;//private variable

        public Account(IAccount account)//parameterized constructor
        {
            this.account = account;//this.account means account variable and right side vala account is parameter vala account
        }

        public void PrintAccount()
        {
            account.PrintDetails();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //so here CurrentAccount and SavingAccount class is not directly dependent on Acount class
            //coz here we used constructor injection using interface for decoupling

            IAccount ca = new CurrentAccount();//current account is child class object
            Account a = new Account(ca);
            a.PrintAccount();
            
            IAccount sa = new SavingAccount();//saving account is child class object
            Account a2 = new Account(sa);
            a2.PrintAccount();

            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Static_class
{
    static class Product
    {
        public static int ProductId;
        public static string ProductName;
        public static int ProductPrice;

        static Product()
        {
            ProductId = 11;
            ProductName = "book";
            ProductPrice = 1500;

        }

        public static void getPRoductDEtails()
        {
            Console.WriteLine("prduct id is {0}",ProductId);
            Console.WriteLine("prduct name is {0}",ProductName);
            Console.WriteLine("prduct price is {0}",ProductPrice);

        }
           
        public static void getDiscount()
        {
            int d_amount = ProductPrice / 10;
            Console.WriteLine("your discount is {0}",d_amount);
            Console.WriteLine("total cost after discount is {0}", (ProductPrice - d_amount));
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Product.getPRoductDEtails();
            Product.getDiscount();

            Console.ReadLine();

        }
    }
}

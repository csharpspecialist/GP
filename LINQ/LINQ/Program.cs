using System;
using System.Linq;
using System.Runtime.InteropServices;

namespace LINQ
{
    class Program
    {
        /* Practice your LINQ!
         * You can use the methods in Data Loader to load products, customers, and some sample numbers
         * 
         * NumbersA, NumbersB, and NumbersC contain some ints
         * 
         * The product data is flat, with just product information
         * 
         * The customer data is hierarchical as customers have zero to many orders
         */

        static void Main()
        {
            //PrintOutOfStock();
            //InStockMoreThan3();
            //Washington();
            //Sequence();  // 4  --
             //Increase();   // 5  --
            // First3OrdersInWash();
            // SkipFirst2InWash();
            // GreaterEqual6();
            // Reverse();     //21---
            // Alphabetic   //18.
            // UnitsInStock()   //19.



            Console.ReadLine();
        }

        private static void PrintOutOfStock()
        {
            var products = DataLoader.LoadProducts();

            //var results = products.Where(p => p.UnitsInStock == 0);
            var results = from p in products
                where p.UnitsInStock == 0
                select p;

            foreach (var product in results)
            {
                Console.WriteLine(product.ProductName);
            }
        }

        //2. Find all products that are in stock and cost more than 3.00 per unit.
        private static void InStockMoreThan3()
        {
            var products = DataLoader.LoadProducts();

            //var results = products.Where(p => p.UnitsInStock > 0 && p.UnitPrice > 3);
            var results = from p in products
                where p.UnitsInStock > 0 && p.UnitPrice > 3
                select p;

            foreach (var product in results)
            {
                Console.WriteLine("{0} has {1} in stock with unit price {2}", product.ProductName,
                    product.UnitsInStock, product.UnitPrice);
            }
        }

        private static void Washington()
        {
            var customer = DataLoader.LoadCustomers();

            //var results = products.Where(p => p.UnitsInStock == 0);
            var results = from c in customer
                where c.Region == "WA"
                select c;

            foreach (var cust in results)
            {
                Console.WriteLine("Company {0} Ordered {1} from the {2} region"
                    , cust.CompanyName, cust.Orders, cust.Region);
            }
        }

        private static void Sequence()
        {
            var products = DataLoader.LoadProducts();

            //var results = products.Where(p => p.UnitsInStock == 0);
            var results = from p in products
                // where p.ProductName == p
                select p.ProductName;

            foreach (var prods in results)
            {
                Console.WriteLine("These are our Products {0}.", prods);
            }
        }

        private static void Increase()
        {
            var products = DataLoader.LoadProducts();
            //did not find the .25% increase!!!
            //var results = products.Where(p => p.UnitsInStock == 0);
            var results = from p in products
                //where p.ProductName == (p
                select p;

            foreach (var prods in results)
            {
                Console.WriteLine("These are our Products {0}. and the Unit Price {1}", prods.ProductName,
                    prods.UnitPrice*1.25m);
            }
        }

        //12 first 3 orders in WA
        private static void First3OrdersInWash()
        {
            var customers = DataLoader.LoadCustomers();

            var results = (from c in customers
                from o in c.Orders
                where c.Region == "WA"
                select new {c.CompanyName, o.OrderID, o.OrderDate}).Take(3);
            foreach (var things in results)
            {
                Console.WriteLine("Our products from {0}, {1}, {2}", things.OrderDate, things.OrderID,
                    things.CompanyName);
            }


        }

        //Skip first 2 orders in WA
        private static void SkipFirst2InWash()
        {
            var customers = DataLoader.LoadCustomers();

            var results = (from c in customers
                from o in c.Orders 
                where c.Region == "WA"
                select new {c.CompanyName, o.OrderID, o.OrderDate}).Skip(2);
            foreach (var things in results)
            {
                Console.WriteLine("Our products from {0}, {1}, {2}", things.OrderDate, things.OrderID,
                    things.CompanyName);
            }


        }

        //15 get All Elemens greater or equal to 6
        private static void GreaterEqual6()
        {
            var numbersC = DataLoader.NumbersC;

            //  var results = numbersC.TakeWhile(n => n < 6);

            var results = (from n in numbersC
                select n).TakeWhile(n => n < 6);

            foreach (var things in results)
            {
                Console.WriteLine(things);
            }
        }

        //  21. Reverse NumbersC. 
        private static void Reverse()
        {
            var numbers = DataLoader.NumbersC.Reverse();

            //  var results = numbersC.TakeWhile(n => n < 6);

            var results = from n in numbers
                select n;
                          // select new {numbersC}. Reverse);

            foreach (var things in results)
            {
                Console.WriteLine(things);
            }
        }
    }
}

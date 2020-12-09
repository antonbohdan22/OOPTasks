using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    public class Runner
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();
            products.Add(new Product("Spaghetti", 0.9, 12));
            products.Add(new Product("Mango", 1.25, 15));
            products.Add(new Product("Kinder", 1.39, 10));
            products.Add(new Product("Rice", 1.45, 16));

            Shop shop = new Shop(products);
            shop.AddProduct(new Product("Juice", 1.35, 22))
            .AddProduct(new Product("Beer", 0.99, 40));

            List<Customer> customers = new List<Customer>();
            customers.Add(new Customer("Anton", 25));
            customers.Add(new Customer("Dmitry", 50));
            customers.Add(new Customer("Rodion", 100));
            customers.Add(new Customer("Paul", 10));


            customers[0].Buy(Shop.Products[0], 2)
            .Buy(Shop.Products[3], 2)
            .Buy(Shop.Products[5], 3)
            .Checkout();
            Console.WriteLine();

            customers[1].Buy(Shop.Products[0], 6)
            .Buy(Shop.Products[4], 2)
            .Buy(Shop.Products[5], 1)
            .Checkout();
            Console.WriteLine();

            customers[2].Buy(Shop.Products[1], 2)
            .Buy(Shop.Products[5], 3)
            .Checkout();
            Console.WriteLine();

            customers[3].Buy(Shop.Products[0], 2)
            .Buy(Shop.Products[2], 1)
            .Buy(Shop.Products[5], 8)
            .Checkout();
            Console.WriteLine();

            Console.ReadKey();

        }
    }
}

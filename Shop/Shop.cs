using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    public class Shop
    {
        static private List<Product> products;

        public Shop() => products = new List<Product>();
        public Shop(List<Product> products) => Shop.products = products;

        public static List<Product> Products => products;

        public Shop AddProduct(Product product)
        {
            products.Add(product);
            return this;
        }

        public Shop AddProducts(params Product[] products)
        {
            foreach (Product product in products) AddProduct(product);
            return this;
        }
    }
}

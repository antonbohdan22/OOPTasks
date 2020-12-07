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


        public static List<Product> Products
        {
            get { return products; }
            set { products = value; }
        }
    }
}

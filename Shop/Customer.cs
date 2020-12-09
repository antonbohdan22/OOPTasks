using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    public class Customer
    {
        protected string name;
        protected double cash;
        protected List<Product> cart;

        public Customer() => cart = new List<Product>();

        public Customer(string name, double cash)
        {
            this.name = name;
            this.cash = cash;
            cart = new List<Product>();
        }

        public Customer Buy(Product product, int quantity)
        {
            if(quantity <= 0)
            {
                Console.WriteLine("Quantity must be >= 0");
            }
            if (product.Quantity >= quantity)
            {
                if (cash >= (product.Price * quantity))
                {
                    cart.Add(new Product(product.Name, product.Price, quantity));
                    product.DecreaseQuantityBy(quantity);
                    cash -= (product.Price * quantity);

                    if (product.Quantity == 0) Shop.Products.Remove(product);
                }
                else Console.WriteLine("Sorry, {0}, you do not have sufficient funds to buy {1}", name, product.Name);
            }
            else Console.WriteLine("There is no such many positions of this product available in the shop");
            return this;
        }

        public Customer Checkout()
        {
            double sum = 0;
            Console.WriteLine("Customer {0}'s Checkout:", name);
            foreach (Product product in cart)
            {
                Console.WriteLine(product.ToString());
                sum += product.Price * product.Quantity;
            }
            Console.WriteLine("Total: {0} \nCharge: {1}", sum, cash);
            return this;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public double Cash
        {
            get { return cash; }
            set { cash = value; }
        }

        public List<Product> Cart
        {
            get { return cart; }
            set { cart = value; }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    public class Product
    {
        protected string name;
        protected double price;
        protected int quantity;

        public Product(string name, double price, int quantity)
        {
            this.name = name;
            this.price = price;
            this.quantity = quantity;
        }

        public string Name => name;

        public double Price => price;

        public int Quantity => quantity;

        public void DecreaseQuantityBy(int quantity)
        {
            this.quantity -= quantity;
        }
        public void IncreaseQuantityBy(int quantity)
        {
            this.quantity += quantity;
        }

        override
            public string ToString()
        {
            return name + " - " + price + "$" +" x " + quantity;
        }

    }
}

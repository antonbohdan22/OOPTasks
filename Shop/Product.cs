﻿using System;
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

        public string Name
        {
            get { return name; }
        }

        public double Price
        {
            get { return price; }
        }

        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        override
            public string ToString()
        {
            return name + " - " + price + "$" +" x " + quantity;
        }

    }
}

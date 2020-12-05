using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore
{
    public class Book
    {
        private long id = 0;
        private string name;
        private Author author;
        private string genre;
        private int price;
        private int quantity;
        private static long idCounter = 0;

        public Book(string name, Author author, string genre, int price, int quantity)
        {
            id = nextId();
            this.name = name;
            this.author = author;
            this.genre = genre;
            this.price = price;
            this.quantity = quantity;
        }

        private static long nextId()
        {
            return ++idCounter;
        }

        public long Id
        {
            get { return id; }
        }

        public string Name
        {
            get { return name; }
        }

        public string Genre
        {
            get { return genre; }
        }

        public int Price
        {
            get { return price; }
            set { price = value; }
        }

        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        override
            public string ToString()
        {
            return "name: " + name +
                "\nauthor: " + author.ToString() +
                "\ngenre: " + genre +
                "\nprice: " + price + "$" +
                "\nquantity: " + quantity + "\n";
        }

        public Author GetAuthor()
        {
            return author;
        }

        public class Author
        {
            private string name;
            private string surname;

            public Author(string name, string surname)
            {
                this.name = name;
                this.surname = surname;
            }

            public string Name
            {
                get { return name; }
            }

            public string Surname
            {
                get { return surname; }
            }

            override
                public string ToString()
            {
                return name + " " + surname;
            }
        }
    }
}

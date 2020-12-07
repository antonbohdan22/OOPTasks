using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore
{
    public class Store
    {
        private List<Book> books;
        private int cash;

        public Store()
        {
            books = new List<Book>();
            cash = 0;
        }
        public List<Book> Books
        {
            get { return books; }
        }


        public int Cash
        {
            get { return cash; }
            set { cash = value; }
        }

        public void AddBook(Book value)
        {
            books.Add(value);
        }

        public void SetMarkup(string genre, int markup)
        {
            for (int i = 0; i < books.Count; i++)
            {
                if (books[i].Genre.Equals(genre)) books[i].Price += markup;
            }
        }

        public void Sell(long bookId)
        {
            for (int i = 0; i < books.Count; i++)
            {
                if (books[i].Id == bookId)
                {
                    books[i].Quantity--;
                    cash += books[i].Price;
                    if(books[i].Quantity == 0) books.Remove(books[i]);
         
                    return;
                }
            }
        }

        public void ShowBooks()
        {
            foreach (Book book in books)
            {
                Console.WriteLine(book.ToString());
            }
        }
    }
}

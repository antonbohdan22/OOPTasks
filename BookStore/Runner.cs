using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore
{
    public class Runner
    {
        static void Main(string[] args)
        {
            Store store = new Store();
            store.AddBook(new Book("Ham on Rye", new Book.Author("Charles", "Bukowski"), "Dirty realism", 6, 13));
            store.AddBook(new Book("Factotum", new Book.Author("Charles", "Bukowski"), "Dirty realism", 6, 6));
            store.AddBook(new Book("1984", new Book.Author("George", "Orwell"), "dystopia", 8, 21));
            store.AddBook(new Book("Brawe new world", new Book.Author("Aldous", "Huxley"), "dystopia", 9, 20));
            store.AddBook(new Book("Deception Point", new Book.Author("Dan", "Brown"), "Science Fiction", 11, 3));
            store.AddBook(new Book("A clockwork orange", new Book.Author("Anthony", "Burgess"), "dystopia", 5, 31));
            store.ShowBooks();
            store.SetMarkup("dystopia", 2);
            store.Sell(1);
            store.ShowBooks();

            int iterationsCount = store.Books[4].Quantity;

            for(int i = 0; i < iterationsCount; i++)
            {
                store.Sell(5);
            }

            store.ShowBooks();

            Console.WriteLine("Cash: {0}", store.Cash);

            Console.ReadKey();
        }
    }
}

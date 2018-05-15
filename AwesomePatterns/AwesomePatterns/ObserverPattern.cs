using System;

namespace AwesomePatterns
{
    class ObserverPattern
    {
        static void Main(string[] args)
        {
            Book book = new Book();
            book.Name = "OriginalBookName";
            book.Action = "S";

            Sell sell = new Sell();
            sell.Update(book);

            Buy buy = new Buy();
            buy.Update(book);

            Stock stock = new Stock();
            stock.Update(book);
        }
    }

    // Observador
    public class Book
    {
        public string Name { get; set; }
        public string Action { get; set; }
    }

    public class Sell : IBrokenBook
    {
        public void Update(Book book)
        {
            if (book.Action.Equals("S"))
                Console.WriteLine("You just sold a book");
        }
    }

    public class Buy : IBrokenBook
    {
        public void Update(Book book)
        {
            if (book.Action.Equals("B"))
                Console.WriteLine("You just bought a book");
        }
    }

    public class Stock : IBrokenBook
    {
        public void Update(Book book)
        {
            if (book.Action.Equals("ST"))
                Console.WriteLine("Checking stock of the book");
        }
    }

    public interface IBrokenBook { void Update(Book book); }
}

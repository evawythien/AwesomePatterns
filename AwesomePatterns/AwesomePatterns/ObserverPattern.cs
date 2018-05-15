using System;

namespace AwesomePatterns
{
	class ObserverPattern
	{
		static void Main(string[] args)
		{
			Book book = new Book();
			book.Name = "OriginalBookName";
			book.State = "FAIL";
		}
	}

	// Observador
	public class Book
	{
		public string Name { get; set; }
		public string State { get; set; }
	}

	public class Sell : IBrokenBook
	{
		public void Update() => Console.WriteLine("You just sold a book");
	}

	public class Buy : IBrokenBook
	{
		public void Update() => Console.WriteLine("You just bought a book");
	}

	public class Stock : IBrokenBook
	{
		public void Update() => Console.WriteLine("Checking stock of the book");
	}

	public interface IBrokenBook { void Update(); }
}

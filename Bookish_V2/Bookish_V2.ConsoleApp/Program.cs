﻿using System;
using System.Collections.Generic;
using Bookish_V2.DataAccess;

namespace Bookish_V2.ConsoleApp
{
	class Program
	{
		static void Main(string[] args)
		{
			PrintAllItems();
		}

		static void PrintAllBooks()
		{
			BookishConnection db = new BookishConnection();
			List<Book> allBooks = db.GetAllBooks();

			foreach (var book in allBooks)
			{
				Console.WriteLine(new string('*', 20));
				Console.WriteLine();
				Console.WriteLine(book.ToString());
				Console.WriteLine();
				Console.WriteLine(new string('*', 20));
			}

			Console.ReadLine();
		}

		static void PrintAllItems()
		{
			BookishConnection db = new BookishConnection();
			List<Item> allItems = db.GetAllItems();

			foreach (var item in allItems)
			{
				Console.WriteLine(new string('*', 20));
				Console.WriteLine();
				Console.WriteLine(item.ToString());
				Console.WriteLine();
				Console.WriteLine(new string('*', 20));
			}

			Console.ReadLine();
		}
	}
}

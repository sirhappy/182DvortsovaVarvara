using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
	class Book
	{
		readonly int _countPages;//количество страниц
		readonly int _sectionNumber;//номер секции
		public Book(int count, int secthion)//конструктор для книги
		{
			_countPages = count;
			_sectionNumber = secthion;
		}
		public int CountPages//поле возвращающее количество страниц книги
		{
			get { return _countPages; }
		}
		public string  GetInfo()//информация о книге
		{
			
			return $"countPages = {_countPages},sectionNumber ={_sectionNumber}";
		}

	}
	class Library
	{
		Book[] _books;//массив из книжек
		public Library()//пустая библиотека
		{
			_books = new Book[0];
		}
		public Library(Book[] book)//создается библиотека из книг
		{
			_books = new Book[book.Length];
			book.CopyTo(_books, 0);
		} 
		public void AdddBook(Book a)//добавление книги в библиотеку
		{
			Array.Resize(ref _books, _books.Length + 1);
			_books[_books.Length - 1] = a;
		}
		public int BooksCount//количество книг в библиотеке
		{
			get{return BooksCount;}
			set
			{
				int count = 0;
				for (int i = 0; i < _books.Length; i++, count++)
				BooksCount = count;
			}
		}
		/// <summary>
		/// Метод ,считающий количество книг с количеством страниц меньше ,чем н.
		/// </summary>
		/// <param name="n"></param>
		/// <returns>коллекцию книг</returns>
		public Book[] CountBooksWithTheLessAmountOfPages(int n)
		{
			Book[] collection = new Book[0];
			
			for(int i = 0; i < _books.Length; i++)
			{
				if (_books[i].CountPages > n)
				{
					Array.Resize(ref collection, collection.Length + 1);
					collection[collection.Length - 1] = _books[i];
				}
			}
			return collection;
		}
		
		public override string ToString()
		{
			string line = "";
			for (int i = 0; i < _books.Length; i++)
			{
				line += _books[i].GetInfo() + "\n";
			}
			return line;
		}

	}
	class Program
	{
		public static Random rnd = new Random();
		static void Main(string[] args)
		{
			do
			{
				Console.Clear();
				int n = rnd.Next(10, 21);

				Library libr = new Library();
				for (int i = 0; i < n; i++)
				{
					libr.AdddBook(new Book(rnd.Next(1, 501), rnd.Next(5, 11)));
				}
				Console.WriteLine("All the books");
				Console.WriteLine(libr);
				Console.WriteLine("All the books With The Less Amount Of Pages ");
				Library libr2 = new Library(libr.CountBooksWithTheLessAmountOfPages(200));
				Console.WriteLine(libr2);
			} while (Console.ReadKey().Key != ConsoleKey.Escape);
			

		}
	}
}

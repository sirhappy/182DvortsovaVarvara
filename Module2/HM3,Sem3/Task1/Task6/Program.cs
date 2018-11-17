using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
	class Book
	{
		readonly int _countPages;
		readonly int _sectionNumber;
		public Book(int count, int secthion)
		{
			_countPages = count;
			_sectionNumber = secthion;
		}

		public string  GetInfo()
		{
			string res;
			return $"countPages = {_countPages},sectionNumber ={_sectionNumber}";
		}

	}
	class Library
	{
		Book[] _books;
		public Library()
		{
			_books = new Book[0];
		}
		public Library(Book[] book)
		{
			_books = book;
		} 
	}
	class Program
	{
		static void Main(string[] args)
		{
			Array.L
		}
	}
}

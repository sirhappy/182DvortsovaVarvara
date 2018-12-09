using MyLib;
using System;

namespace Task3
{
	class Program
	{
		static void Main(string[] args)
		{
			char start = 'к', finish = 'ю';
			char start2 = 'd', finish2 = 'z';

			do
			{
				RussString testString = new RussString(start, finish, 10);
				LatString testLatString = new LatString(start2, finish2, 10);
				MyString firstWord = testString;
				MyString secondWord = testLatString;
				Console.WriteLine(firstWord);
				Console.WriteLine(firstWord.CountLetter('о'));
				Console.WriteLine(firstWord.isPalindrom());
				Console.WriteLine(secondWord);
				Console.WriteLine(secondWord.CountLetter('v'));
				Console.WriteLine(secondWord.isPalindrom());
				try
				{
					//testString = new RussString(start, finish, 11);
					//testLatString = new LatString(start2, finish2, 10);
				}
				catch (ArgumentOutOfRangeException ex)
				{
					Console.WriteLine("Состояние объекта не изменено");// если объект не сформированEX
					Console.WriteLine(ex.Message);
				}


			} while (Console.ReadKey().Key != ConsoleKey.Escape);
		}
	}
}

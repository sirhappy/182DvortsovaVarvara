using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
    Студент:Дворцова Варвара
	Группа :БПИ 182-2
	Задача:Ввести натуральное трехзначное число Р. Найти наибольшее целое
    число, которое можно получить, переставляя цифры числа Р.
*/
namespace Task2
{
	class Program
	{
		public static void MaxIntNumber(int number)
		{
			int f1, f2, f3;
			f1 = number / 100;
			f2 = number / 10 % 10;
			f3 = number % 10;
			int a1, a2, a3;
			a1 = Math.Max(Math.Max(f1, f2), f3);
			a3 = Math.Min(Math.Min(f1, f2), f3);
			a2 = f1 + f2 + f3 - a1 - a3;
			Console.WriteLine($"MaxIntNumber is {a1}{a2}{a3}");
		}
		static void Main(string[] args)
		{
			int number;
			//INPUT.
			do
			{

				Console.Write("Enter a three - digit number = ");
				while (!int.TryParse(Console.ReadLine(), out number) || number < 100 || number > 999)
				{
					Console.WriteLine("Wrong input!Try again");
					Console.Write("Enter a number = ");
				}
				//OUTPUT.
				MaxIntNumber(number);
				Console.WriteLine("\nTo continue press Enter...\nTo exit press Escape...");

			} while (Console.ReadKey().Key != ConsoleKey.Escape);
			

		}
	}
}

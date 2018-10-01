using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Дворцова Варвара
 * Бпи 182 -2 
 * Задача :2) Написать метод, преобразующий число переданное в качестве
параметра в число, записанное теми же цифрами, но идущими в обратном
порядке.
Например, 1024 - > 4201, 120 -> 21
 
	 */

namespace Task2
{
	
	class Program
	{
		public const int MinCorrestValue = 0,MaxCorrectValue = 1000000000;
		/*Преобразует число return в  обратном порядке*/
		public static int Renumber(int number)
		{
			int res = 0;
			while (number > 0)
			{
				res = res * 10 + number % 10;
				number /= 10;
			}
			return res;
		}
		static void Main(string[] args)
		{
			
			int number;
			do {
				Console.Write("Enter a number ");
				while(!int.TryParse(Console.ReadLine(),out number)||number >= MaxCorrectValue||number<= MinCorrestValue)
				{
					Console.Write("Smtg wrong with input,reenter pls ...\n");
					Console.Write("Enter a number ");
				}
				int res;//итоговое число
				res = Renumber(number);
				Console.WriteLine($"before {number} ,after {res}");
				Console.WriteLine("to exit press Esc ...\nTo continue press Enter");
			} while (Console.ReadKey().Key!=ConsoleKey.Escape);

		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
	class Program
	{
		/// <summary>
		/// Считывает целые числа
		/// </summary>
		/// <param name="message"></param>
		/// <returns></returns>
		static int ReadInt(string message)
		{
			bool isCorrect = false;
			int result;
			do
			{
				Console.Write(message);

				if (int.TryParse(Console.ReadLine(), out result) && result >= 0)
					isCorrect = true;
				else
					Console.WriteLine("Неправильный формат числа!");
			} while (!isCorrect);

			return result;
		}
		/// <summary>
		/// Считывает вещественные числа
		/// </summary>
		/// <param name="message"></param>
		/// <returns></returns>
		static double ReadDouble(string message)
		{
			bool isCorrect = false;
			double result;
			do
			{
				Console.Write(message);

				if (double.TryParse(Console.ReadLine(), out result) && result >= 0)
					isCorrect = true;
				else
					Console.WriteLine("Неправильный формат числа!");
			} while (!isCorrect);

			return result;
		}
		static void Main(string[] args)
		{
			do {

				ShoppingCart cart= new ShoppingCart();
				Console.WriteLine("You are in the shop:\n");
				do {
					Console.WriteLine("Добавьте товар в корзину :");
					string name;
					double price;
					int number;
					Console.WriteLine("Введите название предмета: ");
					name = Console.ReadLine();
					price = ReadDouble("Введите цену товара: ");
					number = ReadInt("Введите количество товара: ");
					cart.AddToCart(name, price, number);
					Console.WriteLine(cart);
					Console.WriteLine("Введите y, если хотите ввести еще что-то, " +
					   "n если хотите завершить программу");
					if (Console.ReadLine().Equals("n")) break;


				} while (true);
				Console.WriteLine("Пожалуйста, заплатите {0}", cart.TotalPrice);
				Console.WriteLine("Для выхода нажмите клавишу ESC");


			} while (Console.ReadKey().Key != ConsoleKey.Escape);
		}
	}
}

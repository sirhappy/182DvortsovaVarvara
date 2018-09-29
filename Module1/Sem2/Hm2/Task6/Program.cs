using System;
using System.Text;

/*
 Дворцова Варвара
 БПИ 182 - 2

 */
namespace Task6
{

	class Program
	{
		public static double Persent(double budget, uint persent)
		{
			return budget * persent / 100;

		}
		static void Main(string[] args)
		{

			double budget;
			uint persent;
			do
			{
				//output.
				Console.Write("Enter your budget,pls = ");
				while (!double.TryParse(Console.ReadLine(), out budget))
				{
					Console.WriteLine("Something wrong with input,reenter pls");
					Console.Write("Enter your budget,pls = ");
				}
				Console.Write("Enter your persent ,pls = ");
				while (!uint.TryParse(Console.ReadLine(), out persent))
				{
					Console.WriteLine("Something wrong with input,reenter pls");
					Console.Write("Enter your persent,pls = ");
				}
				double money = Persent(budget, persent);
				//input.
				Console.OutputEncoding = Encoding.Unicode;
				Console.WriteLine($"Your budget for computer games is {money:C}");
				Console.WriteLine("To continue press Enter ...\nTo exit press Esc...");
			} while (Console.ReadKey().Key != ConsoleKey.Escape);
		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
	class Program
	{
		public static bool getDouble(string name, out double value)
		{
			Console.Write($"Enter {name} = ");
			return double.TryParse(Console.ReadLine(), out value);
		}
		public static double F(double x)
		{
			double g;

			if (x <= 0.5)
			{
				g = Math.Sin(Math.PI / 2);
				return g;
			}
			else
			{
				g = Math.Sin((Math.PI *(x-1))/ 2);
				return g;
			}

		}
		static void Main(string[] args)
		{
			double x;


			do
			{
				Console.Clear();
				Console.WriteLine("Enter x ,pls");
				while (!getDouble("x", out x))
				{

					Console.WriteLine("Smng wrong with input,reenter pls ...");

				}

				
				double g = F(x);
				Console.WriteLine($"G = {g}");
				Console.WriteLine("To exit press Esc ...\nTo continue press Enter");
			} while (Console.ReadKey().Key != ConsoleKey.Escape);

		}
	}
}

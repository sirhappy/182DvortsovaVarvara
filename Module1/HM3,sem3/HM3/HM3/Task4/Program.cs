﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
	class Program
	{
		public static bool getDouble(string name, out double value)
		{
			Console.Write($"Enter {name} = ");
			return double.TryParse(Console.ReadLine(), out value);
		}
		public static double F(double x ,double y)
		{
			double g;
			if ((x < y) & (x > 0))
			{
				g = x + Math.Sin(y);
				return g;
			}
			else if ((x > y) & (x < 0))
			{
				g = y - Math.Cos(x);
				return g;
			}
			else g = 0.5 * x * y;
			return g; 

		}
		static void Main(string[] args)
		{
			double x, y;

			
			do
			{
				Console.Clear();
				Console.WriteLine("Enter x and y ,pls");
				while (!getDouble("x", out x))
				{

					Console.WriteLine("Smng wrong with input,reenter pls ...");

				}

				while (!getDouble("y", out y))
				{

					Console.WriteLine("Smng wrong with input,reenter pls ...");

				}
				double g = F(x, y);
				Console.WriteLine($"G = {g}");
				Console.WriteLine("To exit press Esc ...\nTo continue press Enter");
			} while (Console.ReadKey().Key != ConsoleKey.Escape);


		}
	}
}

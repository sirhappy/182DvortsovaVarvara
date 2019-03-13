using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	class Program
	{
		/// <summary>
		/// Метод для считывания целого числа 
		/// </summary>
		/// <param name="message"></param>
		/// <param name="min"></param>
		/// <param name="max"></param>
		/// <returns></returns>
		public static double EnterDouble(string message, double min, double max)
		{
			int res;
			bool isCorrect = false;
			do
			{
				Console.Write(message);
				while (!int.TryParse(Console.ReadLine(), out res) || res < min || res > max)
				{
					Console.Error.WriteLine("Error ,try again ");
					Console.Write(message);
				}
				isCorrect = true;

			} while (!isCorrect);
			return res;
		}
		/// <summary>
		/// Метод для считывания целого числа 
		/// </summary>
		/// <param name="message"></param>
		/// <param name="min"></param>
		/// <param name="max"></param>
		/// <returns></returns>
		public static int EnterInt(string message, int min, int max)
		{
			int res;
			bool isCorrect = false;
			do
			{
				Console.Write(message);
				while (!int.TryParse(Console.ReadLine(), out res) || res < min || res > max)
				{
					Console.Error.WriteLine("Error ,try again ");
					Console.Write(message);
				}
				isCorrect = true;

			} while (!isCorrect);
			return res;
		}
		static void Main(string[] args)
		{
			List < Circle > lists= new List<Circle>();

			do
			{
				int n = EnterInt("Enter count = ",0,1000);
				double r;
				double x;
				double y;
				for (int i = 0; i < n; i++)
				{
					r = EnterDouble("Enter r = ", 0, 1000);
					x = EnterDouble("Enter x = ", 0, 1000);
					y = EnterDouble("Enter y = ", 0, 1000);
					lists.Add(new Circle(r, x, y));
					Console.Clear();

				}
				Array.ForEach(lists.ToArray(), e => Console.WriteLine(e));
				Array.Sort(lists.ToArray(), (a, b) =>
				{
					if (a.Center.Distatnce(new Point(0, 0) )<= b.Center.Distatnce(new Point(0, 0)))return -1;
					if (a.Center.Distatnce(new Point(0, 0)) == b.Center.Distatnce(new Point(0, 0))) return 0;
					return 1;

				});
				Array.ForEach(lists.ToArray(), e => Console.WriteLine(e));
			} while (Console.ReadKey().Key!=ConsoleKey.Escape);
		}
	}
}

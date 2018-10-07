using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
	class Program
	{
		
		public static double S1(int x)
		{
			double sum = 0, sumpred = 0;
			int fuct = 2;
			int j = 2;
			int z = 1;
			do
			{
				sumpred = sum;
				sum += Math.Pow(2, j - 1) * Math.Pow(x, j) / fuct * z;
				j += 2;
				fuct *= j * (j - 1);
				z *= -1;
			} while (sum - sumpred > Double.Epsilon);
			return sum;
		}
		public static double S2(int x)
		{
			double sum = 0, sumpred = 0;
			int n = 0;
			int fuct = 1;
			do
			{
				sum = sumpred;
				if (n == 0) sum += Math.Pow(x, n) / 1;
				else sum += Math.Pow(x, n) / fuct;
				n += 1;
				fuct *= n;
			} while (sum - sumpred > Double.Epsilon);
			return sum;
		}
		static void Main(string[] args)
		{
			int x;
			do
			{
				Console.Write("Enter x = ");
				while (!int.TryParse(Console.ReadLine(), out x) || x < 0)
				{
					Console.Write("Error");
					Console.Write("Enter x = ");
				}
				double sum1, sum2;
				sum1 = S1(x);
				sum2 = S2(x);
				Console.WriteLine($"S1 = {sum1:F3}\tS2 = {sum2:F3}");
			} while (Console.ReadKey().Key != ConsoleKey.Escape);
		}
	}
}

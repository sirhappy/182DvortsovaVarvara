using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
	internal class Program
	{
		
		private const double DetX = 0.05, MinValue = 1, MaxValue = 2,Value = 1.2, eps = 1e-9;
		public static void F(double a,double b ,double c)
		{
			double x = MinValue, y;
			Console.WriteLine("X\tY");
			while ((x - Value)>eps)
			{
				y = a * x * x + b * x + c;
				Console.WriteLine($"{x}\t{y:F3}");
				x += DetX;
			}
			if (Math.Abs(x - Value) > eps)
			{
				y = a /x  + Math.Sqrt(x*x + 1);
				Console.WriteLine($"{x}\t{y:F3}");
				x += DetX;
			}
			while (x < MaxValue)
			{
				y = (a+b*x)/ Math.Sqrt(x * x + 1);
				Console.WriteLine($"{x}\t{y:F3}");
				x += DetX;
			}
		}
		public static double GetDouble(string str)
		{
			double x;
			Console.Write($"Enter {str} = ");
			while(!double.TryParse(Console.ReadLine(),out x) || x == 0)
			{
				Console.WriteLine("Smgn wrong with input,try again");
				Console.Write($"Enter {str} = ");
			}
			return x;
		}
		static void Main(string[] args)
		{

			
			do {
				Console.Clear();
				double a = GetDouble("a"),
				b = GetDouble("b"),
				c = GetDouble("c");
				F(a, b, c);
				Console.WriteLine("To exit press ESC");
			} while (Console.ReadKey().Key!=ConsoleKey.Escape);
		}
	}
}

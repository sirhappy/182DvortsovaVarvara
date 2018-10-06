using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
	class Program
	{
		public static bool Check(double a, double b, double c)
		{
			bool res = (a + b > c) & (a + c > b) & (b + c > a) ? true : false;
			return res;

		}
		public static double S(double a, double b, double c, out double per)
		{
			per = a + b + c;
			double p = (a + b + c) / 2;
			double s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
			return s;
		}
		public const double Maxvalue = 1000;
		static void Main(string[] args)
		{
			double a, b, c;
			do
			{
				Console.Write("Введите число а = ");
				while (!double.TryParse(Console.ReadLine(), out a)||a<0||a>Maxvalue)
				{
					Console.WriteLine("Error ");
					Console.Write("Введите число а = ");
				}
				Console.Write("Введите число b = ");
				while (!double.TryParse(Console.ReadLine(), out b)||b<0|| b > Maxvalue)
				{
					Console.WriteLine("Error ");
					Console.Write("Введите число b = ");
				}
				Console.Write("Введите число c = ");
				while (!double.TryParse(Console.ReadLine(), out c)||c<0|| b > Maxvalue)
				{
					Console.WriteLine("Error ");
					Console.Write("Введите число c = ");
				}
				bool m = Check(a, b, c);

				if (m)
				{
					double s, per;
					s = S(a, b, c, out per);
					Console.WriteLine($"Площадь ={s:F3}  , Периметр ={per} ");
				}
				else Console.WriteLine("Такого треугольника не существует");
			} while (Console.ReadKey().Key != ConsoleKey.Escape);
		}
	}
}

using System;
using System.Numerics;
/*
 Студент : Дворцова Варвара
 Группа: БПИ 182-2
 Задача: Введя значения коэффициентов А, В, С, вычислить корни квадратного
уравнения. Учесть (как хотите) возможность появления комплексных
корней. Оператор if не применять.
 */
namespace Task3
{
	class Program
	{
		public static void Equation( double a,  double b,  double c,out Complex root1,out Complex root2)
		{
			double d = b * b - 4 * a * c;
			root1 = d >= 0 ? new Complex((-b + Math.Sqrt(d)) / (2 * a), 0) : Complex.FromPolarCoordinates(Math.Sqrt((double)c / a), Math.Acos((-b) / (2 * Math.Sqrt(a * c))));
			root2 = d >= 0 ? new Complex((-b - Math.Sqrt(d)) / (2 * a), 0) : Complex.FromPolarCoordinates(Math.Sqrt((double)c / a), -Math.Acos((-b) / (2 * Math.Sqrt(a * c))));


		}
		static void Main(string[] args)
		{
			double a, b, c;
			do
			{
				Console.Write("Введите коэффициент A = ");
				while (!double.TryParse(Console.ReadLine(), out a))
				{
					Console.WriteLine("Ошибка ввода!");
					Console.Write("Введите коэффициент A = ");
				}
				Console.Write("Введите коэффициент B = ");
				while (!double.TryParse(Console.ReadLine(), out b))
				{
					Console.WriteLine("Ошибка ввода!");
					Console.Write("Введите коэффициент B = ");
				}
				Console.Write("Введите коэффициент C = ");
				while (!double.TryParse(Console.ReadLine(), out c))
				{
					Console.WriteLine("Ошибка ввода!");
					Console.Write("Введите коэффициент C = ");
				}
				Complex root1, root2;
				Equation( a,  b,  c,out root1,out root2);
				string str;
				str = root1.Equals(root2)?"Корень  уравнения = "+root1.ToString("F3"):$"1 Корень = {root1},2 корень = {root2}";
				Console.WriteLine(str);

				Console.WriteLine("Для продолжения нажмите Enter... \nДля выхода нажмите Escape ...");

			} while (Console.ReadKey().Key!=ConsoleKey.Escape);
		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
Дисциплина: "Программирование"
Группа: БПИ182
Студент: Дворцова В.В.
Задача: Написать метод для вычисления площади и длины
окружности, радиус которой задает вещественный параметр.
В основной программе, вводя значения радиуса, с помощью
обращения к методу, вычислять площадь и длину окружности. При
вводе применять метод double.TryParse() и проверять корректность
введенного значения. При выводе использовать форматную строку
метода WriteLine(). Окончание работы программы – ввод нулевого
или отрицательного значения радиуса.

*/
namespace Task2
{

	class Program
	{
		public static double Square(double R, out double len)
		{
			len = 2 * Math.PI * R;
			return Math.PI * R * R;
		}
		static void Main(string[] args)
		{
			double R,//radius
				s,//square
				c;//len
			do
			{
				do
				{
					Console.Write("Enter value of radius = ");
				} while (!double.TryParse(Console.ReadLine(), out R));

				s = Square(R, out c);

				Console.WriteLine("Your long of circle = {0}", c.ToString("f3"));
				Console.WriteLine("Your squera of circle = {0}", s.ToString("f3"));
				Console.WriteLine("To exit to click Escape");

			} while (Console.ReadKey().Key != ConsoleKey.Escape);
		}
	}
}

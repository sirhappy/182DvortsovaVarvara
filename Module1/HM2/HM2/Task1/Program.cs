using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Дворцова 
 * БПИ182
 */
namespace Task1
{
	/*
Написать метод для вычисления приближенного значения n-го члена ряда Фибоначчи по формуле Бине:
𝑈_𝑛=(𝑏^𝑛−(〖−𝑏〗^(−𝑛) ))/(2𝑏−1)
𝑏=(1+√5)/2
В основной программе, вводя с помощью метода int.TryParse() значения n, вычислять и 
выводить приближенное вещественное значение n-го члена ряда Фибоначчи. 
Окончание работы программы – ввод нулевого или отрицательного значения n. 
 */
	class Program
	{
		public static int Un(uint n)
		{
			double b = (1 + Math.Sqrt(5)) / 2;
			double Un = (Math.Pow(b, n) - Math.Pow(-b, -n)) / (2 * b - 1);
			return (int)(Un + 0.5);
		}
		static void Main(string[] args)
		{
			uint n;

			do
			{
				do
				{
					Console.Write("Введите n-й член ряда фиббоначи = ");
				} while (!uint.TryParse(Console.ReadLine(), out n));
				int res = Un(n);
				Console.WriteLine("{0} член = {1}", n, res);
				Console.WriteLine("Для продолжения нажмите ENTER.");
				Console.WriteLine("Для выхода из программы нажмите Escape.");
			} while (Console.ReadKey().Key != ConsoleKey.Escape);



		}
	}
}

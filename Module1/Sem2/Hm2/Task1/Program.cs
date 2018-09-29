using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
Дисциплина: "Программирование"
Группа: БПИ182-2
Студент: Дворцова Варвара
Дата: 19.09.2018
Задача: Ввести значение x и вывести значение полинома: F(x) = 12x^4 + 9x^3 - 3x^2 + 2x - 4. Не применять возведение в степень. Использовать минимальное
количество операций умножения.
*/
namespace Task1
{
	class Program
	{
		public static double Polinom(double x)
		{
			double t = x * x;//x^2
			double k = t * t;//x^4
			return 12 * k + 9 * t * x - 3 * t + 2 * x - 4;
		}
		static void Main(string[] args)
		{
			double x;

			do
			{
				// Проверка данных на корректность
				Console.Write("Введите х = ");
				while (!double.TryParse(Console.ReadLine(), out x))
				{
					Console.WriteLine("Неверное значение или формат!Введите данные заново!");
					Console.Write("Введите х = ");
				}

				
					
				
				Console.WriteLine($"Значение полинома ={Polinom(x)} ");
				Console.WriteLine("Для продолжения нажмите Enter...\nДля выхода нажмите Escape...");

			} while (Console.ReadKey().Key != ConsoleKey.Escape);
		}
	}
}

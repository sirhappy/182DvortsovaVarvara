using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Дворцова Варя
 * БПИ 182 -2
 * Задача : Пользователь последовательно вводит целые числа. Для хранения полученных
чисел в программе используется одна переменная. Окончание ввода чисел
определяется либо желанием пользователя, либо когда сумма уже введённых
отрицательных чисел становится меньше -1000. Определить и вывести на
экран среднее арифметическое отрицательных чисел.
 */
namespace Task2
{
	class Program
	{
		static void Main(string[] args)
		{
			
			do
			{
				Console.Clear();
				int a;
				int n = 0;
				double sumNeg = 0;
				do
				{
					
					Console.Write("Введите число  = ");
					while (!int.TryParse(Console.ReadLine(), out a))
					{
						Console.WriteLine("Error");
						Console.Write("Введите число  = ");
					}
					if (a < 0)
					{
						sumNeg += a;
						n++;
					}
					Console.WriteLine("Если вы хотите выйти из ввода ,нажмите Q ");
					if (Console.ReadKey().Key == ConsoleKey.Q)
					{
						break;
					}

				} while (sumNeg >= -1000);
				
				double mid = sumNeg / n;
				Console.WriteLine($"Среднее арифметическое чисел = {mid:F3} ");
				Console.WriteLine("Для выхода нажмите Esc...");
			} while (Console.ReadKey().Key != ConsoleKey.Escape);
		}
	}
}

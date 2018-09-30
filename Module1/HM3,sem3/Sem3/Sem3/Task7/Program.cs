using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 Дворцова Варвара
 БПИ 182 - 2 
 Задача:Написать метод для расчета сложных процентов.
Параметры: начальный капитал, годовая процентная ставка, число лет
(вклада).
Возвращаемое значение – итоговая сумма в конце срока вклада.
static double Total(double k, double r, uint n)
В основной программе ввести начальный капитал (больший нуля),
процентную ставку и число лет. Вывести таблицу значений итоговых сумм в
конце каждого года вплоть до заданного числа лет.
	 */
namespace Task7
{
	class Program
	{
		static double Total(double k, double r, uint n)
		{
			//return  sum.
			double sum = k * Math.Pow((1 + r), n);
			return sum;
		}
		static void Main(string[] args)
		{
			double startCap;// начальный капитал>0
			int p;//процентная ставка
			int n;//число лет
			do
			{
				Console.Write("Ваш начальный капитал = ");
				while (!double.TryParse(Console.ReadLine(), out startCap)| startCap<=0)
				{ Console.Write("Ошибка,попробуйте снова\n");
				 Console.Write("Ваш начальный капитал = ");
				}

				Console.Write("Ваша процентная ставка =  ");
				while (!int.TryParse(Console.ReadLine(), out p) ||( p <= 0 &&p>100))
				{
					Console.Write("Ошибка,попробуйте снова\n");
					Console.Write("Ваша процентная ставка = ");
				}
				Console.Write("колличество лет = ");
				while (!int.TryParse(Console.ReadLine(), out n) | n == 0)
				{
					Console.Write("Ошибка,попробуйте снова\n");
					Console.Write("колличество лет = ");
				}

				for(uint i = 0; i <= n; i++)
				{
					double s = Total(startCap, p, i);
					Console.WriteLine($"Итоговая сумма в конце {i} года = {s} ");
				}
				Console.WriteLine("Для выхода нажмите Esc\nДля продолжения нажмите Enter");
			} while (Console.ReadKey().Key!=ConsoleKey.Escape);
		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Дворцова Варвара
 БПИ 182-2
 Задача:Вычислить площадь под графиком функции X^2 на отрезке [0;A]
при помощи метода трапеций, вещественная точка A и шаг
интегрирования delta задаются с клавиатуры.
• Чтобы организовать проверку корректности введённых данных,
определите ограничения на значения А и delta.
• Как вычисляется значение, добавляемое к интегральной сумме на
каждом шаге.
• Определите условие выхода из цикла формирования
интегральной суммы
*/
namespace Task_3
{
	class Program
	{
		public static double Sqare(int x)
		{
			return x * x;
		}
		public static double Func(double a,int delta)
		{

			double Summ = 0;
			double S ;
			int n = (int)(a / delta);
			for (int i = 0; i < n; i ++)
			{
				S =delta * (Sqare(i*delta) + Sqare((i+1) * delta) )/2;
				Summ += S;
			}
			return Summ;
		}
		static void Main(string[] args)
		{
			double a;
			int delta;
			do {
				Console.Write("Enter a = ");
				while (!double.TryParse(Console.ReadLine(),out a) || a <= 0)
				{
					Console.WriteLine("Smtg wrong with input,reenter pls...");
					Console.Write("Enter a = ");
				}
				Console.Write("Enter delta = ");
				while (!int.TryParse(Console.ReadLine(), out delta) || (delta <= 0) || (delta >= a)) { 
					Console.WriteLine("Smtg wrong with input,reenter pls...");
					Console.Write("Enter delta = ");
				}
				double Summ = Func(a, delta);
				Console.WriteLine($"Summ is {Summ}");
			} while (Console.ReadKey().Key!=ConsoleKey.Escape);

		}
	}
}

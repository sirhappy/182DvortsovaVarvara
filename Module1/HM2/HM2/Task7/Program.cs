using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Вычисление значения логической функции !(X&Y|Z)

namespace Task7
{
	class Program
	{
		static void Main(string[] args)
		{
			bool x, y, z;
			int tmp;//рабочая переменная
			do {

				do {
					Console.Write("Введите Х = ");
						}
				while (!int.TryParse(Console.ReadLine(),out tmp));
				x = tmp == 0 ? false : true;

				do
				{
					Console.Write("Введите Y = ");
				}
				while (!int.TryParse(Console.ReadLine(), out tmp));
				y = tmp == 0 ? false : true;

				do
				{
					Console.Write("Введите Z = ");
				}
				while (!int.TryParse(Console.ReadLine(), out tmp));
				z = tmp == 0 ? false : true;

				bool funk = !(x & y | z);
				Console.WriteLine($"Значение функции  =  {funk} ");
				Console.WriteLine("для выхода нажмите Escape...");

			} while (Console.ReadKey().Key!=ConsoleKey.Escape);
		}
	}
}

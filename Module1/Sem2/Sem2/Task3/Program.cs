using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Задача на применение тернарной операции.
(Не применять оператор if.)
Написать метод, так обменивающий значения трех
переменных x, y, z, чтобы выполнилось
требование: x <= y <= z.
В основной программе, вводить значения трех
переменных и упорядочивать их с помощью
обращения к написанному методу.
Для выхода из программы вводите ESC, для
повторения решения – любую другую клавишу.
*/
namespace Task3
{
	class Program
	{

		public static void ValuesSort(ref int x, ref int y, ref int z)
		{
			// Вспомогательные переменные
			int a1 = 0, a2 = 0, a3 = 0;
			a1 = x < y ? (z < x ? z : x) : (y < z ? y : z);
			a3 = x > y ? (z > x ? z : x) : (y > z ? y : z);
			a2 = x + y + z - a1 - a3;
			x = a1; y = a2; z = a3;
		}
		static void Main(string[] args)
		{
			int x, y, z;
			do {
				do
				{
					Console.Write("Enter X = ");
				} while (!int.TryParse(Console.ReadLine(), out x));
				do
				{
					Console.Write("Enter Y = ");
				} while (!int.TryParse(Console.ReadLine(), out y));
				do
				{
					Console.Write("Enter Z = ");
				} while (!int.TryParse(Console.ReadLine(), out z));
				ValuesSort(ref x, ref y, ref z);
				Console.WriteLine($"x = {x},y ={y},z={z} ");
				Console.WriteLine("To enter to click Escape");


			} while (Console.ReadKey().Key!=ConsoleKey.Escape);
			

		}
	}
}

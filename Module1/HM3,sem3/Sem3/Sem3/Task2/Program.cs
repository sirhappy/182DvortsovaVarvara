using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Дворцова Варвара
 * БПИ 182 -2
 * Задача:
 * Написать метод Function() с двумя логическими параметрами,
вычисляющий и возвращающий значение логического выражения
(конкретное выражение в условии должно быть явно задано).
Логическое выражение:
!(p & q) & !(p | !q)
В основной программе построить таблицу истинности логического
выражения, заданного методом.
Модифицируйте предложенный на слайде 4 код метода Main() так,
чтобы на экран выдавалась таблица из нулей и единиц.
 * 
 */
namespace Task2
{
	class Program
	{
		public static bool Function(  bool p,   bool q)
		{
			return !(p & q) & !(p | !q) ;
		}
		static void Main(string[] args)
		{
			bool p= false, q, res;
			Console.WriteLine("Таблица истинности !(p & q) & !(p | !q)");
			Console.WriteLine("P\tQ\tF");
			do
			{
				q = false;
				do
				{
					res = Function(p, q); // Вызов Function()
					Console.WriteLine("{0}\t{1}\t{2}", p, q, res);
					q = !q;
				} while (q);
				p = !p;
			} while (p);



			Console.ReadKey();
		}
	}
}

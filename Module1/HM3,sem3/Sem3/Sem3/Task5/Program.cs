using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
	/*Дворцова Варвара
	 * Бпи 182-2
	 * Задача :бесконечная сумма
	 */
	class Program
	{
		public static double f(int n)
		{
			double m = (int)n;
			return 1 / (m * (m + 1)*(m + 2));
		}
		static void Main(string[] args)
		{
			double prev = 0;
			int n = 0;
			double sum = 0;
			do {
				prev = sum;
				n += 1;
				sum += f(n);

			} while (sum!= prev);
			Console.WriteLine(sum);
			Console.ReadKey();
		}
	}
}

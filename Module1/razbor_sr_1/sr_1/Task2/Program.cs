using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*среднее гармоническое трех чисел */
namespace Task2
{
	
	class Program
	{
		/// <summary>
		/// почти 0
		/// </summary>
		private const double Eps = 1e-10;
		/// <summary>
		/// Метод для считывания чисел
		/// </summary>
		/// <param name="str">строка на вход </param>
		/// <returns>число типа инт </returns>

		public static int GetInt(string str)
		{
			int number;
			Console.Write($"Enter {str} = ");
			while (!int.TryParse(Console.ReadLine(), out number) || number == 0)
			{
				Console.WriteLine("Something wrong with input,reenter pls");
				Console.Write($"Enter {str} = ");
			}
			return number;
		}
		/// <summary>
		/// Метод для нахождения среднего гармонического
		/// </summary>
		/// <param name="a">1число</param>
		/// <param name="b">2число</param>
		/// <param name="c">3число</param>
		/// <returns>среднее гармоническое</returns>
		public static double F(double a, double b, double c)
		{
			double res;
			double sum = 1/a + 1/b + 1/c;
			res = Math.Abs(sum) > Eps ? 3 / sum : -1;
			return res;
		}
		/// <summary>
		/// вывод результатов
		/// </summary>
		/// <param name="args"></param>
		static void Main(string[] args)
		{
			int a, b, c;//числа
			do {
				Console.Clear();
				//ввод чисел
				a = GetInt("a");
				b = GetInt("b");
				c = GetInt("c");
				//ввывод результатов
				double res = F(a, b, c);
				if (res == -1) Console.WriteLine("Среднего гармонического не существует");
				else Console.WriteLine($"Cреднее гармоническое = {res:f3}");

				Console.WriteLine("To exit press ESC...");

			} while (Console.ReadKey().Key!=ConsoleKey.Escape);
		}
	}
}

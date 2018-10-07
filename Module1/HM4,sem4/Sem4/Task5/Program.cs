using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Написать программу, выводящую на экран таблицу значений
суммы ряда из n элементов для n = 1,…, K. Значение K – целое
неотрицательное вводится с клавиатуры пользователем.
• Сумму вычислять в методе по формуле:*/
namespace Task5
{

	internal class Program
	{
		/// <summary>
		/// Ограничитель сверху
		/// </summary>
		private const int MaxIntValue = 1000;
		/// <summary>
		/// Вычисляет сумму по формуле
		/// </summary>
		/// <param name="n">количество элементов</param>
		/// <param name="k">константа</param>
		/// <returns>сумму n элементов</returns>
		public static double S(int n, int k)
		{
			double s = 0;
			double last;
			for (int i = 0; i < n; i++)
			{
				last = (double)(k + 0.3) / (3 * k * k + 5);
				s += last;
			}
			return s;
		}
		/// <summary>
		/// ввод и приведение к итну
		/// </summary>
		/// <param name="str">строка с именем переменной</param>
		/// <param name="number">возвращаемое число типа инт</param>
		public static void GetInt(string str,out int number)
		{
			Console.Write($"Enter {str} = ");
			while(!int.TryParse(Console.ReadLine(),out number)||number==0||number>MaxIntValue)
			{
				Console.Write($"Smth wrong with input ,reenter pls");
				Console.Write($"Enter {str} = ");
			}
		}
		
		static void Main(string[] args)
		{
			
			int n, k;
			do {
				Console.Clear();
				GetInt("n", out n);
				GetInt("k", out k);
				Console.WriteLine("N\tSum");
				for (int i = 0; i < n; i++) 
				{
					Console.WriteLine($"{i}\t{S(i, k):F3}");
				}
				Console.WriteLine("To exit press ESC...");
			} while (Console.ReadKey().Key!=ConsoleKey.Escape);
		}
	}
}

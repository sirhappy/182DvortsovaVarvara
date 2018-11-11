using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 Студент : Дворцова Варвара
 Группа  : БПИ 182-2
 Задача  : 4
	 */
namespace Task_1
{
	internal class Program
	{

		private const int MaxValue_n = 100000;// ограничим инт сверху


		/// <summary>
		/// Метод находит сумму цифр числа n в mod-ичной системе
		/// </summary>
		/// <param name="n">число</param>
		/// <param name="mod">основание системы счисления</param>
		/// <returns>сумма цифр</returns>
		static int CountDigitSum(int n, int mod)
		{

			int temp;
			int sum = 0;
			while (n != 0)
			{
				temp = n % mod;
				sum += temp;
				n /= mod;
			}
			return sum;
		}
		/// <summary>
		/// Считает сумму цифр от 1 до n в заданной системе счисления , 
		/// считает количество чисел заканчисвающихся на 0 в системе счисления
		/// </summary>
		/// <param name="n">количество чисел в отрезке</param>
		/// <param name="mod">система счисления</param>
		/// <param name="count">количество чисел оканчивающихся на 0 </param>
		/// <returns>сумма</returns>
		static int CountDigitSumOfAllAndCountAllEndsWithZero(int n, int mod, out int count)
		{
			//проверяем на переполнение
			checked
			{
				int res = 0;
				count = 0;
				for (int i = 1; i < n + 1; i++)
				{
					res += CountDigitSum(i, mod);
					if (i % mod == 0) count += 1;
				}
				return res;
			}

		}
		/// <summary>
		/// Считывает числа типа инт
		/// </summary>
		/// <param name="message">сообщение пользователю</param>
		/// <param name="errorMessage">сообщение ощибки</param>
		/// <param name="maxValue">максимальное значение</param>
		/// <param name="minValue">минимальное значение</param>
		/// <returns>число типа инт</returns>
		static int ReadIntWithMinValue(string message, string errorMessage, int maxValue = MaxValue_n, int minValue = 0)
		{
			int res;
			bool isCorrect = false;
			do
			{
				Console.Write(message);
				while (!int.TryParse(Console.ReadLine(), out res) || res > maxValue || res < minValue)
				{
					Console.Error.WriteLine(errorMessage);
					Console.Write(message);
				}

				isCorrect = true;
			} while (!isCorrect);
			return res;
		}
		static void Main(string[] args)
		{
			do
			{
				Console.Clear();
				int n = ReadIntWithMinValue($"Введите n от 1 до {MaxValue_n} = ", "Error", minValue: 1);
				int mod = ReadIntWithMinValue($"Введите mod от 2 до 16! = ", "Error", maxValue:16, minValue: 2);
				try
				{
					int count;
					int sum = CountDigitSumOfAllAndCountAllEndsWithZero(n, mod, out count);
					Console.WriteLine($"сумма {sum},количество чисел оканчивающихся на 0 = {count}");
				}
				catch (OverflowException)
				{
					Console.WriteLine("Произошло переполнение... Введите n поменьше");
				}

				Console.WriteLine("Для выхода нажмите Enter для выхода");
			} while (Console.ReadKey().Key != ConsoleKey.Escape);

		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 Студент : Дворцова Варвара
 Группа : БПИ 182
 Задача : 2
	 */
namespace Task2
{
	internal class Program
	{
		private const int MaxValue_n = 1000;//чтобы долго не считал

		/// <summary>
		/// Метод переворачивающий число
		/// </summary>
		/// <param name="n">само число</param>
		/// <returns>перевернутое число</returns>
		static int ReverseNumber(int n)
		{
			string s = "";
			int res;
			int digit = n;
			int temp;
			while (digit != 0)
			{
				temp = digit % 10;
				s += temp;
				digit /= 10;
			}
			int.TryParse(s, out res);
			return res;
		}
		/// <summary>
		/// Метод считывания целого числа
		/// </summary>
		/// <param name="message">строка для пользователя</param>
		/// <param name="errorMessage">сообщение об ошибке</param>
		/// <param name="maxValue">максимальное значение</param>
		/// <param name="minValue">минимальное значение</param>
		/// <returns>целое число</returns>
		static int ReadInt(string message, string errorMessage, int maxValue = MaxValue_n, int minValue = 0)
		{
			int res;
			bool isCorrect = false;
			do
			{
				Console.Write(message);
				while (!int.TryParse(Console.ReadLine(), out res) || res < minValue || res > maxValue)
				{
					Console.Error.WriteLine(errorMessage);
					Console.Write(message);
				}
				isCorrect = true;
			} while (!isCorrect);
			return res;
		}
		/// <summary>
		/// Счистает разные суммы 0-просто сумма палиндромов 
		/// 1-сумма по модулю 2
		/// 2 - сумма побитовых отрицаний
		/// </summary>
		/// <param name="n">количество чисел</param>
		/// <param name="type">тип суммы</param>
		/// <param name="count">количество полиндромов</param>
		/// <returns>сумма</returns>
		static int CalculateAllNumbersAndCountAllPalindromes(int n, int type, out int count)
		{
			count = 0;
			int sum = 0;
			int number, temp;
			if (type == 0)
			{
				for (int i = 1; i < n + 1; i++)
				{
					temp = i;
					number = ReverseNumber(i);
					if (temp == number) count++;
					sum += number;
				}
			}
			else if (type == 1)
			{
				for (int i = 1; i < n + 1; i++)
				{
					temp = i;
					number = ReverseNumber(i);
					if (temp == number) count++;
					sum ^= i;
				}
			}
			else
			{
				for (int i = 1; i < n + 1; i++)
				{
					temp = i;
					number = ReverseNumber(i);
					if (temp == number) count++;
					sum += ~i;
				}
			}
			return sum;
		}

		static void Main(string[] args)
		{
			do
			{
				Console.Clear();
				int n;
				int type;
				n = ReadInt("Введите максимум = ", "Ошибка");
				type = ReadInt("Введите тип операции(0,1,2) = ", "Ошибка", maxValue: 2, minValue: 0);
				int count;
				int sum = CalculateAllNumbersAndCountAllPalindromes(n, type, out count);
				Console.WriteLine($" n = {n} , type = {type},sum = {sum},колличество палидромов = {count}");
				Console.WriteLine("Для выхода нажмите Escape");
			} while (Console.ReadKey().Key != ConsoleKey.Escape);
		}
	}
}

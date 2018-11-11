using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 Студент :Дворцова Варвара
 Группа : Бпи 182
 Задача : 3 
 */
namespace Task3
{
	internal class Program
	{
		private const int MaxValue = 10000;//ограничение сверху для b
		/// <summary>
		/// Метод проверяющий условие , есть ли в отрезке числа 
		/// ,у которых сумма цифр числа равна количеству цифр 
		/// </summary>
		/// <param name="a">начало диапозона</param>
		/// <param name="b">конец диапозона</param>
		/// <returns>true or false</returns>
		static bool CheckSumEquelCountOfNumber(int a ,int b)
		{
			int count = 0;
			for(int k = a; k < b; k++)
			{
				if (CountSum(k) == CountDigits(k)) count += 1;
			}
			bool result = count > 0 ? true : false;
			return result;
		}
		/// <summary>
		/// Метод проверяющий условие : есть ли в отрезке числа ,
		/// у которых сумма цифр в два раза больше количества цифр
		/// </summary>
		/// <param name="a">начало отрезка</param>
		/// <param name="b">конец отрезка</param>
		/// <returns>true or false</returns>
		static bool CheckSumEquels2CountOfNumberIn(int a, int b)
		{
			int count = 0;
			for (int k = a; k < b; k++)
			{
				if (CountSum(k) == 2*CountDigits(k)) count += 1;
			}
			bool result = count > 0 ? true : false;
			return result;
		}
		/// <summary>
		/// Метод считывания целого числа
		/// </summary>
		/// <param name="message">Сообщение пользователю</param>
		/// <param name="errorMessage">Сообщение ошибки</param>
		/// <param name="minValue">минимальное значение</param>
		/// <param name="maxValue">максимальное значение</param>
		/// <returns>Целое число</returns>
		static int ReadInt(string message, string errorMessage, int minValue = 1 , int maxValue = MaxValue)
		{
			int res;
			bool isCorrect = false;
			do {
				Console.Write(message);
				while(!int.TryParse(Console.ReadLine(),out res) || res < minValue || res > maxValue)
				{
					Console.Error.WriteLine(errorMessage);
					Console.Write(message);
				}
				isCorrect = true;
			} while (!isCorrect);
			return res;
		}
		/// <summary>
		/// Метод подсчета суммы цифр числа
		/// </summary>
		/// <param name="number">число</param>
		/// <returns>сумма</returns>
		static int CountSum(int number)
		{
			int sum = 0;
			int count = CountDigits(number);
			int temp;
			int digit = number;
			for(int i = 0; i < count; i++)
			{
				temp = digit % 10;
				sum += temp;
				digit /= 10;
			}
			return sum;
		}
		/// <summary>
		/// Метод подсчета количества цифр числа
		/// </summary>
		/// <param name="number">Число/param>
		/// <returns>количество цифер в числе</returns>
		static int CountDigits(int number)
		{
			int count = 0;
			int digit = number;
			int temp = 0;
			while (digit != 0)
			{
				count += 1;
				temp = digit % 10;
				digit /= 10;
			}
			return count;
		}
		static void Main(string[] args)
		{
			do {
				Console.Clear();
				int a = ReadInt("Введите а  = ", "Ошибка"); ;
				int b = ReadInt("Введите b < 10000 , но больший ,чем а  = ", "Ошибка", minValue : a + 1);
				bool res = CheckSumEquelCountOfNumber(a,b);
				bool res2 = CheckSumEquels2CountOfNumberIn(a, b);
				if (res)//Проверяем первое условие
				{
					Console.WriteLine("Вывод тех чисел из диапозона[a;b] ,сумма цифр которых равна количеству цифр");
					for (int i = a; i < b; i++)
					{
						if (CountSum(i) == CountDigits(i)) Console.Write(i + " ");
					}
					Console.WriteLine();
				}

				else if (res2)//Проверяем второе условие
				{
					Console.WriteLine("Вывод тех чисел из диапозона[a;b] ,сумма цифр которых в два раза больше количества цифр");
					for (int i = a; i < b; i++)
					{
						if (CountSum(i) == 2 * CountDigits(i)) Console.Write(i + " ");
					}
					Console.WriteLine();
				}
				else Console.WriteLine("Нет чисел удовлетворяющих улсовиям");

				Console.WriteLine("Для выхода нажмите Escape");

			} while (Console.ReadKey().Key != ConsoleKey.Escape);
		}
	}
}

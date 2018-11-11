using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 Студент : Дворцова Варвара
 Группа : БПИ 182 - 2
 Задача 4
	 */
namespace Task4
{
	 internal class Program
	{
		private const int MaxValue_n = 1000;//ограничение сверху

		private const int MinValue_n = 10;// ограничение снизу

		/// <summary>
		/// Метод для считывания целых чисел
		/// </summary>
		/// <param name="message">сообщение пользователю</param>
		/// <param name="errorMessage">сообщение ошибки</param>
		/// <param name="maxValue">максимальное значение</param>
		/// <param name="minValue">минимальное значение</param>
		/// <returns>целое число </returns>
		static int ReadInt(string message, string errorMessage, int maxValue = MaxValue_n,int minValue = MinValue_n)
		{
			int res;
			bool isCorrect = false;
			do {
				Console.Write(message);
				while (!int.TryParse(Console.ReadLine(), out res) || res > maxValue||res < MinValue_n)
				{
					Console.Error.WriteLine(errorMessage);
					Console.Write(message);
				}
				isCorrect = true;
			} while (!isCorrect);
			return res;
		}

		/// <summary>
		/// Метод ,который формирует из исходного числа 2 числа,
		/// 1)число ,составленное из четных цифр исходного и 
		/// 2)число,составленное из нечетных цифр исходного (0 НЕ СЧИТАЕТСЯ)
		/// </summary>
		/// <param name="number">исходное число</param>
		/// <param name="even">число из четных цифр</param>
		/// <param name="odd">число из нечетных цифр</param>
		static void FormNumbers(int number, out int even, out int odd)
		{
			int count = CountDigits(number);// количество цифр в числе
			int digit = number;//будем его изменять в цикле
			int temp = 0;//последняя цифра
			string even_s="", odd_s ="";//строки в которых будут хранится перевернутые числа из соответствующих цифр
			for(int i = 0; i < count; i++)//бежим по количеству цифр в числе
			{
				temp = digit % 10;
				if (temp == 0)//если 0 ,то пропускаем
				{
					digit /= 10;
					continue;
				}
				else if (temp%2==0 )
				{
					even_s += temp;
				}
				else if(temp%2==1 )
				{
					odd_s += temp;
				}
				digit /= 10;
			}
			if(even_s == "")//если пустая строка ,то -1
			{
				even = -1;
			}
			else//иначе переворачиваем
			{
				even_s = Line_flip(even_s);
				int.TryParse(even_s, out even);
			}
			if (odd_s == "")//если пустая строка ,то -1
			{
				odd = -1;
			}
			else//иначе переворачиваем
			{
				odd_s = Line_flip(odd_s);
				int.TryParse(odd_s, out odd);
			}
		}

		/// <summary>
		/// Метод переворачивания строки
		/// </summary>
		/// <param name="str">исходная строка</param>
		/// <returns>перевернутая строка</returns>
		static string Line_flip(string str)
		{
			int digit ;
			int.TryParse(str, out digit);
			int temp ;
			string res = "";
			while (digit != 0)
			{
				temp = digit % 10;
				res += temp;
				digit /= 10;
			}
			return res;

		}

		/// <summary>
		/// Метод считающий количество цифер в числе
		/// </summary>
		/// <param name="number">число ,которое нужно перевернуть</param>
		/// <returns>количество цифр</returns>
		static int CountDigits(int number)
		{
			int count = 0;
			int digit = number;
			while (digit != 0)
			{

				count += 1;
				digit = digit / 10;
			}
			return count;
		}

	
		static void Main(string[] args)
		{
			do {
				Console.Clear();
				int n = ReadInt("Введите число в диапозоне [10,1000] = ","Ошибка");
				for(int k = n; k < MaxValue_n; k++)
				{
					int even, odd;
					FormNumbers(k, out even, out odd);
					Console.WriteLine($"n = {k} , четные = {even} , нечетные  = {odd}");
				}

				Console.WriteLine("Для выхода нажмите Escape");
			} while (Console.ReadKey().Key!=ConsoleKey.Escape);

		}
	}
}

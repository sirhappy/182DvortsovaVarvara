using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Сформировать и заполнить случайными значениями 
 * целочисленную матрицу размером MxN (M и N задаются с клавиатуры). 
 * На экран вывести сумму и произведение элементов k-ой строки (k – задается с клавиатуры).
*/
namespace Task1
{
	class Program
	{
		static Random rnd = new Random();
		private const uint MxUintValue = 1000;
		public static uint ReadUnt(string message, string errormessage, uint maxvalue = MxUintValue,uint minvalue =1)
		{
			uint res;
			bool isCorrect = false;
			do
			{
				Console.Write(message);
				while (!uint.TryParse(Console.ReadLine(), out res) || res < minvalue || res > maxvalue)
				{
					Console.Error.WriteLine(errormessage);
					Console.Write(message);
				}
				isCorrect = true;
			} while (!isCorrect);
			return res;
		}
		/// <summary>
		/// Создает матрицу с случайными значениями
		/// </summary>
		/// <param name="m">строки</param>
		/// <param name="n">столбцы</param>
		/// <returns>матрица</returns>
		public static int[,] CreateMatrix(uint m, uint n)
		{
			int[,] a = new int[m, n];
			for (int i = 0; i < m; i++)
			{
				for (int j = 0; j < n; j++)
				{
					a[i, j] = rnd.Next(100);
				}
			}
			return a;
		}
		/// <summary>
		/// Считает сумму к-ой строки матрицы
		/// </summary>
		/// <param name="a"></param>
		/// <param name="k"></param>
		/// <returns></returns>
		public static int SumKstring(int[,] a, uint k)
		{
			int sum = 0;
			for (int i = 0; i < a.GetLength(0); i++)
			{
				if (k == i)
				{
					for (int j = 0; j < a.GetLength(1); j++)
					{
						sum += a[k, j];
					}
				}

			}
			return sum;
		}
		public static void PrintMatrix(int[,] a)
		{
			Console.WriteLine("Ваша матрица:)");
			for (int i = 0; i < a.GetLength(0); i++, Console.WriteLine())
			{
				for (int j = 0; j < a.GetLength(1); j++)
				{
					Console.Write("{0,5}", a[i, j]);
				}
			}
		}
		static void Main(string[] args)
		{
			do
			{
				Console.Clear();
				uint m, n;
				m = ReadUnt("Введите количество строк = ", "Ошибка");
				n = ReadUnt("Введите количество столбцов = ", "Ошибка");
				int[,] a = CreateMatrix(m, n);
				PrintMatrix(a);
				uint k = ReadUnt("Введите строку, сумму которой хотите посчитать = ", "Ошибка",maxvalue :m-1,minvalue:0);
				int sumK = SumKstring(a, k);
				Console.WriteLine("Сумма = {0}", sumK);
			} while (Console.ReadKey().Key != ConsoleKey.Escape);
		}
	}
}

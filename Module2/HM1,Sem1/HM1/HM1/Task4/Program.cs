using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Получить от пользователя целые числа n и m. Сформировать двумерный массив размера nxm и 
 * заполнить его случайными числами [-100;100). Выполнить следующие преобразования:
Заменить максимальный по модулю элемент каждой строки на противоположный по знаку;
Вставить после каждой строки с чётным индексом нулевую строку;
Удалить все строки, содержащие хотя бы одно нулевое значение;
Поменять местами средние столбцы.
После каждого преобразования матрицу выводить на экран.
Все преобразования оформить методами.
Предложить реализацию задачи с использованием массива массивов.
*/
namespace Task4
{
	internal class Program
	{
		static Random rnd = new Random();
		private const int MaxIntValue = 1000;
		public static void DeleteLines(ref int[,] matr)
		{
			int k = 0;
			int[][] result = new int[(int)(matr.GetLength(0) - 1 / 1.5)][];

			for (int i = 0; i < matr.GetLength(0); i++)
			{
				for (int j = 0; j < matr.GetLength(1); j++)
				{
					if (matr[i, j] == 0) break;
					if (j == matr.GetLength(1) - 1)
					{
						int[] A = new int[matr.GetLength(1)];

						for (int t = 0; t < matr.GetLength(1); t++)
							A[t] = matr[i, t];

						result[k] = A;
						k++;
					}
				}
			}

			matr = new int[k, matr.GetLength(1)];

			for (int i = 0; i < k; i++)
				for (int t = 0; t < matr.GetLength(1); t++)
					matr[i, t] = result[i][t];

		}

		public static void SwapColumn(ref int[,] a)
		{
			if (a.GetLength(1)%2 == 1) Console.WriteLine("Нет средних столбцов");
			else
			{
				for (int j = 0; j < a.GetLength(1); j++)
				{
					if (j == a.GetLength(1) / 2 - 1) { 
						for (int i = 0; i < a.GetLength(0); i++)
						{
							int temp = a[i, a.GetLength(1) / 2 - 1];
							a[i, a.GetLength(1) / 2 - 1] = a[i, a.GetLength(1) / 2];
							a[i, a.GetLength(1) / 2] = temp;
						}
					}
				}
			}

		}
		
		public static void AddZeroStringAfterEvenIndexString( ref int[,] matr)
		{
			int count = 0;
			int[,] result = new int[(int)(matr.GetLength(0) * 1.5 + 1), matr.GetLength(1)];
			for (int i = 0; i < matr.GetLength(0); i++)
			{

				for (int j = 0; j < result.GetLength(1); j++)
					result[i + count, j] = matr[i, j];

				if (i % 2 == 0)
				{
					count++;
					for (int j = 0; j < result.GetLength(1); j++)
						result[i + count, j] = 0;
				}
			}
			matr = result;

		}
		public static int ReadInt(string message,string errormessage,int maxvalue = MaxIntValue,int minvalue = 1)
		{
			int res;
			bool isCorrect = false;
			do {
				Console.Write(message);
				while (!int.TryParse(Console.ReadLine(), out res) || res < minvalue || res > maxvalue)
				{
					Console.Error.WriteLine(errormessage);
					Console.Write(message);
					
				}
				isCorrect = true;
			} while (!isCorrect);
			return res;
		}
		public static int[,] CreateMatrix(int m, int n)
		{
			int[,] arr = new int[m, n];
			for (int i = 0; i < arr.GetLength(0); i++)
			{
				for(int j = 0; j < arr.GetLength(1); j++)
				{
					arr[i, j] = rnd.Next(-100, 100);
				}
			}
			return arr;
		}
		public static void ChangeMaxElemInStringMatrixOnOpposite(ref int[,] a)
		{
			int maxElemString = 0;
			int maxIndex = 0;
			for(int i = 0; i < a.GetLength(0); i++)
			{
				for(int j = 0; j < a.GetLength(1); j++)
				{
					if(maxElemString < Math.Abs(a[i, j]))
					{
						maxElemString = Math.Abs(a[i, j]);
						maxIndex = j;
					}
					
				}
				a[i, maxIndex] = (-1)*a[i, maxIndex];
				maxElemString = 0;
				maxIndex = 0;
			}
		}
		public static void PrintMatrix(int[,] a)
		{
			
			for(int i = 0; i < a.GetLength(0); i++,Console.WriteLine())
			{
				for(int j = 0; j < a.GetLength(1); j++)
				{
					Console.Write("{0,5}", a[i, j]);
				}
			}
			Console.WriteLine();
		}
		static void Main(string[] args)
		{
			do {
				Console.Clear();
				int m = ReadInt("Введите количество строк в матрице = ", "Ошибка");
				int n = ReadInt("Введите количество столбцов в матрице = ", "Ошибка");

				int[,] matr = CreateMatrix(m, n);
				PrintMatrix(matr);

				ChangeMaxElemInStringMatrixOnOpposite(ref matr);
				PrintMatrix(matr);

				AddZeroStringAfterEvenIndexString(ref matr);
				PrintMatrix(matr);

				SwapColumn(ref matr);
				PrintMatrix(matr);



			} while (Console.ReadKey().Key != ConsoleKey.Escape);
		}
	}
}

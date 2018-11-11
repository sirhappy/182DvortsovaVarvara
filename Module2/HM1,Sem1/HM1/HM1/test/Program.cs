using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
	class Program
	{

		public static void EnterInt(string message, int min, int max, out int paramINT)
		{
			Console.WriteLine(message);

			while (!int.TryParse(Console.ReadLine(), out paramINT) || (paramINT < min) || (paramINT > max))
				Console.WriteLine("Ошибка ввода");
		}
		public static int[,] CreateMatrix(int N, int M)
		{
			int[,] matr = new int[M, N];
			Random generator = new Random();

			for (int i = 0; i < M; i++)
				for (int j = 0; j < N; j++)
				{
					matr[i, j] = generator.Next(-100, 101);
				}
			return matr;

		}
		public static void DisplayMatrix(int[,] matr)
		{
			for (int i = 0; i < matr.GetLength(0); i++)
			{
				for (int j = 0; j < matr.GetLength(1); j++)
					Console.Write(matr[i, j] + " ");
				Console.WriteLine();
			}
		}
		public static void MinusMax(ref int[,] matr)
		{
			for (int i = 0; i < matr.GetLength(0); i++)
			{
				int max = matr[i, 0];

				for (int j = 1; j < matr.GetLength(1); j++)
				{
					if (Math.Abs(matr[i, j]) > Math.Abs(max)) max = matr[i, j];
				}

				for (int j = 0; j < matr.GetLength(1); j++)
				{
					if (matr[i, j] == max) matr[i, j] *= -1; ;
				}
			}
		}
		public static void ZeroLines(ref int[,] matr)
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
		public static void SwapColumn(ref int[,] matr)
		{
			if (matr.GetLength(1) % 2 == 1) Console.WriteLine("Среднего столбца нет");
			else
			{
				int j = matr.GetLength(1) / 2 - 1;
				int[] temp = new int[matr.GetLength(0)];
				for (int i = 0; i < matr.GetLength(0); i++)
				{
					temp[i] = matr[i, j];
					matr[i, j] = matr[i, j + 1];
					matr[i, j + 1] = temp[i];
				}
			}
		}
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
		static void Main(string[] args)
		{
			int sizei,
				sizej;
			do
			{
				EnterInt("Введите длину матрицы", 0, 20, out sizei);
				EnterInt("Введите ширину матрицы", 0, 20, out sizej);

				Console.WriteLine();

				int[,] matr = CreateMatrix(sizei, sizej);
				DisplayMatrix(matr);
				Console.WriteLine();

				MinusMax(ref matr);
				DisplayMatrix(matr);
				Console.WriteLine();

				ZeroLines(ref matr);
				DisplayMatrix(matr);
				Console.WriteLine();

				DeleteLines(ref matr);
				DisplayMatrix(matr);
				Console.WriteLine();

				SwapColumn(ref matr);
				DisplayMatrix(matr);

				Console.WriteLine();
				Console.WriteLine("Esc - выход\nЛюбая другая кнопка - повтор решения");
			} while (Console.ReadKey(true).Key != ConsoleKey.Escape);

		}

	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8
{
	class Program
	{

		static Random rnd = new Random();
		private const uint MaxValue = 1000;//ограничение для юинта сверху
		/// <summary>
		/// Создает матрицу из случайных чисел
		/// </summary>
		/// <param name="m">строки</param>
		/// <param name="n">столбцы</param>
		/// <returns>матрица</returns>
		static int[,] CreateMatrix(uint m,uint n)
		{
			int[,] arr = new int[m, n];
			for(int  i = 0; i < m; i++)
			{
				for(int j = 0; j < n; j++)
				{
					arr[i, j] = rnd.Next(1, 11);
				}
			}
			return arr;
		}
		/// <summary>
		/// Умножение двух матриц А*В
		/// </summary>
		/// <param name="A">первая матрица</param>
		/// <param name="B">вторая матрица</param>
		/// <returns>матрица = А*В</returns>
		static int[,] MatrixMult(int[,] A ,int[,]B)
		{
			if (A.GetLength(1) != B.GetLength(0))
			{
				return null;
			}
			int k = 0;
			int temp = B.GetLength(0);
			int[,] new_arr = new int[A.GetLength(0), B.GetLength(1)];
			for(int i = 0; i < new_arr.GetLength(0); i++)
			{
				for(int j = 0; j < new_arr.GetLength(1); j++)
				{
					while (k!= temp) {
						new_arr[i, j] += A[i, k] * B[k, j];
						k++;
					}
					k = 0;
					temp = B.GetLength(0);
				}
			}
			return new_arr;
		}
		/// <summary>
		/// Вывод матрицы в виде таблице
		/// </summary>
		/// <param name="a"></param>
		static void MatrixToString(int[,] a)
		{
			for(int i = 0; i < a.GetLength(0); i++, Console.WriteLine())
			{
				for(int j = 0;j< a.GetLength(1); j++)
				{
					Console.Write("{0,5}", a[i, j]);
				}
			}
		}
		/// <summary>
		/// Ввод положительного целого числа
		/// </summary>
		/// <param name="message">сообщение пользователю</param>
		/// <param name="errormessage">сообщение ошибки</param>
		/// <param name="maxvalue">максимальное значение</param>
		/// <returns></returns>
		static uint ReadUint(string message, string errormessage, uint maxvalue = MaxValue)
		{
			uint res;
			bool isCorrect = false;
			do
			{
				Console.Write(message);
				while (!uint.TryParse(Console.ReadLine(), out res) || res == 0 || res > maxvalue)
				{
					Console.Error.WriteLine(errormessage);
					Console.Write(message);
				}
				isCorrect = true;
				
			} while (!isCorrect);
			return res;
		}
		static void Main(string[] args)
		{
			do {
				Console.Clear();
				Console.WriteLine("Программа умножения матриц.");
				Console.WriteLine();
				uint m, n;
				m = ReadUint("Введите количество строк матрицы А = ", "Ошибка");
				n = ReadUint("Введите количество столбцов матрицы A = ", "Ошибка");
				int[,] A = CreateMatrix(m, n);
				m = ReadUint("Введите количество строк матрицы B = ", "Ошибка");
				n = ReadUint("Введите количество столбцов матрицы B = ", "Ошибка");
				int[,]  B = CreateMatrix(m, n);
				Console.WriteLine("Матрица А ");
				MatrixToString(A);
				Console.WriteLine();
				Console.WriteLine("Матрица B ");
				MatrixToString(B);
				Console.WriteLine();
				if (MatrixMult(A, B) == null)
				{
					Console.WriteLine("Эти матрицы нельзя перемножить");
				}
				else
				{
					int[,] C = MatrixMult(A, B);
					Console.WriteLine("Матрица А*В ");
					MatrixToString(C);
				}
				Console.WriteLine("Для выхода нажмите Escape\nЧтобы продолжить нажмите любую клавишу");
			} while (Console.ReadKey().Key!=ConsoleKey.Escape);
		}
	}
}

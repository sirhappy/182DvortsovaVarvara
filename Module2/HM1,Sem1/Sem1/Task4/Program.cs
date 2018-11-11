using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Ввести положительные значения N и M. Построить двумерный 
// целочисленный массив (матрицу) с размерами N на M, элементы 
// которого a[i, j] = (i+1)*(2*j+1), для i от 0 до (N-1), 
// j от 0 до (M-1). 
// Вывести матрицу в виде таблицы, а также значения свойств 
// Rank и Length. 

namespace Task4
{
	class Program
	{
		static int[,] GetMatrix(uint n ,uint m)
		{
			int[,] arr = new int[n, m];
			for (int i = 0; i < n; i++)
			{
				for (int j = 0; j < m; j++)
				{
					arr[i, j] = (i + 1) * (2 * j + 1);
				}
			}
			return arr;
		}
		static void GhaengeMatrixIfItKvadratnaya(ref int[,] arr)
		{
			if (arr.GetLength(0) != arr.GetLength(1)) return;
			for(int i = 0; i < arr.GetLength(0); i++)
			{
				for(int j = 0; j < arr.GetLength(1); j++)
				{
					if (i >  arr.GetLength(0) - j-1)
					{
						arr[i, j] = 0;
					}
				}
			}
			
		}
		static void Main(string[] args)
		{
			do
			{
				Console.Clear();
				uint M, N;//размеры массива
				do { Console.Write("Введите количество строк = "); }
				while (!uint.TryParse(Console.ReadLine(), out N) || N == 0);
				do { Console.Write("Введите количество столбцов = "); }
				while (!uint.TryParse(Console.ReadLine(), out M));

				int[,] arr = GetMatrix(N, M);
				for (int i = 0; i < arr.GetLength(0); i++, Console.WriteLine())
				{
					for (int j = 0; j < arr.GetLength(1); j++)
					{
						Console.Write("{0,3}", arr[i, j]);
					}
				}
				GhaengeMatrixIfItKvadratnaya(ref arr);
				for (int i = 0; i < arr.GetLength(0); i++, Console.WriteLine())
				{
					for (int j = 0; j < arr.GetLength(1); j++)
					{
						Console.Write("{0,3}", arr[i, j]);
					}
				}
				Console.WriteLine("arr.Rank = {0}", arr.Rank);
				Console.WriteLine("arr.Length = {0}", arr.Length);
				Console.WriteLine("Нажмите Esc для выхода или любую клавишу чтобы продолжить");

			} while (Console.ReadKey().Key != ConsoleKey.Escape);
			
			Console.ReadKey();

		}
	}
}

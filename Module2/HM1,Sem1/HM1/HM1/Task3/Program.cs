using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Написать метод, формирующий по целочисленной матрице MxN (M и N задаются с клавиатуры) 
 * одномерный массив индексов A. В А хранятся индексы столбцов матрицы в отсортированном виде, 
 * в порядке возрастания сумм элементов столбцов. В основной программе сформировать матрицу, 
 * получить индексный массив, 
 * использовать его для вывода столбцов матрицы в порядке возрастания сумм их элементов.*/
namespace Task3
{
	class Program
	{
		private const int MaxUintValue = 1000;//ограничение размера матрицы
		static Random rnd = new Random();
		/// <summary>
		/// Метод формирует массив индексов столбцов матрицы в отсортированном виде,в порядке
		/// возрастания сумм элементов столбцов
		/// </summary>
		/// <param name="a">матрица</param>
		/// <returns>массив индексов</returns>
		public static int[] MatrixIndexColumns(int[,] a)
		{
			int[] indexColumn = new int[a.GetLength(1)];//массив индексов в отсортированном порядке
			int[] sumColumns = new int[a.GetLength(1)];//хранит суммы столбцов
			int sum = 0;//сумма элементов столбца
			for(int j= 0; j < a.GetLength(1); j++)
			{

				for(int i = 0; i < a.GetLength(0); i++)
				{
					sum += a[i, j];
				}
				sumColumns[j] = sum;
				sum = 0;
			    
			}
			for(int i = 0; i < sumColumns.Length; i++)//для проверки
			{
				Console.Write("{0,5}", sumColumns[i]);
			}
			Console.WriteLine();
			for(int i = 0; i < indexColumn.Length; i++)//заполняем массив индексов индексами
			{
				indexColumn[i] = i;
			}
			for(int k = 0; k < indexColumn.Length-1; k++)//сортируем массив индексов
			{
				for(int p = k+1; p < indexColumn.Length ; p++)
				{
					if (sumColumns[indexColumn[k]]  > sumColumns[indexColumn[p]])
					{
						int temp = indexColumn[k];
						indexColumn[k] = indexColumn[p];
						indexColumn[p] = temp;
					}
				}
			}
			return indexColumn;
		}
		/// <summary>
		/// Создает матрицу из м -строк н -столбцов ,состаящую из случайных чисел
		/// </summary>
		/// <param name="m">строки</param>
		/// <param name="n">столбцы</param>
		/// <returns>матрица</returns>
		public static int[,] CreateMatrix(uint m,uint n)
		{
			int[,] a = new int[m, n];
			for(int i = 0; i < a.GetLength(0); i++)
			{
				for(int j = 0; j < a.GetLength(1); j++)
				{
					a[i, j] = rnd.Next(20);
				}
			}
			return a;
		}
		/// <summary>
		/// Ввод целого положительного числа
		/// </summary>
		/// <param name="message">сообщение пользователю</param>
		/// <param name="errormassage">сообщение ошибки</param>
		/// <param name="maxvalue">максимальное значение</param>
		/// <param name="minvalue">минимальное значение</param>
		/// <returns>положительное число</returns>
		public static uint ReadUint(string message,string errormassage,int maxvalue=MaxUintValue,int minvalue=1)
		{
			uint res;
			bool isCorrect = false;
			do {
				Console.Write(message);
				while(!uint.TryParse(Console.ReadLine(),out res) || res > maxvalue || res < minvalue)
				{
					Console.Error.WriteLine(errormassage);
					Console.Write(message);

				}
				isCorrect = true;
			} while (!isCorrect);
			return res;
;		}
		/// <summary>
		/// Вывод матрицы  в виде таблицы
		/// </summary>
		/// <param name="a"></param>
		public static void PrintMatrix(int[,] a)
		{
			for(int i = 0; i < a.GetLength(0); i++,Console.WriteLine())
			{
				for(int j = 0; j < a.GetLength(1); j++)
				{
					Console.Write("{0,3}", a[i, j]);
				}
			}
			Console.WriteLine();
		}
		/// <summary>
		/// Ввывод матрицы в отсортированном виде
		/// по возрастанию сумм стобцов
		/// </summary>
		/// <param name="indexColumns">массив индексов столбцов матрицы arr в отсортированном виде</param>
		/// <param name="arr">матрица</param>
		public static void PrintSortMatrixOfSumOfColumns(int[] indexColumns,int[,] arr)
		{
			Console.WriteLine("Ввывод матрицы по возрастанию сумм стобцов");
			for (int i = 0; i < arr.GetLength(0); i++, Console.WriteLine())
			{
				for (int k = 0; k < indexColumns.Length; k++)
				{
					Console.Write("{0,5}", arr[i, indexColumns[k]]);
				}

			}
		}
		static void Main(string[] args)
		{
			do {
				Console.Clear();
				uint m = ReadUint("Введите количество строк в матрице = ", "Ошибка");
				uint n = ReadUint("Введите количество столбцов в матрице = ", "Ошибка");
				int[,] arr = CreateMatrix(m, n);
				PrintMatrix(arr);
				int[] indexColumn = MatrixIndexColumns(arr);
				Console.WriteLine("Массив индексов столбцов ,отсортированный по возрастанию сумм столбцов");
				foreach(int memb in indexColumn)
				{
					Console.Write("{0,3}", memb);
				}
				Console.WriteLine();
				
				PrintSortMatrixOfSumOfColumns(indexColumn, arr);
				Console.WriteLine("Для выхода нажмите Escape...\nЧтобы продолжить нажмите любую клавишу");
			 } while (Console.ReadKey().Key != ConsoleKey.Escape);
		}
	}
}

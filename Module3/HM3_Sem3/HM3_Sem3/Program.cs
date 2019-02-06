using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 Описать класс, содержащий статические методы работы с двумерным целочисленным 
 массивом.
В классе описать метод построчной печати элементов двумерного массива 
(по пять элементов в строке). Перевод строки организовать при помощи событий.
*/
/*Описать новое событие newItemFilled, 
 * запускаемое при присваивании нового значения очередному 
 * элементу массива. В обработчике вычислять и выводить 
 * на печать сумму элементов двумерного массива
*/
namespace HM3_Sem3
{
	class Program
	{
		public delegate void LineCompliteEvents();
		public delegate void NewItemEvents(int[,] arr);
		public class Methods
		{
			public static event LineCompliteEvents lineComplite;
			public static event NewItemEvents NewItemFild;
			public static int[,] ArrayCreate(int n, int k)
			{
				Random rnd = new Random();
				int[,] arr = new int[n, k];
				for (int i = 0; i < n; i++)
				{
					for (int j = 0; j < k; j++)
					{
						arr[i, j] = rnd.Next(0, 10);
						NewItemFild?.Invoke(arr);
					}
				}
				return arr;
			}
			public static void ArrayPrint(int[,] arr)
			{
				for (int i = 0; i <= arr.GetUpperBound(0); i++)
				{
					for (int j = 0; j <= arr.GetUpperBound(1); j++)
						Console.Write(arr[i, j] + " ");
					lineComplite();
				}
			}
		}
		public static void ArraySum(int[,] arr)
		{
			int sum = 0;
			for (int i = 0; i < arr.GetLength(0); i++)
			{
				for (int j = 0; j < arr.GetLength(1); j++)
				{
					sum += arr[i, j];
				}
			}
			Console.WriteLine($"Sum of elements = {sum}");
		}
		public static void ArrayAverage(int[,] arr)
		{
			int sum = 0;
			int count = 0;
			for (int i = 0; i < arr.GetLength(0); i++)
			{
				for (int j = 0; j < arr.GetLength(1); j++)
				{
					sum += arr[i, j];
					count++;
				}
			}
			Console.WriteLine($"Avarage of exsited elements = {sum / count}");
		}
		public static void ArrayMax(int[,] arr)
		{
			int max = 0;

			for (int i = 0; i < arr.GetLength(0); i++)
			{
				for (int j = 0; j < arr.GetLength(1); j++)
				{
					if (max < arr[i, j]) max = arr[i, j];
				}
			}
			Console.WriteLine($"MaxElement of exsited elements = {max}");
		}
		static void Main(string[] args)
		{
			Methods.NewItemFild += ArraySum;
			Methods.NewItemFild += ArrayAverage;
			Methods.NewItemFild += ArrayMax;
			int[,] myarr = Methods.ArrayCreate(2, 2);


			// в качестве обработчика - лямбда-выражение
			Methods.lineComplite += () => { Console.WriteLine(); };
			Methods.ArrayPrint(myarr);

			Console.ReadKey();
		}
	}
}

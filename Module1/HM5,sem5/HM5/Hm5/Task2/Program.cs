using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Заполнить массив нечетными числами*/
namespace Task2
{
	class Program
	{
		/// <summary>
		/// Заполняет массив целыми числами
		/// </summary>
		/// <param name="arr">массив</param>
		public static void Fill(int[] arr)
		{
			for(int i = 1; i < arr.Length; i++)
			{
				arr[0] = 1;
				arr[i] = 2*i+1;
			}
		}
		/// <summary>
		/// выводит массив
		/// </summary>
		/// <param name="arr">массив</param>
		public static void PrintArr(int[] arr)
		{
			foreach (int memb in arr)
			{
				Console.Write("{0,4}", memb);
			}
		}
		static void Main(string[] args)
		{
			int n;
			do {
				Console.Clear();
				Console.Write("Enter n = ");
				while (!int.TryParse(Console.ReadLine(), out n) || n <= 0 || n > 1e+2)
				{
					Console.WriteLine("Smgn wrong with input");
					Console.Write("Enter n = ");
				}
				int[] arr = new int[n];
				Fill(arr);
				PrintArr(arr);
				Console.WriteLine();
				Console.WriteLine("To exit press Escape");

			} while (Console.ReadKey().Key!=ConsoleKey.Escape);
		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Заполнить массив числами Фиббоначчи
 Перевернуть массив без класса Array
	 */
namespace Task4
{
	class Program
	{
		/// <summary>
		/// Заполняет массив числами фиббоначчи
		/// </summary>
		/// <param name="arr">массив</param>
		public static void Fibb(int[] arr)
		{
			arr[0] = 1;
			arr[1] = 2;
			for(int i = 2; i < arr.Length; i++)
			{
				arr[i] = arr[i - 2] + arr[i - 1];
			}
		}
		/// <summary>
		/// Переворачивает массив
		/// </summary>
		/// <param name="arr">массив</param>
		/// <returns>перевернутый  массив</returns>
		public static int[] Revese(int[] arr)
		{
			int[] copy = new int[arr.Length];
			for(int i = 0; i < arr.Length ; i++)
			{
				copy[i] = arr[arr.Length-1-i];
			}
			return copy;
		}
		static void Main(string[] args)
		{
			int n;
			do
			{
				Console.Clear();
				Console.Write("Enter n = ");
				while (!int.TryParse(Console.ReadLine(), out n) || n < 1 || n > 1e+2)
				{
					Console.WriteLine("Smgn wrong with input");
					Console.Write("Enter n = ");
				}
				int[] arr = new int[n];
				Fibb(arr);
				foreach(int memb in arr)
				{
					Console.Write("{0,2} ", memb);
				}
				Console.WriteLine();

				int[] rev = Revese(arr); 
				foreach (int memb in rev)
				{
					Console.Write("{0,2} ", memb);
				}
				Console.WriteLine();
				Console.WriteLine("To exit press Escape");
			} while (Console.ReadKey().Key != ConsoleKey.Escape);
		}
	}
}

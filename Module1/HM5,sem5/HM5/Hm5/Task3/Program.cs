using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Заполнение массива числами арифметической прогрессии*/
namespace Task3
{
	
	class Program
	{
	
		public static void Enter(string str, out int n,int min )
		{
			
			Console.Write($"Enter {str} = ");
			while (!int.TryParse(Console.ReadLine(), out n) || n < min || n > 1e+2)
			{
				Console.WriteLine("Smgn wrong with input");
				Console.Write("Enter n = ");
			}
		}
		/// <summary>
		/// Заполняет массив числами ариф-ой прогрессии
		/// </summary>
		/// <param name="arr"></param>
		/// <param name="a">первый член</param>
		/// <param name="d">разность</param>
		public static void Fill(int[] arr,int a,int d)
		{
			for(int i = 0; i < arr.Length; i++)
			{
				arr[i] = a;
				a += d;
			}
		}
		static void Main(string[] args)
		{
			int n,a,d;
			do
			{
				Console.Clear();
				Enter("n", out n, 1);
				Enter("a", out a, 0);
				Enter("d", out d, 0);
				int[] arr = new int[n];
				Fill(arr, a, d);
				foreach(int memb in arr)
				{
					Console.Write("{0,2} ", memb);
				}
				Console.WriteLine();
				Console.WriteLine("To exit press Escape");

			} while (Console.ReadKey().Key != ConsoleKey.Escape);
		}
	}
}

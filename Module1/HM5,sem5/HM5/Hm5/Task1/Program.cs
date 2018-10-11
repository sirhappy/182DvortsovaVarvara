using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Заполнение массива степенями числа 2 .*/
namespace Task1
{
	class Program
	{
		public static void GetArr( int[] arr)
		{
			
			for (int i = 0; i < arr.Length; i++)
			{
				arr[i] = (int)Math.Pow(2 ,i);
			}
			
		}
		public static void PrintArr(int[] arr)
		{
			foreach(int memb in arr)
			{
				Console.Write("{0,4}", memb);
			}
		}
		static void Main(string[] args)
		{
			int n;
			do { Console.Write("Введите число н =");
			} while (!int.TryParse(Console.ReadLine(), out n) || n <= 0 || n > 1e+3);
			int[] arr = new int[n];
			GetArr(arr);
			PrintArr(arr);
			Console.ReadLine();

		}
	}
}

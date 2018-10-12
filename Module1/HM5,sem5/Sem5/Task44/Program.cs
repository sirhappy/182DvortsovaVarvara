using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*1. Написать метод для формирования массива, целочисленные
неотрицательные элементы которого вычисляются по следующему
рекуррентному соотношению: ai+1 = ai%2==0 ? ai/2 :(3*ai+1).
Процесс вычисления завершается, когда ai+1 станет равным 1.
Параметр метода задает значение a0
. Количество элементов
массива заранее не известно, так как определяется значением a0
.*/
namespace Task44
{
	class Program
	{
		/// <summary>
		/// Считает кол-во элементов
		/// </summary>
		/// <param name="a0">первый член пос-ти</param>
		/// <returns>кол-во элементов массива</returns>
		public static int CountElem(double a0)
		{
			int count = 1;
			double corrent = a0;
			for(int i = 0; corrent > 1; i++)
			{
				corrent = corrent % 2 == 0 ? corrent / 2 : (3 * corrent + 1);
				
				count += 1;
			}
			return count;
		}
		/// <summary>
		/// Заполнение массива
		/// </summary>
		/// <param name="arr"></param>
		/// <param name="a0"></param>
		public static double[] GetArr(double a0,int count)
		{
			double[] arr = new double[count];
			arr[0] = a0;
;			for (int i = 1; i < arr.Length; i++)
			{
				arr[i] = arr[i-1] % 2 == 0 ? arr[i - 1]  / 2 : (3 * arr[i - 1] + 1);
				
			}
			return arr;


		}
		/// <summary>
		/// Вывод элементов массива по 5 в каждой строке
		/// </summary>
		/// <param name="arr"></param>
		public static void PrintArr(double[] arr)
		{
			int max = 5,count=0;
			for(int i = 0; i < arr.Length; i++)
			{
				if (count != max) Console.Write($"{arr[i]} ");
				else {
					count =0;
					Console.WriteLine();
					Console.Write($"{arr[i]} "); }
				count += 1;
			}

		}
		
		static void Main(string[] args)
		{
		double a0;
			do {
				Console.Clear();
				Console.Write("Enter a0  = ");
				while(!double.TryParse(Console.ReadLine(),out a0) || a0 < 0 || a0 > 1e+2)
				{
					Console.WriteLine("Error,Reenter pls");
					Console.Write("Enter a0  = ");
				}
				int n = CountElem(a0);
				
				GetArr( a0,n);
				Console.WriteLine();
				PrintArr(GetArr(a0, n)) ;
				Console.WriteLine();
				Console.WriteLine("Press any key to continue or Escape to exit");
			} while (Console.ReadKey().Key!=ConsoleKey.Escape);
		}
	}
}

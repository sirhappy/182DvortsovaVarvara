using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task66
{
	class Program
	{
		public static void GetArr(int a) { }
		static void Main(string[] args)
		{
			int n;
			do
			{
				Console.Clear();
				Console.Write("Enter n  = ");
				while (!int.TryParse(Console.ReadLine(), out n) || n < 0 || n > 1e+2)
				{
					Console.WriteLine("Error,Reenter pls");
					Console.Write("Enter n  = ");
				}

				int[] arr = new int[n];
				Random rnd = new Random();
				for (int i = 0; i < arr.Length; i++)
				{
					arr[i] = rnd.Next(-10, 10);
				}
				//Вывели текущий массив
				foreach (int memb in arr)
				{
					Console.Write($"{memb} ");
				}
				Console.WriteLine();
				int m = 0;//paзмер нового массива
				int count = 0;
				for (int k = 0; k < arr.Length-1; k++)
				{
					if (arr[k] * arr[k + 1] % 3 == 0)
					{
						arr[m++] = arr[k] * arr[k + 1];
						for(int j = k+1; j < arr.Length - 1; j++)
						{
							arr[j] = arr[j + 1];

						}
					    Array.Resize(ref arr, arr.Length - 1);
						count += 1;
					}
				}

			
				Console.WriteLine($"{count}");
				//Вывод измененного массива
				foreach (int memb in arr)
				{
					Console.Write($"{memb} ");
				}
				Console.WriteLine();
				Console.WriteLine("Press any key to continue or Escape to exit");
			} while (Console.ReadKey().Key != ConsoleKey.Escape);
		}
	}
}

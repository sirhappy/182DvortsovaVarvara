using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*"Сжать" массив, удалив из него  элементы c четным значением*/
namespace Task55
{
	class Program
	{
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
				for(int i = 0; i < arr.Length; i++)
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
				for(int k = 0; k < arr.Length; k++)
				{
					if (arr[k] % 2 == 1) arr[m++] = arr[k];

				}

				if (m > 0) Array.Resize(ref arr, m);
				Console.WriteLine();
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

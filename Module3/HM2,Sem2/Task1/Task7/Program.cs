using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
	class Program
	{
		static void Main(string[] args)
		{
			do {
				int[] arr = { 8, 9, 4, 70, 0, 2, 6, 4, 8, 8, 0, 0, 4, 5, 78, 100, 3 };
				Array.ForEach(arr, e => Console.Write(e + " "));
				Console.WriteLine("Сортировка по возрастанию");
				Array.Sort(arr, (x, y) =>
				{
					if (x == y) return 0;
					if (x > y) return 1;
					return -1;
				});
				Array.ForEach(arr, e => Console.Write(e + " "));
				Console.WriteLine("Сортировка по нечетности");
				Array.Sort(arr, (x, y) =>
				{
					if (x % 2 == 1&y%2!=1) return -1;
					if (x % 2 == 1 & y % 2 == 1) return 0;
					return 1;
				});
				Array.ForEach(arr, e => Console.Write(e + " "));



			} while (Console.ReadKey().Key != ConsoleKey.Escape);
		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Tests
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] x = new int[] { 2, 2, 3, 3, 4, 5, 5, 6, 6,
				 9, 9, 9, 9, 9,
				 12, 12, 12, 12, 12, 13, 13, 14, 14, 14,
				 17, 17, 17, 17, 17, 18, 18, 18, 19, 19,
				 22, 22, 22, 22, 22, 23, 23, 24, 24, 24, 24, 24,
				 27, 27, 28, 28, 28, 29, 29,
				 32, 32, 32, 32, 32, 33, 34, 34, 34, 34, 34,
				 37, 37, 37, 37, 38, 38, 39, 39, 39, 39,
				 42, 42, 42, 42, 42, 43, 43, 44, 44, 44,
				 47, 47, 47, 47, 47, 48, 48, 49};
			int[] y = new int[] { 2, 3, 4, 5, 6, 5, 4, 3, 2,
				 1, 3, 4, 5, 6,
				 2, 3, 4, 5, 6, 2, 6, 3, 4, 5,
				 2, 3, 4, 5, 6, 2, 4, 6, 2, 6,
				 2, 3, 4, 5, 6, 2, 6, 2, 3, 4, 5, 6,
				 3, 6, 2, 4, 6, 2, 5,
				 2, 3, 4, 5, 6, 4, 2, 3, 4, 5, 6,
				 3, 4, 5, 6, 2, 4, 3, 4, 5, 6,
				 2, 3, 4, 5, 6, 2, 4, 3, 5, 6,
				 2, 3, 4, 5, 6, 2, 4, 3};

			Console.BackgroundColor = ConsoleColor.Blue;
			Console.ForegroundColor = ConsoleColor.White;
			for (int i = 0; i < x.Length; i++)
			{
				Console.SetCursorPosition(x[i], y[i]);
				Console.Write("*");
				Thread.Sleep(200);
			}
			Console.ReadKey();
		}
	}
}

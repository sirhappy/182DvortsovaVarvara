using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
	class Program
	{
		public static void GetMatrix( ref int[][] ar)
		{
			for (int i = 0; i < ar.Length; i++)
			{
				ar[i] = new int[i + 1]; // объект - массив элементов типа int
				ar[i][0] = ar[i][i] = 1;
				for (int j = 1; j < i; j++)
					ar[i][j] = ar[i - 1][j - 1] + ar[i - 1][j];
			}

		}



		static void Main(string[] args)
		{
			int[][] paskal; // ссылка на массив ссылок на массив
			int n;
			do                  // цикл для повторения решения
			{
				do Console.Write("Введите n: ");
				while (!int.TryParse(Console.ReadLine(), out n) || n < 0);
				paskal = new int[n + 1][]; // объект - массив пустых ссылок
				GetMatrix(ref paskal);
				foreach (int[] ar in paskal)    // перебор ссылок типа int[] 
				{
					foreach (int cnk in ar)     // перебор элементов типа int
						Console.Write("{0,4}", cnk);
					Console.WriteLine();
				}


				Console.WriteLine("Для выхода нажмите клавишу ESC");
			} while (Console.ReadKey(true).Key != ConsoleKey.Escape);
			Console.WriteLine();

		}
	}
}
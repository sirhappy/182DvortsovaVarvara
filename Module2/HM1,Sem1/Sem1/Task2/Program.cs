using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
	class Program
	{
		static void GhaengeMatrixIfItKvadratnaya(ref int[,] arr)
		{
			if (arr.GetLength(0) != arr.GetLength(1)) return;
			for (int i = 0; i < arr.GetLength(0); i++)
			{
				for (int j = 0; j < arr.GetLength(1); j++)
				{
					if (i > arr.GetLength(0) - j - 1)
					{
						arr[i, j] = 0;
					}
				}
			}

		}
		static void Main(string[] args)
		{
			int n = 4;
			int[,] a = new int[n, n];
			int k = 0;
			for (int i = 0; i < a.GetLength(0); i++)
			{
				k++;
				for (int j = 0; j < a.GetLength(1); j++)
				{

					a[i, j] = (j + k) % (n + 1);
					
				}
				//if (a[i, n - 1] == 0) a[i, n - 1] = a[i, 0];

			}
			int l = 0;
			foreach (var memb in a)
			{
				l++;
				Console.Write("{0,3}", memb);
				if (l >= a.GetLength(0))
				{
					Console.WriteLine();
					l = 0;
				}
			}
			GhaengeMatrixIfItKvadratnaya(ref a);
			foreach (var memb in a)
			{
				l++;
				Console.Write("{0,3}", memb);
				if (l >= a.GetLength(0))
				{
					Console.WriteLine();
					l = 0;
				}
			}
			Console.ReadKey();
		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = 5;
			int[,] matr = new int[n,n];
			int k = 0;
			for(int i = 0; i < n; i++)
			{
				k++;
				for(int j = 0; j < n; j++)
				{
					matr[i, j] = (j + k) % (n + 1);
				}
			}
			for (int i = 0; i < matr.GetLength(0); i++)
			{
				for (int j = 0; j < matr.GetLength(1); j++)
				{
					Console.Write("{0,3}", matr[i, j]);
				}
				Console.WriteLine();
			}
			Console.ReadKey();
		}
	}
}

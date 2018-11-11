using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
	internal class Program
	{
		public static Random rnd = new Random();
		public static int[,] CreateMatrix(int m ,int n)
		{
			int[,] ar = new int[n, m];
			for(int i = 0; i < n; i++)
			{
				for(int j = 0; j < 0; j++)
				{
					ar[i, j] = rnd.Next(1, 11);
				}
			}
			return ar;
		}
		public static int[,] Matrixmult(int[,] a ,int[,] b)
		{
			int[,] c = new int[a.GetLength(0), b.GetLength(1)];
			if (a.GetLength(1) == b.GetLength(0))
			{
				for(int i  = 0; i < c.Length; i++)
				{
					for(int j = 0; j < c.Length; j++)
					{
						c[i, j] = a[i, j] * b[i, j];
					}
				}
			}
		}
		public static void MatrixTostring()
		{

		}
		
		static void Main(string[] args)
		{

		}
	}
}

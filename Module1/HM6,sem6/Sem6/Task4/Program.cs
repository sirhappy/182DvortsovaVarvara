using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
	class Program
	{
		public static void GetMatrix(int n ,int m,out int[,] ar )
		{
			ar = new int[n, m];
			for (int i = 0; i < (n - 1); i++)
			{
				for (int j = 0; j < (m - 1); j++)
				{
					ar[i, j] = (i + 1) * (2 * j + 1);
				}

			}
		}
		public static void RedidMatrix(int n, int m, ref ar)
		{
			if (n == m) {
				for (int i = 0; i < ar.Length; i++)
				{
					for (int j = 0; j < ar.Length; j++)
					{
						if (i > ar.Length - j - 1) 
							ar[i, j] = 0;
					}

				}
			}
			
		}
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			int m = int.Parse(Console.ReadLine());
			int[,] ar ;
			GetMatrix(n, m,out ar);
			for(int i = 0; i < ar.GetLength(0); i++,Console.WriteLine())
			{
				for(int j=0;j< ar.GetLength(1); j++)
				{
					Console.Write(ar[i, j]+" ");
				}
			}
			Console.ReadLine();

			RedidMatrix(n, m, ref ar);

			for (int i = 0; i < ar.GetLength(0); i++, Console.WriteLine())
			{
				for (int j = 0; j < ar.GetLength(1); j++)
				{
					Console.Write(ar[i, j] + " ");
				}
			}
			Console.ReadKey();
		}
	}
}

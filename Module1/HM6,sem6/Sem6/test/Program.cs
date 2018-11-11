using System;

namespace test
{
	class Program
	{
		static void Main(string[] args)
		{
			var a = new [] { 1, 2, 3, 4, 5 };
			var b = new long[2,5];
			foreach(int memb in a)
			{
				Console.Write("{0,3}", memb);
			}
			

			for(int i = 0; i < b.GetLength(0); i++,Console.WriteLine())
			{Console.WriteLine();
				for(int j = 0; j < b.GetLength(1); j++)
				{
					Console.Write("{0,3}", b[i, j]);
				}
			}
			int[][,] arr;
			arr = new int[3][,];
			arr[0] = new int[,] { { 1, 2 }, { 3, 4 } };
			arr[1] = new int[,] { { 50, 10 }, { 18, 19 } };
			arr[2] = new int[,] { { 15, 20 }, { 40, 80 } };
			for(int i = 0; i < arr.GetLength(0); i++,Console.WriteLine())
			{
				for(int j = 0; j < arr[i].GetLength(0); j++)
				{
					for(int k = 0; k < arr[i].GetLength(1); k++)
					{
						Console.Write("{0,3}", arr[i][j, k]);
					}
				}
			}
			int[][] matr = new int[3][];
			matr[0]  = new int[] { 1,2};
			matr[1] = new int[] { 2, 50 };
			matr[2] = new int[] { 1, 6 };
			Console.WriteLine();
			for (int i = 0; i < matr.GetLength(0); i++,Console.WriteLine())
			{
				for(int j = 0; j < matr[i].GetLength(0); j++)
				{
					Console.Write("{0,3}", matr[i][j]);
				}
			}

			Console.WriteLine();
			Console.WriteLine("a.Length = {0}", a.Length);
			Console.WriteLine("a.Rank = {0}", a.Rank);
			
			Console.WriteLine("a.GetLength(0) = {0}", a.GetLength(0));
			Console.WriteLine(" a.GetUpperBound(0) = {0}", a.GetUpperBound(0));

			//Console.WriteLine("a.GetLength(0) = ", a.GetLength(0));

			Console.ReadKey();
		}
	}
}

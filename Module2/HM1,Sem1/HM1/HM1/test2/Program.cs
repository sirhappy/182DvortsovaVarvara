using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test2
{

	class Program
	{
		public static int[,] DellMAtrixString(int[,] matr)
		{
			int indexZer;
			int temp = 0;
			for (int i = temp; i < matr.GetLength(0); i++)
			{
				
				for (int j = 0; j < matr.GetLength(1); j++)
				{
					//PrintMatrix(matr);
					if (matr[i,j] == 0)
					{
						indexZer = i;
						
						matr = HelpDell(matr, indexZer);
						i = temp;
						Console.WriteLine("*");
						if(matr == null)
						{
							return null;
						}
						
						
					}
					continue;
				}
				continue;
				
			}
			return matr;
		}
		public static int[,] HelpDell(int[,] matr,int temp)
		{
			
			int k = 0;
			if (matr.GetLength(0) == 1)
			{
				Console.WriteLine(" Я сюда зашел!");
				return null;
			}
			int[,] b = new int[matr.GetLength(0) - 1, matr.GetLength(1)];
			//PrintMatrix(b);
			for (int i = 0; i < b.GetLength(0); i++)
			{
				for (int j = 0; j < b.GetLength(1); j++)
				{
					if (k == temp) k++;
					b[i, j] = matr[k, j];
				}
				k++;
			}
			matr = b;
			return matr;
		}
		public static void PrintMatrix(int[,] a)
		{

			for (int i = 0; i < a.GetLength(0); i++, Console.WriteLine())
			{
				for (int j = 0; j < a.GetLength(1); j++)
				{
					Console.Write("{0,5}", a[i, j]);
				}
			}
			Console.WriteLine();
		}
		static void Main(string[] args)
		{
			int[,] a = new int[,] { { 9, 0, 1 },{ 1, 3, 5 } };
			PrintMatrix(a);
			//int temp = 2;
			int k = 0;
			//int[,] arr = DellMAtrixString(a);
			//int[,] b = new int[a.GetLength(0) - 1, a.GetLength(1)];
			//PrintMatrix(arr);
			int[,] test = new int[a.GetLength(0)+1, a.GetLength(1) + 1];
			a.Clone();
			//for (int i = 0; i < b.GetLength(0);i++)
			{
				//for(int j = 0; j < b.GetLength(1); j++)
				{
					//if (k == temp) k++;
					//b[i, j] = a[k,j];
				}
				k++;
			}
			PrintMatrix(test);
			Console.ReadLine();

		}
	}
}

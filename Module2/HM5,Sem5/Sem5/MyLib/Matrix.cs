using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLib
{
	public class Matrix
	{
		int[,] arr;
		public void PrintMatrix()
		{
			for (int i = 0; i < arr.GetLength(0); i++, Console.WriteLine())
			{
				for (int j = 0; j < arr.GetLength(1); j++)
				{
					Console.Write(arr[i, j]);
				}
			}
		}
		public  void CreateMatrix(int n)
		{
			if (n <= 0)
			{
				throw new ArgumentOutOfRangeException(" Razmer massiva <0!!!");
			}
			arr = new int[n, n];
			for (int i = 0; i < arr.GetLength(0); i++, Console.WriteLine())
			{
				for (int j = 0; j < arr.GetLength(1); j++)
				{
					arr[i, j] = 0;
					if (i == j) arr[i, j] = 1;
				}
			}
			
		}
		

	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
	class Program
	{
		static void Main(string[] args)
		{
			int[,] matr = new int[3, 4] { { 0, 1, 3, 4 }, { 5, 6, 7, 8 }, { 9, -1, -2, -3 } };
			Console.WriteLine("matr.Rank = {0}", matr.Rank);
			Console.WriteLine("matr.Length = {0}", matr.Length);
			Console.WriteLine("matr.GetLength(0) = {0}", matr.GetLength(0));
			Console.WriteLine("matr.GetLength(1) = {0}", matr.GetLength(1));
			Console.WriteLine("matr.GetUpperBound(0) = {0}", matr.GetUpperBound(0));
			Console.WriteLine("matr.GetUpperBound(1) = {0}", matr.GetUpperBound(1));
			Console.WriteLine("matr.IsFixedSize = {0}", matr.IsFixedSize);
			Console.WriteLine();
			int i = 0;
			Console.WriteLine("foreach :");
			foreach (var memb in matr)
			{
				Console.Write("{0,3}", memb);
				i++;
				if (i > matr.GetLength(0))
				{
					i = 0;
					Console.WriteLine();
				}
			}
			Console.WriteLine("for :");
			for(int j = 0; j < matr.GetLength(0);j++,Console.WriteLine())
			{
				for(int k = 0; k < matr.GetLength(1); k++)
				{
					Console.Write("{0,3}", matr[j, k]);
				}
			}
			Console.ReadKey();
		}
	}
}

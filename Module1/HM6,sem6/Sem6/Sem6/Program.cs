using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem6
{
	class Program
	{
		static void Main(string[] args)
		{
			int[,] matr = new int[3, 4] ;
			Random rnd = new Random();
			for (int i = 0; i < matr.GetLength(0); i++)
			{
				for (int k = 0; k < matr.GetLength(1); k++)
				{
					matr[i, k] = rnd.Next(-10,10);
				}
				
			}
			Console.WriteLine("ранг массива = {0}",matr.Rank);
			Console.WriteLine("Длина массива = {0}",matr.Length);
			Console.WriteLine("число элементов в 1 измерении = {0}", matr.GetLength(0));
			Console.WriteLine("число элементов  во втором  измерении  = {0}", matr.GetLength(1));
			Console.WriteLine(matr.GetUpperBound(0));
			Console.WriteLine(matr.IsFixedSize);
			foreach(int memb in matr)
			{
				Console.Write("{0,3}",memb);
			}
			for(int i = 0; i < matr.GetLength(0); i++)
			{
				for(int k = 0;k< matr.GetLength(1); k++)
				{
					Console.Write("{0,3}", matr[i,k]);
				}
				Console.WriteLine();
			}
			Console.ReadKey();



		}
	}
}

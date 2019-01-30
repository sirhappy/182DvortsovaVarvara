using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
	
	class Series
	{
		public int[] arr;
		public void Order(Comparison<int> f)
		{
			Array.Sort(arr, f);
			
		}
	}
	
	class Program
	{
		public static int Comp(int x, int y)
		{
			if (x > y) return 1;
			if (x < y) return -1;
			else return 0;
		}
		static void Main(string[] args)
		{
			do {

				Series ser = new Series();
				ser.arr = new int[] { 9,7,5,8,18,4,1,0,56,89};
				Array.ForEach(ser.arr, e => Console.Write(e + " "));
				ser.Order(Comp);
				Console.WriteLine();
				Array.ForEach(ser.arr, e => Console.Write(e + " "));


			} while (Console.ReadKey().Key != ConsoleKey.Escape);
		}
	}
}

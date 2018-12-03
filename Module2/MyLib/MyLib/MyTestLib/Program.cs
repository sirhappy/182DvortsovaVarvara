using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLib;

namespace MyTestLib
{
	class Program
	{
		public static Random rnd = new Random();
		public static double[] ArrayGenerate(int n)
		{
			double[] arr = new double[n];
			for(int i = 0; i < arr.Length; i++)
			{
				arr[i] = rnd.Next(-10, 11);
			}
			return arr;
		}
		public static void ShowArray(double[] arr)
		{
			Console.WriteLine();
			for(int i = 0; i < arr.Length; i++)
			{
				Console.Write($"{arr[i]}");
			}
		}
		static void Main(string[] args)
		{
			do {
				double[] arr = ArrayGenerate(10);
				ShowArray(arr);
				double maxElem = MyLib.Procedure.maxSearch(arr, 0, arr.Length - 1);
				double count_step = Procedure.callNumb;
				Console.WriteLine($"maxElem = {maxElem},count_step = {count_step}");
			} while (Console.ReadKey().Key != ConsoleKey.Escape);
			

		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task03
{
	class Program
	{
		//факториал
		public static double Fact(int n)
		{
			if (n == 1) return 1;
			else return Fact(n - 1) * n;
		}
		//формула члена ряда
		public static double CalcOnePart(double x, int i)
		{
			return Math.Pow(-1, (i % 2)) * Math.Pow(x, i * 2 + 3) / Fact(i * 2 + 3);
		}
		//метод ,который вносит в массив члены ряда кол-ва n
		public static double[] Row(double x,int n)
		{
			double[] arr = new double[n];
			for(int i = 0; i < n; i++)
			{
				arr[i] = CalcOnePart(x, i);
			}
			return arr;
		}
		//суммирование эл-ов массива
		public static double SumArr(ref double[] arr)
		{
			double sum = 0;
			foreach(double memb in arr)
			{
				sum += memb;
			}
			return sum;
		}
		//вывод массива
		public static void PrintArr(double[] arr)
		{
			foreach(double memb in arr)
			{
				Console.Write("{0,4} ", memb);
			}
		}
		static void Main(string[] args)
		{
			int n;
			do {
				do { Console.Write("Enter n = "); }
				while (!int.TryParse(Console.ReadLine(), out n) || n <= 0||n>1e+3) ;
				double[] arr = new double[n];
				arr = Row(Math.PI, n);
				PrintArr(arr);
				Console.WriteLine();
				Console.WriteLine("by Row");
				Console.WriteLine(SumArr(ref arr));
				Console.WriteLine("Using Math.Sin");
				Console.WriteLine(Math.Sin(1));


			} while (Console.ReadKey().Key!=ConsoleKey.Escape);


		}
	}
}

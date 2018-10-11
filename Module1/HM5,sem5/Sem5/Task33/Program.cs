using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*3.1. Написать метод, формирующий и возвращающий массив из N
членов разложения в ряд функции sin(1):
sin(x)= x - x^3/3! + x^5/5! - ...
Параметр N – число требуемых членов ряда.*/
namespace Task33
{
	class Program
	{
		public static void Sinn(int n,int x,out double[] arr)
		{
			arr = new double[n];

			int c = 0;
			for (int i = 0; i < n; i++)
			{
				
				arr[i] = i % 2 == 0 ? Math.Pow(x, 1+c) / (1+c) : -Math.Pow(x, 1 + c) / 1 + c;
				c += 2;

			}

		}
		static void Main(string[] args)
		{
			int n = 5;
			int x = 1;
			double[] line = new double[n];
			Sinn(n, x, out line);
			foreach(int memb in line)
			{
				Console.Write("{0}  ", memb);
			}
			Console.ReadKey();
		}
	}
}

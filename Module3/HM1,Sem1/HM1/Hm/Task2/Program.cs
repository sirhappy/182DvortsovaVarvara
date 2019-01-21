using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
	public delegate double Sum(int n);
	class Program
	{
		static void Main(string[] args)
		{
			
			Sum del1 = (int n ) => {
				double sum = 0;
				double sum1 = 0;
				for (int i = 1; i <n+1 ; i++)
				{
					for (int j = 1; j < i; j++)
					{
						sum1 += 1 / j;// Math.Pow(2,j);
					}
					sum += sum1;
					sum1 = 0;
				}
				return sum;

			};
			do {
				int a;
				Console.Write("Enter a = ");
				int.TryParse(Console.ReadLine(), out a);
				Console.WriteLine($"Sum = {del1(a)}");


			} while (Console.ReadKey().Key != ConsoleKey.Escape);
			

			
		}
	}
}

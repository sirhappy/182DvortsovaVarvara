using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Дворцова Варя
 * БПИ 182 -2*/
namespace Task1
{
	class Program
	{
		public static double S()
		{
			int n = 20;
			double sum = 0;
			for(int a = 1; a < n; a++)
			{
				for(int b = a; b < n ; b++)
				{
					for (int c = b-1; c< n ; c++)
					{
						if (a * a + b * b == c * c)
						{
							sum++;
							Console.WriteLine($"{a}*{a} +{b}*{b} ={c}*{c}");
						}
					}
				}
			}
			return sum;
		}
		static void Main(string[] args)
		{
			double sum = S();
			Console.WriteLine($"sum = {sum}");
			Console.ReadLine();
		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
	public delegate double Del(double x);
	public delegate double Del2(double x, int i);

	class Program
	{
		
		static void Main(string[] args)
		{
			Del2 pro = (double x, int i) =>
			{
				double res1 = 1;
				for (int j = 1; j < 6; j++)
				{
					res1 *= i * x / j;
				}
				return res1;
			};
			Del sum = (x) =>
			{
				double res2 = 0;
				for (int i = 1; i < 6; i++)
				{
					res2 += pro(x,i);
				}
				return res2;
			};

			Console.Write("Write double x = ");
			double my_x;
			double.TryParse(Console.ReadLine(), out my_x);
			Console.WriteLine($"results = {sum?.Invoke(my_x)}");
			
			Console.ReadKey();
		}
	}
}

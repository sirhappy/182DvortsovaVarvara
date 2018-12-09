using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLib;

namespace Task4
{
	class Program
	{
		static void Main(string[] args)
		{
			do
			{
				QuadraticTrinomial f1 = new QuadraticTrinomial(2, 3, 7);
				QuadraticTrinomial f2 = new QuadraticTrinomial(1, -5, 6);
				double[] arr = { 1, -3, 3, 2, 7, 100, 0 };

				for (int i = 0; i < arr.Length; i++)
				{
					try
					{
						Console.WriteLine($"f1.DevideTrinomal({arr[i]:f3}, f2) = {f1.DevideTrinomal(arr[i], f2):f3}" );
					}
					catch (DivideByZeroException ex)
					{
						Console.WriteLine(ex.Message);
						Console.WriteLine(ex.GetType());
						continue;
					}
				}
					
				
			} while (Console.ReadKey().Key != ConsoleKey.Escape);
		}
	}
}

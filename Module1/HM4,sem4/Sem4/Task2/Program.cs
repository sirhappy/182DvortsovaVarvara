using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
	class Program
	{
		public static uint F(uint number,out uint sum_nech1)
		{
			uint digit = number;
			uint last;
			uint sum_ch = 0, sum_nech=0;
			while (number > 0)
			{
				last = digit % 10;
				digit /= 10;
				if (digit.ToString().Length%2!=0) sum_ch += last;
				else sum_nech += last;
				
			}
			sum_nech1 = sum_nech;
			return sum_ch;
		}
		public static bool getDouble(string name, out uint value)
		{
			Console.Write($"Enter {name} = ");
			return uint.TryParse(Console.ReadLine(), out value);
		}
		static void Main(string[] args)
		{
			uint number;
			do
			{
				Console.Write("Введите число а = ");
				while (!uint.TryParse(Console.ReadLine(), out number) )
				{
					Console.WriteLine("Error ");
					Console.Write("Введите число а = ");
				}

				
			} while (Console.ReadKey().Key != ConsoleKey.Escape);
		}
	}
}

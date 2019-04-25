using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
	class Program
	{
		static void Main(string[] args)
		{
			do
			{
				Console.Clear();
				int Xmax, Ymax, Zmax;
				
				int count = 0;
				while (count!=3)
				{
					Console.Write($"Enter x{count} = ");
					count++;
				}


			} while(Console.ReadKey().Key!=ConsoleKey.Escape);
		}
	}
}

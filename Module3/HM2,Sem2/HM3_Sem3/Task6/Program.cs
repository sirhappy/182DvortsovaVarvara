using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
	class Program
	{
		static void Main(string[] args)
		{
			do {
				double[] dob = { 0.1, .2, 3.0, 0.5 };
				Array.ForEach(dob, e => Console.Write(e + " "));
				Console.WriteLine();
				double max_abs =0.0000001;
				foreach (var item in dob)
				{
					if (Math.Abs(item) > max_abs&&item!=0)
						max_abs = item;
				}Console.WriteLine($"Max of array = {max_abs}");

				
					
				double[] dob2 = Array.ConvertAll(dob, e => e / max_abs);
				Array.ForEach(dob2, e => Console.Write(e + " "));

			} while (Console.ReadKey().Key!=ConsoleKey.Escape);
		}
	}
}

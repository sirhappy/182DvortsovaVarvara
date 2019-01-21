using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace Hm
{
	class Program
	{
		static void Main(string[] args)
		{
			do {
				ClassLibrary1.MyDel del = new ClassLibrary1.MyDel(TestClassstat.TestMethod);
				int a, b;
				Console.Write("Enter a = ");
				int.TryParse(Console.ReadLine(), out a);
				Console.Write("Enter b = ");
				int.TryParse(Console.ReadLine(), out b);
				Console.WriteLine($"Max = {del(a,b)}");

			} while (Console.ReadKey().Key!=ConsoleKey.Escape);
		}
	}
}

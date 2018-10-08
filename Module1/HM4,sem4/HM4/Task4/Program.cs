using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
	class Program
	{
		/// <summary>
		/// возведение в степень двойки через побитовый сдвиг влево
		/// </summary>
		/// <param name="pow">степень</param>
		/// <returns>число в степени</returns>
		public static long FastPow(int pow)
		{
			return (long)(1 << pow );
		}
		static void Main(string[] args)
		{
			int N, M;
			do
			{
				Console.Clear();
				Console.WriteLine("Enter N and M");
				Console.Write("Enter N = ");
				while (!int.TryParse(Console.ReadLine(), out N) || N < 0)
				{
					Console.WriteLine("Smth wrong with input,REENTER Z");
					Console.Write("N = ");
				}
				Console.Write("Enter M = ");
				while (!int.TryParse(Console.ReadLine(), out M) || M < 0 )
				{
					Console.WriteLine("Smth wrong with input,REENTER M");
					Console.Write("M = ");
				}
				Console.WriteLine($"2^{N} + 2^{M} = {FastPow(N)+ FastPow(M)}");
				Console.WriteLine("To exit press ESC...");
				
			} while (Console.ReadKey().Key != ConsoleKey.Escape);
		}
	}
}

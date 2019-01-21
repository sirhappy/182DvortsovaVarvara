using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NumericLibrary;

namespace Kr1
{
	class Program
	{
		public static Random rnd = new Random();
		static void Main(string[] args)
		{
			do
			{
				Console.Clear();
				int n;


				Console.Write("Enter n = ");
				while (!int.TryParse(Console.ReadLine(), out n) || n == 0 || n < 0 || n > 100)
				{
					Console.WriteLine("Error , try again ");
					Console.Write("Enter n = ");
				}
				Pair[] arr = new Pair[n];
				for (int i = 0; i < arr.Length; i++)
				{
					try
					{
						if (rnd.Next(0, 2) == 0) arr[i] = new Complex(rnd.Next(-50, 50), rnd.Next(-50, 50));
						else arr[i] = new Rational(rnd.Next(-50, 50), rnd.Next(-50, 50));
					}
					catch (ArgumentOutOfRangeException ex)
					{
						Console.WriteLine(ex.Message);
						arr[i] = new Rational(rnd.Next(-50, 50), rnd.Next(-50, 50));
						continue;
					}
					catch (Exception ex)
					{
						Console.WriteLine(ex.Message);
					}
				}
				for (int i = 0; i < arr.Length; i++)
				{
					Console.WriteLine(arr[i].ToString());
				}
				Rational rati;
				try { rati = new Rational(rnd.Next(-50, 50), rnd.Next(-50, 50)); }
				catch (ArgumentOutOfRangeException ex)
				{
					Console.WriteLine(ex.Message);
					rati = new Rational(rnd.Next(-50, 50), rnd.Next(-50, 50));
					continue;
				}
				Console.WriteLine("Random Rati = " + rati.ToString());
				Console.WriteLine("All the Rational numbers which more than RandomRati");
				for (int i = 0; i < arr.Length; i++)
				{
					if (arr[i] is Rational & arr[i].PairEqual(rati) == -1) Console.WriteLine(arr[i].ToString());
				}
				Console.WriteLine("All the Rational numbers which more than RandomRati\n And their mult");
				for (int i = 0; i < arr.Length; i++)
				{
					if (arr[i] is Rational & arr[i].PairEqual(rati) == -1) Console.WriteLine($"mult {arr[i].ToString()} and {rati.ToString()} = {arr[i].Mult(rati).ToString()}");
				}
				Complex minComplex = new Complex(100, 100);
				Complex maxComplex = new Complex(-100, -100);
				for (int i = 0; i < arr.Length; i++)
				{
					if (arr[i] is Complex)
					{
						if (((Complex)arr[i]).PairEqual(minComplex) == -1) minComplex = (Complex)arr[i];
						else if (((Complex)arr[i]).PairEqual(maxComplex) == -1) maxComplex = (Complex)arr[i];
					}
				}
				Console.WriteLine("minComplex = " + minComplex.ToString());
				Console.WriteLine("maxComplex = " + maxComplex.ToString());
				Console.WriteLine($"minComplex.Add(maxComplex) = {minComplex.Add(maxComplex)}");
				Console.WriteLine($"minComplex.Sub(maxComplex) = {minComplex.Sub(maxComplex)}");
				Console.WriteLine($"minComplex.Mult(maxComplex) = {minComplex.Mult(maxComplex)}");

			} while (Console.ReadKey().Key != ConsoleKey.Escape);
		}
	}
}

using System;

namespace Task2
{
	class Program
	{
		static void Main(string[] args)
		{
			do
			{
				GeomProgr g1 = new GeomProgr();
				Console.Clear();
				try
				{
					
					Console.Write("b = ");
					double b;
					double.TryParse(Console.ReadLine(),out b);
					Console.Write("q = ");
					double q = double.Parse(Console.ReadLine());
					g1.B = b;
					g1.Q = q;
					Console.Write("n = ");
					
					int n = int.Parse(Console.ReadLine());
					if(n<0) throw new ArgumentException(" Razmer massiva <0!!!");
					Console.WriteLine($"b = {g1.B}, q = {g1.Q}, n = {n}, sum = {g1.GetSum(n)},g1[n] = {g1[n]}");
					
					
					
					
					
				}
				catch(FormatException ex)
				{
					Console.WriteLine(ex.Message);
					Console.WriteLine(ex.GetType());
				}
				catch(ArgumentException ex)
				{
					Console.WriteLine(ex.Message);
					Console.WriteLine(ex.GetType());
				}
				catch(Exception ex)
				{
					Console.WriteLine(ex.Message);
					Console.WriteLine(ex.GetType());
				}
				finally
				{
					Console.WriteLine("finally");
				}
			} while (Console.ReadKey().Key != ConsoleKey.Escape);
		}
	}
}

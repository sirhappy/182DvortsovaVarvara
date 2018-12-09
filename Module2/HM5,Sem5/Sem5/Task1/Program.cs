using MyLib;
using System;

namespace Task1
{
	class Program
	{
		
		static void Main(string[] args)
		{
			do {
				Console.Clear();
				Matrix arr = new Matrix();
				try
				{
					int n ;
					Console.Write("Enter n = ");
					n = int.Parse(Console.ReadLine())  ;
				    arr.CreateMatrix(n);
					arr.PrintMatrix();
				}
				catch(OverflowException ex)//переполнениние
				{
					Console.WriteLine(ex.Message);
					Console.WriteLine(ex.GetType());
				}
				catch(OutOfMemoryException ex)
				{
					Console.WriteLine(ex.Message);
					Console.WriteLine(ex.GetType());
				}
				catch(ArgumentException ex)
				{

					Console.WriteLine(ex.Message);
					Console.WriteLine(ex.GetType());
					Console.Write("Enter n = ");
					int n = int.Parse(Console.ReadLine());
				}
				catch(FormatException ex)
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

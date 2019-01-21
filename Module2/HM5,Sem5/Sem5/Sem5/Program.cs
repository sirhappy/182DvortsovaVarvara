using System;

namespace Sem5
{
	class Program
	{
		static void Main(string[] args)
		{
			int df = 9;
			int a = 10;
			int b = 20;
			int c = 0;
			int d = 0;
			try
			{
				return;// делает файнали и все 
				d = a / c;

			}
			catch(DivideByZeroException ex)
			{
				Console.WriteLine("1");
				Console.WriteLine(ex.Message);
				Console.WriteLine(ex.GetType());
				throw ;
			}
			catch(Exception ex)
			{
				Console.WriteLine("2");
				Console.WriteLine(ex.Message);
				Console.WriteLine(ex.GetType());
			}
			finally
			{
				Console.WriteLine("finally");
			}
			Console.ReadKey();
		}
	}
}

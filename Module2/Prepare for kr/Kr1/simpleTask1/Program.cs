using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Matrix;

namespace simpleTask1
{
	class Program
	{
		public static Random rnd = new Random();
		static void Main(string[] args)
		{
			do {
				Console.Clear();
				Matrix.Matrix m1 = new Matrix.Matrix(rnd.Next(3, 7), rnd.Next(3, 7));
				Matrix.Matrix m2 = new Matrix.Matrix(rnd.Next(3, 7), rnd.Next(3, 7));
				Console.WriteLine("m1------");
				Console.WriteLine(m1.ToString());
				Console.WriteLine("m2------");
				Console.WriteLine(m2.ToString());
				MatrixOperation[] operation = new MatrixOperation[rnd.Next(4, 8)];
				
				for (int i = 0; i < operation.Length; i++)
				{
					double random = rnd.NextDouble();
					if (random < 0.33) { operation[i] = new TramsposeOperation(); }
					else operation[i] = new SumOperation();
				}
				Console.WriteLine("m2------");
				for (int i = 0; i < operation.Length; i++)
				{
					Console.WriteLine(operation[i]);
				}
				Matrix.Matrix[] arr = new Matrix.Matrix[operation.Length];
				
				for (int i = 0; i < operation.Length; i++)
				{
					try
					{
						if (operation[i] is TramsposeOperation)
						{
							((TramsposeOperation)operation[i]).PerformOperation(m1, m2);
							arr[i] = ((TramsposeOperation)operation[i]).PerformOperation(m1, m2); ;
						}
						else
						{


							arr[i] = ((SumOperation)operation[i]).PerformOperation(m1, m2);

						}
					}
					catch (ArgumentException ex)
					{
						Console.WriteLine(ex.Message);
						continue;

					}

					
					
					

				}
				
				
				Console.WriteLine("Object------");
				for (int i = 0; i < arr.Length; i++)
				{
					if (arr[i] == null) continue;
					Console.WriteLine(arr[i].ToString());
				}



			} while (Console.ReadKey().Key != ConsoleKey.Escape);
		}
	}
}

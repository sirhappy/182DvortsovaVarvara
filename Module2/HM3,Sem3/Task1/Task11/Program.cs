using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task11
{
	class Program
	{
		public static Random rnd = new Random();
		static void Main(string[] args)
		{
			do {
				Console.Clear();

				GeometricProgression b = new GeometricProgression(rnd.Next(0,10), rnd.Next(0, 1));
				GeometricProgression[] arr = new GeometricProgression[rnd.Next(5,16)];
				for(int i = 0; i<arr.Length; i++)
				{
					arr[i] = new GeometricProgression(rnd.Next(0, 10), rnd.Next(2, 6));
				}
				int step = rnd.Next(3, 16);
				Console.WriteLine($"\n\tStep = {step}\tb[step] = {b[step]}\n");
				for(int i = 0; i < arr.Length; i++)
				{
					if (arr[i][step] > b[step])
					{
						Console.WriteLine(arr[i].ToString()+$"\tarr[i][step] = {arr[i][step]}");
					}
				}
				Console.WriteLine($"\n\tSum of Progression of array for step = {step} elements\n");
				for (int i = 0; i < arr.Length; i++)
				{
					
					Console.WriteLine(arr[i].ToString() + $"\tSum of {step} elements  = {arr[i].GetSum(step):f3}");
					
				}
			} while (Console.ReadKey().Key != ConsoleKey.Escape);
		}
	}
}

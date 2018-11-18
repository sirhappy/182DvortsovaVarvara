using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8
{
	class Program
	{ public static Random rnd = new Random();
		static void Main(string[] args)
		{
			do {
				Console.Clear();
				int n = rnd.Next(5, 16);
				Triangle[] arr = new Triangle [n] ;
				for(int i = 0; i < arr.Length; i++)
				{
					Point a = new Point(rnd.Next(-10, 11), rnd.Next(-10, 11));
					Point b = new Point(rnd.Next(-10, 11), rnd.Next(-10, 11));
					Point c = new Point(rnd.Next(-10, 11), rnd.Next(-10, 11));
					arr[i] = new Triangle(a,b,c);
				}
				Console.WriteLine("Вывод массива треугольников");
				for(int i = 0; i < arr.Length; i++)
				{
					Console.WriteLine($"arr[{i}] = " + arr[i].ToString());
				}
				for(int i = 0; i < arr.Length-1; i++)
				{
					for(int j = i+1; j < arr.Length ; j++)
					{
						if (arr[i].Sqeare < arr[j].Sqeare)
						{
							Triangle temp = arr[i];
							arr[i] = arr[j];
							arr[j] = temp;

						}
					}
				}
				Console.WriteLine("Вывод отсортированного массива");
				for (int i = 0; i < arr.Length; i++)
				{
					Console.WriteLine($"arr[{i}] = " + arr[i].ToString());
				}


			} while (Console.ReadKey().Key != ConsoleKey.Escape);
		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_10
{
	class Program
	{
		public static Random rnd = new Random();
		static void Main(string[] args)
		{
			do {
				Console.Clear();
				int n;
				do { Console.Write("Enter n = "); } while (!int.TryParse(Console.ReadLine(),out n)||n==0||n<0||n>1000);
				Circle[] arr = new Circle[n];
				for(int i = 0; i < arr.Length; i++)
				{
					arr[i] = new Circle(rnd.Next(1, 16), rnd.Next(1, 16), rnd.Next(1, 16));
				}
				Circle myCircle = new Circle(rnd.Next(1, 16), rnd.Next(1, 16), rnd.Next(1, 16));
				Console.WriteLine("Your Circle Array:\n");
				for(int i = 0; i < arr.Length; i++)
				{
					Console.WriteLine(arr[i].ToString());
				}
				Console.WriteLine($"\nThis{myCircle.ToString()} cross with:\n");
				for(int i = 0; i < arr.Length; i++)
				{
					if (Circle.CrossCircle(arr[i], myCircle))
					{
						Console.WriteLine(arr[i].ToString());
					}
				}
			} while (Console.ReadKey().Key !=ConsoleKey.Escape);
		}
	}
}

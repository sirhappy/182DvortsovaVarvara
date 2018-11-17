using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
	class Program
	{
		public static Random rnd = new Random();
		static void Main(string[] args)
		{
			do {
				Console.Clear();
				Point[] points = new Point[rnd.Next(5, 16)];
				for (int i = 0; i < points.Length; i++)
				{
					points[i] = new Point(rnd.Next(-10, 10), rnd.Next(-10, 10), rnd.Next(-10, 10));
				}
				Console.WriteLine("Все точки коллекции");
				for (int i = 0; i < points.Length; i++)
				{
					Console.WriteLine($"points[{i}] : {points[i].ToString()}, Point.Distance(points[{i}],new Point(0,0,0)) = {Point.Distance(points[i], new Point(0, 0, 0)):f3}");
				}
				Point big = null;
				double dist = 0;
				for (int i = 0; i < points.Length; i++)
				{
					if (Point.Distance(points[i], new Point(0, 0, 0)) > dist)
					{
						dist = Point.Distance(points[i], new Point(0, 0, 0));
						big = points[i];
					}
				}
				Console.WriteLine("Cамая удаленная точка из колекции : " + big.ToString());
				Console.WriteLine("Point.Distance(big, new Point(0, 0, 0)) =  " + Point.Distance(big, new Point(0, 0, 0)).ToString("f3"));
			} while (Console.ReadKey().Key != ConsoleKey.Escape);
			






			//Point p1 = new Point(1, 2, 10);
			//Point p2 = new Point(5, 3, 8);
			//Point p3 = new Point(2, 8, 9);
			//Console.WriteLine(p1.ToString());
			//Console.WriteLine(p2.ToString());
			//Console.WriteLine(p3.ToString());
			//Console.WriteLine("Point.Distance(p1, new Point(0, 0, 0) = " + Point.Distance(p1, new Point(0, 0, 0)).ToString("f3"));
			//Console.WriteLine("Point.Distance(p2, new Point(0, 0, 0) = " + Point.Distance(p2, new Point(0, 0, 0)).ToString("f3"));
			//Console.WriteLine("Point.Distance(p3, new Point(0, 0, 0) = " + Point.Distance(p3, new Point(0, 0, 0)).ToString("f3"));
			Console.ReadKey();
		}
	}
}

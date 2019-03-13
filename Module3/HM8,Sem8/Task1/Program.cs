using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{

	public class Point<T> : IComparable<Point<T>>
	{
		public T X { get; set; }
		public T Y { get; set; }
		public int CompareTo(Point<T> other)
		{
			
			if((dynamic)(other).X* (dynamic)(other).X+ (dynamic)(other).Y* (dynamic)(other).Y>
				(dynamic)this.X * (dynamic)this.X + (dynamic)this.Y * (dynamic)this.Y)
			{
				return 1;
			}
			if ((dynamic)(other).X * (dynamic)(other).X + (dynamic)(other).Y * (dynamic)(other).Y <
				(dynamic)this.X * (dynamic)this.X + (dynamic)this.Y * (dynamic)this.Y)
			{
				return 0;
			}
			return -1;
		}
		public override string ToString()
		{
			return $"x ={this.X} y = {this.Y}";
		}
	}
	class Program
	{
		static void Main(string[] args)
		{
			Random rnd = new Random();
			Point<float>[] points = new Point<float>[rnd.Next(10,20)];
			for (int i = 0; i < points.Length; i++)
			{
				points[i].Y = rnd.Next(5, 15);
				points[i].X= rnd.Next(5, 15);
			}
			Array.ForEach(points, e => Console.WriteLine(e));

			Console.ReadLine();
		}
	}
}

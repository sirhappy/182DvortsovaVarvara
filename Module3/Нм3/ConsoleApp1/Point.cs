using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	public class Point
	{
		double x;
		double y;

		public Point(double x, double y)
		{
			X = x;
			Y = y;
		}

		public double X { get => x; set => x = value; }
		public double Y { get => y; set => y = value; }
		public double Distatnce(Point p)
		{
			return Math.Sqrt((this.X - p.X) * (this.X - p.X) + (this.Y - p.Y) * (this.Y - p.Y));
		}
	}
}

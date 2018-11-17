using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
	class Point
	{
		private double x, y, z;
		public Point() : this(0, 0, 0) { }
		public Point(double x,double y,double z)
		{
			this.x = x;
			this.y = y;
			this.z = z;
		}
		public double X
		{
			get { return x; }
		}
		public double Y
		{
			get { return y; }
		}
		public double Z
		{
			get { return z; }
		}
		public static double Distance(Point a ,Point b)
		{
			return Math.Sqrt((a.X - b.X)* (a.X - b.X) + (a.Y - b.Y)* (a.Y - b.Y) + (a.Z - b.Z)* (a.Z - b.Z));
		}
		public override string ToString()
		{
			return $"X = {X} , Y = {Y} , Z = {Z} " ;
		}
	}
}

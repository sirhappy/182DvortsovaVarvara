using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8
{
	class Point
	{
		double x, y;
		public Point(double x, double y)
		{
			this.x = x;
			this.y = y;
		}
		public Point() : this(0, 0) { }

		public double X { get{ return x ;} }
		public double Y { get { return y; } }
		public override string ToString()
		{
			return $"x = {this.x} ,y = {this.y}";
		}
	}
}

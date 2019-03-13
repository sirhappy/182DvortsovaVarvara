using System;
using System.Collections.Generic;
using System.Text;

namespace Structure2
{
	public struct PointS : IComparable
	{   
		double x, y;
		public double X { get { return x; } set { x = value; } }
		public double Y { get { return y; } set { y = value; } }
		public PointS(double a, double b) { x = a; y = b; }
		public double distance(PointS ps)
		{
			double dx = x - ps.X;
			double dy = y - ps.Y;
			return Math.Sqrt(dx * dx + dy * dy);
		}
		
		public int CompareTo(object ob)
		{
			PointS temp = new PointS(0, 0);
			if (this.distance(temp) <
				((PointS)ob).distance(temp)) return 1;
			if (this.distance(temp) >
				((PointS)ob).distance(temp)) return -1;
			return 0;
		}
	}
}

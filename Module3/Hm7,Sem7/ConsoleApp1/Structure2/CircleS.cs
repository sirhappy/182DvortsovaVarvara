using System;
using System.Collections.Generic;
using System.Text;

namespace Structure2
{
	public struct CircleS : IComparable
	{     // композиция структур
		PointS center;      // центр круга
		double rad;         // радиус круга
		public CircleS(double xc, double yc, double rad)
		{
			center = new PointS(xc, yc);
			this.rad = rad;
		}
		
		public PointS Center
		{
			get { return center; }
			set { center = value; }
		}
		
		public double Rad
		{
			get { return rad; }
			set { rad = value; }
		}
		
		public double Len { get { return 2 * rad * Math.PI; } }
		
		public new string ToString()
		{
			string format = "xc={0:f3},\tyc={1:f3},\tRad={2:f3}";
			string res = string.Format(format, center.X, center.Y, Rad);
			return res;
		}

		// сравнение радиусов 
		public int CompareTo(object cs)
		{
			if (this.rad < ((CircleS)cs).Rad) return -1;
			if (this.rad > ((CircleS)cs).Rad) return 1;
			return 0;
		}

	}
}

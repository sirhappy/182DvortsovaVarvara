using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_10
{
	class Circle
	{
		double x, y, r;
		public double R{get { return r; }}
		public double X{get { return x; }}
		public double Y { get { return y; } }
		public Circle(double x,double y,double r)
		{
			this.x = x;
			this.y = y;
			this.r = r;
		}
		public Circle() : this(0, 0, 1) { }
		public static bool CrossCircle(Circle a,Circle b)
		{
			bool res = false;
			double AB = Math.Sqrt((a.X - b.X) * (a.X - b.X) + (a.Y - b.Y) * (a.Y - b.Y));
			double R1_R2 = a.R + b.R;
			res = (R1_R2 >= AB) ? true : false;
			return res;
		}
		public override string ToString()
		{
			return $"\tCenter({X},{Y})\tR={R}";
		}
	}
}

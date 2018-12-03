using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figure
{
	public class Triangle:Point
	{
		public double A { get; set; }
		public double B { get; set; }
		public double C { get; set; }
		public Triangle(double x,double y,double a,double b ,double c)
		{
			base.X= x;
			base.Y = y;
			A = a;
			B = b;
			C = c;

		}
		public override double Area => Math.Sqrt(P*(P-A)*(P-C)*(P-B)) ;
		//Perimetr
		public double P { get { return (A + B + C) / 2; } }
		public override string ToString()
		{
			return "I'm Triangle\n"+$"Area = {Area:F3}";
		}

	}
}

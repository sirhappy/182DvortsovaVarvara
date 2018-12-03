using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
	public class Circle:Point
	{
		double rad;
		public double Rad
		{
			get { return rad; }
		}
		public virtual void Display()
		{
			Console.WriteLine("{rad}");
		}
		public Circle(double x,double y,double rad)
		{
			base.X = x;
			base.Y = y;
			this.rad = rad;
		}
		public override double Area { get { return 2*rad*rad * Math.PI; } }
		public virtual double Len { get { return 2 * rad * Math.PI; } }
	}
}

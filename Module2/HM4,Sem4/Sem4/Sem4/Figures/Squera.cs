using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
	public class Squera:Point
	{
		double side;
		public double Side
		{
			get { return side; }
			
		}
		public virtual void Display()
		{
			Console.WriteLine($"{Side}");
		}
		public Squera(double x,double y,double side)
		{
			X = x;
			Y = y;
			this.side = side;
		}
		public override double Area { get { return side*side; } }
		public virtual double Len { get { return 4*side; } }
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figure
{
	public class Circle:Point
	{
		double _rad;
		public double Rad
		{
			get
			{
				return _rad;
			}
			set
			{
				_rad = value;
			}
		}

		public Circle(double x, double y, double rad)
		{
			X = x;
			Y = y;
			Rad = rad;
		}
		public override string ToString()
		{
			return "\nI am Circle:)\n"+ $"Area ={Area}";
		}
		
		public double Len
		{
			get
			{
				return 2 * Math.PI * Rad;
			}
		}
		public override double Area
		{
			get { return Math.PI *Rad*Rad; }
		}
	}
}

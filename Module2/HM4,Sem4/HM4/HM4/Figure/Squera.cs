using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figure
{
	public class Squera:Point
	{
		double _side;
		public double Side { get { return _side; } }
		public Squera(double x ,double y ,double side)
		{
			X = x;
			Y = y;
			_side = side;
		}
		public override string ToString()
		{
			return "\nI am Squere:)\n"+ $"Area = {Area:F3} ";
		}
		
		public override double Area
		{
			get { return Side * Side; }
		}
		public  double Len
		{
			get { return Side * 4; }
		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
	public class Point
	{
		double _x;
		double _y;
		public double X { get { return _x; } set { _x = value; } }
		public double Y { get { return _y; } set { _y = value; } }
		public virtual void DisPlay()
		{
			Console.Writeline($"X = {_x}, Y ={_y}");
		}
		public virtual double  Area{ get{return 0;} }
	}
}

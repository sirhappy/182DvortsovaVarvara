using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figure
{
	public class Point
	{
	
		public double X { get; set; }
		public double Y { get; set; }
		public virtual  double Area { get { return 0; } }
		public override string ToString()
		{
			return $"x = {X},y={Y}";
		}
		
	}
}

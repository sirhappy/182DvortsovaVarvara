using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2
{
	public class Fun_3:Integrand
	{
		public Fun_3(double xmax,double xmin)
		{
			Xmax = xmax;
			Xmin = xmin;
		}
		public override double function(double x)
		{
			return Math.Cos(Math.Pow(x,3));
		}
	}
}

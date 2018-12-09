using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLib
{
	public class QuadraticTrinomial
	{
		
		public double A { get; set; }
		public double B { get; set; }
		public double C { get; set; }
		public QuadraticTrinomial(double a,double b ,double c)
		{
			A= a;
			B = b;
			C = c;
		}
		public double ValueInPoint(double x0)
		{
			return A * x0*x0 + B * x0 + C;
		}
		public double DevideTrinomal(double x0 ,QuadraticTrinomial fanc)
		{
			if(fanc.ValueInPoint(x0) == 0)throw new DivideByZeroException($"Divide by Zero\nIn x0 = {x0} value ==0");
			return ValueInPoint(x0) / fanc.ValueInPoint(x0);

		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task03
{
	class Complex
	{
		
		private double _a, _b;
		public Complex(Complex c)
		{
			_a = c.Re();
			_b = c.Lm();
		}
		public Complex(double a, double b)
		{
			_a = a;
			_b = b;
		}
		public double Re()
		{
			return _a;
		}
		public double Lm()
		{
			return _b;
		}
		public double Abs()
		{
			return Math.Abs(_a + _b * Math.Sqrt(-1));
		}
		public double Arg()
		{
			return _a + _b * Math.Sqrt(-1);
		}
		public double Sum(Complex a ,Complex b)
		{
			return a._a +b._a +( a._b +b._b)* Math.Sqrt(-1);
		}
		public double Sum(double a, Complex b)
		{
			return a + b._a +b._b * Math.Sqrt(-1);
		}
		public double Sum(Complex a, double b)
		{
			return b + a._a + a._b * Math.Sqrt(-1);
		}

	}
	class Program
	{
		static void Main(string[] args)
		{
		}
	}
}

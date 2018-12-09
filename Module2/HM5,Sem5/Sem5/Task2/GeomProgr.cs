using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
	class GeomProgr
	{
		static int objectNumber ;
		double _b;
		double _q;
		public double B
		{
			set { if (value == 0) { throw new ArgumentException("B menishe 0!!"); }
				_b = value;
			}
			get { return _b; }
		}
		public double Q
		{
			set
			{
				if (value == 0) { throw new ArgumentException("Q must be more than Zero"); }
				_b = value;
			}
			get { return _b; }
		}
		
		public GeomProgr(double b,double q)
		{
			B = b;
			Q = q;
			objectNumber++;
		}
		public double GetSum(int n)
		{
			if (Q == 1) return n * B;
			return B * Math.Pow(Q, n - 1) / (Q - 1);
			// OverFlow
		}
		public GeomProgr() : this(1, 1) { }
		public double this[int index]
		{
			get {
				


				return B * Math.Pow(Q, index - 1); }
		}

	}
}

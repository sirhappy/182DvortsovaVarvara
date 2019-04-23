using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FractionSum
{
	public class DecimalFraction
	{
		double decFraction = 0;

		public DecimalFraction(double numb)
		{
			DecFraction = numb;
		}

		public DecimalFraction(Fraction fraction)
		{
			DecFraction = fraction.Num / fraction.Den;
		}

		public double DecFraction { get => decFraction; set => decFraction = value; }

	}
}

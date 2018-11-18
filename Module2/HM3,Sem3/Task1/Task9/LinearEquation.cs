using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task9
{
	class LinearEquation
	{
		double a, b, c;

		public LinearEquation(double a,double b ,double c)
		{
			this.a = a;
			this.c = c;
			this.b = b;
			if (!isCorrect(this.a)) throw new ArgumentException();
		}
		public LinearEquation() : this(1, 0, 0) { }
		public double A { get { return a; } }
		public double B { get { return b; } }
		public double C { get { return c; } }
		public double Root
		{
			get { return (double)(C - B) / A; }

		}
		public bool isCorrect(double a)
		{
			bool isCorrect = false;
			if (a == 0) isCorrect = false;
			else isCorrect = true;
			return isCorrect;
		}
		public override string ToString()
		{
			return $"{A}x + {B} = {C} , root is {Root:f3} ";
		}

	}
}

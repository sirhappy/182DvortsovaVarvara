using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*класс комплексных*/
namespace NumericLibrary
{
	public class Complex:Pair
	{
		public Complex(int x, int y) : base(x, y) { }
		public override Pair Add(Pair b)
		{
			Complex sum = new Complex(X + b.X, Y + b.Y);
			Pair sum_end = sum;
			return sum_end;
		}
		public override Pair Sub(Pair b)
		{
			Complex sub = new Complex(X - b.X, Y- b.Y);
			Pair sub_end =sub;
			return sub_end;
		}
		public override Pair Mult(Pair b)
		{
			int mult_i = X * b.Y +Y * b.X;
			int mult_r = X * b.X  -(Y * b.Y);
			Complex sub = new Complex(X - mult_r, mult_i);
			Pair sub_end = sub;
			return sub_end;
		}
		/// <summary>
		/// переопределенный PairEqual(Pair b)
		/// </summary>
		/// <param name="b"></param>
		/// <returns></returns>
		public override int PairEqual(Pair b)
		{
			double myabs = Math.Abs(X * X + Y * Y);
			double b_abs = Math.Abs(b.X * b.X + b.Y * b.Y);
			if (myabs == b_abs) return 0;
			else if (myabs < b_abs )return -1;
			return 1;
		}
		public override string ToString()
		{
			return $"{X} + {Y}*i ";
		}

	}
}

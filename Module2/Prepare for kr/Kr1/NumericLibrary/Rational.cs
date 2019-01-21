using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumericLibrary
{
	public class Rational:Pair
	{
		public Rational(int x ,int y) : base(x, y)
		{
			if (y == 0) throw new ArgumentOutOfRangeException();
			
		}
		public override Pair Add(Pair b)
		{
			if (Y == b.Y)
			{
				int sum = X + b.X;
				Rational sum_r = new Rational(sum, Y);
				Pair sum_p = sum_r;
				return sum_p;

			}
			else
			{
				int low = b.Y * Y;
				int high = X * b.Y + b.X * Y;
				Rational sum_r = new Rational(high, low);
				Pair sum_p = sum_r;
				return sum_p;
			}

 		}
		public override Pair Sub(Pair b)
		{
			if (Y == b.Y)
			{
				int sub = X - b.X;
				Rational sub_r = new Rational(sub, Y);
				Pair sub_p = sub_r;
				return sub_p;

			}
			else
			{
				int low = b.Y * Y;
				int high = X * b.Y - b.X * Y;
				Rational sub_r = new Rational(high, low);
				Pair sub_p = sub_r;
				return sub_p;
			}
		}
		public override Pair Mult(Pair b)
		{
			int low = b.Y * Y;
			int high = X * b.X;
			Rational sub_r = new Rational(high, low);
			Pair sub_p = sub_r;
			return sub_p;
		}
		public override string ToString()
		{
			return $"{X}/{Y}";
		}
		public Rational Reduse(Rational b)
		{
			if (Nod(b.X, b.Y) != 0)
			{

				return new Rational(b.X / Nod(b.X, b.Y), b.Y / Nod(b.X, b.Y));
			}
			else return b;
		}
		/// <summary>
		/// Переопределенный PairEqual(Pair b)
		/// </summary>
		/// <param name="b"></param>
		/// <returns></returns>
		public override int PairEqual(Pair b)
		{
			if (b.X*Y == b.Y*X) return 0;
			else if (b.X * Y < b.Y * X) return -1;
			return 1;
		}
		/// <summary>
		/// Нод числителя и знаменателя 
		/// </summary>
		/// <param name="n"></param>
		/// <param name="d"></param>
		/// <returns></returns>
		private static int Nod(int n, int d)
		{
			n = Math.Abs(n);
			d = Math.Abs(d);
			while (d != 0 && n != 0)
			{
				if (n % d > 0)
				{
					var temp = n;
					n = d;
					d = temp % d;
				}
				else break;
			}
			if (d != 0 && n != 0) return d;
			return 0;
		}
	}
}

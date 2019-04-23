using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task05
{
	public class Interval
	{
		int xmin;
		int xmax;

		public Interval(Interval interval)
		{
			Xmin = interval.Xmin;
			Xmax = interval.Xmax;
		}

		public Interval(int xmin, int xmax)
		{
			Xmin = xmin;
			Xmax = xmax;
		}

		public int Xmin { get => xmin; set => xmin = value; }
		public int Xmax { get => xmax; set => xmax = value; }
		public int Len
		{
			get => len; set {
				len = Xmax - Xmin;


			}
		}

		int len;

		public override string ToString()
		{
			return $"[{Xmin},{Xmax}]";
		}

		public static Interval operator +(Interval interval1,Interval interval2)
		{
			return new Interval(interval1.xmin + interval2.xmin, interval1.Xmax + interval2.Xmax);
		}
		public static Interval operator -(Interval interval1, Interval interval2)
		{
			return new Interval(interval1.xmin - interval2.xmin, interval1.Xmax - interval2.Xmax);
		}
		public static Interval operator *(Interval interval1, Interval interval2)
		{
			int min = Math.Min(Math.Min(interval1.xmin * interval2.xmin, interval1.Xmax * interval2.Xmax),Math.Min( interval1.Xmax * interval2.Xmin, interval1.xmin * interval2.Xmax));
			int max = Math.Max(Math.Max(interval1.xmin * interval2.xmin, interval1.Xmax * interval2.Xmax), Math.Max(interval1.Xmax * interval2.Xmin, interval1.xmin * interval2.Xmax));
			return new Interval(min,max);
		}
		public static Interval operator /(Interval interval1, Interval interval2)
		{
			int min = Math.Min(Math.Min(interval1.xmin / interval2.xmin, interval1.Xmax / interval2.Xmax), Math.Min(interval1.Xmax / interval2.Xmin, interval1.xmin / interval2.Xmax));
			int max = Math.Max(Math.Max(interval1.xmin / interval2.xmin, interval1.Xmax / interval2.Xmax), Math.Max(interval1.Xmax / interval2.Xmin, interval1.xmin / interval2.Xmax));
			return new Interval(min, max);
		}
	}
}

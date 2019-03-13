using System;
using System.Collections.Generic;
using System.Text;

namespace Structures
{
	public struct Circle:IComparable<Circle>
	{
		int rad;//радиус

		public int Rad { get => rad; set => rad = value; }
		public PointS Center { get => center; set => center = value; }

		PointS center;//центр

		public Circle(int rad, int x, int y) : this()
		{
			Rad = rad;
			//отношение композиции
			Center = new PointS(x, y);
		}

		public double LengthCircle { get => 2 * Math.PI * Rad; }
		public override string ToString()
		{
			return $"RAd = {Rad} Center = {Center}";
		}

		public int CompareTo(Circle other)
		{
			if (other.Rad > this.Rad) return 1;
			if (other.Rad < this.Rad) return -1;
			return 0;
		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ
{
	/// <summary>
	/// равносторонний треугольник
	/// </summary>
	public class Rectangle : Figure,ISquera
	{
		public Rectangle(double a)
		{
			A = a;
		}

		public double A { get; set; }
		
		public double Squera { get => A * A * Math.Pow(3, 1 / 2) / 4; }

		public override string ToString()
		{
			return base.ToString()+$" Rectangle a = {A} ";
		}
	}
}

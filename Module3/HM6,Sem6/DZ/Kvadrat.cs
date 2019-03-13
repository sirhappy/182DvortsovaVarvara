using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ
{
	public class Kvadrat : Figure, ISquera
	{
		public Kvadrat(double a, double b)
		{
			A = a;
			B = b;
		}

		public double A { get; set; }
		public double B { get; set; }

		public double Squera => A*B;

		public override string ToString()
		{
			return base.ToString()+$" Kvadrat  S = {Squera} A= {A} B ={B}";
		}
	}
}

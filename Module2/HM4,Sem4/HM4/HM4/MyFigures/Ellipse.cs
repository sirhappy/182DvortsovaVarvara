using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFigures
{
	public class Ellipse:Dimensions
	{
		public Ellipse(double X,double Y) : base(X, Y) { }
		public override double Area => (Math.PI*DimX*DimY)/4;
		public override string description()
		{
			return $"elips x = {DimX}, y = {DimY} ,Area ={Area}";
		}
		public override string Record => $"Эллипс\t{DimX}\t{DimY}";
	}
}

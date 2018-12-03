using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFigures
{
	public class Triangle:Dimensions
	{
		public Triangle(double x, double y) : base(x, y) { }
		public override double Area => DimX*DimY/2;
		override public string description()
		{
			return $"Треугольник x = {DimX} , y = {DimY},Area = {Area}";
		}
		public override string Record => $"Треугольник\t{DimX}\t{DimY}";
	}
}

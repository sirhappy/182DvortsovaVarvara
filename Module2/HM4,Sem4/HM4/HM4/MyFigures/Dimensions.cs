using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFigures
{
	 abstract public class Dimensions
	{
		public double DimX { get; set; }
		public double DimY { get; set; }
		public Dimensions(double dimX,double dimY)
		{
			DimY = dimY;
			DimX = dimX;
		}
		public void  GhengeGabarits(int k)
		{
			DimX *= k;DimY *= k;
		}
		abstract public string description();
		abstract public double Area { get; }
		abstract public string Record { get; }
	}
}

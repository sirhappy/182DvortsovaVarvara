using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	public class Circle
	{
		double rad;

		public double Rad { get => rad; set => rad = value; }
		internal Point Center { get => center; set => center = value; }

		Point center  ;

		public Circle(double rad,double x,double y)
		{
			Center = new Point(x,y);
			Rad = rad;
		}
		public override string ToString()
		{
			return $"Rad= {Rad} X = {Center.X} Y ={Center.Y}";
		}
	}
}

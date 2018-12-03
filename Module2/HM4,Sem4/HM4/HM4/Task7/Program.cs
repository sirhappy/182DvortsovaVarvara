using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyFigures;

namespace Task7
{
	class Program
	{
		static void Main(string[] args)
		{
			Ellipse e = new Ellipse(3, 8);
			Console.WriteLine(e.description());
			e.GhengeGabarits(10);
			Console.WriteLine(e.description());
			Triangle t = new Triangle(5, 4);
			Console.WriteLine(t.description());
			Dimensions[] fig = new Dimensions[4];
			fig[0] = e;
			fig[1] = t;
			fig[2] = new Ellipse(4, 6);
			fig[3] = new Triangle(2, 8);
			foreach (Dimensions d in fig)
				Console.WriteLine(d.description());
			Console.Read();



		}
	}
}

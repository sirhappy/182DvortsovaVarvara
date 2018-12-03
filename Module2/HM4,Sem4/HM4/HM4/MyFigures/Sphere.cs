﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFigures
{
	public class Sphere : Shape
	{
		public Sphere(double r) : base(r, 0)
		{
		}

		public override double Area()
		{
			return 4 * PI * x * x;
		}
	}
}

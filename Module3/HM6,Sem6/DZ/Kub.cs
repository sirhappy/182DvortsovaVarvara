using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ
{
	public class Kub : Figure, IVolume
	{
		public Kub(double h)
		{
			H = h;
		}

		public double H { get; set; }
		public double Volume { get => H * H * H; }

		public override string ToString()
		{
			return base.ToString()+$"Kub V = {Volume} H= {H}";
		}
	}
}

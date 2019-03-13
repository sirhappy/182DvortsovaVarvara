
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Form2
{
	public class Estimates
	{
		double xMin;
		double xMax;
		double numb;
		double sumX;
		double sumX2;

		public Estimates()
		{
		}
		public void Add() { }

		public double XMin { get => xMin; set => xMin = value; }
		public double XMax { get => xMax; set => xMax = value; }
		public double Numb { get => numb; set => numb = value; }
		public double SumX { get => sumX; set => sumX = value; }
		public double SumX2 { get => sumX2; set => sumX2 = value; }
		public double Average
		{
			get;set;
		}
		public double Deviation
		{
			get; set;
		}


	}
}
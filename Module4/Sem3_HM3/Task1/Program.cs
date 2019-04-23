using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
	class myComplex
	{
		public double re, im;
		public myComplex(double xre, double xim)
		{
			re = xre;
			im = xim;
		}

		// почему так делать не стоит?
		public static myComplex operator --(myComplex mc)
		{
			mc.re--;
			mc.im--;
			return mc;
		}

		public double Mod()
		{
			return Math.Abs(re * re + im * im);
		}
		static public bool operator true(myComplex f)
		{
			if (f.Mod() > 1.0) return true;
			else return false;
		}
		static public bool operator false(myComplex f)
		{
			if (f.Mod() <= 1.0) return true;
			else return false;
		}
		public static myComplex operator +(myComplex f,myComplex d)
		{
			return new myComplex(f.re + d.re, d.im + f.im);
		}
		public static myComplex operator -(myComplex f,myComplex d)
		{
			return new myComplex(f.re + d.re, d.im + f.im);
		}
		public static myComplex operator *(myComplex f, myComplex d)
		{
			return new myComplex(f.re * d.re - d.im * f.im, f.re * d.re + d.im * f.im);

		}
		
		public static myComplex operator /(myComplex f, myComplex d)
		{
			return new myComplex((f.re * d.re + d.im * f.im)/(f.re*f.re +d.re*d.re), (d.re * f.re - d.im * f.im) / (f.re * f.re + d.re * d.re));

		}

	}

	class Program
	{
		static void display(myComplex cs)
		{
			Console.WriteLine("real=" + cs.re + ", image=" + cs.im);
		}
		static void Main(string[] args)
		{

			Console.ReadLine();
		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
	/// <summary>
	/// класс квадратных многочленов вида ax^2 +bx + c,где a,b,c принадлежат R.
	/// </summary>
	public class Polynominal2
	{
		double a;
		double b;
		double c;

		public Polynominal2(Polynominal2 polynominal)
		{
			A = polynominal.A;
			B = polynominal.B;
			C = polynominal.C;
		}

		public Polynominal2(double a, double b, double c)
		{
			A = a;
			B = b;
			C = c;
		}

		public double A { get => a; set => a = value; }
		public double B { get => b; set => b = value; }
		public double C { get => c; set => c = value; }

		public double Value(double x)
		{
			return A * x * x + B * x + C * x;
		}

		public override string ToString()
		{
			return $"f(x) = {A}x^2 + {B}x + {C}";
		}
		/// <summary>
		/// Сложение многочленов
		/// </summary>
		/// <param name="polynominal1"></param>
		/// <param name="polynominal2"></param>
		/// <returns></returns>
		public static Polynominal2 operator +(Polynominal2 polynominal1, Polynominal2 polynominal2)
		{
			double a = polynominal1.A + polynominal2.A;
			double b = polynominal1.B + polynominal2.B; ;
			double c = polynominal1.C + polynominal2.C; ;

			return new Polynominal2(a, b, c);
		}

		public static Polynominal2 operator -(Polynominal2 polynominal1, Polynominal2 polynominal2)
		{
			double a = polynominal1.A - polynominal2.A;
			double b = polynominal1.B - polynominal2.B;
			double c = polynominal1.C - polynominal2.C;

			return new Polynominal2(a, b, c);
		}
		public static Polynominal2 operator *(Polynominal2 polynominal1, double dob)
		{
			double a = polynominal1.A * dob;
			double b = polynominal1.B * dob;
			double c = polynominal1.C * dob;

			return new Polynominal2(a, b, c);
		}
		public static Polynominal2 operator /(Polynominal2 polynominal1, double dob)
		{
			double a = polynominal1.A / dob;
			double b = polynominal1.B / dob;
			double c = polynominal1.C / dob;

			return new Polynominal2(a, b, c);
		}



	}
}

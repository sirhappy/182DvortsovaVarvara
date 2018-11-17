using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task03
{
	class Complex
	{
		
		
		
		public Complex(Complex c):this(c.Re,c.Lm)//копирующий конструктор
		{
		}
		public Complex(double a, double b)//конструктор принимающий действительную и мнимую части
		{
			Re = a;
			Lm = b;
		}
		public double Re//возвращает действ часть
		{ get; set; }
		public double Lm//возвращает мнимую часть
		{get ;set ;}
		public double Abs()//модуль комплексного числа
		{
			return Math.Sqrt(Re*Re + Lm *Lm);
		}
		public double Arg()//аргумент модульного числа
		{
			return Math.Tan(Re/ Lm );
		}
		public static Complex Sum(Complex a ,Complex b)//сумма двух комлексных
		{
			return new Complex((a.Re +b.Re),( a.Lm +b.Lm));
		}
		public static Complex Sum(double a, Complex b)//сумма дабл и комплексного
		{
			return new Complex(a + b.Re ,b.Lm );
		}
		public static Complex Sum(Complex a, double b)//сумма наоборот
		{
			return new Complex(b + a.Re ,a.Lm);
		}
		public static Complex Difference(Complex a,Complex b)//разность двух комплексных
		{
			return new Complex((a.Re - b.Re) , (a.Lm + b.Lm) );
		}
		public static Complex Difference(double a, Complex b)
		{
			return new Complex(a - b.Re , b.Lm);
		}
		public static Complex Difference(Complex a, double b)
		{
			return  new Complex(a.Re -b, a.Lm);
		}
		public static Complex Mult(Complex a, Complex b)//умножение
		{
			return new Complex(a.Re * b.Re, a.Lm * b.Lm);
		}
		public static Complex Mult(double a, Complex b)
		{
			return new Complex(a * b.Re,  b.Lm);
		}
		public static Complex Mult(Complex a, double b)
		{
			return new Complex(a.Re* b, a.Lm);
		}
		public static Complex Div(Complex a, Complex b)//деление
		{
			return new Complex((a.Re*b.Re + b.Lm*a.Lm)/(a.Lm*a.Lm + b.Lm*b.Lm), (a.Re * b.Re - b.Lm * a.Lm) / (a.Lm * a.Lm + b.Lm * b.Lm));
		}

		public override string ToString()//переопределенный метод тустринг
		{
			return $"{Re:f3} +{Lm:f3}*i";
		}
	}
	class Program
	{
		static void Main(string[] args)
		{
			do {
				Complex number1 = new Complex(1, 2);
				Complex number2 = new Complex(3, 4);
				double f = 5;
				Console.WriteLine("f=" + f.ToString());
				Console.WriteLine("namber1 = "+number1.ToString());
				Console.WriteLine("number1.Abs() = " + number1.Arg().ToString("f3"));
				Console.WriteLine("number2 = "+number2.ToString());
				Console.WriteLine("number2.Arg() = " + number2.Arg().ToString("f3"));

				Complex sum = Complex.Sum(number1, number2);
				Console.WriteLine("Sum(number1, number2) = " + sum.ToString());
				Complex dif1 = Complex.Difference(number1, number2);
				Console.WriteLine("Complex.Difference(number1, number2) = "+dif1.ToString());
				Complex mult1 = Complex.Mult(number1, number2);
				Console.WriteLine("Complex.Mult(number1, number2) = " + mult1.ToString());
				Complex div1 = Complex.Div(number1, number2);
				Console.WriteLine("Complex.Div(number1, number2) = " + div1.ToString());
				Complex sum2 = Complex.Sum(f, number1);
				Console.WriteLine("Complex.Sum(f, number1) = " + sum2.ToString());
				Complex def5 = Complex.Difference(number1, number2);
				Console.WriteLine("Complex.Difference(number1, number2) = " +def5.ToString());
				Complex number3 = new Complex(number1);
				Console.WriteLine("number3 = " + number3.ToString());
			} while (Console.ReadKey().Key!=ConsoleKey.Escape);
		}
	}
}

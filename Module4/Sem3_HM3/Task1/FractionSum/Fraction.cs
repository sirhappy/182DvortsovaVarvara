using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FractionSum
{
	public class Fraction
	{
		int num;    //.. числитель
		int den;    //.. знаменатель

		public int Num { get => num; set => num = value; }
		public int Den { get => den; set => den = value; }

		public Fraction(int n, int d)
		{ //  Конструктор
			if (n >= 0 && d > 0) { Num = n; Den = d; return; }
			if (n >= 0 && d < 0) { Num = -n; Den = -d; return; }
			if (n <= 0 && d > 0) { Num = n; Den = d; return; }
			if (n <= 0 && d < 0) { Num = -n; Den = -d; return; }
			Console.WriteLine("Нулевой знаменатель: {0}/{1}", n, d);
			return;
		}
		public override string ToString()
		{
			return String.Format("{0}/{1}", Num, Den);
		}

		static public Fraction operator -(Fraction f)
		{ // унарный минус
			return new Fraction(-f.Num, f.Den);
		}
		static public Fraction operator +(Fraction f1, Fraction f2)
		{
			int n = f1.Num * f2.Den + f1.Den * f2.Num;
			int d = f1.Den * f2.Den;
			return new Fraction(n, d);
		}
		static public Fraction operator -(Fraction f1, Fraction f2)
		{
			int n = f1.Num * f2.Den - f1.Den * f2.Num;
			int d = f1.Den * f2.Den;
			return new Fraction(n, d);
		}
		static public Fraction operator *(Fraction f1, Fraction f2)
		{
			int n = f1.Num * f2.Num;
			int d = f1.Den * f2.Den;
			return new Fraction(n, d);
		}
		static public Fraction operator /(Fraction f1, Fraction f2)
		{
			int n = f1.Num * f2.Den;
			int d = f1.Den * f2.Num;
			return new Fraction(n, d);
		}
		static public bool operator <(Fraction f1, Fraction f2)
		{
			if (f1.Num * f2.Den < f1.Den * f2.Num) return true;
			else return false;
		}
		static public bool operator >(Fraction f1, Fraction f2)
		{
			if (f1.Num * f2.Den > f1.Den * f2.Num) return true;
			else return false;
		}

		static public Fraction operator ++(Fraction fraction)
		{
			return new Fraction(fraction.Num + fraction.Den, fraction.Den);
		}
		static public Fraction operator --(Fraction fraction)
		{
			return new Fraction(fraction.Num - fraction.Den, fraction.Den);
		}
		/// <summary>
		/// Метод переводящий десятичные в простые дроби 
		/// </summary>
		public void ToDecimal(DecimalFraction decimalFraction)
		{
			int num=0, del=0;
			ParsDouble(decimalFraction.DecFraction, ref num, ref del);
			this.Num = num;this.Den = del;
		}
		internal void ParsDouble(Double number,ref int num,ref int del)
		{
			string[] numb = number.ToString().Split(new char[] { ',' },StringSplitOptions.RemoveEmptyEntries);
			num = (int)(number * (int)Math.Pow(10, numb[1].Length));
			del = (int)Math.Pow(10, numb[1].Length);
		}
	}// End of class Fraction
}

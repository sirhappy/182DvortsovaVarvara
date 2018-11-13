using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
	class Circle
	{
		double _r;
		public double R
		{
			get
			{
				return _r;
			}
			set
			{
				if (value <= 0)
				{
					throw new ArgumentOutOfRangeException($"{nameof(value)} must be more than 0");
				}
				_r = value;
			}
		}
		public Circle(double r)
		{
			R = r;
		}
		public Circle() : this(1) { }
		public double S
		{
			get { return Math.PI * R * R; }
		}

	}
	class Program
	{
		public static double EnterDouble(string message,double maxvalue = 500)
		{
			double res;
			bool isCorrect = false;
			do {
				Console.Write(message);
				while(!double.TryParse(Console.ReadLine(),out res) ||res>maxvalue)
				{
					Console.Error.WriteLine("Error.../n Try again");
					Console.Write(message);
				}

				isCorrect = true;
			} while (!isCorrect);
			return res;
		}
		static void Main(string[] args)
		{
			do {
				Console.Clear();
				double Rmin = EnterDouble("Введите нижнюю границу = ");
				double Rmax = EnterDouble("Введите верхнюю границу = ");
				double delta = EnterDouble("Введите шаг  = ");
				for(double i = Rmin; i < Rmax; i += delta)
				{
					Circle c = new Circle(i);
					Console.WriteLine($" r = {i} S = {c.S:F3}");
				}

				Console.WriteLine("To exit press ESC.../n To continue press any keyword");
			} while (Console.ReadKey().Key != ConsoleKey.Escape);
		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
	class Point
	{


		public double X { get; set; }
		public double Y { get; set; }

		public double Ro
		{
			get
			{
				return Math.Sqrt(X * X + Y * Y);
			}
		}

		public double Fi
		{
			get
			{
				if (X > 0 & Y > 0)
				{
					return Math.Atan(Y / X);
				}
				else if (X > 0 & Y < 0)
				{
					return Math.Atan(Y / X) + 2 * Math.PI;
				}
				else if (X < 0)
				{
					return Math.Atan(Y / X) + Math.PI;
				}
				else if(X == 0& Y > 0)
				{
					return Math.PI / 2;
				}
				else if (X == 0 & Y < 0)
				{
					return Math.PI*3 / 2;
					
				}
				else
				{
					return 0;
				}
			}
		}
	
		public double F { get; }
		public Point() : this(0, 0) { }
		public Point(double y ,double x)
			{
				Y = y;
				X = x;
			}
		public string GetInfo
		{
			// СВОЙСТВО
			get
			{
				string maket = "X = {0:F2}; Y = {1:F2}; Ro = {2:F2}; Fi = {3:F2} ";
				return string.Format(maket, X, Y, Ro, Fi);
			}

		}
	}
	class Program
	{
		static double EnterDouble(string message)
		{
			double res;
			bool isCorrect = false;
			do {

				Console.Write(message);
				while(!double.TryParse(Console.ReadLine(),out res) || res > 1000)
				{
					Console.Error.WriteLine("Error");
					Console.Write(message);

				}

				isCorrect = true;
			} while (!isCorrect);
			return res;
		}
		static void Main(string[] args)
		{
			
			Point a = new Point(10,10);
			Console.WriteLine(a.GetInfo);
			Point b = new Point(30,30);
			Console.WriteLine(b.GetInfo);
			
			Point c = new Point();
			double x, y;
			do
			{
				
				x = EnterDouble("X = ");
				y  = EnterDouble("Y = ");
				c.X = x; c.Y = y;
				// #TODO3: следующий слайд
			} while (x != 0 | y != 0);
			



			
			
			Console.ReadKey();


		}
	}
}

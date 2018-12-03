using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{

	public class Point
	{
		double _x;
		double _y;
		public double X { get { return _x; } set { _x = value; } }
		public double Y { get { return _y; } set { _y = value; } }
		public virtual void DisPlay()
		{
			Console.WriteLine($"X = {_x}, Y ={_y}");
		}
		public virtual double Area { get { return 0; } }
	}
	public class Circle : Point
	{
		double rad;
		public double Rad
		{
			get { return rad; }
		}
		public virtual void Display()
		{
			Console.WriteLine($"{rad},X={X},Y={Y}");
		}
		public Circle(double x, double y, double rad)
		{
			base.X = x;
			base.Y = y;
			this.rad = rad;
		}
		public override double Area { get { return 2 * rad * rad * Math.PI; } }
		public virtual double Len { get { return 2 * rad * Math.PI; } }
	}
	public class Square : Point
	{
		double side;
		public double Side
		{
			get { return side; }

		}
		public virtual void Display()
		{
			Console.WriteLine($"{Side}");
		}
		public Square(double x, double y, double side)
		{
			X = x;
			Y = y;
			this.side = side;
		}
		public override void DisPlay()
		{
			Console.WriteLine($"{side},X={X},Y={Y}");
		}
		public override double Area { get { return side * side; } }
		public virtual double Len { get { return 4 * side; } }
	}
	class Program
	{
		public static Random rnd = new Random();
		public static Point[][] FigArray(int n)
		{
			Point[][] arr = new Point[n][];
			for(int i = 0; i < arr.Length; i++)
			{
				arr[i] = new Point[rnd.Next(0, 10)];
				for(int j = 0; j < arr[i].Length; j++)
				{
					if (rnd.Next(0, 1) == 0)
						arr[i][j] = new Circle(rnd.Next(10, 100), rnd.Next(10, 100), rnd.Next(10, 100));
					else arr[i][j] = new Square(rnd.Next(10, 100), rnd.Next(10, 100), rnd.Next(10, 100));

				}
				
			}

			return arr;
		}

		static void Main(string[] args)
		{
			Point p = new Point();
			p.DisPlay();
			Console.WriteLine("p.Area для Point = " + p.Area);
			p = new Circle(1, 2, 6);
			p.DisPlay();
			Console.WriteLine("p.Area для Circle = " + p.Area);
			p = new Square(3, 5, 8);
			p.DisPlay();
			Console.WriteLine("p.Area для Square = " + p.Area);
			Console.ReadLine();
		}
	}
}

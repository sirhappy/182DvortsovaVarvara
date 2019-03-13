using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
	public class Circle
	{
		private Coords centr;
		private double radius;

		public Circle(double a, double b, double c)
		{
		}

		public Circle(Coords centr, double radius)
		{
			Centr = centr;
			Radius = radius;
		}
		public override string ToString()
		{
			return $"centr = {Centr} Radius = {Radius}";
		}

		public Coords Centr { get => centr; set => centr = value; }
		public double Radius
		{
			get => radius; set
			{

				if (value < 0)
					throw new ArgumentException("Radius must be more than 0!");

				radius = value;
			}
		}


	}
	public struct Coords
	{
		public Coords(double x, double y) : this()
		{
			X = x;
			Y = y;
		}

		public double X { get; set; }
		public double Y { get; set; }
		public override string ToString()
		{
			return $"X = {X:F4} Y = {Y:F4}";
		}

	}
	public class Rectangl:IComparable
	{
		public Rectangl(Coords leftHighAngle, Coords rightLowAngle)
		{
			if (leftHighAngle.X > rightLowAngle.X || leftHighAngle.Y < rightLowAngle.X)
				throw new ArgumentException("Incorrect data!");
			LeftHighAngle = leftHighAngle;
			RightLowAngle = rightLowAngle;
		}

		public Coords LeftHighAngle { get; set; }
		public Coords RightLowAngle { get; set; }
		public double Squera { get {
				return (double)Math.Abs((RightLowAngle.X - LeftHighAngle.X) * (LeftHighAngle.Y - RightLowAngle.Y));

			} }

		public int CompareTo(object obj)
		{
			dynamic Dobj = obj;
			if (((Rectangl)Dobj).Squera > this.Squera) return 1;
			if (((Rectangl)Dobj).Squera < this.Squera) return -1;
			return 0;
		}
		public override string ToString()
		{
			return $"LeftHighAngle = {LeftHighAngle} RightLowAngle = {RightLowAngle} " +
				$"Squera = {Squera:F4}";
		}
	}
	class Program
	{
		static void Main(string[] args)
		{
			do
			{
				bool check = false;
				Random rnd = new Random();
				Rectangl[] arr = new Rectangl[20];
				for (int i = 0; i < arr.Length; i++)
				{
					check = false;
					while (!check)
					{
						try
						{
							arr[i] = new Rectangl(new Coords((double)rnd.Next(10,20)+ rnd.NextDouble(), 
								(double)rnd.Next(10, 20) + rnd.NextDouble()), new Coords((double)rnd.Next(10, 20) +rnd.NextDouble(), (double)rnd.Next(10, 20) + rnd.NextDouble()));
							check = true;
						}
						catch (Exception)
						{
						}

					}
				}
				Array.ForEach(arr, e => Console.WriteLine(e));
				Array.Sort(arr, (a, b) => b.CompareTo(a));
				Console.WriteLine("After sort");

				Array.ForEach(arr, e => Console.WriteLine(e));

			} while (Console.ReadKey().Key!=ConsoleKey.Escape);
		}
	}
}

﻿using System;

namespace Task03
{
	interface IFigure
	{
		double GetArea { get; }
		string ToString();
	}
	public class Square : IFigure
	{
		int a;
		public Square(int a)
		{
			this.a = a;
		}
		public override string ToString()
		{
			return "Квадрат со стороной " + a;
		}
		public double GetArea
		{
			get { return a * a; }
		}
	}

	public class Circle : IFigure
	{
		int R;
		public Circle(int r) { R = r; }
		public double GetArea
		{
			get { return Math.PI * R * R; }
		} 
		public override string ToString()
		{
			return "Круг радиуса " + R;
		} 
	} 
	class Methods
	{
		public static void PorArea<T>(T[] mass, double Porog)
							where T : IFigure
		{
			foreach (T el in mass)
				if (el.GetArea > Porog)
					Console.WriteLine(el.ToString());
		}
	} 

	class Program
	{
		static void Main()
		{
			do
			{
				Console.Clear();
				Random Rnd = new Random();
				const int Dim = 7;
				Circle[] MassCircles = new Circle[Dim];
				Square[] MassSquares = new Square[Dim];
				for (int i = 0; i < Dim; i++)
				{
					MassCircles[i] = new Circle(Rnd.Next(10));
					MassSquares[i] = new Square(Rnd.Next(10));
				}
				Methods.PorArea(MassCircles, 30);
				Methods.PorArea(MassSquares, 4);
				Console.WriteLine("Нажмите Enter для повтора, любую другую клавишу для выхода.");
			} while (Console.ReadKey().Key == ConsoleKey.Enter);
		}
	}
}
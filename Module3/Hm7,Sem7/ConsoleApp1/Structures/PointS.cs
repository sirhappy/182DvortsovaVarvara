using System;
using System.Collections.Generic;
using System.Text;

namespace Structures
{
	/// <summary>
	/// Структура точка на плоскости
	/// </summary>
	 public struct PointS
	{
		int x;
		int y;

		public PointS(int x, int y) : this()
		{
			X = x;
			Y = y;
		}
		public int Distance(PointS a,PointS b)
		{
			return (int)Math.Sqrt((a.X * a.X - b.X * b.X) + (a.Y * a.y - b.Y * b.Y));
		}
		public int X { get => x; set => x = value; }
		public int Y { get => y; set => y = value; }
		public override string ToString()
		{
			return $" X = {X} Y ={Y}";
		}
	}
}

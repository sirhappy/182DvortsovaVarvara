using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
	public class Point3D
	{
		int x;
		int y;
		int z;

		public Point3D(int x, int y, int z)
		{
			if (x < 0 || y < 0 || z < 0)
			{
				throw new ArgumentException("Кординаты должны быть строго больше нуля");
			}
			X = x;
			Y = y;
			Z = z;
		}

		public int X { get => x; set => x = value; }
		public int Y { get => y; set => y = value; }
		public int Z { get => z; set => z = value; }

		public static bool operator <(Point3D point1,Point3D point2)
		{
			if(Math.Sqrt(point1.X* point1.X+ point1.Y* point1.Y+ point1.Z* point1.Z )<
				Math.Sqrt(point2.X * point2.X + point2.Y * point2.Y + point2.Z * point2.Z ))
			{
				return true;
			}
			return false;
		}
		public static bool operator >(Point3D point1, Point3D point2)
		{
			if (Math.Sqrt(point1.X * point1.X + point1.Y * point1.Y + point1.Z * point1.Z) >
				Math.Sqrt(point2.X * point2.X + point2.Y * point2.Y + point2.Z * point2.Z))
			{
				return true;
			}
			return false;
		}


	}
}

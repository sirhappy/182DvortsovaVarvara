using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8
{
	class Triangle
	{
		Point x,y,z;
		public Triangle(Point x, Point y, Point z)
		{
			this.x = x;
			this.y = y;
			this.z = z;
			//bool TRingleExist = Triangleexist(this.x, this.y, this.z);
			//if (!TRingleExist)
			//{
			//	throw new ArgumentException();
			////}
		}
		public Triangle(){ }
		public Point X { get { return x; } }
		public Point Y { get { return y; } }
		public Point Z { get { return z; } }
		public double Perimetr
		{
			get
			{
				bool TRingleExist = Triangleexist(this.x, this.y, this.z);
				if (!TRingleExist)
				{
					return 0;
				}
				double AB = Math.Sqrt((x.X - y.X) * (x.X - y.X) + (x.Y - y.Y) * (x.Y - y.Y));
				double BC = Math.Sqrt((y.X - z.X) * (y.X - z.X) + (y.Y - z.Y) * (y.Y - z.Y));
				double AC = Math.Sqrt((x.X - z.X) * (x.X - z.X) + (x.Y - z.Y) * (x.Y - z.Y));
				return AB + BC + AC;
			}
		}
		public double Sqeare
		{
			get {
				bool TRingleExist = Triangleexist(this.x, this.y, this.z);
				if (!TRingleExist)
				{
					return 0;
				}
				return Math.Abs(1 / 2 * (x.X - z.X) * (y.Y - z.Y) - (y.X - z.X) * (x.Y - z.Y)); }
		}
		public bool Triangleexist(Point a,Point b,Point c)//Проверка треугольника на существование
		{
			bool Exist = false;
			double AB = Math.Sqrt((a.X - b.X) * (a.X - b.X) + (a.Y - b.Y) * (a.Y - b.Y));
			double BC = Math.Sqrt((b.X - c.X) * (b.X - c.X) + (b.Y - c.Y) * (b.Y - c.Y));
			double AC = Math.Sqrt((a.X - c.X) * (a.X - c.X) + (a.Y - c.Y) * (a.Y - c.Y));
			Exist = (AB + BC > AC) ? (BC + AC > AB ? (AB + AC > BC ? true : false) : false) : false;
			return Exist;
		}
		public override string ToString()
		{
			return $"A = ({this.X}) , B =({this.Y}) ,C = ({this.Z}) ,Perimetr = {this.Perimetr:f3} , Sqera = {this.Sqeare:f3}";
		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyFigures;

namespace Task4
{
	class Program
	{
		public static Random rnd = new Random();
		static void Main(string[] args)
		{
			do {
				Dictionary<Type, int> dict = new Dictionary<Type, int>();
				Console.Clear();
				int N1 = rnd.Next(3, 5);
				int N2 = rnd.Next(3, 5);
				int N3 = rnd.Next(3, 5);
				
				Shape[] sh = new Shape[N1 + N2 + N3];
				for (int i = 0; i < N1; i++)
				{
					sh[i] = new Circle(rnd.Next(1, 10));
					if (!dict.ContainsKey(sh[i].GetType()))
					{
						dict.Add(sh[i].GetType(), 0);
					}
					
				}
				for (int i = N1; i < N1 + N2; i++)
				{
					sh[i] = new Sphere(rnd.Next(1, 10));
					if (!dict.ContainsKey(sh[i].GetType()))
					{
						dict.Add(sh[i].GetType(), 2);
					}

				}
				for (int i = N1 + N2; i < N1 + N2 + N3; i++)
				{
					sh[i] = new Cylinder(rnd.Next(1, 10), rnd.Next(1, 10));
					if (!dict.ContainsKey(sh[i].GetType()))
					{
						dict.Add(sh[i].GetType(), 1);
					}
				}

				Console.WriteLine("*************************");
				foreach(Shape fig in sh)
				{
					Console.WriteLine(fig.Area());
				}
				Console.WriteLine("*************************");
				foreach (Shape fig in sh)
				{
					if (fig is Cylinder) Console.WriteLine($"Cylinder Area ={fig.Area():f3} ");
					else if(fig is Sphere) Console.WriteLine($"Sphere Area ={fig.Area():f3} ");
					else Console.WriteLine($"Circle Area ={fig.Area():f3} ");
				}
				Console.WriteLine("*************************");

				Array.Sort(sh, (Shape x, Shape y) => dict[x.GetType()].CompareTo(dict[y.GetType()]));
				for (int i = 0; i < sh.Length; i++)
				{
					Console.WriteLine(sh[i]);
				}



			} while (Console.ReadKey().Key != ConsoleKey.Escape);
			
		}
	}
}

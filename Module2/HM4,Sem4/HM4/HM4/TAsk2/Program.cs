using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Figure;
namespace TAsk2
{
	class Program
	{
		public static Random rnd = new Random();
		public static Point[] FigArray( )
		{
			
			int n1 = rnd.Next(0, 11);
			int n2 = rnd.Next(0, 11);
			int n3 = rnd.Next(0, 11);
			int n = n1 + n2 +n3;
			Point[] arr = new Point[n];
			for(int i = 0; i < n1; i++)
			{
				arr[i] = new Circle(rnd.Next(10, 100), rnd.Next(10, 100), rnd.Next(10, 100));
			}
			for(int i = n1; i < n2; i++) { arr[i] = new Squera(rnd.Next(10, 100), rnd.Next(10, 100), rnd.Next(10, 100)); }
			for (int i = n2; i < n; i++) { arr[i] = new Triangle(rnd.Next(10, 100), rnd.Next(10, 100), 3,5,4); }
			return arr;
		}
		static void Main(string[] args)
		{
			do
			{
				Console.Clear();
				Point[] arr = FigArray();
				double avarege = 0;
				int countCircle = 0;
				int countSquera = 0;
				int countTringle = 0;
				for (int i = 0; i < arr.Length; i++)
				{


					if (arr[i] is Circle)
					{
						countCircle++;
						avarege += arr[i].Area;
					}
					else if (arr[i] is Triangle) countTringle++;
					else countSquera++;

				}
				Console.WriteLine($"Число квадратов = {countSquera} \tЧисло кругов = {countCircle}\tЧисло треугольников = {countTringle}");
				
				Array.Sort(arr, (Point x, Point y) => x.Area.CompareTo(y.Area));//сортируем по площадям

				for (int i = 0; i < arr.Length; i++)
				{
					Console.WriteLine(arr[i].ToString());
				}
			} while (Console.ReadKey().Key != ConsoleKey.Escape);
			Console.ReadKey();
			//Array.Sort(arr, (Point x, Point y) => (x.X * x.X + x.Y * x.Y).CompareTo(y.X * y.X + y.Y * y.Y));//сортируем по расстоянию от их центра до начала координат
		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task05
{
	class Program
	{
		static void Main(string[] args)
		{
			Interval interval1 = new Interval(1, 10);
			Interval interval2 = new Interval(2, 15);
			Console.WriteLine($"Int1 = {interval1.ToString()},Int2 = {interval2.ToString()}");
			Interval interval3 = new Interval(3, 18);

			interval3 = interval1 + interval2;
			Console.WriteLine("interval1 + interval2 = {0}", interval3);
			interval3 = interval1 - interval2;
			Console.WriteLine("interval1 - interval2 = {0}", interval3);

			interval3 = interval1 * interval2;
			Console.WriteLine("interval1 * interval2 = {0}", interval3);
			interval3 = interval1 / interval2;
			Console.WriteLine("interval1 / interval2 = {0}", interval3);
			Console.ReadKey();
		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

	class Program
	{
		public delegate int Cast(double a);
		static void Main(string[] args)
		{
			Cast del1 = (a)=>
			{
				return (int)Math.Round(a / 2 * 2);//ближайшее четное число
			};
			Cast del2 = (a)=>
			{


				return (int)Math.Log10(a) + 1;//порадок числа

			};
			Cast del3 = del1;
			del3 += del2;
			double b = 115.557;
			Console.WriteLine(del3?.Invoke(b));
			
			Console.ReadKey();
		}
	}
}

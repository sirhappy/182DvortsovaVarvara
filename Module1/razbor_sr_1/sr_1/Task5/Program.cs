using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
	internal class Program
	{
		/// <summary>
		/// почти 0
		/// </summary>
		private const double Eps = 1e-10;
		/// <summary>
		/// ограничитель сверху
		/// </summary>
		private const double MaxDoubleValue = 1e+5;
		/// <summary>
		/// для считывания чисел
		/// </summary>
		/// <param name="str">имя переменной</param>
		/// <returns>число типа double</returns>
		public static double Getdouble(string str)
		{
			double res;
			Console.Write($"Enter {str} = ");
			while(!double.TryParse(Console.ReadLine(),out res)||res> MaxDoubleValue||res<0)
			{
				Console.Write($"Something wrong with input,reenter pls\n");
				Console.Write($"Enter {str} = ");
			}
			return res;
		}
		static void Main(string[] args)
		{
			double Odz1, Odz2, Okr;
			Odz1 = Getdouble("Odz1");
			Odz2 = Getdouble("Odz2");
			Okr = Getdouble("Okr");
			double temp = Odz2 - Odz1 > Eps ? Odz1 * 0.62 + Odz2 * 0.38 : Odz1 * 0.38 + Odz2 * 0.62;
			double Odz = (int)(temp);
			double result =(int)(Odz * Okr);
			Console.WriteLine($"Your result is {result}");
			Console.ReadLine();
		}
	}
}

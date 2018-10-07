using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Студент :Дворцова Варвара
 * Группа :БПИ 182-2
 * Вариант :1
 * 
 * программа считывает время разговора и цену за 1 минуту;
 начиная с 5 мин действует скидка 20%;
 вывести сумму за разговор;
 */
namespace Task1
{
	class Program
	{
		private const int SaleStartTime = 5;//минуты ,начиная с которых децствует скидка
		public const double MaxDoubleValueInput = 1000;
		private const double SaleSize = 0.8;//скидка 80/100
		public static void GetUint(string str,out uint t)
		{
			Console.Write($"Enter {str} pls ");
			while (!uint.TryParse(Console.ReadLine(),out t)||t<0)
			{
				Console.WriteLine("ERROR");
				Console.Write($"Enter {str} pls ");
			}
		}
		public static void GetDouble(string str, out double p)
		{
			Console.Write($"Enter {str} pls ");
			while (!double.TryParse(Console.ReadLine(), out p) || p < 0||p> MaxDoubleValueInput)
			{
				Console.WriteLine("ERROR");
				Console.Write($"Enter {str} pls ");
			}
		}
		//считает деньги за разговор
		public static double Money(uint t,double p)
		{
			double res;
			res = t > SaleStartTime ? SaleStartTime * p + (t - SaleStartTime) * SaleSize*p : t * p;
			return res;
		}
		
		static void Main(string[] args)
		{
			uint t;//минуты
			double p;//стоимость 1 минуты
			do {
				//input
				Console.Clear();
				GetUint("number of minutes ", out t);
				GetDouble("number of money ", out p);
				//output
				Console.WriteLine($"You spent {Money(t, p):f3}");
				Console.WriteLine("To exit press ESC ...\nTo continue press any key...");
			} while (Console.ReadKey().Key != ConsoleKey.Escape);
					

			
		}
	}
}

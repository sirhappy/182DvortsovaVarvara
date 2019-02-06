using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* описать статический метод SquareConsoleInfo(A),
 * возвращающий значение void и выводящий в консоль, 
 * с точностью до двух знаков после запятой вещественное число A,
 * переданное в качестве параметра.
В методе Main() получить от пользователя координаты углов квадрата. 
На основе этих координат создать объект S типа Square. 
Связать метод SquareConsoleInfo() с событием OnSizeChanged объекта S. 
В цикле получать от пользователя координаты правого 
нижнего угла квадрата X и Y, используя свойства объекта Square, 
изменять координаты углов S, условие окончания цикла определить самостоятельно.
*/
namespace DopTask2
{
	class Program
	{
		public static void SquareConsoleInfo(double A)
		{
			Console.WriteLine($"Dlina kvadrata = {A:f2}");
		}

		public static double EnterDouble(string message, double minvalue = 0, double maxValue = 10000)
		{
			double res;
			bool isCorrect = false;
			do
			{
				Console.Write(message);
				while (!Double.TryParse(Console.ReadLine(), out res) || res > maxValue || res < minvalue)
				{
					Console.WriteLine("Error ,try again !");
					Console.Write(message);
				}
				isCorrect = true;

			} while (!isCorrect);
			return res;
		}
		static void Main(string[] args)
		{
			do
			{
				
				

				Squera S = new Squera();
				S.OnSizeChanged += SquareConsoleInfo;
				S.Storona = EnterDouble("Enter Storona = ");
				
				S.LeftVerhAngl1 = EnterDouble("Enter leftDouble = ");
				S.RightNizAngl1= EnterDouble("Enter RightNizAngl = ");
				
				
				
				

			} while (Console.ReadKey().Key != ConsoleKey.Escape);
		}
	}
}

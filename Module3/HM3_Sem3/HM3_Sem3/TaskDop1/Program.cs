using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*описать статический метод PrintInfo(A), 
 * возвращающий значение void и выводящий в 
 * консоль координаты объекта A типа Dot, переданного в качестве параметра.
В методе Main() получить от пользователя 
две вещественные координаты X и Y. 
Создать объект D типа Dot с координатами X и Y. 
Подписать метод PrintInfo() на событие OnCoordChanged. 
Запустить для объекта D метод DotFlow().

	 */
namespace TaskDop1
{
	class Program
	{
		public static void PrintInfo(Dot dot)
		{
			Console.WriteLine($"Coordinates x = {dot.X} y= {dot.Y}");
		}
		public static double EnterDouble(string message,double minvalue =0,double maxValue =10000)
		{
			double res;
			bool isCorrect = false;
			do {
				Console.Write(message);
				while(!Double.TryParse(Console.ReadLine(),out res)||res>maxValue||res<minvalue)
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
			do {
				double x = EnterDouble("Enter x = ");
				double y = EnterDouble("Enter y = ");
				Dot d = new Dot(x, y);
				d.OnCoordChanged += PrintInfo;
				d.DotFlow();

			} while (Console.ReadKey().Key != ConsoleKey.Escape);
		}
	}
}

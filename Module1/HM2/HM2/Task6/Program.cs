using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
Задан круг с центром в начале координат и
радиусом R=10.
Ввести координаты точки и вывести сообщение:
«Точка внутри круга!» или «Точка вне круга!».
Предусмотреть проверку входных данных и цикл
повторения решений.
*/
namespace Task6
{
	class Program
	{
		public static string inCircle(int x, int y)
		{
			int r = 10;
			string str = "Точка ";
			str += x * x + y * y < r*r ? "в круге" : "вне круга";
			return str;
		}
		static void Main(string[] args)
		{
			int x, y;
			do {

				do {
					Console.Write("Введите x = ");
				} while (!int.TryParse(Console.ReadLine(),out x));

				do
				{
					Console.Write("Введите y = ");
				} while (!int.TryParse(Console.ReadLine(), out y));

				Console.WriteLine(inCircle(x,  y));
				Console.WriteLine("Для выхода нажмите Escape...");


			} while (Console.ReadKey().Key!=ConsoleKey.Escape);
		}
	}
}

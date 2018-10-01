using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 Дворцова Варвара
 БПИ 182-2
 Задача:Написать метод, вычисляющий логическое значение функции G=F(X,Y).
Результат равен true, если точка с координатами (X,Y) попадает в фигуру G, и
результат равен false, если точка с координатами (X,Y) не попадает в фигуру G.
Фигура G - сектор круга радиусом R=2 в диапазоне углов -90<= fi <=45
	 */
namespace Task3
{
	class Program
	{
		//  Отдельный метод для ввода чисел типа double
		public static bool getDouble(string name, out double value)
		{
			Console.Write($"Enter {name} = ");
			return double.TryParse(Console.ReadLine(), out value);
		}
		//попадает точка в сектор или нет?
		public static bool F(double x, double y)
		{
			int r = 2;
			bool result = (x >= 0 & x <= 1) & (y >= 3 * Math.PI / 2 & y <= Math.PI / 4) ? (y * y + x * x < r ? true : false) : false;
			return result;
		}
		static void Main(string[] args)
		{
			double x, y;
		
			Console.Title = "Сегмент оружности";
			do
			{
				Console.Clear();
				Console.WriteLine("Enter x and y ,pls");
				while (!getDouble("x", out x))
				{
					
					Console.WriteLine("Smng wrong with input,reenter pls ...");
					
				}
				
				while (!getDouble("y", out y))
				{
					
					Console.WriteLine("Smng wrong with input,reenter pls ...");
					
				}
				bool result = F(x, y);
				string str = (result) ? $"It is possible" : $"It is not possible";
				Console.WriteLine(str);
				Console.WriteLine("To exit press Esc ...\nTo continue press Enter");
			} while (Console.ReadKey().Key != ConsoleKey.Escape);

		}
	}
}

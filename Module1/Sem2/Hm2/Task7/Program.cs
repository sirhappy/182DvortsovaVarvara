using System;

/*Дворцова Варвара
 * БПИ 182 -2 
 * Задача:Написать программу с использованием двух методов. Первый метод
возвращает дробную и целую часть числа. Второй метод возвращает
квадрат и корень из числа. В основной программе пользователь вводит
дробное число. Программа должна вычислить, если это возможно,
значение корня, квадрата числа, выделить целую и дробную часть из
числа
 */
namespace Task7
{
	class Program
	{
		public static void Parts(double number, out uint integer, out double fraction)
		{
			integer = (uint)number;
			fraction = number - integer;

		}
		public static void Root(double number, out string root, out double square)
		{
			root = number < 0 ? "Error !a negative number" : $"{Math.Sqrt(number):F3}";
			square = number * number;
		}


		static void Main(string[] args)
		{
			double number;
			uint integer;
			double fraction, square;
			string root;
			do
			{
				//Input.
				Console.Write("Enter your number = ");
				while (!double.TryParse(Console.ReadLine(), out number))
				{
					Console.WriteLine("Something wrong with input,reenter pls");
					Console.Write("Enter your number = ");
				}

				Parts(number, out integer, out fraction);
				Root(number, out root, out square);

				//Output.
				Console.WriteLine($"integer is {integer},fraction is {fraction:F3}");
				Console.WriteLine($"root is {root},square is {square:F3}");

				Console.WriteLine("To continue press Esc...\nTo exit press Enter");

			} while (Console.ReadKey().Key != ConsoleKey.Escape);



		}
	}
}

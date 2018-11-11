using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
	internal class Program
	{
		private const double Interval = 1e+5;//интервал в котором могут быть точки.
		private const double eps = 1e-7;//константа для сравнения
		private const int CountIntValue = 1000;//Ограничение инта  ,чтобы долго не считало.
											
		static double InputDouble(string message, string errormessage = "Ошибка", double minValue = -Interval, double maxvalue = Interval)
		{
			double res;
			bool isCorrect = false;
			do
			{
				Console.Write(message);
				while (!(isCorrect = double.TryParse(Console.ReadLine(), out res) && (res- minValue)>=eps && (maxvalue - res) >=eps))
				{
					Console.Error.WriteLine(errormessage);
					Console.Write(message);
				}

			} while (!isCorrect);
			return res;
		}
		/// <summary>
		/// Метод считывает целые числа
		/// </summary>
		/// <param name="message">Сообщекение пользователю</param>
		/// <param name="errormessage"></param>
		/// <param name="minValue"></param>
		/// <param name="maxvalue"></param>
		/// <returns></returns>
		static int InputInt(string message, string errormessage = "Ошибка", int minValue = 1, int maxvalue = CountIntValue)
		{
			int res;
			bool isCorrect = false;
			do
			{
				Console.Write(message);
				while (!(isCorrect = int.TryParse(Console.ReadLine(), out res) && res >= minValue && res <= maxvalue))
				{
					Console.Error.WriteLine(errormessage);
					Console.Write(message);
				}

			} while (!isCorrect);
			return res;
		}

		static void CaculateF1_F2(double x, out double f1, out double f2, out bool Okf1, out bool Okf2)
		{
			Okf1 = Okf2 = true;
			f1 = f2 = 0;
			if (-x - 7 >= eps) { 
				
				Okf1 = false;
			}
			else f1 = Math.Log(x + 7);
			if (Math.Abs(x)<eps)
				Okf2 = false;
			else f2 = (double)1 / 2 * x;


		}
		static void Main(string[] args)
		{
			double x, y;
			int n;
			do
			{
				Console.Clear();
				Console.WriteLine("Введите x < y");
				x = InputDouble("Введите х = ");
				y = InputDouble("Введите y = ",minValue:x+eps);
				
				n = InputInt("Введите n = ");
				double f1, f2;
				double delta = (double)(y - x) / n;
				double corrent = x;
				bool res1, res2;
				for (int i = 1; i < n + 1; i++,corrent += delta)
				{
					CaculateF1_F2(corrent, out f1, out f2,out res1,out res2);
					Console.WriteLine("В точке {0:f3} значение первой функции = {1} значение второй функции = {2}", corrent,
						res1 ? f1.ToString("f3") : "не удалось посчитать", res2 ? f2.ToString("f3") : "не удалось посчитать");
				}

				Console.WriteLine("Для выхода нажмите Esc");
			} while (Console.ReadKey().Key != ConsoleKey.Escape);

		}
	}
}

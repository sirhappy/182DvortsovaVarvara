using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 Дворцова Варвара
 БПИ 182-2
 Написать метод, переводящий оценку в баллах десятибалльной шкалы в
аттестационную (четырех балльную) шкалу:
* 1, 2, 3 балла – неудовлетворительно;
* 4,5 – удовлетворительно;
* 6,7 – хорошо;
* 8, 9, 10 – отлично.
Используйте переключатель.
В основной программе в получайте от пользователя оценки (целые числа из
диапазона 1..10 и выводите значение в четырёх балльной шкале.  
	 */

namespace Task1
{
	class Program
	{
		public static void Convert(uint ball)
		{
			switch (ball)
			{
				case uint n when (n>=1 && n<=3):
					Console.WriteLine("неудовлетворительно");
					break;
				case uint n when (n >= 4 && n <= 5):
					Console.WriteLine("удовлетворительно");
					break;
				case uint n when (n >= 6 && n <= 7):
					Console.WriteLine("хорошо");
					break;
				case uint n when (n >= 8 && n <= 10):
					Console.WriteLine("отлично");
					break;
				default:
					Console.WriteLine("Default case");
					break;
			}
		}
		static void Main(string[] args)
		{
			uint ball;
			do {
				Console.Write("Введите оценку = ");
				while(!uint.TryParse(Console.ReadLine(),out ball)|| ball < 1 || ball > 10)
				{
					Console.Write("Ошибка ввода,попробуйте еще раз ");
					Console.Write("Введите оценку = ");
				}
				Convert(ball);
				Console.WriteLine("Для выхода нажмите Esc ...\nДля продолжения Enter");

			} while (Console.ReadKey().Key!= ConsoleKey.Escape);
		}
	}
}

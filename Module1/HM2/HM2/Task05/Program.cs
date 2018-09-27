using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
Выделение отдельных цифр натурального числа
Задача.
Ввести трехзначное натуральное число и
напечатать его цифры "столбиком".
*/
namespace Task05
{
	class Program
	{
		

		public static void Numbers(int number, out int f1,out int  f2,out int f3)
		{
			f3 = number % 10;
			int temp = number / 10;
			f2 = temp % 10;
			f1 = temp / 10;


		}
		static void Main(string[] args)
		{
			int number;
			int f1, f2, f3;
			do
			{
				do
				{
					Console.Write("Введите трехзначное число");
				} while (!int.TryParse(Console.ReadLine(), out number) || number<100||number>999);
				Numbers(number, out f1, out f2, out f3);
				Console.WriteLine("{0}\n{1}\n{2}", f1, f2, f3);
				Console.WriteLine("Для выхода нажмите Escape");
			} while (Console.ReadKey().Key != ConsoleKey.Escape);
		}
	}
}

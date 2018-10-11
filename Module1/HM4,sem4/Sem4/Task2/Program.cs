using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Задача:В основной программе ввести натуральное число и вычислить суммы
его цифр, находящихся в чётных и на нечётных разрядах. Разряд
единиц считать нулевым и чётным.
Для этого написать метод с натуральным параметром, вычисляющий
суммы цифр, находящихся на четных и на нечетных позициях в записи
значения параметра. */
namespace Task2
{
	class Program
	{
		public static void F(uint number,ref uint sum_nech,ref uint sum_ch)
		{
			uint digit = number;
			uint last;
			while (digit != 0)
			{
				last = digit % 10;
				
				if (digit.ToString().Length%2==0) sum_ch += last;
				else sum_nech += last;
				digit /= 10;

			}

		}
		public static bool getDouble(string name, out uint value)
		{
			Console.Write($"Enter {name} = ");
			return uint.TryParse(Console.ReadLine(), out value);
		}
		static void Main(string[] args)
		{
			uint number;
			
			do
			{
				Console.Clear();
				uint sum_nech = 0,
				sum_ch = 0;
				if (getDouble("number", out number))
				{
					F(number, ref sum_ch, ref sum_nech);
					Console.WriteLine($"Сумма на четных местах = {sum_ch},Сумма на нечетных местах ={sum_nech}");
				}
				else Console.WriteLine("error");

				
				
			} while (Console.ReadKey().Key != ConsoleKey.Escape);
		}
	}
}

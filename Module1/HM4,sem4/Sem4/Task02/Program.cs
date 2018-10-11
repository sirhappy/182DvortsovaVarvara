using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*В основной программе ввести символ, и если это символ латинской
строчной буквы - сдвинуть его циклически в алфавите на 4 позиции.
Для этого написать метод, изменяющий значение символьного
параметра (сдвинуть его циклически в алфавите на 4 позиции, влево
или вправо по вашему усмотрению)*/
namespace Task02
{
	class Program
	{
		public static bool Symbol(ref char s)
		{
			
			

			if(s >= 'a' & s <= 'z')
			{
				s = (char)((s + 4) < 'z' ? (s + 4) : ((s + 4) - ('z' - 'a' + 1)));
				return true;
			}
			return false;
		}
		static void Main(string[] args)
		{
			char simbol;
			do {
				Console.Write("Enter any symbol = ");
				while(!char.TryParse(Console.ReadLine(),out simbol))
				{
					Console.WriteLine("Smth wrong with input,reenter pls");
					Console.Write("Enter any symbol = ");
				}
				if (Symbol(ref simbol)) Console.WriteLine($"+4 is {simbol}");
				else Console.WriteLine("I don't know your symbol");
				Console.WriteLine("To exit press Esc");
			} while (Console.ReadKey().Key!=ConsoleKey.Escape);
		}
	}
}

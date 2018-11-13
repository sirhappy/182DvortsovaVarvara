using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
	class LatinChar
	{
		char _char = 'a';
		public char Char
		{
			get { return _char; }
			set
			{
				if(value >= 'a' && value <= 'z') { _char = value; }
				

			}
		}
		public LatinChar(char ch)
		{
			Char = ch;
		}

	}
	class Program
	{
		public static char EnterChar(string message)
		{
			char res ='a';
			bool isCorrect = false;
			do
			{
				Console.Write(message);
				while (!char.TryParse(Console.ReadLine(), out res) )
				{
					Console.Error.WriteLine("Error.../n Try again");
					Console.Write(message);
				}

				isCorrect = true;
			} while (!isCorrect);
			return res;
		}
		public static double EnterDouble(string message, double maxvalue = 500)
		{
			double res;
			bool isCorrect = false;
			do
			{
				Console.Write(message);
				while (!double.TryParse(Console.ReadLine(), out res) || res > maxvalue)
				{
					Console.Error.WriteLine("Error.../n Try again");
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
				Console.Clear();
				char minChar = EnterChar("Введите нижнюю границу(символ) = ");
				char maxChar = EnterChar("Введите верхнюю границу(символ) = ");
				double delta = EnterDouble("Введите шаг  = ");
				if (minChar < maxChar)
				{
					for (char i = minChar; i < maxChar; i += (char)delta)
					{
						LatinChar c = new LatinChar(i);
						Console.WriteLine($" char = {c.Char:F3}");
					}
				}
				

				Console.WriteLine("To exit press ESC.../n To continue press any keyword");
			} while (Console.ReadKey().Key != ConsoleKey.Escape);
		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Animal;

namespace Task10
{
	class Program
	{
		public static string EnterString(string message)
		{
			string res;
			Console.Write(message);
			res = Console.ReadLine();
			Console.WriteLine("\n");
			return res;
		}
		public static double EnterDouble(string message, double doubleMax)
		{
			double res;
			bool isCorrect;
			Console.Write(message);
			do
			{

				while (!double.TryParse(Console.ReadLine(), out res) || res > doubleMax)
				{
					Console.Error.WriteLine("error!!!");
					Console.Write(message);
				}
				Console.WriteLine("\n");
				isCorrect = true;
			} while (!isCorrect);

			return res;
		}
		public static int EnterInt(string message, int doubleMax)
		{
			int res;
			bool isCorrect;

			do
			{
				Console.Write(message);
				while (!int.TryParse(Console.ReadLine(), out res) || res > doubleMax)
				{
					Console.Error.WriteLine("error!!!");
					Console.Write(message);
				}
				Console.WriteLine("\n");
				isCorrect = true;
			} while (!isCorrect);

			return res;
		}
		public static bool EnterBool(string message)
		{
			bool res;
			bool isCorrect;
			Console.Write(message);
			do
			{

				while (!bool.TryParse(Console.ReadLine(), out res))
				{
					Console.Error.WriteLine("error!!!");
					Console.Write(message);
				}
				Console.WriteLine("\n");
				isCorrect = true;
			} while (!isCorrect);

			return res;
		}
		static void Main(string[] args)
		{
			do
			{
				Console.Clear();
				Dog dog1;
				Cow cow1;

				try { dog1 = new Dog(EnterString("Name of dog = "), EnterInt("Years of your Dog = ", 100), EnterString("Poroda of dog = "), EnterBool("You dog is trained ? - ")); }
				catch (ArgumentOutOfRangeException) { Console.WriteLine("Something wrong with input reenter pls"); dog1 = new Dog(EnterString("Name of dog = "), EnterInt("Years of your Dog = ", 100), EnterString("Poroda of dog = "), EnterBool("You dog is trained ? - ")); }
				try { cow1 = new Cow(EnterString("Name of cow = "), EnterInt("Years of your Cow = ", 100), EnterInt("Count of liters of milk of your Cow = ", 100)); }
				catch (ArgumentOutOfRangeException) { Console.WriteLine("Something wrong with input reenter pls"); cow1 = new Cow(EnterString("Name of cow = "), EnterInt("Years of your Cow = ", 100), EnterInt("Count of liters of milk of your Cow = ", 100)); }



				Console.WriteLine(dog1.AnimalInfo() + " " + dog1.AnimalSound());
				Console.WriteLine(cow1.AnimalInfo() + " " + cow1.AnimalSound());


			} while (Console.ReadKey().Key != ConsoleKey.Escape);
		}
	}
}

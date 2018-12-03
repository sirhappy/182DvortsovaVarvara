using System;
using AbstractTestLibrary;
namespace Task05
{
	class Program
	{
		public static Random rnd = new Random();
		static void Main(string[] args)
		{
			do
			{
				Console.Clear();

				UnitsBase[] arr = new UnitsBase[5];
				int skidca;
				Console.Write("Enter skidca = ");
				int.TryParse(Console.ReadLine(), out skidca);
				for (int i = 0; i < arr.Length; i++)
				{
					if (rnd.Next(0, 2) == 0) arr[i] = new CD("cd", rnd.Next(20, 150), skidca, 0, rnd.Next(100, 500));
					else if(rnd.Next(0, 2) == 1) arr[i] = new Cards("cards", rnd.Next(5, 100), skidca, 1, "OUO");
					else arr[i] = new Books("book", rnd.Next(20, 150), skidca, 2, rnd.Next(20, 150),true);
				}
				
				for(int i = 0; i < arr.Length; i++)
				{
					Console.WriteLine($"{arr[i].name}\tprise = {arr[i].price}\twhith_skidka ={arr[i].Discount()} ");
				}

			} while (Console.ReadKey().Key!=ConsoleKey.Escape);
			
			

		}
	}
}

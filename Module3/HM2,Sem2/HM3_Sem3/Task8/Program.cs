using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8
{
	class Plant
	{
		double growth;// рост
		double photosensitivity;//светочувствительность  от 0 до 100 включительно.
		double frostresistance;// морозоустойчивость  от 0 до 100 включительно.

		public Plant(double growth, double photosensitivity, double frostresistance)
		{
			Growth = growth;
			Photosensitivity = photosensitivity;
			Frostresistance = frostresistance;
		}

		public double Growth { get => growth; set => growth = value; }
		public double Photosensitivity { get => photosensitivity; set => photosensitivity = value; }
		public double Frostresistance { get => frostresistance; set => frostresistance = value; }

		public override string ToString()
		{
			return $"growth = {Growth:f3},photosensitivity = {Photosensitivity:f3}, frostresistance = {Frostresistance:f3}";
		}
	}

	class Program
	{
		public static Random rnd = new Random();
		public delegate int CompSome(Plant a, Plant b);
		static void Main(string[] args)
		{
			do
			{
				Console.Clear();
				int n;
				Console.Write("Enter n = ");
				while (!int.TryParse(Console.ReadLine(), out n) || n == 0 || n < 0 || n > 1000)
				{
					Console.WriteLine("Error try again");
					Console.Write("Enter n = ");
				}
				Plant[] plants = new Plant[n];
				for (int i = 0; i < plants.Length; i++)
				{
					plants[i] = new Plant(rnd.Next(25, 101) , rnd.Next(0, 101) , rnd.Next(0, 81) );
				}
				Array.ForEach(plants, e => Console.WriteLine(e));

				Console.WriteLine("По неубыванию роста \n");
				CompSome growth = delegate (Plant x, Plant y)
				{
					if (x.Growth > y.Growth) return 1;
					if (x.Growth == y.Growth) return 0;
					return -1;
				};
				Array.Sort(plants, (Plant a, Plant b) => growth(a, b));
				Array.ForEach(plants, e => Console.WriteLine(e));

				Console.WriteLine("По возрастанию морозоустойчивости  \n");
				Array.Sort(plants, (Plant a, Plant b) =>
				{
					if (a.Frostresistance > b.Frostresistance) return 1;
					if (a.Frostresistance < b.Frostresistance) return -1;
					return 0;

				});
				Array.ForEach(plants, e => Console.WriteLine(e));

				Console.WriteLine("t по четности светочувствительности  \n");
				Array.Sort(plants, (Plant a, Plant b) =>
				{
					if (a.Photosensitivity % 2 == 0 && b.Photosensitivity % 2 == 0) return 0;
					if (a.Photosensitivity % 2 == 0 && b.Photosensitivity % 2 != 0) return -1;
					return 1;
				});
				Array.ForEach(plants, e => Console.WriteLine(e));

				Plant[] newPlants = Array.ConvertAll(plants, (e) =>
				{
					if (e.Frostresistance % 2 == 0)
						e.Frostresistance = e.Frostresistance / 3;
					else e.Frostresistance = e.Frostresistance / 2;
					return e;
				});
				Console.WriteLine(" \n Измените параметр морозоустойчивость у всех растений массива, используя метод\n"+
"Array.ConvertAll.Морозоустойчивость меняем по следующему правилу: четные значения\n"+
"уменьшаем в 3 раза, нечетные значения уменьшаем в 2 раза.\n");
				Array.ForEach(newPlants, e => Console.WriteLine(e));

			} while (Console.ReadKey().Key != ConsoleKey.Escape);
		}
	}
}

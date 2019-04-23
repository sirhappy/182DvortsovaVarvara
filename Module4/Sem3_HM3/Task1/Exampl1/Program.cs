using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exampl1
{
	// хлеб
	class Bread
	{
		public int Weight { get; set; } // масса

		public static Sandwich operator +(Bread bread, Butter butter)
		{
			return new Sandwich { Weight = bread.Weight + butter.Weight };
		}
		public static Sandwich operator +(Bread bread, Fish fish)
		{
			return new Sandwich { Weight = bread.Weight + fish.Weight };
		}
		public static Sandwich operator +(Bread bread, Becon becon)
		{
			return new Sandwich { Weight = bread.Weight + becon.Weight };
		}
	}
	//бекон
	class Becon
	{
		public int Weight { get; set; } // масса

	}
	//Рыба
	class Fish
	{
		public int Weight { get; set; } // масса
	}
	// масло
	class Butter
	{
		public int Weight { get; set; } // масса
	}

	// бутерброд
	class Sandwich
	{
		public int Weight { get; set; } // масса
		public static Sandwich operator +(Sandwich sandwich,Becon becon)
		{
			return new Sandwich() { Weight = sandwich.Weight + becon.Weight };
		}
		public static Sandwich operator +(Sandwich sandwich, Fish fish)
		{
			return new Sandwich() { Weight = sandwich.Weight + fish.Weight };
		}
		public static bool operator >(Sandwich sandwich1, Sandwich sandwich2)
		{
			if (sandwich1.Weight > sandwich2.Weight) return true;
			return false;
		}
		public static bool operator <(Sandwich sandwich1, Sandwich sandwich2)
		{
			if (sandwich1.Weight < sandwich2.Weight) return true;
			return false;
		}

	}
	class Program
	{
		static void Main(string[] args)
		{
			Bread bread = new Bread { Weight = 80 };
			Butter butter = new Butter { Weight = 20 };
			Fish fish = new Fish { Weight = 10 };
			Becon becon = new Becon { Weight = 20 };
			Sandwich sandwich = bread + butter;
			Sandwich sandwich2 = bread + fish ;
			Console.WriteLine("san = (bread + butter) = {0}", sandwich.Weight);  // 100
			Console.WriteLine("san2 = (bread + fish) = {0}",sandwich2.Weight);
			Console.WriteLine($"sandwich>sandwich2 = {sandwich > sandwich2}");
			sandwich2 += becon;
			Console.WriteLine("san2 = (bread + fish + becon) = {0}", (sandwich2).Weight);
			Console.WriteLine($"sandwich>sandwich2 = {sandwich>sandwich2}");
			Console.ReadKey();
		}
	}
}

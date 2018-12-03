using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cinderella;

namespace ConsoleApp1
{
	class Program
	{
		public static Random rnd = new Random();
		static void Main(string[] args)
		{
			do
			{
				Console.Clear();
				int n;
				Console.Write("Enter n pls = ");
				int.TryParse(Console.ReadLine(), out n);
				Something[] arr = new Something[n];
				for (int i = 0; i < arr.Length; i++)
				{
					if (rnd.Next(0, 2) == 0) arr[i] = new Lentil();
					else arr[i] = new Ashes();
				}
				for (int i = 0; i < arr.Length; i++)
				{
					Console.WriteLine(arr[i]);
				}
				Console.WriteLine("------------------");
				Something[] lent = {} ;
				Something[] ash = {};
				for (int i = 0; i < arr.Length; i++)
				{
					if (arr[i] is Lentil)
					{
						Array.Resize(ref lent, lent.Length + 1);
						lent[lent.Length - 1] = arr[i];
					}
					else
					{
						Array.Resize(ref ash, ash.Length + 1);
						ash[ash.Length - 1] = arr[i];
					}
				}
				Console.WriteLine("------------------");
				Console.WriteLine("lent");
				Console.WriteLine("------------------");
				for (int i = 0; i < lent.Length; i++)
				{
					Console.WriteLine(lent[i]);
				}
				Console.WriteLine("------------------");
				Console.WriteLine("ash");
				Console.WriteLine("------------------");
				for (int i = 0; i < ash.Length; i++)
				{
					Console.WriteLine(ash[i]);
				}

			} while (Console.ReadKey().Key != ConsoleKey.Escape);
		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ
{
	class Program
	{

		static void Main(string[] args)
		{
			Random rnd = new Random();
			do
			{
				Figure[] fig = new Figure[rnd.Next(10, 20)];
				for (int i = 0; i < fig.Length; i++)
				{
					double random = rnd.NextDouble();
					if (random < 0.4)
						fig[i] = new Rectangle(rnd.Next(5, 15));
					if (random > 0.4&& random < 0.6)
						fig[i] = new Kub(rnd.Next(5, 15));
					fig[i] = new Kvadrat(rnd.Next(5, 15), rnd.Next(5, 15));

				}
				IVolume[] volume = new IVolume[0];
				for (int i = 0; i < fig.Length; i++)
				{
					double random = rnd.NextDouble();
					if (random < 0.4)
						fig[i] = new Rectangle(rnd.Next(5, 15));
					if (random > 0.4 && random < 0.6)
						fig[i] = new Kub(rnd.Next(5, 15));
					fig[i] = new Kvadrat(rnd.Next(5, 15), rnd.Next(5, 15));

				}

			} while (Console.ReadKey().Key!=ConsoleKey.Escape);
		}
	}
}

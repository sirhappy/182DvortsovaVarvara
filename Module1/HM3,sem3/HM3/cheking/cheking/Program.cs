using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cheking
{
	class Program
	{
		static void Main(string[] args)
		{
			byte a = 142;
			int b = a >> 5;

			switch (b)
			{
				case 1:
				case 2:
				case 3:
					Console.WriteLine(1);
					break;
				case 4:
				case 5:
					Console.WriteLine(2);
					break;
				default:
					Console.WriteLine(3);
					break;
			}


			Console.ReadKey();


		}
	}
}

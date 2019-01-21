using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
	class Program
	{
		static void Main(string[] args)
		{
			int i = 9;

			while (i > 0)
			{
				do
					if (i > 4) Console.Write(i % 3);
				while (i-- > 3);
				Console.WriteLine(--i);
				break;
			}
			Console.Read();
		}

	}
}

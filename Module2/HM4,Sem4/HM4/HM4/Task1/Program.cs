using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace Task1
{
	class Program
	{
		static Random rnd = new Random();
		static void Main(string[] args)
		{
			A[] arr = new A[10];
			for(int i = 0; i < 10; i++)
			{
				if (rnd.Next(1, 3) == 1)
				{ arr[i] = new B(); }
				else arr[i] = new A();
			}
			for(int i = 0; i < 10; i++)
			{
				arr[i].GetA();
			}
			Console.WriteLine("===========");
			for (int i = 0; i < 10; i++)
			{
				if(arr[i] is B)
				{
					arr[i].GetA();
				}
			}
			Console.WriteLine("===========");
			for (int i = 0; i < 10; i++)
			{
				if (arr[i] is A)
				{
					arr[i].GetA();
				}
			}
			Console.WriteLine("===========");
			Console.ReadKey();
		}
	}
}

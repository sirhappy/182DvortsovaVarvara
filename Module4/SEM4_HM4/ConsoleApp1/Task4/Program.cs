using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Создать класс Evens для представления нумеруемой (перечислимой)
коллекции целых четных чисел из фиксированного диапазона [Nmin,
Nmax]. В основной программе создать объект класса-коллекции и
применить к нему оператор foreach.*/
namespace Task4
{
	class Evens
	{
		public IEnumerable GetItems(int nmin,int nmaxx)
		{
			int i = nmin;
			for (; i <= nmaxx; i++)
			{
				if (i % 2 == 0)
					yield return i;
			}
		}
	}
	class Program
	{

		static void Main(string[] args)
		{
			Evens evens = new Evens();
			foreach (var item in evens.GetItems(5,20))
			{
				Console.WriteLine(item);
			}

			Console.ReadLine();
		}
	}
}

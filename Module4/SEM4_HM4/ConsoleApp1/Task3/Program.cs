using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Определить коллекцию (класс Fibbonacci) с именованным итератором
(в виде метода, возвращающего интерфейс IEnumerable) для
получения заданного количества членов ряда Фибоначчи, поля класса
– последний и предпоследний член ряда Фибоначчи. */
namespace Task3
{
	class Fibbi 
	{
		int first = 1;
		int second = 0;

		public IEnumerable GetEnu(int limit)
		{
			int t;
			for (int i = 0; i < limit; i++)
			{
				t = first + second;
				first = second;
				
				yield return second = t;
			}
		}
	}
	class TriangleNums
	{
		public IEnumerable GetItems(int count)
		{
			for (int i = 1; i < count; i++)
			{
				yield return (int)(0.5 * i*(i + 1));
			}
		}
	}
	class Program
	{
		static void Main(string[] args)
		{
			//Fibbi fibbi = new Fibbi();
			//foreach (var item in fibbi.GetEnu(5))
			//{
			//	Console.WriteLine(item);
			//}
			TriangleNums nums = new  TriangleNums();
			foreach (var item in nums.GetItems(10))
			{
				Console.WriteLine(item);
			}
			Console.ReadLine();
		}
	}
}

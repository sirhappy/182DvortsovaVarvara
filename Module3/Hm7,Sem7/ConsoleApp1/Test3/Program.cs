using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Structures;
namespace Test3
{
	class Program
	{
		//Сорт по ключам типа дабл
		static void Main(string[] args)
		{
			do
			{
				Random rnd = new Random();
				Circle[] arr = new Circle[20];
				for (int i = 0; i < arr.Length; i++)
				{
					arr[i] = new Circle(rnd.Next(10, 50), rnd.Next(10, 50), rnd.Next(10, 50));
				}
				//foreach (var item in arr)
				//{
				//	Console.WriteLine(item);
				//}
				//Array.Sort(arr);
				//Console.WriteLine("After Sort");
				//foreach (var item in arr)
				//{
				//	Console.WriteLine(item);
				//}
				double[] DistArr =new  double[arr.Length];
				for (int i = 0; i < arr.Length; i++)
				{
					DistArr[i] = arr[i].Center.Distance(arr[i].Center, new PointS(0, 0));
				}
				Array.ForEach(arr, e => Console.WriteLine(e + " " + " distance = " + e.Center.Distance(e.Center, new PointS(0, 0))));
				Console.WriteLine("Выполнить упорядочение массива типа CircleS по удаленности центров кругов от начала координат");
				//Сортировка по ключам
				
				Array.Sort(DistArr, arr);

				Array.ForEach(arr, e => Console.WriteLine(e + " " + " distance = " + e.Center.Distance(e.Center, new PointS(0, 0))));


			} while(Console.ReadKey().Key!=ConsoleKey.Escape);
		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 В консольном приложении сформировать массив из десяти случайных целых
элементов, со значениями из диапазона (–15; 15). Используя метод Array.Sort()
отсортировать массив в порядке возрастания абсолютных значений его элементов,
признак сортировки задавать лямбда-выражением. Исходный и отсортированный
массивы вывести на экран. Для представления каждого значения элемента массива
отвести четыре позиции*/
namespace DopTask1
{
	class Program
	{
		static Random rnd = new Random();
		static void Main(string[] args)
		{
			do {
				int[] numbs=new int[10];
				for (int i = 0; i < numbs.Length; i++)
				{
					numbs[i] = rnd.Next(-15, 15);
				}
				Array.ForEach(numbs, e => Console.Write(e + " "));
				Array.Sort(numbs, (x, y) =>
				{
					if (Math.Abs(x) > Math.Abs(y)) return 1;
					if (Math.Abs(x) < Math.Abs(y)) return -1;
					return 0;
				});
				Console.WriteLine();
				Array.ForEach(numbs, e => Console.Write($"{e.ToString().PadRight(4)}"));

			} while (Console.ReadKey().Key != ConsoleKey.Escape);
		}
	}
}

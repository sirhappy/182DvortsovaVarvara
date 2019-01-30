using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 В консольном приложении сформировать массив A из десяти случайных целых
элементов, со значениями из диапазона (0; 20). Используя метод Array.ConvertAll()
получить массив B вещественных значений, каждое из которых представляет собой
значение функции 1/x в точках, заданных элементами массива A, преобразование
задавать лямбда-выражением. Значения элементов A и B вывести на экран.
Точность вывода вещественных значений: два знака после десятичного
разделителя.
	 */
namespace DopTask2
{
	class Program
	{
		static Random rnd = new Random();
		static void Main(string[] args)
		{
			do
			{
				int[] numbs = new int[10];
				for (int i = 0; i < numbs.Length; i++)
				{
					numbs[i] = rnd.Next(1, 20);
				}
				Array.ForEach(numbs, e => Console.Write($"{e} "));
				double[] B = Array.ConvertAll(numbs, (e) =>
				{
					
					return (double)(1 / (double)e);
				});

				Console.WriteLine();
				Array.ForEach(B, e => Console.Write($"{e:f2} "));

			} while (Console.ReadKey().Key != ConsoleKey.Escape);
		}
	}
}

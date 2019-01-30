using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*В консольном приложении сформировать массив A из десяти случайных
вещественных элементов, со значениями из диапазона (-3; 3). Используя метод
Array.ConvertAll() получить массив B целых значений, каждое из которых
представляет собой целые части для неотрицательных, и 0 для отрицательных
элементов массива A, преобразование задавать анонимным методом. Значения
элементов A и B вывести на экран. Точность вывода вещественных значений: два
знака после десятичного разделителя.*/
namespace DopTask3
{
	class Program
	{
		static Random rnd = new Random();
		static void Main(string[] args)
		{
			do
			{
				double[] A = new double[10];
				for (int i = 0; i < A.Length; i++)
				{
					A[i] = rnd.Next(-3, 3)+rnd.NextDouble();
				}
				Array.ForEach(A, e => Console.Write($"{e:f2} "));
				Func<double, int> der = delegate (double e)
				{
					if (e < 0) return (int)Math.Truncate(e);
					return 0;
				};
				int[] B = Array.ConvertAll(A,  e=>der(e));

				Console.WriteLine();
				Array.ForEach(B, e => Console.Write($"{e} "));

			} while (Console.ReadKey().Key != ConsoleKey.Escape);
		}
	}
}

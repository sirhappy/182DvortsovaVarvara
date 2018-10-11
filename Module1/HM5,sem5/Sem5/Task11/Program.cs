using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*В программе получить от пользователя количества элементов в
двух целочисленных массивах: А и В. Массивы заполнить
значениями случайными числами из диапазона [10, 50].
• Изменить массив А, добавив в конец все четные по значению
элементы массива B.
• На экран вывести:
– Исходный массив A
– Исходный массив B
– Модифицированный массив A
• Решение основано на однократном проходе массивов и
выделении памяти под массив А с запасом */
namespace Task11
{
	class Program
	{
		static void Main(string[] args)
		{
			int countA, countB;
			int min = 10, max = 50;

			//ввод кол-ва элементов массива A
			do { Console.Write("Enter a number = "); }
			while (!int.TryParse(Console.ReadLine(),out countA));

			//ввод кол-ва элементов массива В
			do { Console.Write("Enter a number = "); }
			while (!int.TryParse(Console.ReadLine(), out countB));

			int[] A = new int[countA + countB];
			int[] B = new int[countB];

			Random rnd = new Random();
			//забиваем А случайными числами
			Console.WriteLine("Массив А");

			for (int i=0 ; i < countA; i++)
			{
				A[i] = rnd.Next(min, max+1);
				Console.Write("{0,4}", A[i]);
			}
			//забиваем В случайными числами
			Console.WriteLine();
			Console.WriteLine("Массив В");
			for (int i = 0; i < countB; i++)
			{
				B[i] = rnd.Next(min, max + 1);
				Console.Write("{0,4}", B[i]);
			}

			int k = countA;//число эл-ов в дополненом массиве А
			//в си шарпе нет метода добавления в конец массива
			//как в питоне:(((
			for(int i = 0; i < B.Length; i++)
			{
				if (B[i] % 2 == 0) A[k++] = B[i];
			}
			//создаем новый массив с к-элементами
			int[] newA = new int[k];
			Array.Copy(A, newA, k);
			Console.WriteLine();
			Console.WriteLine("Массив новыйА");
			for (int i = 0; i < newA.Length; i++)
			{
				Console.Write("{0,4}", newA[i]);

			}
			Console.WriteLine();
			Console.WriteLine("Массив А с четными элементами В в конце");
			for (int i = 0; i < k; i++)
				Console.Write("{0,4}", A[i]);
			Console.Read();
		}
	}
}

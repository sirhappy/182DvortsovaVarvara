using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Определить массив массивов для представления треугольника Паскаля.
// 0-й элемент - массив из одного элемента со значением С(0,0)=1, 
// 1-й элемент - массив из 2-х элементов С(1,0)=С(1,1)=1.
// 2-й элемент - массив из 3-х элементов С(2,0)=С(2,2)=1, С(2,1)=2...
// n-й элемент - массив из n+1 элементов: С(n,0)=С(n,n)=1, 
//   С(n,k)=C(n-1,k-1)+C(n-1,k). 
// Вводя неотрицательные значение n, построить массив-массивов  
// со значениями биномиальных коэффициентов и вывести его на экран 
// с помощью циклов foreach, размещая значения элементов каждого
// массива нижнего уровня по на отдельной строке...

namespace Task5
{
	class Program
	{
		static int[][] GetPaskal(uint n)
		{
			int[][] arr = new int[n][];
			for (int i = 0; i < arr.Length; i++)
			{
				arr[i] = new int[i + 1];
				arr[i][0] = arr[i][i] = 1;
				for (int j = 1; j < i; j++)
				{
					arr[i][j] = arr[i - 1][j - 1] + arr[i - 1][j];
				}

			}
			return arr;
		}
		static void Main(string[] args)
		{
			do
			{
				Console.Clear();
				uint n;
				do { Console.Write("Введите количество строк = "); }
				while (!uint.TryParse(Console.ReadLine(), out n) || n == 0);

				int[][] c = GetPaskal(n);
				
				
				foreach(int[] memb in c)
				{
					foreach(int memb1 in memb)
					{
						Console.Write("{0,3}", memb1);
					}
					Console.WriteLine();
				}
				Console.WriteLine("Нажмите Esc для выхода или любую клавишу чтобы продолжить");

			} while (Console.ReadKey().Key != ConsoleKey.Escape);
		}
	}
}

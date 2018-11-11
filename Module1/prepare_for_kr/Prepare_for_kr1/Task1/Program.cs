using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*Метод ShiftArray( ), «удаляет» из переданного в параметре
 * вещественного массива все отрицательные элементы, сдвигая оставшиеся вправо. 
 * Если отрицательный элемент – крайний слева, заменить его нулём. Например, для массива {-1, 0, 5, -7,11} 
 * результат работы метода: {0, 0, 0, 5, 11}, а для {1, 2, -4, 6, -8} результат: {1, 1, 1, 2, 6}. */
namespace Task1
{
	internal class Program
	{
		public static Random rnd = new Random();
		static void OutputArr(ref int[] arr)
		{
			foreach(int memb in arr)
			{
				Console.Write(memb + " ");
			}
			Console.WriteLine();
		}
		static void ShiftArray(ref int[] arr)
		{
			if (arr[0] < 0) arr[0] = 0;
			for(int i = 0; i < arr.Length; i++)
			{
				if (arr[i] < 0)
				{
					for(int k = i; k > 0; k--)
					{
						arr[k] = arr[k - 1];
					}
				}
			}
			
		}


		static void Main(string[] args)
		{
			do {
				Console.Clear();
				Console.WriteLine("Введите количество элементов массива");
				Console.Write("n = ");
				int n;
				while(!int.TryParse(Console.ReadLine(),out n)){
					Console.Error.WriteLine("Ошибка");
					Console.Write("n = ");
				}
				int[] arr = new int[n];
				for(int i = 0; i < arr.Length; i++)
				{
					arr[i] = rnd.Next(-30,31);

				}
				Console.WriteLine();
				OutputArr(ref arr);
				ShiftArray(ref arr);
				Console.WriteLine();
				OutputArr(ref arr);

			} while (Console.ReadKey().Key!=ConsoleKey.Escape);

		}
	}
}

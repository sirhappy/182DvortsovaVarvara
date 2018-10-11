using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
	class Program
	{
		// метод добавляет значение в конец массива
		// массив передаём по ссылки, потому что внутри метода
		// осуществлён вызов Array.Resize(), куда массив передаётся по
		// ссылке.
		// Если arr будет передан по значению, массив не будет изменён для
		// кода, вызывающего addToEnd()

		public static void AddToEnd(ref int[] arr,int num)
		{
			Array.Resize(ref arr, arr.Length + 1);
			arr[arr.Length - 1] = num;
		}

		// в методе вычисляется процентное соотношения чётных и нечётных значений

		public static void Count( int[] arr, out double oddPer, out double evenPer)
		{
			oddPer = 0.0;
			evenPer = 0.0;
			int oddsNumb = 0, evenNumb = 0;
			foreach (int memb in arr)
			{
				if (memb % 2 == 0) evenNumb += 1;
				else oddsNumb += 1;
			}
			oddPer = oddsNumb * arr.Length / 100.0;
			evenPer = 100 - oddPer;
			
		}
		static void Main(string[] args)
		{
			int[] arr2 = new int[0];
			int n;
			
			do
			{
				Console.Write("Enter an element of massive=");
				if(int.TryParse(Console.ReadLine(), out n)& n > 0)AddToEnd(ref arr2, n);
				
			} while (n != -1);
			for(int i = 0; i < arr2.Length; i++)
			{
				Console.Write($"{arr2[i]}  ");
			}
			double oddPer, evenPer;
			Count(arr2, out oddPer, out evenPer);
			Console.WriteLine($"Процентное соотношение четных элементов = {evenPer}\nПроцентное соотношение нечетных элементов ={oddPer}");
			Console.Read();
				
		}
	}
}

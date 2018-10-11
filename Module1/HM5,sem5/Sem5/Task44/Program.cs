using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*1. Написать метод для формирования массива, целочисленные
неотрицательные элементы которого вычисляются по следующему
рекуррентному соотношению: ai+1 = ai%2==0 ? ai/2 :(3*ai+1).
Процесс вычисления завершается, когда ai+1 станет равным 1.
Параметр метода задает значение a0
. Количество элементов
массива заранее не известно, так как определяется значением a0
.*/
namespace Task44
{
	class Program
	{
		public static double Elem(int i , int a0)
		{
			double a;
			if (i == 0) return a0;
			return a = Elem(i - 1, a0) % 2 == 0 ? Elem(i - 1, a0) / 2 : (3 * Elem(i - 1, a0) + 1);
		}
		public static void GetArr(int a0)
		{
			double[] arr = new double[a0];
			for(int i = 0; i < a0; i++)
			{
				arr[i] = Elem(i, a0);
				if (arr[i] == 1) break;
			}

		}
		static void Main(string[] args)
		{
		}
	}
}

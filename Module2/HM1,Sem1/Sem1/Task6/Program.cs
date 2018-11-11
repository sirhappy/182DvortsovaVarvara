using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Определите и инициализируйте массив строк.
// Выведите строки в порядке возрастания их длин.
// Порядок элементов в исходном массиве строк не менять.

namespace Task6
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] lines = new string[] { "нуль", "один", "два",
					"три", "четыре", "пять", "шесть", "семь", "восемь","девять", "десять" };
			int len = lines.Length;
			int[] index = new int[len];
			for(int i = 0; i < index.Length; i++)
			{
				index[i] = i;
			}
			
			for(int i = 0; i < len-1; i++)
			{
				for(int j = i + 1; j < len; j++)
				{
					if (lines[index[i]].Length > lines[index[i + 1]].Length)
					{
						int temp = index[i];
						index[i] = index[j];
						index[j] = temp;
					}
				}
			}
			for(int i = 0; i < len; i++)
			{
				Console.Write("{0,3}  ", lines[index[i]]);
			}
			Console.ReadKey();

		}
	}
}

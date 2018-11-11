using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] filials = new string[3] { "Западный","Центральный","Восточный" };
			string[] kvertal = new string[4] { "I", "II", "III", "IV" };
			int[,] results = new int[4, 3] { { 20, 24, 25 }, { 21, 20, 18 }, { 23, 27, 24 }, { 22, 19, 20 } };
			int count_car = 0;
			int sum_max_kvartal = 0;
			int sum_kvartal = 0;
			int index_max_kvartal = 0;
			for (int i = 0; i < results.GetLength(0); i++)
			{
				for(int j = 0; j < results.GetLength(1); j++)
				{
					count_car += results[i, j];
					sum_kvartal += results[i, j];
				}
				if (sum_max_kvartal < sum_kvartal)
				{
					sum_max_kvartal = sum_kvartal;
					index_max_kvartal = i;
				}
				sum_kvartal = 0;
			}
			Console.WriteLine("Общее количество афтомобилей = {0}", count_car);
			int maks_for_kvartal=0;
			int index_kvartal=0;
			int sum_max_filial = 0;
			
			int sum_max = 0;
			int index_sum_max = 0;
			for (int j = 0; j < results.GetLength(1);j++)
			{
				for (int i = 0; i < results.GetLength(0); i++)
				{
					 sum_max += results[i, j];


					if (maks_for_kvartal < results[i, j])
					{
						maks_for_kvartal = results[i, j];
						index_kvartal = i;
					}

				}
				if (sum_max_filial < sum_max) {

					sum_max_filial = sum_max;
					index_sum_max = j;
				}
				Console.WriteLine($"{filials[j]} {kvertal[index_kvartal]} {maks_for_kvartal}");
				index_kvartal = 0;
				maks_for_kvartal = 0;
				sum_max = 0;
			}
			Console.WriteLine($"Больше всего машин за год продал {filials[index_sum_max]} {sum_max_filial }");
			Console.WriteLine($"Самый успешный квартал {kvertal[index_max_kvartal]} продал авто {sum_max_kvartal}");
			Console.ReadKey();
		}
	}
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLib
{
	public static class Procedure
	{
		public static int callNumb = 0;//counts calls recursi
		// Метод рекурсивного поиска максимального элемента массива:
		public static double maxSearch(double[] ar , int beg , int end)
		{
			//beg ,end - границы поиска массива
			callNumb++;
			double resBeg, resEnd;  // частные результаты справа и слева
			if (beg == end) return ar[beg]; // шаг рекурсии
			int central = (beg + end) / 2; // индекс центрального элемента
			resBeg = maxSearch(ar, beg, central);
			resEnd = maxSearch(ar, central + 1, end);
			return resBeg > resEnd ? resBeg : resEnd;




		}

	}
}

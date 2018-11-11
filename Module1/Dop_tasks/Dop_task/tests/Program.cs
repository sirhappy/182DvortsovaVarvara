using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tests
{
	class Program
	{
		static int CountDigitSum(int n, int mod)
		{
						int digit = n;
			int temp;
			int sum = 0;
			while (digit != 0)
			{
				temp = digit % 10;
				sum += temp;
				digit /= 10;
			}
			string temp1 = Convert.ToString(sum, mod);
			Console.WriteLine(temp1);
			return sum;
		}
		static void Main(string[] args)
		{
			int n = 1010;
			int mod = 2;
			int sum = CountDigitSum(n, mod);
			Console.WriteLine(sum);
			Console.ReadLine();
		}
	}
}

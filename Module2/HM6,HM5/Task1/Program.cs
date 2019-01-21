using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
	class Program
	{
		static Random rnd = new Random();
		/// <summary>
		/// для создания строки заданной длины из символов, случайно выбираемых из указанного диапазона.
		/// </summary>
		/// <param name="n"></param>
		/// <param name="min"></param>
		/// <param name="max"></param>
		/// <returns></returns>
		static string CreateString(int n, char min ='a', char max = 'z')
		{
			if (n < 0) throw new Exception("Аргумент must be больше 0");
			string res = String.Empty;
			char temp = min;
			
			if (min > max){ max = min; min = temp; }
			
			for (int i = 0; i < n; i++)
			{
				res += (char)rnd.Next(min, max+1);

			}
			return res;
		}
		/// <summary>
		///  Удалить из строки s1 все символы другой строки s2:
		/// </summary>
		/// <param name="s1"></param>
		/// <param name="s2"></param>
		/// <returns></returns>
		static string MoveOff(string s1,string s2)
		{
			string res = s1;
			int index;
			for (int i = 0; i < s2.Length; i++)
			{
				while ((index = res.IndexOf(s2[i]))>=0)
				{
					res = res.Remove(index, 1);
				}
			}
			return res;
		}

		static void Main(string[] args)
		{
			do {
				int N = getINT();
				string res = CreateString(N,'0','9');
				string res2 = MoveOff(res, "02468");
				Console.WriteLine(res2);
			} while (Console.ReadKey().Key != ConsoleKey.Escape);
			Console.ReadLine();
		}

		private static int getINT()
		{
			int res;

			do Console.Write("Enter integer number :");
			while (!int.TryParse(Console.ReadLine(), out res));
			return res;
		}
	}
}

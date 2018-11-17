using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
	class Program
	{
		public static Random rnd = new Random();
		public static string RandomString(int n)
		{
			//char ch = (char)rnd.Next('a', 'z');

			string strstring = "";
			for (int i = 0; i < n; i++)
			{
				strstring += (char)rnd.Next('a', 'z');
			}
			return strstring;
		}
		static void Main(string[] args)
		{
			string a = RandomString(5);
			Console.WriteLine(a);
			Console.ReadKey();
		}
	}
}

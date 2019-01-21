using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sem6
{
	class Program
	{
		public static Random rnd = new Random();
		public static string CreateString(int n ,char start,char end)
		{
			if (n < 0) throw new ArgumentException("n<0");
			string str = "";
			for (int i = 0; i < n; i++)
				str += (char)rnd.Next(start, end + 1);
			return str;
		}

		public static string MoveOff(string fordelit,string symbol)
		{
			foreach( char ch in symbol)
			{
				//while (fordelit.IndexOf(ch) > 0)
				{
					//fordelit = fordelit.Remove(fordelit.IndexOf(ch), 1);
				}
				fordelit = fordelit.Replace(new string(ch, 1), "");
			}
			return fordelit;
		}
		static void Main(string[] args)
		{

		}
	}
}

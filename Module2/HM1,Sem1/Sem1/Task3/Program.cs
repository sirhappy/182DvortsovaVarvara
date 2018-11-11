using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
	class Program
	{
		static void Main(string[] args)
		{
			char[][][] arr =
			{
				new char[][] {
					new char[] {'a','b','h'},
					new char[] {'c','d','e'},
					new char[] {'v','f','y' } },
				new char[][] {
					new char[]{'s','h'},
					new char[]{'s','f'}},
				new char[][] {
					new char[]{'e','r'}}
			};
			Console.WriteLine("arr.Rank = {0}", arr.Rank);
			Console.WriteLine("arr.Length = {0}", arr.Length);
			Console.WriteLine("arr.GetLength(0) = {0}", arr.GetLength(0));
			
			Console.WriteLine("arr.GetLowerBound(0)={0}", arr.GetLowerBound(0));
			Console.WriteLine("arr.IsFixedSize = {0}", arr.IsFixedSize);
			
			foreach(char[][] memb in arr)
			{
				Console.WriteLine("leve1:");
				foreach(char[] memb2 in memb)
				{
					Console.Write("\tleve2:\t");
					foreach (char memb3 in memb2)
					{
						Console.Write("{0,3}", memb3);
					}
					Console.WriteLine();

				}
						
			}

			Console.ReadKey();
		}
	}
}

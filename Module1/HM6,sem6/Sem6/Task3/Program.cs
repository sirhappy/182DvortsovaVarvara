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
			char[][][] matr = new char[][][]
			{
				new char[][] {
						new char[]{'a', 'b'} ,
						new char[] { 'c', 'd', 'e' },
						new char []{ 'f', 'g', 'h', 'i'}
				},
				new char[][] {
					new char[] {'j','k'},
					new char[] {'l','m','n'}
					
				},
				new char[][]
				{
					new char[]{'a','b'}
					
				}
			};
			foreach(char[][] a in matr)
			{
				foreach(char[]b in a)
				{
					foreach (char s in b)
						Console.Write(s + " ");
				}
				Console.WriteLine();
			}
			Console.ReadKey();
		}
	}
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
	public class Alphabet
	{
		public int Lenth => 26;
		char start = 'A';
		public IEnumerator GetEnumerator()
		{
			return new AlphabetEnumerator(start,Lenth);
		}
	}
	public class AlphabetEnumerator : IEnumerator
	{
		char start;
		int Lenth;
		char[] alphabet = null;
		int position = -1;
		public AlphabetEnumerator(char start, int lenth)
		{
			this.start = start;
			Lenth = lenth;
			alphabet = new char[lenth];
			for (int i = 0; i < alphabet.Length; i++)
			{
				alphabet[i] = (char)(start + i);
			}
		}

		public object Current => alphabet[position];
		public bool MoveNext()=> ++position < alphabet.Length;
		public void Reset() => position = -1;
		
	}
	class Program
	{
		static void Main(string[] args)
		{

			Alphabet alph = new Alphabet();
			foreach (var item in alph)
			{
				Console.WriteLine(item);
			}

			Console.ReadLine();
		}
	}
}

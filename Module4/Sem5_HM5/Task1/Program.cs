using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
	class OtherEnglishWords : IEnumerable<string[]>
	{
		public string[] wordsStr = { "awdaw", "rgd", "wadaw" };
		public IEnumerable<string[]> GetEnumerator();
		
		public IEnumerator<string[]> GetEnumerator()
		{
			
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			throw new NotImplementedException();
		}
	}
	class EnglishWords
	{
		string[] engWords = { "wadwa", "wadw", "AWdwd" };
		public IEnumerable<string> GetEnum()
		{
			Array.Sort(engWords, (a, b) =>
			{
				if (a[0] > b[0]) return 1;
				if (a[0] < b[0]) return -1;
				return 0;

			});
			for (int i = 0; i < engWords.Length; i++)
			{
				yield return engWords[i];
			}
		}
	}
	class Program
	{
		static void Main(string[] args)
		{
			EnglishWords words = new EnglishWords();
			foreach (var item in words.GetEnum())
			{
				Console.WriteLine(item);
			}
			Console.Read();
		}
	}
}

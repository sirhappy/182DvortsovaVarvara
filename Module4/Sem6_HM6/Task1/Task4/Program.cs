using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
	public class RandomCollection : IEnumerable<int>
	{
		int n;
		
		public RandomCollection(int n)
		{
			N = n;
		}

		public int N { get => n; set => n = value; }

		public IEnumerator<int> GetEnumerator()
		{
			return new RandomEnumerator(n);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			throw new NotImplementedException();
		}
		sealed class RandomEnumerator : IEnumerator<int>
		{
			int[] arr;
			int n;
			static Random rnd = new Random();
			public RandomEnumerator(int n)
			{
				N = n;
				arr = new int[n];
				for (int i = 0; i < arr.Length; i++)
				{
					arr[i] = rnd.Next(-100, 100);
				}
			}
			int Position = -1;
			public int Current => arr[Position];

			public int N { get => n; set => n = value; }

			object IEnumerator.Current => throw new NotImplementedException();

			public void Dispose()
			{
				
			}

			public bool MoveNext() => ++Position < arr.Length;


			public void Reset() => Position = -1;
			
		}
	}
	class Program
	{
		static void Main(string[] args)
		{
			RandomCollection rndColl = new RandomCollection(10);
			foreach (var item in rndColl)
			{
				Console.WriteLine(item);
			}

			Console.ReadLine();
		}
	}
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
	public class MyInt : IEnumerable, IEnumerator
	{
		int[] arr;
		int Position = -1;
		public MyInt(int[] arr)
		{
			Arr = arr;
		}

		public object Current => arr[Position];

		public int[] Arr { get => arr; set => arr = value; }

		public IEnumerator GetEnumerator()
		{
			return this;

		}

		public bool MoveNext()
		{
			return ++Position < Arr.Length;
		}

		public void Reset()
		{
			Position = -1;
		}
	}
	class Program
	{
		static void Main(string[] args)
		{
			int[] arr = { 1, 2, 3, 4 };
			MyInt myInt = new MyInt(arr);
			foreach (var item in myInt)
			{
				Console.WriteLine(item);
			}
			Console.ReadLine();
		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
	class SampleCollection<T>
	{
		// Declare an array to store the data elements.
		private T[] arr = new T[100];
		int nextIndex = 0;

		// Define the indexer to allow client code to use [] notation.
		public T this[int i]=>arr[i];
		public void Add(T value)
		{
			if (nextIndex >= arr.Length)
				throw new IndexOutOfRangeException($"The collection can hold only {arr.Length} elements.");
			arr[nextIndex++] = value;
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			var stringCollection = new SampleCollection<string>();
			stringCollection[0] = "Hello, World";
			Console.WriteLine(stringCollection[0]);
			var integerCollection = new SampleCollection<int>();
			integerCollection[0] = 2;
			integerCollection[1] = 3;
			integerCollection[2] = 4;
			Console.WriteLine(integerCollection[1]);
			// Keep the console window open in debug mode.
			Console.WriteLine("Press any key to exit.");
			Console.ReadKey();
		}
	}
}

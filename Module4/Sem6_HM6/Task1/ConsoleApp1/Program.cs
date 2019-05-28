using System;
using System.Collections;
public class PowersOf2
{
	class MyClass
	{
		int[] a = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
		public IEnumerator GetEnumerator()
		{
			for (int i = 0; i < 20; i++)
			{
				if (a[i] % 2 == 0)
					yield return (int)(a[i]);
			}
		}
	}
	class Program
	{
		static void Main(string[] args)
		{
			MyClass mc = new MyClass();
			foreach (int i in mc)
				Console.Write(i);
			Console.WriteLine();
			Console.ReadLine();
		}
	}
}
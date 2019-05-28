using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
	class ArithmeticProgression
	{
		public IEnumerator GetEnumerator()
		{
			return new ArithmeticProgressionEnumerator(A0, D, N);
		}
		int  a0;
		int d;
		int n;

		public ArithmeticProgression(int a0, int d, int n)
		{
			A0 = a0;
			D = d;
			N = n;
		}

		public  int A0 { get => a0; set => a0 = value; }
		public  int D { get => d; set => d = value; }
		public  int N { get => n; set => n = value; }

		public class ArithmeticProgressionEnumerator : IEnumerator
		{
			int  a0;
			int d;
			int n;

			public int A0 { get => a0; set => a0 = value; }
			public int D { get => d; set => d = value; }
			public int N { get => n; set => n = value; }

			int Position = -1;

			public ArithmeticProgressionEnumerator(int a0, int d, int n)
			{
				A0 = a0;
				D = d;
				N = n;
			}

			public object Current
			{
				get
				{
					return A0 + D*(Position - 1);
				}
			}

			public bool MoveNext()
			{
				return ++Position < N;
			}

			public void Reset()
			{
				Position = -1;
			}
		}
	}
	class Program
	{
		static void Main(string[] args)
		{
			ArithmeticProgression progression = new ArithmeticProgression(5,2,10);
			foreach (var item in progression)
			{
				Console.WriteLine(item);
			}
			
			Console.ReadLine();
		}
	}
}

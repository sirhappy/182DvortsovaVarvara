using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sr6
{
	class Program
	{
		interface IlocalMinimum<T>
			where T : IComparable<T>
		{
			T this[int index] { get; }
			int CountLocalMinimun();
			bool isAllEqual();
		}
		public class MySequence<T> : IlocalMinimum<T> where T:class, IComparable<T>
		{
			private List<T> seq;
			
			public MySequence(IList<T> ls)
			{
				if (ls == null)
					throw new ArgumentNullException(nameof(ls));
				this.seq = new List<T>(ls);
			}

			public T this[int index]
			{
				get
				{

					try
					{
						return seq[index];
					}
					catch (ArgumentOutOfRangeException ex)
					{

						throw new IndexOutOfRangeException("Index out of range ",ex);
					}

					
				}
			}

			

			public int CountLocalMinimun()
			{
				int count = 0;
				for (int i = 0; i < seq.Count-2; i++)
				{
					if (seq[i].CompareTo(seq[i + 1]) > 0 && seq[i + 1].CompareTo(seq[i + 2]) < 0)
						count++;
				}
				return count;
			}

				
			public bool isAllEqual()=>seq.All(a=>a.CompareTo(seq.FirstOrDefault())==0);
			
		}
		public class TestClass : IComparable<TestClass>
		{
			public TestClass(int x)
			{
				X = x;
			}
			public override string ToString()
			{
				return X.ToString();
			}
			public int X { get; set; }

			public int CompareTo(TestClass other) => other.X.CompareTo(this.X);


		}
		
		static void Main(string[] args)
		{

			do
			{
				try
				{
					Console.Clear();
					Random rnd = new Random();
					int n;
					Console.Write("Enter x = ");
					int.TryParse(Console.ReadLine(), out n);
					List<TestClass> Tarr = new List<TestClass>();
					for (int i = 0; i < n; i++)
					{
						Tarr.Add(new TestClass(rnd.Next(-5, 5)));

					}
					MySequence<TestClass> arr = new MySequence<TestClass>(Tarr);

					Console.WriteLine("Count of lokal minimum = {0}", arr.CountLocalMinimun());
					if (arr.isAllEqual())
					{
						Console.WriteLine("All equal");
					}
					else
					{
						for (int i = 0; ; i++)
						{
							Console.WriteLine(arr[i]);
						}
					}
				}
				catch (Exception ex )
				{

					Console.WriteLine(ex.Message);
				}
				
			} while (Console.ReadKey().Key!=ConsoleKey.Escape);
		}
	}
}

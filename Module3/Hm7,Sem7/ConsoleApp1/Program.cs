using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ConsoleApp1
{
	class Program
	{
		public class TestClass : IComparable<TestClass>
		{
			public int A { get; set; }

			public int CompareTo(TestClass other)
			{
				if (other.A > this.A) return -1;
				if (other.A < this.A) return 1;
				return 0;

			}

		}
		public struct TestStruct:IComparable<TestStruct>
		{
			public int A { get; set; }

			public int CompareTo(TestStruct other)
			{
				if (other.A > this.A) return -1;
				if (other.A < this.A) return 1;
				return 0;
			}
		}
		static void Main(string[] args)
		{
			Random rnd = new Random();
			Stopwatch sw = new Stopwatch();
			sw.Start();
			//some code
			TestClass[] Tclass = new TestClass[10000];
			for (int i = 0; i < Tclass.Length; i++)
			{
				Tclass[i] = new TestClass();
				Tclass[i].A = rnd.Next(0, 10);
			}
			Array.Sort(Tclass);
			sw.Stop();
			Console.WriteLine("Class = "+sw.Elapsed);
			sw.Start();
			//some code
			TestStruct[] Tstruct = new TestStruct[10000];
			for (int i = 0; i < Tstruct.Length; i++)
			{
				Tstruct[i] = new TestStruct();
				Tstruct[i].A = rnd.Next(0, 10);
			}
			Array.Sort(Tstruct);
			sw.Stop();
			Console.WriteLine("Struct = " + sw.Elapsed);

			Console.ReadLine();
		}
	}
}

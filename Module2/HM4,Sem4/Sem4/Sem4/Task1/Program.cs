using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
	abstract public class AbstractClass
	{
		int a;
		protected int b;

		public void GetInfo()
		{
			Console.WriteLine("String");
		}
		abstract public void GetInfo2();
	}
	abstract class AbstractClass2 : AbstractClass
	{

	}
	class AbstractClass3 : AbstractClass2
	{
		public override void GetInfo2()
		{
			Console.WriteLine("getInfo2");
		}
	}
	class A
	{
		int a1;
		protected int a2;//
		internal int a3;//доступен внутри сборки
		public int a4;
	}
	class C: A { 
		public void GetA()
		{
			Console.WriteLine("a" + a2);
		}
	}
	class B : A
	{
		public void GetA()
		{
			Console.WriteLine("a" + a2);
		}
	}
	class Program
	{
		static void Main(string[] args)
		{


		}
	}
}

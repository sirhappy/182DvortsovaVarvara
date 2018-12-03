using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
	class A
	{
		int a1;
		protected int a2;//
		internal int a3;//доступен внутри сборки
		public int a4;
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

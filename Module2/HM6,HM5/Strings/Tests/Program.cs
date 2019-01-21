using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
	class Program
	{
		class Box
		{
			protected static int a;
			
			public int A
			{
				get { return a; }
			}
			static Box()
			{
				Console.WriteLine("static ctor was called");
			}

			//public Box()
			//{
			//	Console.WriteLine("default ctor was calleds");
			//}

			public static string Data { get { return "You are trying to get data"; } }

			public const int Foo = 7;
		}
		class Box2 : Box
		{
			public double A { get { return a; } }

		}
		static int Calculate(int c)
		{
			if (c % 2 == 1) return 1;
			else if (c == 0) return 0;
			else
				return c % 3 + Calculate(c / 2);
		}
		static public bool Do(params sbyte[] a)   
		{ return true; }		public class A
		{
			int k = 2;
int q = 3;
			public A(int x)
			{
				Show();
				k = q = x;
			}
			public void Show() { Console.Write(k); }
		}
		static double N(int a,int g) { return a + g; }
		public static void Main(string[] args)
		{



			//string str = new char[] {'У','р','а','!'}.ToString();
			//string str = string.Concat("ра", "!");
			//string str = new string(new char[] {'У','р','а','!'});
			//string str = Convert.ToString(new
			 // char[] { 'У', 'р', 'а', '!' });
			string str = String.Join("Ура", new string[] {"!&","#"});
			Console.WriteLine(str);

			Console.ReadKey();
			
		}
	}
}

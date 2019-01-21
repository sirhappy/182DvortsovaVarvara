using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace Task2
{
	class Program
	{
		static void Main(string[] args)
		{
			int a = 12345;
			int[] b = { 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
			
			ClassLibrary1.del1 del1;
			Class1.del2 del2;
			del1 = new ClassLibrary1.del1(Class1.meth1);
			del2 = new Class1.del2(Class1.meth2);
		    Console.WriteLine("a = 12345 ");
			int[] newArrA = del1(a);
			del2(del1(a));
			Console.WriteLine("\nint[] b = { 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 }\n");
			del2(b);
			Console.WriteLine();
			Console.WriteLine(del1.Method);
			Console.WriteLine(del1.Target);

			Console.WriteLine(del2.Method);
			Console.WriteLine(del2.Target);




			Console.Read();
		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	public class A:IEnumerable
	{
		private string[] arr = { "раз ромашка ", "два ромашка ",
"три ромашка ", "пять ромашка ", "шесть ромашка " };


	} //end of A
	class Program
		{

		static void Main()
		{
			string[] testArr = { "раз ", "два ", "три " };
			foreach (string str in testArr) // "проходит" по любому массиву
				Console.Write(str);
			A a = new A();
			foreach (string str in a) // ошибка компиляции
				Console.Write(str);
		} // end of Main()
	}
	}

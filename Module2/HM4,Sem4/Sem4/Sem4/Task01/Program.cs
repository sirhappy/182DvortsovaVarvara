using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace Task01
{
	class Program
	{
		static void Main(string[] args)
		{
			A[] arr = new A[10];
			for (int i = 0; i < arr.Length; i++)
			{
				arr[i] = new A();
			}
			for (int i = 0; i < arr.Length; i++)
			{
				arr[i].getA();
			}
			Console.ReadLine();
		}	
	}
}

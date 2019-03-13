using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	public class MyClass<T>
	{
		public List<T> mylist = new List<T>();

	}
	class Program
	{
		static void Main(string[] args)
		{
			MyClass<int> intClass = new MyClass<int>();
			intClass.mylist.Add(10);
			intClass.mylist.Add(15);
			intClass.mylist.Add(16);
			
			Array.ForEach(intClass.mylist.ToArray(), e => Console.Write(e + " "));
			Console.WriteLine($"leght = {intClass.mylist.Count}");
			Console.WriteLine($"Del some element = {intClass.mylist.Remove(10)}");
			Array.ForEach(intClass.mylist.ToArray(), e => Console.Write(e + " "));



			Console.ReadLine();
		}
	}
}

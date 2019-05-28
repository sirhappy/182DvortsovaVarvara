using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
	class Rainbow
	{ // Радуга
		string[] text = new string[] { "каждый ", "охотник ", "желает ", "знать ", "где " };
		public System.Collections.IEnumerator GetEnumerator()
		{
			foreach (var item in text)
			{
				yield return item;
			}
		}
	}
	class Program
	{
		static void Main()
		{
			Rainbow rain = new Rainbow();
			foreach (var item in rain)
			{
				Console.WriteLine(item);
			}
			Console.ReadLine();
		}
	}
}

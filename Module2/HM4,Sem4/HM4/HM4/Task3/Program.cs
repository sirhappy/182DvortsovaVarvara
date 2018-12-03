using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyEmploy;

namespace Task3
{
	class Program
	{
		
		public static string RandomString(int deep)
		{
			string str = "";
			for(int i = 0; i < deep; i++)
			{
				str += (char)rnd.Next('A', 'Z');
			}
			return str;
		}
		public static Random rnd = new Random();
		static void Main(string[] args)
		{
			do
			{
				Console.Clear();
				int n;
				Console.Write("Enter n = ");
				int.TryParse(Console.ReadLine(), out n);
				Employee[] empls = new Employee[n];
				string name = RandomString(rnd.Next(10000, 15000));
				for(int i = 0; i < empls.Length; i++)
				{
					if (rnd.Next(0, 2) == 1)
					{
						empls[i] = new SalesEmployee(RandomString(rnd.Next(3, 7)), rnd.Next(10, 1000),rnd.Next(10,1000));
					}
					else
						empls[i] = new PartTimeEmployee(RandomString(rnd.Next(3, 7)), rnd.Next(10, 1000), rnd.Next(10, 40));
				}
				for(int i = 0; i < empls.Length; i++)
				{
					Console.WriteLine(empls[i]);
				}
				Array.Sort(empls, (e1, e2) => e1.CalculatePay().CompareTo(e2.CalculatePay()));
				 Console.WriteLine("***");
				for (int i = 0; i < empls.Length; i++)
				{
					Console.WriteLine(empls[i]);
				}
				Console.WriteLine("***");
				foreach (Employee employee in empls)
				{
					if (employee is SalesEmployee)
					{
						Console.WriteLine(employee.CalculatePay());
					}
				}
				Console.WriteLine("***");
				foreach (Employee employee in empls)
				{
					if (employee is PartTimeEmployee)
					{
						Console.WriteLine(employee.CalculatePay());
					}
				}

			} while (Console.ReadKey().Key != ConsoleKey.Escape);
			

		}
	}
}

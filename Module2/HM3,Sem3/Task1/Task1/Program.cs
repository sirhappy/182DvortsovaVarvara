using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
	class AruthmeticSequence
	{
		double _start;
		double _increament;
		public AruthmeticSequence()
		{
			_start = 0;
			_increament = 1;
		}
		public AruthmeticSequence(double start,double increment)
		{
			_start = start;
			_increament = increment;
		}
		public double this[int index]
		{
			get
			{
				return _start +_increament*(index-1);
			}
		}
		public string GetInfo()
		{
			string res = $"start={_start},increment = {_increament}";
			return res;
		}
		public double GetSum(int n)
		{
			return (2 * _start + (n - 1) * _increament) * n / 2 ;
		}
	}
	class Program
	{
		public static Random rnd = new Random();
		static void Main(string[] args)
		{
			int n = rnd.Next(5, 16);
			
			AruthmeticSequence sec = new AruthmeticSequence(rnd.Next(0,1000),rnd.Next(1,10));
			AruthmeticSequence[] arr = new AruthmeticSequence[n];
			for(int i = 0; i < arr.Length; i++)
			{
				arr[i] = new AruthmeticSequence(rnd.Next(0, 1000), rnd.Next(1, 10));
			}
			int step = rnd.Next(3, 15);
			for(int i = 0; i < arr.Length; i++)
			{
				if (arr[i][step] > sec[step])
				{
					Console.WriteLine(arr[i].GetInfo());
					Console.WriteLine("sum = "+arr[i].GetSum(step));
				}
			}
			Console.WriteLine("For Every Sequence Sum = ");
			for(int i = 0; i < arr.Length; i++)
			{
				Console.WriteLine("sum =" + arr[i].GetSum(n));//Додумать это место
			}
			Console.ReadKey();

		}
	}
}

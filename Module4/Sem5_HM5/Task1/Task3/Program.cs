using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
	public class VArithmeticProgression
	{
		int a0;
		int d;
		public IEnumerable GetProgression(int a0,int d,int count)
		{
			for (int i = 2; i < count; i++)
			{
				yield return a0+d*(i-1);
			}
		}
	}
	class Program
	{
		static void Main(string[] args)
		{
			VArithmeticProgression progression = new VArithmeticProgression();
			foreach (var item in progression.GetProgression(1,5,10))
			{
				Console.WriteLine(item);
			}
			Console.ReadLine();
		}
	}
}

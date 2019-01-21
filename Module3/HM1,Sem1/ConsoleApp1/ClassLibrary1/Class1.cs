using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
	public delegate int[] del1(int par);

	public class Class1
    {
		
		public delegate void del2(int[] par);
		public static int[] meth1(int par)
		{
			string pars = Convert.ToString(par); 

			int temp = par;
			int[] numbs = new int[pars.Length];
			for (int i = numbs.Length-1; i >=0; i--)
			{
				numbs[i] = temp % 10;
				temp/= 10;

			}
           
			return numbs;
		}
		public static void meth2(int[] arr)
		{

			Array.ForEach(arr, y => Console.Write(y + "\t"));

		}
	}
}

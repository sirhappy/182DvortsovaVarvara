using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{ 
		 public delegate string ConvertRule(string str);
class Converter
	{
		public string MyConvert(string str ,ConvertRule cr)
		{
			return cr?.Invoke(str);
		}
	}
	class Program
	{
		public static string RemoveDigits(string str)
		{
			
			
				while(str.IndexOfAny("0123456789".ToCharArray()) > -1)
					str = str.Remove(0, str.IndexOfAny("0123456789".ToCharArray()));
			return str;
			
		}
		static void Main(string[] args) { 
		

			Console.ReadKey();
		}
	}
}

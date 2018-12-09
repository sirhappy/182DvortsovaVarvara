using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLib
{
	public static class EnterValue
	{
		public static int GetIntValue(string comment)
		{
			Console.Write(comment);
			return int.Parse(Console.ReadLine());
		}
	}
}

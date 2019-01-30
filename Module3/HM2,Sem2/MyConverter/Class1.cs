using System;

namespace MyConverter
{
	public delegate string ConvertRule(string str);
	public class Converter
	{
		public  string Convert(string str,ConvertRule cr)
		{
			return cr?.Invoke(str);
		}
	}
}
